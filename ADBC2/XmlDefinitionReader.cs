using System;
using System.Xml;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;
using System.Reflection.Emit;
using System.IO;
using DBFilesClient.NET;

namespace ADBC2
{
    public static class XmlDefinitionReader
    {
        static XmlDocument _reader = null;
        static IDictionary<string, TypeBuilder> _structures = new Dictionary<string, TypeBuilder>();
    
        public static void Load(string fileName, uint clientBuild)
        {
            _structures.Clear();
            
            _reader = new XmlDocument();
            _reader.Load(fileName);
            GenerateTypes(clientBuild);
        }

        public static int Count { get { return _structures.Count; } }
        
        public static IDictionary<string, TypeBuilder> GetStructures()
        {
            return _structures;
        }

        public static TypeBuilder GetStructure(string dbcName)
        {
            return _structures[dbcName];
        }
        
        static bool GenerateTypes(uint build)
        {
            if (!_reader["Definitions"].HasChildNodes)
                return false;
                
            var nodes = _reader["Definitions"].GetElementsByTagName(@"file");
            if (nodes.Count == 0)
                return false;

            var filteredNodes = new List<XmlNode>();
            for (var i = 0; i < nodes.Count; ++i)
                if (nodes[i].Attributes["build"].Value == build.ToString())
                    filteredNodes.Add(nodes[i]);
            
            if (filteredNodes.Count == 0)
                return false;
                
            // Construct type infos
            foreach (var node in filteredNodes) {
                var childNodes = node.ChildNodes;
                var fileName = node.Attributes["name"].Value;
                _structures[fileName] = DynamicStructureBuilder.CreateStructure(Path.GetFileNameWithoutExtension(fileName) + "Entry");

                foreach (XmlNode childNode in childNodes)
                {
                    if (childNode.Name != "field")
                        continue;

                    Type fieldType; // Triggers type
                    switch (childNode.Attributes["type"].Value)
                    {
                        case "u32": case "uint32": case "uint":
                            fieldType = typeof(uint);
                            break;
                        case "i32": case "int32": case "int":
                            fieldType = typeof(int);
                            break;
                        case "u16": case "uint16": case "ushort":
                            fieldType = typeof(ushort);
                            break;
                        case "i16": case "int16": case "short":
                            fieldType = typeof(short);
                            break;
                        case "u8": case "uint8": case "byte":
                            fieldType = typeof(byte);
                            break;
                        case "i8": case "int8": case "sbyte":
                            fieldType = typeof(sbyte);
                            break;
                        case "double":
                            fieldType = typeof(double);
                            break;
                        case "float":
                            fieldType = typeof(float);
                            break;
                        case "string":
                            fieldType = typeof(string);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(String.Format("Field type {0} is not handled.", childNode.Attributes["type"]));
                    }
                    _structures[fileName].DefineField(childNode.Attributes["name"].Value, fieldType, FieldAttributes.Public);
                }
            }
            
            return true;
        }
    }
    
    // Memo for research: http://www.codeproject.com/script/Articles/ViewDownloads.aspx?aid=121568
    // Current code throws an exception because of ReflectionOnly banning Activator.
    public static class DynamicStructureBuilder
    {
        public static TypeBuilder CreateStructure(string structureName)
        {
            return GetType(GetModule(GetAssemblyBuilder("EmittedStructures")), structureName, TypeAttributes.Public | TypeAttributes.Sealed);
        }
        
        static AssemblyBuilder GetAssemblyBuilder(string assemblyName)
        {
            var aname = new AssemblyName(assemblyName);
            var currentDomain = AppDomain.CurrentDomain; // Thread.GetDomain();
            return currentDomain.DefineDynamicAssembly(aname, AssemblyBuilderAccess.ReflectionOnly);
        }
        
        static ModuleBuilder GetModule(AssemblyBuilder asmBuilder)
        {
            return asmBuilder.DefineDynamicModule("EmitMethods", "EmitMethods.dll");
        }
        
        static TypeBuilder GetType(ModuleBuilder modBuilder, string className)
        {
            return modBuilder.DefineType(className, TypeAttributes.Public);
        }
        
        static TypeBuilder GetType(ModuleBuilder modBuilder, string className, TypeAttributes attrs)
        {
            return modBuilder.DefineType(className, attrs);        
        }
        
        static TypeBuilder GetType(ModuleBuilder modBuilder, string className, params string[] genericparameters)
        {
            TypeBuilder builder = modBuilder.DefineType(className, TypeAttributes.Public);
            GenericTypeParameterBuilder[] genBuilders = builder.DefineGenericParameters(genericparameters);
        
            foreach (GenericTypeParameterBuilder genBuilder in genBuilders) // We take each generic type T : class, new()
                genBuilder.SetGenericParameterAttributes(GenericParameterAttributes.ReferenceTypeConstraint | GenericParameterAttributes.DefaultConstructorConstraint);
        
            return builder;
        }
    }
    
    public class DynamicStructure : DynamicObject
    {
        // Yes, hacks.
        [StoragePresence(StoragePresenceOption.Exclude)]
        IDictionary<string, dynamic> _values;
        
        public DynamicStructure()
        {
            _values = new Dictionary<string, dynamic>();
        }
        
        public override bool TryGetIndex(GetIndexBinder binder, object[] indexes, out dynamic result)
        {
            var list = new List<dynamic>();
            foreach (var index in indexes)
                list.Add(_values.Values.ElementAt((int)index));
            result = list.ToArray();
            return true;
        }
        
        public DynamicStructure(IDictionary<string, dynamic> values)
        {
            _values = values;
        }
        
        public override bool TryGetMember(GetMemberBinder binder, out dynamic result)
        {
            if (_values.ContainsKey(binder.Name))
            {
                result = _values[binder.Name];
                return true;
            }

            result = null;
            return false;
        }
        
        public override bool TrySetMember(SetMemberBinder binder, dynamic value)
        {
            _values[binder.Name] = value;
            return true;
        }
        
        public override IEnumerable<string> GetDynamicMemberNames()
        {
            return _values.Keys;
        }
        
        public dynamic this[string key]
        {
            get { return _values[key]; }
            set { _values[key] = value; }
        }
    }
    
    //
    // Code below from CodeProject
    // SharpDevelop shits itself at the amount of warnings this yields.
    // http://www.codeproject.com/Articles/42929/C-Exposer-an-evil-DynamicObject
    //
    public interface IConvertTo<T>
    {
        T Convert();
    }

    public interface IObjectWithType
    {
        Type Type { get; set; }
    }

    public class Exposer<T> : DynamicObject, IObjectWithType, IConvertTo<T>
    {
        public T Object { get; set; }
        public Type Type { get; set; }

        static Dictionary<string, Func<T, object[], object>> _methods = 
            new Dictionary<string, Func<T, object[], object>>();
        static Dictionary<string, Func<T, object>> _getters = 
                new Dictionary<string, Func<T, object>>();
        static Dictionary<string, Action<T, object>> _setters = 
                new Dictionary<string, Action<T, object>>();

        static MethodInfo _doConvert = typeof(Exposer<T>).GetMethod
        ("DoConvert", BindingFlags.NonPublic | BindingFlags.Static);

        public Exposer(T obj)
        {
            this.Object = obj;
            this.Type = obj.GetType();
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            var key = binder.Name;
            Func<T, object> getter = null;

            if (_getters.ContainsKey(key))
            {
                getter = _getters[key];
            }
            else
            {
                IEnumerable<MemberInfo> members = this.Type.GetMembers(
                    BindingFlags.Instance | BindingFlags.Public | 
                    BindingFlags.NonPublic | BindingFlags.GetProperty | 
                    BindingFlags.GetField);

                members = from mem in members
                          where mem.Name == key
                          select mem;

                var member = members.FirstOrDefault();

                if(member != null) {
                    getter = BuildGetter(member);
                    _getters.Add(key, getter);
                }
            }

            if (getter != null)
            {
                result = Wrap(getter(this.Object));
                return true;
            }
            else
                return base.TryGetMember(binder, out result);
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            var key = binder.Name;
            Action<T, object> setter = null;

            if (_setters.ContainsKey(key))
            {
                setter = _setters[key];
            }
            else
            {
                IEnumerable<MemberInfo> members = this.Type.GetMembers(
                    BindingFlags.Instance | BindingFlags.Public | 
                    BindingFlags.NonPublic | BindingFlags.SetProperty | 
                    BindingFlags.SetField);

                members = from mem in members
                          where mem.Name == key
                          select mem;

                var member = members.FirstOrDefault();

                if (member != null)
                {
                    setter = BuildSetter(member);
                    _setters.Add(key, setter);
                }
            }

            if (setter != null)
            {
                setter(this.Object, value);
                return true;
            }
            else
                return base.TrySetMember(binder, value);
        }

        public override bool TryInvokeMember
        (InvokeMemberBinder binder, object[] args, out object result)
        {
            Func<T, object[], object> func = null;

            var key = MakeKey(binder, args);

            if (_methods.ContainsKey(key))
                func = _methods[key];
            else
            {
                var argTypes = args.Select(arg => arg is IObjectWithType ? 
                    (arg as IObjectWithType).Type : arg.GetType()).ToArray();
                IEnumerable<MethodInfo> methods = this.Type.GetMethods
                    (BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

                methods = from method in methods
                          where method.Name == binder.Name && ArgsMatch(method, argTypes)
                          select method;

                var info = methods.FirstOrDefault();

                if (info != null)
                {
                    var paramTypes = info.GetParameters().Select
                (p => p.ParameterType).ToArray();

                    var target = Expression.Parameter(this.Type, "obj");
                    var param = Expression.Parameter(typeof(object[]), "args");
                    var call = Expression.Call(target, info,
                        paramTypes.Select((p, i) =>
                        BuildConvertExpression(Expression.ArrayAccess
                            (param, Expression.Constant(i)), p)));

                    func = Expression.Lambda<Func<T, object[], object>>(
                        Expression.Convert(call, typeof(object)), 
                    target, param).Compile();
                }

                _methods.Add(key, func);
            }

            if (func != null)
            {
                var res = func(this.Object, args);

                result = Wrap(res);

                return true;
            }
            return base.TryInvokeMember(binder, args, out result);
        }

        public override bool TryConvert(ConvertBinder binder, out object result)
        {
            if (binder.Type.IsAssignableFrom(this.Type))
            {
                result = this.Object;
                return true;
            }
            return base.TryConvert(binder, out result);
        }

        #region Builders
        #region Getter
        private Func<T, object> BuildGetter(MemberInfo member)
        {
            switch (member.MemberType)
            {
                case MemberTypes.Field:
                    return BuildFieldGetter(member as FieldInfo);
                case MemberTypes.Property:
                    return BuildPropertyGetter(member as PropertyInfo);
                default:
                    //Returning null effectively marks this as not supported, 
                    //since the getter will be null as binding exception will be thrown
                    return null;
            }
        }

        private Func<T, object> BuildFieldGetter(FieldInfo fieldInfo)
        {
            var param = Expression.Parameter(this.Type, "obj");

            var lambda = Expression.Lambda<Func<T, object>>(
                Expression.Field(param, fieldInfo),
                param);

            return lambda.Compile();
        }

        private Func<T, object> BuildPropertyGetter(PropertyInfo propertyInfo)
        {
            var param = Expression.Parameter(this.Type, "obj");

            var lambda = Expression.Lambda<Func<T, object>>(
                Expression.Property(param, propertyInfo),
                param);

            return lambda.Compile();
        }
        #endregion
        #region Setter
        private Action<T, object> BuildSetter(MemberInfo member)
        {
            switch (member.MemberType)
            {
                case MemberTypes.Field:
                    return BuildFieldSetter(member as FieldInfo);
                case MemberTypes.Property:
                    return BuildPropertySetter(member as PropertyInfo);
                default:
                    //Returning null effectively marks this as not supported, 
                    //since the setter will be null as binding exception will be thrown
                    return null;
            }
        }

        private Action<T, object> BuildFieldSetter(FieldInfo fieldInfo)
        {
            var param = Expression.Parameter(this.Type, "obj");
            var value = Expression.Parameter(typeof(object), "val");

            var lambda = Expression.Lambda<Action<T, object>>(
                Expression.Assign(
                    Expression.Field(param, fieldInfo),
                    Expression.Convert(value, fieldInfo.FieldType)),
                param, value);

            return lambda.Compile();
        }

        private Action<T, object> BuildPropertySetter(PropertyInfo propertyInfo)
        {
            var param = Expression.Parameter(this.Type, "obj");
            var value = Expression.Parameter(typeof(object), "val");

            var lambda = Expression.Lambda<Action<T, object>>(
                Expression.Assign(
                    Expression.Property(param, propertyInfo),
                    Expression.Convert(value, propertyInfo.PropertyType)),
                param, value);

            return lambda.Compile();
        }
        #endregion
        #region Convert
        public Expression BuildConvertExpression(Expression target, Type type)
        {
            if (type == typeof(object))
                return target;

            return Expression.Call(_doConvert.MakeGenericMethod(type), target);
        }

        static R DoConvert<R>(object i)
        {
            if (i is IConvertTo<R>)
            {
                return (i as IConvertTo<R>).Convert();
            }
            else
            {
                return (R)i;
            }
        }
        #endregion
        #endregion

        #region Helpers
        private static object Wrap(object res)
        {
            if (res == null)
                return null;

            var type = res.GetType();

            if (type.IsPrimitive)
                return res;

            var expType = typeof(Exposer<>).MakeGenericType(type);

            return Activator.CreateInstance(expType, res);
        }

        private static string MakeKey(InvokeMemberBinder binder, object[] args)
        {
            var ret = new StringBuilder();
            ret.Append(binder.Name);

            foreach (var arg in args)
                ret.Append(arg.GetType().Name);

            return ret.ToString();
        }

        private static bool ArgsMatch(MethodInfo info, Type[] argTypes)
        {
            return info.GetParameters()
                .Select((p, i) => p.ParameterType.IsAssignableFrom(argTypes[i]))
                .All(b => b);
        }
        #endregion

        #region IConvertTo<T> Members

        public T Convert()
        {
            return this.Object;
        }

        #endregion
    }

    public static class XmlExtensions
    {
        public static Exposer<T> Expose<T>(this T target)
        {
            return new Exposer<T>(target);
        }
    }
}

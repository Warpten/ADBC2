using System;
using System.Xml;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.IO;
using DBFilesClient.NET;

namespace ADBC2
{
    public static class XmlDefinitionReader
    {
        static XmlDocument _reader = null;
        static IDictionary<string, Type> _structures = new Dictionary<string, Type>();
    
        public static void Load(string fileName, uint clientBuild)
        {
            _structures.Clear();
            
            _reader = new XmlDocument();
            _reader.Load(fileName);
            GenerateTypes(clientBuild);
        }

        public static int Count { get { return _structures.Count; } }
        
        public static IDictionary<string, Type> GetStructures()
        {
            return _structures;
        }

        public static Type GetStructure(string dbcName)
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
                
            _structures.Clear();
            
            var builders = new Dictionary<string, TypeBuilder>();
                
            // Construct type infos
            foreach (var node in filteredNodes) {
                var childNodes = node.ChildNodes;
                var fileName = node.Attributes["name"].Value;
                builders[fileName] = DynamicStructureBuilder.CreateStructure(Path.GetFileNameWithoutExtension(fileName) + "Entry");

                foreach (XmlNode childNode in childNodes)
                {
                    if (childNode.Name != "field")
                        continue;
                    
                    var arraySize = 0;
                    if (childNode.Attributes["array"] != null)
                        arraySize = Convert.ToInt32(childNode.Attributes["array"].Value);

                    Type fieldType; // Triggers type
                    switch (childNode.Attributes["type"].Value)
                    {
                        case "u32": case "uint32": case "uint":
                            fieldType = arraySize == 0 ? typeof(uint) : typeof(uint[]);
                            break;
                        case "i32": case "int32": case "int":
                            fieldType = arraySize == 0 ? typeof(int) : typeof(int[]);
                            break;
                        // Apparently DBCs do not hold any 16 bits type.
                        // case "u16": case "uint16": case "ushort":
                        //     fieldType = typeof(ushort);
                        //     break;
                        // case "i16": case "int16": case "short":
                        //     fieldType = typeof(short);
                        //     break;
                        case "u8": case "uint8": case "byte":
                            fieldType = arraySize == 0 ? typeof(byte) : typeof(byte[]);
                            break;
                        case "i8": case "int8": case "sbyte":
                            fieldType = arraySize == 0 ? typeof(sbyte) : typeof(sbyte[]);
                            break;
                        // Nor doubles.
                        // case "double": case "d":
                        //     fieldType = !isArray ? typeof(double) : typeof(double[]);
                        //     break;
                        case "float": case "f":
                            fieldType = arraySize == 0 ? typeof(float) : typeof(float[]);
                            break;
                        case "string":
                            fieldType = arraySize == 0 ? typeof(string) : typeof(string[]);
                            break;
                        case "ulong": case "u64":
                            fieldType = arraySize == 0 ? typeof(ulong) : typeof(ulong[]);
                            break;
                        case "long": case "i64":
                            fieldType = arraySize == 0 ? typeof(long) : typeof(long[]);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(String.Format("Field type {0} is not handled.", childNode.Attributes["type"]));
                    }

                    var fieldBuilder = builders[fileName].DefineField(childNode.Attributes["name"].Value, fieldType, FieldAttributes.Public);
                    if (arraySize > 0)
                    {
                        var attrBuilder = new CustomAttributeBuilder(
                            typeof(StoragePresenceAttribute).GetConstructor(
                                new [] { typeof(StoragePresenceOption), typeof(int) }),
                                new object[] { StoragePresenceOption.Include, arraySize });
                        fieldBuilder.SetCustomAttribute(attrBuilder);
                    }
                }
            }
            
            for (var i = 0; i < builders.Count; ++i)
                _structures.Add(builders.Keys.ElementAt(i), builders.Values.ElementAt(i).CreateType());
            
            return true;
        }
    }

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
            return currentDomain.DefineDynamicAssembly(aname, AssemblyBuilderAccess.Run);
        }
        
        static ModuleBuilder GetModule(AssemblyBuilder asmBuilder)
        {
            // Build debug symbols for now
            return asmBuilder.DefineDynamicModule("EmitMethods", true);
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
}

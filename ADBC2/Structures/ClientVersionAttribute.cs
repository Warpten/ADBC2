using System;

namespace ADBC2.Structures
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ClientVersionAttribute : Attribute
    {
        public int Build;
        
        public ClientVersionAttribute(int Build)
        {
            this.Build = Build;
        }
        
        public override string ToString()
        {
            return string.Format("[ClientVersionAttribute Build={0}]", Build);
        }
    }
}

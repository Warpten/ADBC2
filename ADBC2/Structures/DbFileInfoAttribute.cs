using System;

namespace ADBC2.Structures
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class DbFileInfoAttribute : Attribute
    {
        public string FileName;
        public int Build;
        public bool Enabled;
    
        public enum ClientBuild
        {
            V3_3_5_12340 = 12340,
            V4_3_4_15595 = 15595,
            V6_0_1_18179 = 18179
        }

        public DbFileInfoAttribute(int build, string fileName, bool enabled = true)
        {
            FileName = fileName;
            Build = build;
            Enabled = enabled;
        }
    }
}

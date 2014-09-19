using System;

namespace ADBC2
{
    /// <summary>
    /// This tag is used to load dynamically DBC/DB2 files once clicked in menus.
    /// </summary>
    public class DbcTag
    {
        public string FileName;
        public Type Structure;
        
        public DbcTag(string fileName, Type structureType)
        {
            this.FileName = fileName;
            this.Structure = structureType;
        }
    }
}

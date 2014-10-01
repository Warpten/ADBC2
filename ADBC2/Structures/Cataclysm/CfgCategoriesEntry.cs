
using System;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "Cfg_Categories.dbc")]
    public sealed class CfgCategoriesEntry
    {
        public uint Id;
        public uint LocaleMask;
        public uint CharsetMask;
        public uint CharsetMask2;
        public uint Flags;
        public string Name;
    }
}

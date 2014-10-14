using BrightIdeasSoftware;
using System;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "Cfg_Categories.dbc")]
    public sealed class CfgCategoriesEntry
    {
        public uint Id;
        public uint LocaleMask;
        public uint CreateCharsetMask;
        public uint ExistingCharsetMask;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public string Name;
    }
}

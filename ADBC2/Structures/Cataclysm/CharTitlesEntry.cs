using System;
using BrightIdeasSoftware;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "CharTitles.dbc")]
    public sealed class CharTitlesEntry
    {
        public uint Id;
        public uint ConditionId;
        public string Name;
        public string NameFemale;
        public uint MaskId;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }
}

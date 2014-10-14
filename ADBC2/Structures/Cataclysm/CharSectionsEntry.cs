using System;
using BrightIdeasSoftware;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "CharSections.dbc")]
    public sealed class CharSectionsEntry
    {
        public uint Id;
        public uint Race;
        public uint Gender;
        public uint GeneralType;
        public string Texture1;
        public string Texture2;
        public string Texture3;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public uint Type;
        public uint Variation;
    }
}

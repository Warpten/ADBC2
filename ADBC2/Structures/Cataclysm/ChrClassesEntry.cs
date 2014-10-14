using System;
using BrightIdeasSoftware;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "ChrClasses.dbc")]
    public sealed class ChrClassesEntry
    {
        public uint ClassID;
        public uint PowerDisplayId;
        public uint PetNameToken;
        public string Name;
        public string NameFemale;
        public string NameMale;
        public string FileName;
        public uint SpellClassSet;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public uint CinematicSequence;
        public uint Expansion;
        public uint APPerStrenth;
        public uint APPerAgility;
        public uint RAPPerAgility;
    }
}

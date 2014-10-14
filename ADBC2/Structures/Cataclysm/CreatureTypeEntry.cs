using System;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "CreatureType.dbc")]
    public sealed class CreatureTypeEntry
    {
        public uint Id;
        public string Name;
        public uint NoExperience; // Actually flags
    }
}

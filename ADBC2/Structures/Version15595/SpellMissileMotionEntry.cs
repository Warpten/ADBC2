using System;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "SpellMissileMotion.dbc")]
    public sealed class SpellMissileMotionEntry
    {
        public uint Id;
        public string Name;
        public string Script;
        public uint Flags;
        public uint MissileCount;
    }
}

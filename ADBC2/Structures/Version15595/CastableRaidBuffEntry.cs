using System;

namespace ADBC2.Structures.Cataclysm
{
    // Seems corrupt, throws an exception ... Not sure why
    [DbFileInfo(15595, "CastableRaidBuffs.dbc", false)]
    public sealed class CastableRaidBuffsEntry
    {
        public uint Id;
        public uint SpellID;
        public uint CastingSpellId;
    }
}

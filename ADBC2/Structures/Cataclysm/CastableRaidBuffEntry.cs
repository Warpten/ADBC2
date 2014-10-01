using System;

namespace ADBC2.Structures.Cataclysm
{
    // Seems corrupt, throws an exception ... Not sure why
    [DbFileInfo(15595, "CastableRaidBuffs.dbc", true)]
    public sealed class CastableRaidBuffsEntry
    {
        public uint Id;
        public int Unk1;
        public int Unk2;
    }
}

using System;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "BarberShopStyle.dbc")]
    public sealed class BarberShopStyleEntry
    {
        public uint Id;
        public uint Type;
        public string Name;
        public uint Unk;
        public float CostMultiplier;
        public uint Race;
        public uint Gender;
        public uint HairId;
    }
}

using System;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "AuctionHouse.dbc")]
    public sealed class AuctionHouseEntry
    {
        public uint Id;
        public uint Faction;
        public uint DepositPercent;
        public uint CutPercent;
        public string Name;
    }
}

using System;

namespace ADBC2.Structures.Cataclysm
{
    [ClientVersion(15595)]
    [FileStructure("ItemCurrencyCost.db2")]
    public sealed class ItemCurrencyCostEntry
    {
        private uint _Id;
        public uint Id { get { return _Id; } }
        
        private uint _ItemId;
        public uint ItemId { get { return _ItemId; } }
    }
}

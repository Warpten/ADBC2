using System;

namespace ADBC2.Structures.Cataclysm
{
    [ClientVersion(15595)]
    [FileStructure("ItemCurrencyCost.db2")]
    public sealed class ItemCurrencyCostEntry
    {
        public uint Id;
        public uint ItemId;
    }
}

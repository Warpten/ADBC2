using System;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "CurrencyCategory.dbc")]
    public sealed class CurrencyCategoryEntry
    {
        public uint Id;
        public uint Flags;
        public string Name;
    }
}

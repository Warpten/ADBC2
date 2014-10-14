using System;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "ResearchBranch.dbc")]
    public sealed class ResearchBranchEntry
    {
        public uint Id;
        public string Name;
        public int ResearchFieldId;
        public int CurrencyId;
        public string Texture;
        public int ItemId; // Keystone
    }
}

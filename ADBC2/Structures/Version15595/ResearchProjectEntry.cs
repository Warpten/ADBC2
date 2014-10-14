using System;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "ResearchProject.dbc")]
    public sealed class ResearchProjectEntry
    {
        public uint Id;
        public string Name;
        public string Description;
        public int Rarity; // 0 Common - 1 Rare
        public int ResearchBranchId; // ResearchBranch.dbc
        public uint SpellId;
        public int NumSockets; // Amount that can be used in project
        public string Texture;
        public int RequiredWeight; // Amount needed
    }
}

using System;
using BrightIdeasSoftware;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfoAttribute(15595, "Achievement.dbc")]
    public sealed class AchievementEntry
    {
        public uint Id;
        public int RequiredFaction;
        public int MapId;
        public int ParentAchievement;
        public string Name;
        public string Description;
        public uint Category;
        public uint Points;
        public uint OrderInCategory;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public uint Icon;
        public string Reward;
        public uint Count;
        public uint ReferenceAchievement;
    }
}

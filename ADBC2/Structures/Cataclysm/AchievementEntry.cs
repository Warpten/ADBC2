using System;
using BrightIdeasSoftware;

namespace ADBC2.Structures.Cataclysm
{
    [ClientVersion(15595)]
    [FileStructure("Achievement.dbc")]
    public sealed class AchievementEntry
    {
        private uint _Id;
        // public uint Id { get { return _Id; } }
        
        private int _RequiredFaction;
        public int RequiredFaction { get { return _RequiredFaction; } }
        
        private int _MapId;
        public int MapId { get { return _MapId; } }
        
        private int _ParentAchievement;
        public int ParentAchievement { get { return _ParentAchievement; } }
        
        private string _Name;
        public string Name { get { return _Name; } }
        
        private string _Description;
        public string Description { get { return _Description; } }
        
        private uint _Category;
        public uint Category { get { return _Category; } }
        
        private uint _Points;
        public uint Points { get { return _Points; } }
        
        private uint _OrderInCategory;
        public uint OrderInCategory { get { return _OrderInCategory; } }
        
        private uint _Flags;
        public uint Flags { get { return _Flags; } }
        
        private uint _Icon;
        public uint Icon { get { return _Icon; } }
        
        private string _Reward;
        public string Reward { get { return _Reward; } }
        
        private uint _Count;
        public uint Count { get { return _Count; } }
        
        private uint _ReferenceAchievement;
        public uint ReferenceAchievement { get { return _ReferenceAchievement; } }

    }
}

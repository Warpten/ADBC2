using System;

namespace ADBC2.Structures.Cataclysm
{
    [ClientVersion(15595)]
    [FileStructure("Achievement_Category.dbc")]
    // private (.+) _(.+);
    // private \1 _\2;\r\npublic \1 \2 { get { return _\2; } }\r\n
    public sealed class AchievementCategoryEntry
    {
        private uint _Id;
        public uint Id { get { return _Id; } }
        
        private int _ParentCategory;
        public int ParentCategory { get { return _ParentCategory; } }
        
        private string _Name;
        public string Name { get { return _Name; } }
        
        private uint _SortOrder;
        public uint SortOrder { get { return _SortOrder; } }
    }
}

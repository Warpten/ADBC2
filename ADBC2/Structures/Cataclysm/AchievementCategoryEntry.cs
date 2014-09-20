using System;

namespace ADBC2.Structures.Cataclysm
{
    [ClientVersion(15595)]
    [FileStructure("Achievement_Category.dbc")]
    // private (.+) _(.+);
    // private \1 _\2;\r\npublic \1 \2 { get { return _\2; } }\r\n
    public sealed class AchievementCategoryEntry
    {
        public uint Id;
        public int ParentCategory;
        public string Name;
        public uint SortOrder;
    }
}

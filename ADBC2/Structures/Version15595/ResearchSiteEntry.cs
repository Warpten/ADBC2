using System;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "ResearchSite.dbc")]
    public sealed class ResearchSiteEntry
    {
        public uint Id;
        public int MapId;
        public int QuestPOIBlobID;
        public string Name;
        public int AreaPOIIconEnum;
    }
}

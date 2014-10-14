using System;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "QuestPOIBlob.dbc")]
    public sealed class QuestPOIBlobEntry
    {
        public int ID;
        public int NumPoints;
        public int MapID;
        public int WorldMapAreaID;
    }
}

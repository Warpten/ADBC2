using System;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "QuestPOIPoint.dbc")]
    public sealed class QuestPOIPointEntry
    {
        public int Id;
        public int X;
        public int Y;
        public int QuestPOIBlobID;
    }
}

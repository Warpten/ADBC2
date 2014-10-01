using DBFilesClient.NET;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfoAttribute(15595, "AreaPOI.dbc")]
    public sealed class AreaPOIEntry
    {
        public uint Id;              //0
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 11)]
        public uint[] Icon;        //1-11
        public float X;
        public float Y;
        public uint MapId;
        public int Flags;
        public int ZoneId;
        public string Name;
        public string Name2;
        public int WorldState;
        public int Unk1;
        public int Unk2;
    }
}

using DBFilesClient.NET;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "BattlemasterList.dbc")]
    public sealed class BattlemasterListEntry
    {
        public uint Id;

        [StoragePresence(StoragePresenceOption.Include, ArraySize = 8)]
        public int[] Mapid;

        public uint Type;
        public uint CanJoinAsGroup;
        public string Name;
        public uint MaxGroupSize;
        public uint HolidayWorldStateId;
        public uint MinLevel;
        public uint MaxLevel;
        public uint MaxGroupSizeRated;
        public uint MinPlayers;
        public uint MaxPlayers;
        public uint UnkCataclysm;
    }
}
using DBFilesClient.NET;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfoAttribute(15595, "AreaGroup.dbc")]
    public sealed class AreaGroupEntry
    {
        public uint Id;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 6)]
        public uint[] AreaId;
        public uint NextGroup;
    }
}
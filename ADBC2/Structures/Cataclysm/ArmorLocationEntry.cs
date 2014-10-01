using System;
using DBFilesClient.NET;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "ArmorLocation.dbc")]
    public sealed class ArmorLocationEntry
    {
        public uint InventoryType;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 5)]
        public float[] Value;
    }
}

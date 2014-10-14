using System;
using DBFilesClient.NET;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "CreatureSpellData.dbc")]
    public sealed class CreatureSpellDataEntry
    {
        public uint Id;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 4)]
        public uint[] SpellId;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 4)]
        public uint[] Availability;
    }
}

using System;
using DBFilesClient.NET;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "CinematicSequences.dbc")]
    public sealed class CinematicSequencesEntry
    {
        public uint Id;
        public uint SoundId;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 8)]
        public uint[] CinematicCamera;
    }
}

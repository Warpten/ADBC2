using System;
using DBFilesClient.NET;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "GameObjectDisplayInfo.dbc")]
    public sealed class GameObjectDisplayInfoEntry
    {
        public int DisplayId;
        public string FileName;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 10)]
        public int[] SoundId;
        public float MinX;
        public float MinY;
        public float MinZ;
        public float MaxX;
        public float MaxY;
        public float MaxZ;
        public uint Transport;
        public float OverrideLootEffectScale;
        public float OverrideNameScale;
    }
}

using System;
using DBFilesClient.NET;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "CreatureDisplayInfo.dbc")]
    public sealed class CreatureDisplayInfoEntry
    {
        public uint Id;
        public uint ModelId;
        public uint SoundId;
        public uint ExtendedDisplayInfoId;
        public float ModelScale;
        public uint ModelAlpha;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 3)]
        public string[] TextureVariations;
        public string PortraitTextureName;
        public int SizeClass;
        public uint BloodId;
        public uint NPCSoundId;
        public uint ParticleColorId;
        public uint CreatureGeosetData;
        public uint ObjectEffectPackageId;
        public uint AnimReplacementSetId;		
    }
}

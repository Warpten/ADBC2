using System;
using DBFilesClient.NET;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "CreatureFamily.dbc")]
    public sealed class CreatureFamilyEntry
    {
        public uint Id;
        public float MinScale;
        public uint MinScaleLevel;
        public float MaxScale;
        public uint MaxScaleLevel;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 2)]
        public uint[] SkillLine;
        public uint PetFoodMask;
        public int PetTalentType;
        public uint CategoryEnumId;
        public string Name;
        public uint IconFile;
    }
}

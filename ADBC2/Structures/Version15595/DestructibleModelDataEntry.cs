using System;

namespace ADBC2.Structures.Cataclysm
{
    // Names taken from 6.0.1.18179, adding one field to match file header
    [DbFileInfo(15595, "DestructibleModelData.dbc")]
    public sealed class DestructibleModelDataEntry
    {
        public int Id;
        public int State0Wmo;
        public int State0ImpactEffectDoodadSet;
        public int State0AmbientDoodadSet;
        public int State0NameSet;
        public int State1Wmo;
        public int State1ImpactEffectDoodadSet;
        public int State1AmbientDoodadSet;
        public int State1NameSet;
        public int RebuildingDisplayId;
        public int State2Wmo;
        public int State2ImpactEffectDoodadSet;
        public int State2AmbientDoodadSet;
        public int State2NameSet;
        public int State3Wmo;
        public int State3ImpactEffectDoodadSet;
        public int State3AmbientDoodadSet;
        public int State3NameSet;
        public int EjectDirection;
        public int RepairGroundFx;
        public int DoNotHighlight;
        public int HealEffect;
        public int HealEffectSpeed;
        public int Unk0;
    }
}

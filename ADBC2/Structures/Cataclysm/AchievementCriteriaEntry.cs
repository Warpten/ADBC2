using System;
using DBFilesClient.NET;

namespace ADBC2.Structures.Cataclysm
{
    [ClientVersion(15595)]
    [FileStructure("Achievement_Criteria.dbc")]
    public sealed class AchievementCriteriaEntry
    {
        private uint _Id;
        //public uint Id { get; set; }
        
        private uint _AchievementId;
        public uint AchievementId { get { return _AchievementId; } }
        
        private uint _Type;
        public uint Type { get { return _Type; } }
        
        private uint _FirstValue;
        public uint MainRequirement { get { return _FirstValue; } }
        
        private ulong _SecondValue;
        public ulong MainRequirementCount { get { return _SecondValue; } }
        
        private uint _ExtraReqType_0;
        public uint ExtraReqType_0 { get { return _ExtraReqType_0; } }
        
        private uint _ExtraReqValue_0;
        public uint ExtraReqValue_0 { get { return _ExtraReqValue_0; } }
        
        private uint _ExtraReqType_1;
        public uint ExtraReqType_1 { get { return _ExtraReqType_1; } }
        
        private uint _ExtraReqValue_1;
        public uint ExtraReqValue_1 { get { return _ExtraReqValue_1; } }
        
        private string _Name;
        public string Name { get { return _Name; } }
        
        private uint _CompletionFlags;
        public uint CompletionFlags { get { return _CompletionFlags; } }
        
        private uint _TimedCriteriaStartType;
        public uint TimedCriteriaStartType { get { return _TimedCriteriaStartType; } }
        
        private uint _TimedCriteriaMiscId;
        public uint TimedCriteriaMiscId { get { return _TimedCriteriaMiscId; } }
        
        private uint _TimerLimit;
        public uint TimerLimit { get { return _TimerLimit; } }
        
        private uint _ShowOrder;
        public uint ShowOrder { get { return _ShowOrder; } }
        
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 2)]
        private uint[] _Unk_1;
        // public uint Unk_1 { get { return _Unk_1; } } // Unhide when meaning is found
        
        // private uint _Unk_2;
        // public uint Unk_2 { get { return _Unk_2; } } // Unhide when meaning is found
        
        private uint _ExtraConditionType1;
        private uint _ExtraConditionType2;
        private uint _ExtraConditionType3;
        public uint ExtraConditionType1 { get { return _ExtraConditionType1; } }
        public uint ExtraConditionType2 { get { return _ExtraConditionType2; } }
        public uint ExtraConditionType3 { get { return _ExtraConditionType3; } }
        
        private uint _ExtraConditionValue1;
        private uint _ExtraConditionValue2;
        private uint _ExtraConditionValue3;
        public uint ExtraConditionValue1 { get { return _ExtraConditionValue1; } }
        public uint ExtraConditionValue2 { get { return _ExtraConditionValue2; } }
        public uint ExtraConditionValue3 { get { return _ExtraConditionValue3; } }
    }
}

using System;
using BrightIdeasSoftware;
using DBFilesClient.NET;
using BrightIdeasSoftware;

namespace ADBC2.Structures.Cataclysm
{
    [ClientVersion(15595)]
    [FileStructure("Achievement_Criteria.dbc")]
    public sealed class AchievementCriteriaEntry
    {
        public uint Id;
        public uint AchievementId;
        public uint Type;
        public uint MainRequirement;
        public ulong MainRequirementCount;
        public uint ExtraReqType_0;
        public uint ExtraReqValue_0;
        public uint ExtraReqType_1;
        public uint ExtraReqValue_1;
        public string Name;
        public uint CompletionFlags;
        public uint TimedCriteriaStartType;
        public uint TimedCriteriaMiscId;
        public uint TimerLimit;
        public uint ShowOrder;
        
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 2)]
        [OLVIgnore]
        public uint[] _Unk_1;
        
        public uint ExtraConditionType_1;
        public uint ExtraConditionType_2;
        public uint ExtraConditionType_3;
        public uint ExtraConditionValue_1;
        public uint ExtraConditionValue_2;
        public uint ExtraConditionValue_3;
    }
}

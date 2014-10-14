using System;
using BrightIdeasSoftware; 

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "Map.dbc")]
    public sealed class MapEntry
    {
        public uint MapId;
        public string InternalName;
        public uint InstanceType; // MapType
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public uint MapType; // 18179 name
        public uint IsPvP;
        public string MapName;
        public uint AreaTableId;
        public string HordeIntro;
        public string AllianceIntro;
        public int LoadingScreenId;
        public float BattlefieldMapIconScale;
        public int CorpseMapId;
        public float CorpseEntranceX;
        public float CorpseEntranceY;
        public int TimeOfDayOverride;
        public uint Expansion;
        public uint ExpireTime;
        public uint MaxPlayers;
        public int RootPhaseMap;
    }
}

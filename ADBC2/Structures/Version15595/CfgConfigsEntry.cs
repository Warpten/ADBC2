using System;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "Cfg_Configs.dbc")]
    // Names taken from 16179 build (has an extra field)
    public sealed class CfgConfigsEntry
    {
        public uint ID;
        public uint RealmType;
        public uint PlayerKillingAllowed;
        public uint RolePlaying;
        public uint PlayerAttackSpeedBase;
    }
}

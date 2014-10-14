using System;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "PhaseShiftZoneSounds.dbc")]
    public sealed class PhaseShiftZoneSoundsEntry
    {
        public uint Id;
        public uint AreaId;
        public uint WmoAreaId;
        public uint PhaseId;
        public uint PhaseGroupId;
        public uint PhaseUsesFlags;
        public uint ZoneIntroMusicId;
        public uint ZoneMusicId;
        public uint SoundAmbienceId;
        public uint SoundProviderReferenceId;
        public uint UWZoneIntroMusicId;
        public uint UWZoneMusicId;
        public uint UWSoundAmbienceId;
        public uint UWSoundProviderPreferencesID;
    }
}

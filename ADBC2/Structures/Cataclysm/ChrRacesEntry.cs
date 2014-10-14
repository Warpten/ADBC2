using System;
using BrightIdeasSoftware;
using DBFilesClient.NET;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "ChrRaces.dbc")]
    public sealed class ChrRacesEntry
    {
        public uint RaceId;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public uint FactionId;
        public uint ExplorationSoundId;
        public uint MaleDisplayId;
        public uint FemaleDisplayId;
        public string ClientPrefix;
        public uint BaseLanguage;
        public uint CreatureType;
        public uint ResSicknessSpellId;
        public uint SplashSoundId;
        public string ClientFileString;
        public uint CinematicSequence;
        public uint Alliance;
        public string Name;
        public string NameFemale;
        public string NameMale;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 2)]
        public uint[] FacialHairCustomization;
        public uint HairCustomization;
        public uint Expansion; // Probably not it.
        public uint UnkCataclysm1;
        public uint UnkCataclysm2;
        public uint UnkCataclysm3;
    }
}

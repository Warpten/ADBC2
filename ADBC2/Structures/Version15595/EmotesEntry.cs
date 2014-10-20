using System;
using BrightIdeasSoftware;

namespace ADBC2.Structures.Version15595
{
    [DbFileInfo(15595, "Emotes.dbc")]
    public sealed class EmotesEntry
    {
        public uint Id;
        public string SlashCommand;
        public uint AnimationId;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint EmoteFlags;
        public uint EmoteType;
        public uint UnitStandState;
        public uint SoundId;
        public uint SpellVisualKitId;
    }
}

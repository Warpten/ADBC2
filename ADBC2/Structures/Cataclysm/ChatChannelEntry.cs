using System;
using BrightIdeasSoftware;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "ChatChannels.dbc")]
    public sealed class ChatChannelsEntry
    {
        public int ID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int FactionGroup;
        public string Name;
        public string ShortcutName;
    }
}

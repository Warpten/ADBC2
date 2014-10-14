using System;
using BrightIdeasSoftware;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "Phase.dbc")]
    public sealed class PhaseEntry
    {
        public uint Id;
        public string Name;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flag;
    }
}

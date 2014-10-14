using System;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "CreatureMovementInfo.dbc")]
    public sealed class CreatureMovementInfoEntry
    {
        public uint Id;
        public uint SmoothFacingChaseRate;
    }
}

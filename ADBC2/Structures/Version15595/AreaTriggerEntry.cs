﻿using System;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "AreaTrigger.dbc")]
    public sealed class AreaTriggerEntry
    {
        public uint Id;
        public uint MapId;
        public float X;
        public float Y;
        public float Z;
        public uint UnkCataclysm1;
        public uint Phase;
        public uint UnkCataclysm2;
        public float Radius;
        public float Box_X;
        public float Box_Y;
        public float Box_Z;
        public float Box_Orientation;
    }
}

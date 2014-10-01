﻿using System;

namespace ADBC2.Structures.Cataclysm
{
    /// <summary>
    /// Description of CameraShakesEntry.
    /// </summary>
    [DbFileInfo(15595, "CameraShakes.dbc")]
    public sealed class CameraShakesEntry
    {
        public uint Id;
        public uint ShakeType;
        public uint Direction;
        public float Amplitude;
        public float Frequency;
        public float Duration;
        public float Phase;
        public float Coefficient;
        public uint UnkCataclysm;
    }
}

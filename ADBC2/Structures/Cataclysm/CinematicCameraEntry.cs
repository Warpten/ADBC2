using System;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfo(15595, "CinematicCamera.dbc")]
    public sealed class CinematicCameraEntry
    {
        public uint Id;
        public string FileName;
        public uint Soundid;
        public float StartX;
        public float StartY;
        public float StartZ;
        public float Rotation;
    }
}

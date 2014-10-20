using System;

namespace ADBC2.Structures.Version15595
{
    [DbFileInfo(15595, "DungeonMap.dbc")]
    public sealed class DungeonMapEntry
    {
        public uint Id;
        public uint MapId;
        public int FloorIndex;
        public float MinX; // X or Y, magic build names do not tell
        public float MinY; // X or Y, magic build names do not tell
        public float MaxX; // X or Y, magic build names do not tell
        public float MaxY; // X or Y, magic build names do not tell
        public uint ParentWorldMapId;
    }
}

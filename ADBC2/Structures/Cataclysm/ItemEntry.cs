using System;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfoAttribute(15595, "Item.db2")]
    public sealed class ItemEntry
    {
        public uint Id;
        public uint Class;
        public uint SubClass;
        public int SoundOverrideSubclass;
        public int Material;
        public uint DisplayId;
        public uint InventoryType;
        public uint Sheath;
    }
}

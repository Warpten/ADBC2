using DBFilesClient.NET;

namespace ADBC2.Structures.Cataclysm
{
    [DbFileInfoAttribute(15595, "ItemExtendedCost.db2")]
    public sealed class ItemExtendedCostEntry
    {
        public uint Id;
        public uint RequiredHonorPoints;
        public uint RequiredArenaPoints;
        public uint RequiredArenaSlot;

        [StoragePresence(StoragePresenceOption.Include, ArraySize = 5)]
        public uint[] RequiredItem;

        [StoragePresence(StoragePresenceOption.Include, ArraySize = 5)]
        public uint[] RequiredItemCount;

        public uint RequiredPersonalArenaRating;
        public uint ItemPurchaseGroup;

        [StoragePresence(StoragePresenceOption.Include, ArraySize = 5)]
        public uint[] RequiredCurrency;

        [StoragePresence(StoragePresenceOption.Include, ArraySize = 5)]
        public uint[] RequiredCurrencyCount;

        public uint Unk1;
        public uint Unk2;
        public uint Unk3;
        public uint Unk4;
        public uint Unk5;
    }
}
using System;
using DBFilesClient.NET;

namespace ADBC2.Structures.Cataclysm
{
    [ClientVersion(15595)]
    [FileStructure("Item-sparse.db2")]
    public sealed class ItemSparseEntry
    {
        /*private uint _Id;
        public uint Id { get { return _Id; } }*/
        
        private uint _Quality;
        public uint Quality { get { return _Quality; } }
        
        private uint _Flags;
        public uint Flags { get { return _Flags; } }
        
        private uint _Flags2;
        public uint Flags2 { get { return _Flags2; } }
        
        private float _Unk430_1;
        public float Unk430_1 { get { return _Unk430_1; } }
        
        private float _Unk430_2;
        public float Unk430_2 { get { return _Unk430_2; } }
        
        private uint _BuyCount;
        public uint BuyCount { get { return _BuyCount; } }
        
        private uint _BuyPrice;
        public uint BuyPrice { get { return _BuyPrice; } }
        
        private uint _SellPrice;
        public uint SellPrice { get { return _SellPrice; } }
        
        private uint _InventoryType;
        public uint InventoryType { get { return _InventoryType; } }
        
        private int _AllowableClass;
        public int AllowableClass { get { return _AllowableClass; } }
        
        private int _AllowableRace;
        public int AllowableRace { get { return _AllowableRace; } }
        
        private uint _ItemLevel;
        public uint ItemLevel { get { return _ItemLevel; } }
        
        private int _RequiredLevel;
        public int RequiredLevel { get { return _RequiredLevel; } }
        
        private uint _RequiredSkill;
        public uint RequiredSkill { get { return _RequiredSkill; } }
        
        private uint _RequiredSkillRank;
        public uint RequiredSkillRank { get { return _RequiredSkillRank; } }
        
        private uint _RequiredSpell;
        public uint RequiredSpell { get { return _RequiredSpell; } }
        
        private uint _RequiredHonorRank;
        public uint RequiredHonorRank { get { return _RequiredHonorRank; } }
        
        private uint _RequiredCityRank;
        public uint RequiredCityRank { get { return _RequiredCityRank; } }
        
        private uint _RequiredReputationFaction;
        public uint RequiredReputationFaction { get { return _RequiredReputationFaction; } }
        
        private uint _RequiredReputationRank;
        public uint RequiredReputationRank { get { return _RequiredReputationRank; } }
        
        private uint _MaxCount;
        public uint MaxCount { get { return _MaxCount; } }
        
        private uint _Stackable;
        public uint Stackable { get { return _Stackable; } }
        
        private uint _ContainerSlots;
        public uint ContainerSlots { get { return _ContainerSlots; } }

        [StoragePresence(StoragePresenceOption.Include, ArraySize = 10)]
        private int[] _ItemStatType;
        public string ItemStatType { get { return _ItemStatType.Join(); } }

        [StoragePresence(StoragePresenceOption.Include, ArraySize = 10)]
        private uint[] _ItemStatValue;
        public uint[] ItemStatValue { get { return _ItemStatValue; } }
        
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 10)]
        private int[] _ItemStatUnk1;
        public int[] ItemStatUnk1 { get { return _ItemStatUnk1; } }

        [StoragePresence(StoragePresenceOption.Include, ArraySize = 10)]
        private int[] _ItemStatUnk2;
        public int[] ItemStatUnk2 { get { return _ItemStatUnk2; } }

        private uint _ScalingStatDistribution;
        public uint ScalingStatDistribution { get { return _ScalingStatDistribution; } }
        
        private uint _DamageType;
        public uint DamageType { get { return _DamageType; } }
        
        private uint _Delay;
        public uint Delay { get { return _Delay; } }
        
        private float _RangedModRange;
        public float RangedModRange { get { return _RangedModRange; } }
        
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 5)]
        private int[] _SpellId;
        public int[] SpellId { get { return _SpellId; } }
        
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 5)]
        private int[] _SpellTrigger;
        public int[] SpellTrigger { get { return _SpellTrigger; } }
        
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 5)]
        private int[] _SpellCharges;
        public int[] SpellCharges { get { return _SpellCharges; } }
        
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 5)]
        private int[] _SpellCooldown;
        public int[] SpellCooldown { get { return _SpellCooldown; } }
        
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 5)]
        private int[] _SpellCategory;
        public int[] SpellCategory { get { return _SpellCategory; } }
        
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 5)]
        private int[] _SpellCategoryCooldown;
        public int[] SpellCategoryCooldown { get { return _SpellCategoryCooldown; } }
                
        private uint _Bonding;
        public uint Bonding { get { return _Bonding; } }

        private string _Name;
        public string Name { get { return _Name; } }
        
        private string _Name2;
        public string Name2 { get { return _Name2; } }
        
        private string _Name3;
        public string Name3 { get { return _Name3; } }
        
        private string _Name4;
        public string Name4 { get { return _Name4; } }
        
        private string _Description;
        public string Description { get { return _Description; } }
        
        private uint _PageText;
        public uint PageText { get { return _PageText; } }
        
        private uint _LanguageID;
        public uint LanguageID { get { return _LanguageID; } }
        
        private uint _PageMaterial;
        public uint PageMaterial { get { return _PageMaterial; } }
        
        private uint _StartQuest;
        public uint StartQuest { get { return _StartQuest; } }
        
        private uint _LockID;
        public uint LockID { get { return _LockID; } }
        
        private int _Material;
        public int Material { get { return _Material; } }
        
        private uint _Sheath;
        public uint Sheath { get { return _Sheath; } }
        
        private uint _RandomProperty;
        public uint RandomProperty { get { return _RandomProperty; } }
        
        private uint _RandomSuffix;
        public uint RandomSuffix { get { return _RandomSuffix; } }
        
        private uint _ItemSet;
        public uint ItemSet { get { return _ItemSet; } }
        
        private uint _Area;
        public uint Area { get { return _Area; } }
        
        private uint _Map;
        public uint Map { get { return _Map; } }
        
        private uint _BagFamily;
        public uint BagFamily { get { return _BagFamily; } }
        
        private uint _TotemCategory;
        public uint TotemCategory { get { return _TotemCategory; } }

        [StoragePresence(StoragePresenceOption.Include, ArraySize = 3)]
        private uint[] _Color;
        public string Color { get { return _Color.ToString(); } }

        [StoragePresence(StoragePresenceOption.Include, ArraySize = 3)]
        private uint[] _Content;
        public uint[] Content { get { return _Content; } }

        private int _SocketBonus;
        public int SocketBonus { get { return _SocketBonus; } }
        
        private uint _GemProperties;
        public uint GemProperties { get { return _GemProperties; } }
        
        private float _ArmorDamageModifier;
        public float ArmorDamageModifier { get { return _ArmorDamageModifier; } }
        
        private uint _Duration;
        public uint Duration { get { return _Duration; } }
        
        private uint _ItemLimitCategory;
        public uint ItemLimitCategory { get { return _ItemLimitCategory; } }
        
        private uint _HolidayId;
        public uint HolidayId { get { return _HolidayId; } }
        
        private float _StatScalingFactor;
        public float StatScalingFactor { get { return _StatScalingFactor; } }
        
        private int _CurrencySubstitutionId;
        public int CurrencySubstitutionId { get { return _CurrencySubstitutionId; } }
        
        private int _CurrencySubstitutionCount;
        public int CurrencySubstitutionCount { get { return _CurrencySubstitutionCount; } }
    }
}

using System;

namespace ADBC2.Structures.Version12340
{
    [DbFileInfo(12340, "Faction.dbc")]
    public sealed class FactionEntry
    {
        public uint m_ID;
        public int m_reputationIndex;
        public uint m_reputationRaceMask_1;
        public uint m_reputationRaceMask_2;
        public uint m_reputationRaceMask_3;
        public uint m_reputationRaceMask_4;
        public uint m_reputationClassMask_1;
        public uint m_reputationClassMask_2;
        public uint m_reputationClassMask_3;
        public uint m_reputationClassMask_4;
        public int m_reputationBase_1;
        public int m_reputationBase_2;
        public int m_reputationBase_3;
        public int m_reputationBase_4;
        public uint m_reputationFlags_1;
        public uint m_reputationFlags_2;
        public uint m_reputationFlags_3;
        public uint m_reputationFlags_4;
        public uint m_parentFactionID;
        public float spilloverRate1;
        public float spilloverRate2;
        public uint spilloverMaxRank;
        public uint spilloverRank_unk;
        public string m_name_lang_1;
        public string m_name_lang_2;
        public string m_name_lang_3;
        public string m_name_lang_4;
        public string m_name_lang_5;
        public string m_name_lang_6;
        public string m_name_lang_7;
        public string m_name_lang_8;
        public string m_name_lang_9;
        public string m_name_lang_10;
        public string m_name_lang_11;
        public string m_name_lang_12;
        public string m_name_lang_13;
        public string m_name_lang_14;
        public string m_name_lang_15;
        public string m_name_lang_16;
        public uint m_name_flag;
        public string m_description_lang_1;
        public string m_description_lang_2;
        public string m_description_lang_3;
        public string m_description_lang_4;
        public string m_description_lang_5;
        public string m_description_lang_6;
        public string m_description_lang_7;
        public string m_description_lang_8;
        public string m_description_lang_9;
        public string m_description_lang_10;
        public string m_description_lang_11;
        public string m_description_lang_12;
        public string m_description_lang_13;
        public string m_description_lang_14;
        public string m_description_lang_15;
        public string m_description_lang_16;
        public uint m_description_flag;
    };

    [DbFileInfo(12340, "FactionTemplate.dbc")]
    public sealed class FactionTemplateEntry
    {
        public uint m_ID;
        public uint m_faction;
        public uint m_flags;
        public uint m_factionGroup;
        public uint m_friendGroup;
        public uint m_enemyGroup;
        public uint m_enemies_1;
        public uint m_enemies_2;
        public uint m_enemies_3;
        public uint m_enemies_4;
        public uint m_friend_1;
        public uint m_friend_2;
        public uint m_friend_3;
        public uint m_friend_4;
    };

    [DbFileInfo(12340, "Spell.dbc")]
    public sealed class SpellEntry
    {
        public uint m_ID;
        public uint m_category;
        public uint m_dispelType;
        public uint m_mechanic;
        public uint m_attributes;
        public uint m_attributesEx;
        public uint m_attributesExB;
        public uint m_attributesExC;
        public uint m_attributesExD;
        public uint m_attributesExE;
        public uint m_attributesExF;
        public uint m_attributesExG;
        public ulong m_shapeshiftMask;
        public ulong m_shapeshiftExclude;
        public uint m_targets;
        public uint m_targetCreatureType;
        public uint m_requiresSpellFocus;
        public uint m_facingCasterFlags;
        public uint m_casterAuraState;
        public uint m_targetAuraState;
        public uint m_excludeCasterAuraState;
        public uint m_excludeTargetAuraState;
        public uint m_casterAuraSpell;
        public uint m_targetAuraSpell;
        public uint m_excludeCasterAuraSpell;
        public uint m_excludeTargetAuraSpell;
        public uint m_castingTimeIndex;
        public uint m_recoveryTime;
        public uint m_categoryRecoveryTime;
        public uint m_interruptFlags;
        public uint m_auraInterruptFlags;
        public uint m_channelInterruptFlags;
        public uint m_procTypeMask;
        public uint m_procChance;
        public uint m_procCharges;
        public uint m_maxLevel;
        public uint m_baseLevel;
        public uint m_spellLevel;
        public uint m_durationIndex;
        public int m_powerType;
        public uint m_manaCost;
        public uint m_manaCostPerLevel;
        public uint m_manaPerSecond;
        public uint m_manaPerSecondPerLevel;
        public uint m_rangeIndex;
        public float m_speed;
        public uint m_modalNextSpell;
        public uint m_cumulativeAura;
        public uint m_totem_1;
        public uint m_totem_2;
        public int m_reagent_1;
        public int m_reagent_2;
        public int m_reagent_3;
        public int m_reagent_4;
        public int m_reagent_5;
        public int m_reagent_6;
        public int m_reagent_7;
        public int m_reagent_8;
        public int m_reagentCount_1;
        public int m_reagentCount_2;
        public int m_reagentCount_3;
        public int m_reagentCount_4;
        public int m_reagentCount_5;
        public int m_reagentCount_6;
        public int m_reagentCount_7;
        public int m_reagentCount_8;
        public int m_equippedItemClass;
        public int m_equippedItemSubclass;
        public int m_equippedItemInvTypes;
        public uint m_effect_1;
        public uint m_effect_2;
        public uint m_effect_3;
        public int m_effectDieSides_1;
        public int m_effectDieSides_2;
        public int m_effectDieSides_3;
        public float m_effectRealPointsPerLevel_1;
        public float m_effectRealPointsPerLevel_2;
        public float m_effectRealPointsPerLevel_3;
        public int m_effectBasePoints_1;
        public int m_effectBasePoints_2;
        public int m_effectBasePoints_3;
        public uint m_effectMechanic_1;
        public uint m_effectMechanic_2;
        public uint m_effectMechanic_3;
        public uint m_implicitTargetA_1;
        public uint m_implicitTargetA_2;
        public uint m_implicitTargetA_3;
        public uint m_implicitTargetB_1;
        public uint m_implicitTargetB_2;
        public uint m_implicitTargetB_3;
        public uint m_effectRadiusIndex_1;
        public uint m_effectRadiusIndex_2;
        public uint m_effectRadiusIndex_3;
        public uint m_effectAura_1;
        public uint m_effectAura_2;
        public uint m_effectAura_3;
        public uint m_effectAuraPeriod_1;
        public uint m_effectAuraPeriod_2;
        public uint m_effectAuraPeriod_3;
        public float m_effectAmplitude_1;
        public float m_effectAmplitude_2;
        public float m_effectAmplitude_3;
        public uint m_effectChainTargets_1;
        public uint m_effectChainTargets_2;
        public uint m_effectChainTargets_3;
        public uint m_effectItemType_1;
        public uint m_effectItemType_2;
        public uint m_effectItemType_3;
        public int m_effectMiscValue_1;
        public int m_effectMiscValue_2;
        public int m_effectMiscValue_3;
        public int m_effectMiscValueB_1;
        public int m_effectMiscValueB_2;
        public int m_effectMiscValueB_3;
        public uint m_effectTriggerSpell_1;
        public uint m_effectTriggerSpell_2;
        public uint m_effectTriggerSpell_3;
        public float m_effectPointsPerCombo_1;
        public float m_effectPointsPerCombo_2;
        public float m_effectPointsPerCombo_3;
        public uint m_effectSpellClassMaskA_1;
        public uint m_effectSpellClassMaskA_2;
        public uint m_effectSpellClassMaskA_3;
        public uint m_effectSpellClassMaskB_1;
        public uint m_effectSpellClassMaskB_2;
        public uint m_effectSpellClassMaskB_3;
        public uint m_effectSpellClassMaskC_1;
        public uint m_effectSpellClassMaskC_2;
        public uint m_effectSpellClassMaskC_3;
        public uint m_spellVisualID_1;
        public uint m_spellVisualID_2;
        public uint m_spellIconID;
        public uint m_activeIconID;
        public uint m_spellPriority;
        public string m_name_lang_1;
        public string m_name_lang_2;
        public string m_name_lang_3;
        public string m_name_lang_4;
        public string m_name_lang_5;
        public string m_name_lang_6;
        public string m_name_lang_7;
        public string m_name_lang_8;
        public string m_name_lang_9;
        public string m_name_lang_10;
        public string m_name_lang_11;
        public string m_name_lang_12;
        public string m_name_lang_13;
        public string m_name_lang_14;
        public string m_name_lang_15;
        public string m_name_lang_16;
        public uint m_name_flag;
        public string m_nameSubtext_lang_1;
        public string m_nameSubtext_lang_2;
        public string m_nameSubtext_lang_3;
        public string m_nameSubtext_lang_4;
        public string m_nameSubtext_lang_5;
        public string m_nameSubtext_lang_6;
        public string m_nameSubtext_lang_7;
        public string m_nameSubtext_lang_8;
        public string m_nameSubtext_lang_9;
        public string m_nameSubtext_lang_10;
        public string m_nameSubtext_lang_11;
        public string m_nameSubtext_lang_12;
        public string m_nameSubtext_lang_13;
        public string m_nameSubtext_lang_14;
        public string m_nameSubtext_lang_15;
        public string m_nameSubtext_lang_16;
        public uint m_nameSubtext_flag;
        public string m_description_lang_1;
        public string m_description_lang_2;
        public string m_description_lang_3;
        public string m_description_lang_4;
        public string m_description_lang_5;
        public string m_description_lang_6;
        public string m_description_lang_7;
        public string m_description_lang_8;
        public string m_description_lang_9;
        public string m_description_lang_10;
        public string m_description_lang_11;
        public string m_description_lang_12;
        public string m_description_lang_13;
        public string m_description_lang_14;
        public string m_description_lang_15;
        public string m_description_lang_16;
        public uint m_description_flag;
        public string m_auraDescription_lang_1;
        public string m_auraDescription_lang_2;
        public string m_auraDescription_lang_3;
        public string m_auraDescription_lang_4;
        public string m_auraDescription_lang_5;
        public string m_auraDescription_lang_6;
        public string m_auraDescription_lang_7;
        public string m_auraDescription_lang_8;
        public string m_auraDescription_lang_9;
        public string m_auraDescription_lang_10;
        public string m_auraDescription_lang_11;
        public string m_auraDescription_lang_12;
        public string m_auraDescription_lang_13;
        public string m_auraDescription_lang_14;
        public string m_auraDescription_lang_15;
        public string m_auraDescription_lang_16;
        public uint m_auraDescription_flag;
        public uint m_manaCostPct;
        public uint m_startRecoveryCategory;
        public uint m_startRecoveryTime;
        public uint m_maxTargetLevel;
        public uint m_spellClassSet;
        public uint m_spellClassMask_1;
        public uint m_spellClassMask_2;
        public uint m_spellClassMask_3;
        public uint m_maxTargets;
        public uint m_defenseType;
        public uint m_preventionType;
        public uint m_stanceBarOrder;
        public float m_effectChainAmplitude_1;
        public float m_effectChainAmplitude_2;
        public float m_effectChainAmplitude_3;
        public uint m_minFactionID;
        public uint m_minReputation;
        public uint m_requiredAuraVision;
        public uint m_requiredTotemCategoryID_1;
        public uint m_requiredTotemCategoryID_2;
        public int m_requiredAreasID;
        public uint m_schoolMask;
        public uint m_runeCostID;
        public uint m_spellMissileID;
        public int m_powerDisplayID;
        public float m_unk1_1;
        public float m_unk1_2;
        public float m_unk1_3;
        public uint m_spellDescriptionVariableID;
        public uint m_spellDifficultyID;
    };

    [DbFileInfo(12340, "SpellCastTimes.dbc")]
    public sealed class SpellCastTimesEntry
    {
        public int id;
        public int CastTime;
        public int CastTimePerLevel;
        public int MinCastTime;
    };

    [DbFileInfo(12340, "SpellIcon.dbc")]
    public sealed class SpellIconEntry
    {
        public int id;
        public string icon;
    };

    [DbFileInfo(12340, "SpellItemEnchantmentCondition.dbc")]
    public sealed class SpellItemEnchantmentConditionEntry
    {
        public int m_ID;
        public byte m_lt_operandType1;
        public byte m_lt_operandType2;
        public byte m_lt_operandType3;
        public byte m_lt_operandType4;
        public byte m_lt_operandType5;
        public uint m_lt_operand1;
        public uint m_lt_operand2;
        public uint m_lt_operand3;
        public uint m_lt_operand4;
        public uint m_lt_operand5;
        public byte m_operator1;
        public byte m_operator2;
        public byte m_operator3;
        public byte m_operator4;
        public byte m_operator5;
        public byte m_rt_operandType1;
        public byte m_rt_operandType2;
        public byte m_rt_operandType3;
        public byte m_rt_operandType4;
        public byte m_rt_operandType5;
        public uint m_rt_operand1;
        public uint m_rt_operand2;
        public uint m_rt_operand3;
        public uint m_rt_operand4;
        public uint m_rt_operand5;
        public byte m_logic1;
        public byte m_logic2;
        public byte m_logic3;
        public byte m_logic4;
        public byte m_logic5;
    };

    [DbFileInfo(12340, "WorldSafeLocs.dbc")]
    public sealed class WorldSafeLocsEntry
    {
        public uint id;
        public uint map;
        public float pos_x;
        public float pos_y;
        public float pos_z;
        public string m_name_lang_1;
        public string m_name_lang_2;
        public string m_name_lang_3;
        public string m_name_lang_4;
        public string m_name_lang_5;
        public string m_name_lang_6;
        public string m_name_lang_7;
        public string m_name_lang_8;
        public string m_name_lang_9;
        public string m_name_lang_10;
        public string m_name_lang_11;
        public string m_name_lang_12;
        public string m_name_lang_13;
        public string m_name_lang_14;
        public string m_name_lang_15;
        public string m_name_lang_16;
        public int m_name_lang_flags;
    };

    [DbFileInfo(12340, "gtBarberShopCostBase.dbc")]
    public sealed class gtBarberShopCostBaseEntry
    {
        public float m_cost;
    };

    [DbFileInfo(12340, "AnimationData.dbc")]
    public sealed class AnimationDataEntry
    {
        public int newField0;
        public string newField1;
        public int newField2;
        public int newField3;
        public int newField4;
        public int newField5;
        public int newField6;
        public int newField7;
    };

    [DbFileInfo(12340, "TeamContributionPoints.dbc")]
    public sealed class TeamContributionPointsEntry
    {
        public uint m_level;
        public float m_multiplier;
    };

    [DbFileInfo(12340, "Map.dbc")]
    public sealed class MapEntry
    {
        public int m_ID;
        public string m_Directory;
        public int m_InstanceType;
        public int m_Flags;
        public int m_PVP;
        public string m_MapName_lang1;
        public string m_MapName_lang2;
        public string m_MapName_lang3;
        public string m_MapName_lang4;
        public string m_MapName_lang5;
        public string m_MapName_lang6;
        public string m_MapName_lang7;
        public string m_MapName_lang8;
        public string m_MapName_lang9;
        public string m_MapName_lang10;
        public string m_MapName_lang11;
        public string m_MapName_lang12;
        public string m_MapName_lang13;
        public string m_MapName_lang14;
        public string m_MapName_lang15;
        public string m_MapName_lang16;
        public int m_MapName_lang_flags;
        public int m_areaTableID;
        public string m_MapDescription0_lang1;
        public string m_MapDescription0_lang2;
        public string m_MapDescription0_lang3;
        public string m_MapDescription0_lang4;
        public string m_MapDescription0_lang5;
        public string m_MapDescription0_lang6;
        public string m_MapDescription0_lang7;
        public string m_MapDescription0_lang8;
        public string m_MapDescription0_lang9;
        public string m_MapDescription0_lang10;
        public string m_MapDescription0_lang11;
        public string m_MapDescription0_lang12;
        public string m_MapDescription0_lang13;
        public string m_MapDescription0_lang14;
        public string m_MapDescription0_lang15;
        public string m_MapDescription0_lang16;
        public int m_MapDescription0_lang_flags;
        public string m_MapDescription1_lang1;
        public string m_MapDescription1_lang2;
        public string m_MapDescription1_lang3;
        public string m_MapDescription1_lang4;
        public string m_MapDescription1_lang5;
        public string m_MapDescription1_lang6;
        public string m_MapDescription1_lang7;
        public string m_MapDescription1_lang8;
        public string m_MapDescription1_lang9;
        public string m_MapDescription1_lang10;
        public string m_MapDescription1_lang11;
        public string m_MapDescription1_lang12;
        public string m_MapDescription1_lang13;
        public string m_MapDescription1_lang14;
        public string m_MapDescription1_lang15;
        public string m_MapDescription1_lang16;
        public int m_MapDescription1_lang_flags;
        public int m_LoadingScreenID;
        public float m_minimapIconScale;
        public int m_corpseMapID;
        public float m_corpseX;
        public float m_corpseY;
        public int m_timeOfDayOverride;
        public int m_expansionID;
        public int m_raidOffset;
        public int m_maxPlayers;
    };

    [DbFileInfo(12340, "gtCombatRatings.dbc")]
    public sealed class gtCombatRatingsEntry
    {
        public float field0;
    };

    [DbFileInfo(12340, "Holidays.dbc")]
    public sealed class HolidaysEntry
    {
        public int field0;
        public int field1;
        public int field2;
        public int field3;
        public int field4;
        public int field5;
        public int field6;
        public int field7;
        public int field8;
        public int field9;
        public int field10;
        public int field11;
        public int field12;
        public int field13;
        public int field14;
        public int field15;
        public int field16;
        public int field17;
        public int field18;
        public int field19;
        public int field20;
        public int field21;
        public int field22;
        public int field23;
        public int field24;
        public int field25;
        public int field26;
        public int field27;
        public int field28;
        public int field29;
        public int field30;
        public int field31;
        public int field32;
        public int field33;
        public int field34;
        public int field35;
        public int field36;
        public int field37;
        public int field38;
        public int field39;
        public int field40;
        public int field41;
        public int field42;
        public int field43;
        public int field44;
        public int field45;
        public int field46;
        public int field47;
        public int field48;
        public int holidayNameId;
        public int holidayDescriptionId;
        public string texture;
        public int field52;
        public int field53;
        public int field54;
    };

    [DbFileInfo(12340, "HolidayDescriptions.dbc")]
    public sealed class HolidayDescriptionsEntry
    {
        public int field0;
        public string field1;
        public string field2;
        public string field3;
        public string field4;
        public string field5;
        public string field6;
        public string field7;
        public string field8;
        public string field9;
        public string field10;
        public string field11;
        public string field12;
        public string field13;
        public string field14;
        public string field15;
        public string field16;
        public int field17;
    };

    [DbFileInfo(12340, "HolidayNames.dbc")]
    public sealed class HolidayNamesEntry
    {
        public int field0;
        public string field1;
        public string field2;
        public string field3;
        public string field4;
        public string field5;
        public string field6;
        public string field7;
        public string field8;
        public string field9;
        public string field10;
        public string field11;
        public string field12;
        public string field13;
        public string field14;
        public string field15;
        public string field16;
        public int field17;
    };

    [DbFileInfo(12340, "SpellRadius.dbc")]
    public sealed class SpellRadiusEntry
    {
        public int m_ID;
        public float m_radius;
        public float m_radiusPerLevel;
        public float m_radiusMax;
    };

    [DbFileInfo(12340, "SpellItemEnchantment.dbc")]
    public sealed class SpellItemEnchantmentEntry
    {
        public int m_ID;
        public int m_charges;
        public int m_effect_1;
        public int m_effect_2;
        public int m_effect_3;
        public int m_effectPointsMin_1;
        public int m_effectPointsMin_2;
        public int m_effectPointsMin_3;
        public int m_effectPointsMax_1;
        public int m_effectPointsMax_2;
        public int m_effectPointsMax_3;
        public int m_effectArg_1;
        public int m_effectArg_2;
        public int m_effectArg_3;
        public string m_name_lang_1;
        public int m_name_lang_2;
        public int m_name_lang_3;
        public int m_name_lang_4;
        public int m_name_lang_5;
        public int m_name_lang_6;
        public int m_name_lang_7;
        public int m_name_lang_8;
        public int m_name_lang_9;
        public int m_name_lang_10;
        public int m_name_lang_11;
        public int m_name_lang_12;
        public int m_name_lang_13;
        public int m_name_lang_14;
        public int m_name_lang_15;
        public int m_name_lang_16;
        public int m_name_flags;
        public int m_itemVisual;
        public int m_flags;
        public int m_src_itemID;
        public int m_condition_id;
        public int m_requiredSkillID;
        public int m_requiredSkillRank;
        public int m_minLevel;
    };

    [DbFileInfo(12340, "GemProperties.dbc")]
    public sealed class GemPropertiesEntry
    {
        public int field0;
        public int field1;
        public int field2;
        public int field3;
        public int field4;
    };

    [DbFileInfo(12340, "EmotesText.dbc")]
    public sealed class EmotesTextEntry
    {
        public int field0;
        public int field1;
        public int field2;
        public int field3;
        public int field4;
        public int field5;
        public int field6;
        public int field7;
        public int field8;
        public int field9;
        public int field10;
        public int field11;
        public int field12;
        public int field13;
        public int field14;
        public int field15;
        public int field16;
        public int field17;
        public int field18;
    };

    [DbFileInfo(12340, "ChrRaces.dbc")]
    public sealed class ChrRacesEntry
    {
        public int field0;
        public int field1;
        public int field2;
        public int field3;
        public int field4;
        public int field5;
        public string field6;
        public int field7;
        public int field8;
        public int field9;
        public int field10;
        public string field11;
        public int field12;
        public int field13;
        public string field14;
        public int field15;
        public int field16;
        public int field17;
        public int field18;
        public int field19;
        public int field20;
        public int field21;
        public int field22;
        public int field23;
        public int field24;
        public int field25;
        public int field26;
        public int field27;
        public int field28;
        public int field29;
        public int field30;
        public int field31;
        public int field32;
        public int field33;
        public int field34;
        public int field35;
        public int field36;
        public int field37;
        public int field38;
        public int field39;
        public int field40;
        public int field41;
        public int field42;
        public int field43;
        public int field44;
        public int field45;
        public int field46;
        public int field47;
        public int field48;
        public int field49;
        public int field50;
        public int field51;
        public int field52;
        public int field53;
        public int field54;
        public int field55;
        public int field56;
        public int field57;
        public int field58;
        public int field59;
        public int field60;
        public int field61;
        public int field62;
        public int field63;
        public int field64;
        public string field65;
        public string field66;
        public string field67;
        public int field68;
    };

    [DbFileInfo(12340, "AreaTable.dbc")]
    public sealed class AreaTableEntry
    {
        public int m_ID;
        public int m_ContinentID;
        public int m_ParentAreaID;
        public int m_AreaBit;
        public int m_flags;
        public int m_SoundProviderPref;
        public int m_SoundProviderPrefUnderwater;
        public int m_AmbienceID;
        public int m_ZoneMusic;
        public int m_IntroSound;
        public int m_ExplorationLevel;
        public string m_AreaName_lang;
        public int m_AreaName_lang2;
        public int m_AreaName_lang3;
        public int m_AreaName_lang4;
        public int m_AreaName_lang5;
        public int m_AreaName_lang6;
        public int m_AreaName_lang7;
        public int m_AreaName_lang8;
        public int m_AreaName_lang9;
        public int m_AreaName_lang10;
        public int m_AreaName_lang11;
        public int m_AreaName_lang12;
        public int m_AreaName_lang13;
        public int m_AreaName_lang14;
        public int m_AreaName_lang15;
        public int m_AreaName_lang16;
        public int m_AreaName_flags;
        public int m_factionGroupMask;
        public int m_liquidTypeID_1;
        public int m_liquidTypeID_2;
        public int m_liquidTypeID_3;
        public int m_liquidTypeID_4;
        public float m_minElevation;
        public float m_ambient_multiplier;
        public int m_lightid;
    };

    [DbFileInfo(12340, "LFGDungeons.dbc")]
    public sealed class LFGDungeonsEntry
    {
        public int m_ID;
        public string m_name_lang1;
        public int m_name_lang2;
        public int m_name_lang3;
        public int m_name_lang4;
        public int m_name_lang5;
        public int m_name_lang6;
        public int m_name_lang7;
        public int m_name_lang8;
        public int m_name_lang9;
        public int m_name_lang10;
        public int m_name_lang11;
        public int m_name_lang12;
        public int m_name_lang13;
        public int m_name_lang14;
        public int m_name_lang15;
        public int m_name_lang16;
        public int m_name_lang_flags;
        public int m_minLevel;
        public int m_maxLevel;
        public int m_target_level;
        public int m_target_level_min;
        public int m_target_level_max;
        public int m_mapID;
        public int m_difficulty;
        public int m_flags;
        public int m_typeID;
        public int m_faction;
        public string m_textureFilename;
        public int m_order_index;
        public int newField1;
        public int m_group_id;
        public string m_description_lang1;
        public string m_description_lang2;
        public string m_description_lang3;
        public string m_description_lang4;
        public string m_description_lang5;
        public string m_description_lang6;
        public string m_description_lang7;
        public string m_description_lang8;
        public string m_description_lang9;
        public string m_description_lang10;
        public string m_description_lang11;
        public string m_description_lang12;
        public string m_description_lang13;
        public string m_description_lang14;
        public string m_description_lang15;
        public string m_description_lang16;
        public int m_description_lang_flags;
    };

    [DbFileInfo(12340, "AuctionHouse.dbc")]
    public sealed class AuctionHouseEntry
    {
        public int field0;
        public int field1;
        public int field2;
        public int field3;
        public string field4;
        public int field5;
        public int field6;
        public int field7;
        public int field8;
        public int field9;
        public int field10;
        public int field11;
        public int field12;
        public int field13;
        public int field14;
        public int field15;
        public int field16;
        public int field17;
        public int field18;
        public int field19;
        public int field20;
    };

    [DbFileInfo(12340, "SpellDifficulty.dbc")]
    public sealed class SpellDifficultyEntry
    {
        public int m_id;
        public int m_spell_1;
        public int m_spell_2;
        public int m_spell_3;
        public int m_spell_4;
    };

    [DbFileInfo(12340, "SkillTiers.dbc")]
    public sealed class SkillTiersEntry
    {
        public int field0;
        public int field1;
        public int field2;
        public int field3;
        public int field4;
        public int field5;
        public int field6;
        public int field7;
        public int field8;
        public int field9;
        public int field10;
        public int field11;
        public int field12;
        public int field13;
        public int field14;
        public int field15;
        public int field16;
        public int field17;
        public int field18;
        public int field19;
        public int field20;
        public int field21;
        public int field22;
        public int field23;
        public int field24;
        public int field25;
        public int field26;
        public int field27;
        public int field28;
        public int field29;
        public int field30;
        public int field31;
        public int field32;
    };

    [DbFileInfo(12340, "SkillLineAbility.dbc")]
    public sealed class SkillLineAbilityEntry
    {
        public int field0;
        public int field1;
        public int field2;
        public int field3;
        public int field4;
        public int field5;
        public int field6;
        public int field7;
        public int field8;
        public int field9;
        public int field10;
        public int field11;
        public int field12;
        public int field13;
    };

    [DbFileInfo(12340, "SkillLine.dbc")]
    public sealed class SkillLineEntry
    {
        public int field0;
        public int field1;
        public int field2;
        public string field3;
        public int field4;
        public int field5;
        public int field6;
        public int field7;
        public int field8;
        public int field9;
        public int field10;
        public int field11;
        public int field12;
        public int field13;
        public int field14;
        public int field15;
        public int field16;
        public int field17;
        public int field18;
        public int field19;
        public string field20;
        public int field21;
        public int field22;
        public int field23;
        public int field24;
        public int field25;
        public int field26;
        public int field27;
        public int field28;
        public int field29;
        public int field30;
        public int field31;
        public int field32;
        public int field33;
        public int field34;
        public int field35;
        public int field36;
        public int field37;
        public string field38;
        public int field39;
        public int field40;
        public int field41;
        public int field42;
        public int field43;
        public int field44;
        public int field45;
        public int field46;
        public int field47;
        public int field48;
        public int field49;
        public int field50;
        public int field51;
        public int field52;
        public int field53;
        public int field54;
        public int field55;
    };

    [DbFileInfo(12340, "ItemRandomProperties.dbc")]
    public sealed class ItemRandomPropertiesEntry
    {
        public int m_ID;
        public string m_Name;
        public int m_Enchantment1;
        public int m_Enchantment2;
        public int m_Enchantment3;
        public int m_Enchantment4;
        public int m_Enchantment5;
        public string m_name_lang1;
        public int field8;
        public int field9;
        public int field10;
        public int field11;
        public int field12;
        public int field13;
        public int field14;
        public int field15;
        public int field16;
        public int field17;
        public int field18;
        public int field19;
        public int field20;
        public int field21;
        public int field22;
        public int field23;
    };

    [DbFileInfo(12340, "ItemRandomSuffix.dbc")]
    public sealed class ItemRandomSuffixEntry
    {
        public int field0;
        public string field1;
        public int field2;
        public int field3;
        public int field4;
        public int field5;
        public int field6;
        public int field7;
        public int field8;
        public int field9;
        public int field10;
        public int field11;
        public int field12;
        public int field13;
        public int field14;
        public int field15;
        public int field16;
        public int field17;
        public string field18;
        public int field19;
        public int field20;
        public int field21;
        public int field22;
        public int field23;
        public int field24;
        public int field25;
        public int field26;
        public int field27;
        public int field28;
    };

    [DbFileInfo(12340, "SpellVisualEffectName.dbc")]
    public sealed class SpellVisualEffectNameEntry
    {
        public int field0;
        public string field1;
        public string field2;
        public float field3;
        public float field4;
        public float field5;
        public float field6;
    };

    [DbFileInfo(12340, "WorldStateUI.dbc")]
    public sealed class WorldStateUIEntry
    {
        public int field0;
        public int field1;
        public int field2;
        public int field3;
        public string field4;
        public string field5;
        public int field6;
        public int field7;
        public int field8;
        public int field9;
        public int field10;
        public int field11;
        public int field12;
        public int field13;
        public int field14;
        public int field15;
        public int field16;
        public int field17;
        public int field18;
        public int field19;
        public int field20;
        public int field21;
        public string field22;
        public int field23;
        public int field24;
        public int field25;
        public int field26;
        public int field27;
        public int field28;
        public int field29;
        public int field30;
        public int field31;
        public int field32;
        public int field33;
        public int field34;
        public int field35;
        public int field36;
        public int field37;
        public int field38;
        public int field39;
        public int field40;
        public string field41;
        public string field42;
        public int field43;
        public int field44;
        public int field45;
        public int field46;
        public int field47;
        public int field48;
        public int field49;
        public int field50;
        public int field51;
        public int field52;
        public int field53;
        public int field54;
        public int field55;
        public int field56;
        public int field57;
        public int field58;
        public int field59;
        public int field60;
        public int field61;
        public int field62;
    };

    [DbFileInfo(12340, "WorldStateZoneSounds.dbc")]
    public sealed class WorldStateZoneSoundsEntry
    {
        public int field0;
        public int field1;
        public int field2;
        public int field3;
        public int field4;
        public int field5;
        public int field6;
        public int field7;
    };
}

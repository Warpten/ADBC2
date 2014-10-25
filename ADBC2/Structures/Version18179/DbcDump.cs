using System;
using BrightIdeasSoftware;

namespace ADBC2.Structures.Version18179
{
    [DbFileInfo(18179, "Achievement_Category.dbc")]
    public sealed class AchievementCategoryEntry
    {
        public int ID;
        public int parent;
        public string name_lang;
        public int ui_order;
    }

    [DbFileInfo(18179, "Achievement.dbc")]
    public sealed class AchievementEntry
    {
        public int ID;
        public int faction;
        public int instance_id;
        public int supercedes;
        public string title_lang;
        public string description_lang;
        public int category;
        public int points;
        public int ui_order;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int iconID;
        public string reward_lang;
        public int minimum_criteria;
        public int shares_criteria;
        public int criteria_tree;
    }

    [DbFileInfo(18179, "AnimKitBoneSetAlias.dbc")]
    public sealed class AnimKitBoneSetAliasEntry
    {
        public int ID;
        public int boneDataID;
        public int animKitBoneSetID;
    }

    [DbFileInfo(18179, "AnimKitBoneSet.dbc")]
    public sealed class AnimKitBoneSetEntry
    {
        public int ID;
        public string name;
        public int boneDataID;
        public int parentAnimKitBoneSetID;
        public int extraBoneCount;
        public int altAnimKitBoneSetID;
    }

    [DbFileInfo(18179, "AnimKitConfigBoneSet.dbc")]
    public sealed class AnimKitConfigBoneSetEntry
    {
        public int ID;
        public int parentAnimKitConfigID;
        public int animKitBoneSetID;
        public int animKitPriorityID;
    }

    [DbFileInfo(18179, "AnimKitConfig.dbc")]
    public sealed class AnimKitConfigEntry
    {
        public int ID;
        public int configFlags;
    }

    [DbFileInfo(18179, "AnimKitPriority.dbc")]
    public sealed class AnimKitPriorityEntry
    {
        public int ID;
        public int priority;
    }

    [DbFileInfo(18179, "AnimKit.dbc")]
    public sealed class AnimKitEntry
    {
        public int ID;
        public int oneShotDuration;
        public int oneShotStopAnimKitID;
        public int lowDefAnimKitID;
    }

    [DbFileInfo(18179, "AnimKitSegment.dbc")]
    public sealed class AnimKitSegmentEntry
    {
        public int ID;
        public int parentAnimKitID;
        public int orderIndex;
        public int animID;
        public int animStartTime;
        public int animKitConfigID;
        public int startCondition;
        public int startConditionParam;
        public int startConditionDelay;
        public int endCondition;
        public int endConditionParam;
        public int endConditionDelay;
        public float speed;
        public int segmentFlags;
        public int forcedVariation;
        public int overrideConfigFlags;
        public int loopToSegmentIndex;
    }

    [DbFileInfo(18179, "AnimReplacement.dbc")]
    public sealed class AnimReplacementEntry
    {
        public int ID;
        public int srcAnimID;
        public int dstAnimID;
        public int parentAnimReplacementSetID;
    }

    [DbFileInfo(18179, "AnimReplacementSet.dbc")]
    public sealed class AnimReplacementSetEntry
    {
        public int ID;
        public int execOrder;
    }

    [DbFileInfo(18179, "AreaAssignment.dbc")]
    public sealed class AreaAssignmentEntry
    {
        public int MapID;
        public int AreaID;
        public int ChunkX;
        public int ChunkY;
    }

    [DbFileInfo(18179, "AreaGroup.dbc")]
    public sealed class AreaGroupEntry
    {
        public int ID;
        public int areaID1;
        public int areaID2;
        public int areaID3;
        public int areaID4;
        public int areaID5;
        public int areaID6;
        public int nextAreaID;
    }

    [DbFileInfo(18179, "AreaPOI.dbc")]
    public sealed class AreaPOIEntry
    {
        public int ID;
        public int importance;
        public int icon1;
        public int icon2;
        public int icon3;
        public int icon4;
        public int icon5;
        public int icon6;
        public int icon7;
        public int icon8;
        public int icon9;
        public int factionID;
        public float pos1;
        public float pos2;
        public int continentID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int areaID;
        public string name_lang;
        public string description_lang;
        public int worldStateID;
        public int playerConditionID;
        public int worldMapLink;
        public int portLocID;
    }

    [DbFileInfo(18179, "AreaTriggerActionSet.dbc")]
    public sealed class AreaTriggerActionSetEntry
    {
        public int ID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "AreaTriggerBox.dbc")]
    public sealed class AreaTriggerBoxEntry
    {
        public int ID;
        public float extents1;
        public float extents2;
        public float extents3;
    }

    [DbFileInfo(18179, "AreaTriggerCylinder.dbc")]
    public sealed class AreaTriggerCylinderEntry
    {
        public int ID;
        public float radius;
        public float height;
    }

    [DbFileInfo(18179, "AreaTrigger.dbc")]
    public sealed class AreaTriggerEntry
    {
        public int ID;
        public int ContinentID;
        public float pos1;
        public float pos2;
        public float pos3;
        public int phaseUseFlags;
        public int phaseID;
        public int phaseGroupID;
        public float radius;
        public float box_length;
        public float box_width;
        public float box_height;
        public float box_yaw;
        public int shapeType;
        public int shapeID;
        public int areaTriggerActionSetID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "AreaTriggerSphere.dbc")]
    public sealed class AreaTriggerSphereEntry
    {
        public int ID;
        public float maxRadius;
    }

    [DbFileInfo(18179, "ArmorLocation.dbc")]
    public sealed class ArmorLocationEntry
    {
        public int ID;
        public float clothmodifier;
        public float leathermodifier;
        public float chainmodifier;
        public float platemodifier;
        public float modifier;
    }

    [DbFileInfo(18179, "AuctionHouse.dbc")]
    public sealed class AuctionHouseEntry
    {
        public int ID;
        public int factionID;
        public int depositRate;
        public int consignmentRate;
        public string name_lang;
    }

    [DbFileInfo(18179, "BankBagSlotPrices.dbc")]
    public sealed class BankBagSlotPricesEntry
    {
        public int ID;
        public int Cost;
    }

    [DbFileInfo(18179, "BannedAddOns.dbc")]
    public sealed class BannedAddOnsEntry
    {
        public int ID;
        public int nameMD5_1;
        public int nameMD5_2;
        public int nameMD5_3;
        public int nameMD5_4;
        public int versionMD5_1;
        public int versionMD5_2;
        public int versionMD5_3;
        public int versionMD5_4;
        public int lastModified;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "BarberShopStyle.dbc")]
    public sealed class BarberShopStyleEntry
    {
        public int ID;
        public int type;
        public string DisplayName_lang;
        public string Description_lang;
        public float Cost_Modifier;
        public int race;
        public int sex;
        public int data;
    }

    [DbFileInfo(18179, "BattlemasterList.dbc")]
    public sealed class BattlemasterListEntry
    {
        public int ID;
        public int mapID1;
        public int mapID2;
        public int mapID3;
        public int mapID4;
        public int mapID5;
        public int mapID6;
        public int mapID7;
        public int mapID8;
        public int mapID9;
        public int mapID10;
        public int mapID11;
        public int mapID12;
        public int mapID13;
        public int mapID14;
        public int mapID15;
        public int mapID16;
        public int instanceType;
        public int groupsAllowed;
        public string name_lang;
        public int maxGroupSize;
        public int holidayWorldState;
        public int minlevel;
        public int maxlevel;
        public int ratedPlayers;
        public int minPlayers;
        public int maxPlayers;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int iconFileDataID;
        public string gametype_lang;
    }

    [DbFileInfo(18179, "CameraMode.dbc")]
    public sealed class CameraModeEntry
    {
        public int ID;
        public string name;
        public int type;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public float positionOffset1;
        public float positionOffset2;
        public float positionOffset3;
        public float targetOffset1;
        public float targetOffset2;
        public float targetOffset3;
        public float positionSmoothing;
        public float rotationSmoothing;
        public float fieldOfView;
        public int lockedPositionOffsetBase;
        public int lockedPositionOffsetDirection;
        public int lockedTargetOffsetBase;
        public int lockedTargetOffsetDirection;
    }

    [DbFileInfo(18179, "CameraShakes.dbc")]
    public sealed class CameraShakesEntry
    {
        public int ID;
        public int shakeType;
        public int direction;
        public float amplitude;
        public float frequency;
        public float duration;
        public float phase;
        public float coefficient;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "CastableRaidBuffs.dbc")]
    public sealed class CastableRaidBuffsEntry
    {
        public int ID;
        public int spellID;
        public int castingSpellID;
    }

    [DbFileInfo(18179, "Cfg_Categories.dbc")]
    public sealed class CfgCategoriesEntry
    {
        public int ID;
        public int localeMask;
        public int create_charsetMask;
        public int existing_charsetMask;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public string name_lang;
    }

    [DbFileInfo(18179, "Cfg_Configs.dbc")]
    public sealed class CfgConfigsEntry
    {
        public int ID;
        public int realmType;
        public int playerKillingAllowed;
        public int roleplaying;
        public int playerAttackSpeedBase;
        public int maxDamageReductionPctPhysical;
    }

    [DbFileInfo(18179, "Cfg_Regions.dbc")]
    public sealed class CfgRegionsEntry
    {
        public int ID;
        public string tag;
        public int region_group_mask;
        public int rulesetID;
    }

    [DbFileInfo(18179, "CharacterFacialHairStyles.dbc")]
    public sealed class CharacterFacialHairStylesEntry
    {
        public int raceID;
        public int sexID;
        public int VariationID;
        public int Geoset1;
        public int Geoset2;
        public int Geoset3;
        public int Geoset4;
        public int Geoset5;
    }

    [DbFileInfo(18179, "CharacterLoadoutItem.dbc")]
    public sealed class CharacterLoadoutItemEntry
    {
        public int ID;
        public int characterLoadoutID;
        public int itemID;
        public int itemDisplayInfoID;
        public int itemInventoryType;
    }

    [DbFileInfo(18179, "CharacterLoadout.dbc")]
    public sealed class CharacterLoadoutEntry
    {
        public int ID;
        public int chrClassID;
        public int purpose;
        public int racemask;
    }

    [DbFileInfo(18179, "CharBaseInfo.dbc")]
    public sealed class CharBaseInfoEntry
    {
        public int raceID;
        public int classID;
    }

    [DbFileInfo(18179, "CharBaseSection.dbc")]
    public sealed class CharBaseSectionEntry
    {
        public int ID;
        public int fallbackID;
        public int layoutResType;
    }

    [DbFileInfo(18179, "CharComponentTextureLayouts.dbc")]
    public sealed class CharComponentTextureLayoutsEntry
    {
        public int ID;
        public int width;
        public int height;
    }

    [DbFileInfo(18179, "CharComponentTextureSections.dbc")]
    public sealed class CharComponentTextureSectionsEntry
    {
        public int ID;
        public int charComponentTextureLayoutID;
        public int sectionType;
        public int x;
        public int y;
        public int width;
        public int height;
    }

    [DbFileInfo(18179, "CharHairGeosets.dbc")]
    public sealed class CharHairGeosetsEntry
    {
        public int ID;
        public int RaceID;
        public int SexID;
        public int VariationID;
        public int VariationType;
        public int GeosetID;
        public int GeosetType;
        public int Showscalp;
        public int ColorIndex;
    }

    [DbFileInfo(18179, "CharSections.dbc")]
    public sealed class CharSectionsEntry
    {
        public int ID;
        public int raceID;
        public int sexID;
        public int baseSection;
        public string TextureName1;
        public string TextureName2;
        public string TextureName3;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int variationIndex;
        public int colorIndex;
    }

    [DbFileInfo(18179, "CharStartOutfit.dbc")]
    public sealed class CharStartOutfitEntry
    {
        public int ID;
        public int raceID;
        public int classID;
        public int sexID;
        public int outfitID;
        public int ItemID1;
        public int ItemID2;
        public int ItemID3;
        public int ItemID4;
        public int ItemID5;
        public int ItemID6;
        public int ItemID7;
        public int ItemID8;
        public int ItemID9;
        public int ItemID10;
        public int ItemID11;
        public int ItemID12;
        public int ItemID13;
        public int ItemID14;
        public int ItemID15;
        public int ItemID16;
        public int ItemID17;
        public int ItemID18;
        public int ItemID19;
        public int ItemID20;
        public int ItemID21;
        public int ItemID22;
        public int ItemID23;
        public int ItemID24;
        public int DisplayItemID1;
        public int DisplayItemID2;
        public int DisplayItemID3;
        public int DisplayItemID4;
        public int DisplayItemID5;
        public int DisplayItemID6;
        public int DisplayItemID7;
        public int DisplayItemID8;
        public int DisplayItemID9;
        public int DisplayItemID10;
        public int DisplayItemID11;
        public int DisplayItemID12;
        public int DisplayItemID13;
        public int DisplayItemID14;
        public int DisplayItemID15;
        public int DisplayItemID16;
        public int DisplayItemID17;
        public int DisplayItemID18;
        public int DisplayItemID19;
        public int DisplayItemID20;
        public int DisplayItemID21;
        public int DisplayItemID22;
        public int DisplayItemID23;
        public int DisplayItemID24;
        public int InventoryType1;
        public int InventoryType2;
        public int InventoryType3;
        public int InventoryType4;
        public int InventoryType5;
        public int InventoryType6;
        public int InventoryType7;
        public int InventoryType8;
        public int InventoryType9;
        public int InventoryType10;
        public int InventoryType11;
        public int InventoryType12;
        public int InventoryType13;
        public int InventoryType14;
        public int InventoryType15;
        public int InventoryType16;
        public int InventoryType17;
        public int InventoryType18;
        public int InventoryType19;
        public int InventoryType20;
        public int InventoryType21;
        public int InventoryType22;
        public int InventoryType23;
        public int InventoryType24;
        public int petDisplayID;
        public int petFamilyID;
    }

    [DbFileInfo(18179, "CharTitles.dbc")]
    public sealed class CharTitlesEntry
    {
        public int ID;
        public int Condition_ID;
        public string name_lang;
        public string name1_lang;
        public int mask_ID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "ChatChannels.dbc")]
    public sealed class ChatChannelsEntry
    {
        public int ID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int factionGroup;
        public string name_lang;
        public string shortcut_lang;
    }

    [DbFileInfo(18179, "ChatProfanity.dbc")]
    public sealed class ChatProfanityEntry
    {
        public int ID;
        public string text;
        public int Language;
    }

    [DbFileInfo(18179, "ChrClasses.dbc")]
    public sealed class ChrClassesEntry
    {
        public int ID;
        public int DisplayPower;
        public string petNameToken;
        public string name_lang;
        public string name_female_lang;
        public string name_male_lang;
        public string filename;
        public int spellClassSet;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int cinematicSequenceID;
        public int attackPowerPerStrength;
        public int attackPowerPerAgility;
        public int rangedAttackPowerPerAgility;
        public int defaultSpec;
        public int createScreenFileDataID;
        public int selectScreenFileDataID;
        public int lowResScreenFileDataID;
        public int iconFileDataID;
    }

    [DbFileInfo(18179, "ChrClassesXPowerTypes.dbc")]
    public sealed class ChrClassesXPowerTypesEntry
    {
        public int classID;
        public int powerType;
    }

    [DbFileInfo(18179, "ChrRaces.dbc")]
    public sealed class ChrRacesEntry
    {
        public int ID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int factionID;
        public int ExplorationSoundID;
        public int MaleDisplayId;
        public int FemaleDisplayId;
        public string ClientPrefix;
        public int BaseLanguage;
        public int creatureType;
        public int ResSicknessSpellID;
        public int SplashSoundID;
        public string clientFileString;
        public int cinematicSequenceID;
        public int alliance;
        public string name_lang;
        public string name_female_lang;
        public string name_male_lang;
        public string facialHairCustomization1;
        public string facialHairCustomization2;
        public string hairCustomization;
        public int race_related;
        public int unalteredVisualRaceID;
        public int uaMaleCreatureSoundDataID;
        public int uaFemaleCreatureSoundDataID;
        public int charComponentTextureLayoutID;
        public int defaultClassID;
        public int createScreenFileDataID;
        public int selectScreenFileDataID;
        public float maleCustomizeOffset1;
        public float maleCustomizeOffset2;
        public float maleCustomizeOffset3;
        public float femaleCustomizeOffset1;
        public float femaleCustomizeOffset2;
        public float femaleCustomizeOffset3;
        public int neutralRaceID;
        public int lowResScreenFileDataID;
        public int HighResMaleDisplayId;
        public int HighResFemaleDisplayId;
        public int charComponentTexLayoutHiResID;
    }

    [DbFileInfo(18179, "ChrSpecialization.dbc")]
    public sealed class ChrSpecializationEntry
    {
        public int ID;
        public string backgroundFile;
        public int classID;
        public int masterySpellID1;
        public int masterySpellID2;
        public int orderIndex;
        public int petTalentType;
        public int role;
        public int spellIconID;
        public int raidBuffs;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public string name_lang;
        public string description_lang;
        public int maxBuffs;
        public int primaryStatOrder1;
        public int primaryStatOrder2;
        public int primaryStatOrder3;
    }

    [DbFileInfo(18179, "CinematicCamera.dbc")]
    public sealed class CinematicCameraEntry
    {
        public int ID;
        public string model;
        public int soundID;
        public float origin1;
        public float origin2;
        public float origin3;
        public float originFacing;
    }

    [DbFileInfo(18179, "CinematicSequences.dbc")]
    public sealed class CinematicSequencesEntry
    {
        public int ID;
        public int soundID;
        public int camera1;
        public int camera2;
        public int camera3;
        public int camera4;
        public int camera5;
        public int camera6;
        public int camera7;
        public int camera8;
    }

    [DbFileInfo(18179, "CombatCondition.dbc")]
    public sealed class CombatConditionEntry
    {
        public int ID;
        public int worldStateExpressionID;
        public int selfConditionID;
        public int targetConditionID;
        public int friendConditionID1;
        public int friendConditionID2;
        public int friendConditionOp1;
        public int friendConditionOp2;
        public int friendConditionCount1;
        public int friendConditionCount2;
        public int friendConditionLogic;
        public int enemyConditionID1;
        public int enemyConditionID2;
        public int enemyConditionOp1;
        public int enemyConditionOp2;
        public int enemyConditionCount1;
        public int enemyConditionCount2;
        public int enemyConditionLogic;
    }

    [DbFileInfo(18179, "ConsoleScripts.dbc")]
    public sealed class ConsoleScriptsEntry
    {
        public int ID;
        public string name;
        public string script;
    }

    [DbFileInfo(18179, "CreatureDisplayInfoExtra.dbc")]
    public sealed class CreatureDisplayInfoExtraEntry
    {
        public int ID;
        public int DisplayRaceID;
        public int DisplaySexID;
        public int SkinID;
        public int FaceID;
        public int HairStyleID;
        public int HairColorID;
        public int FacialHairID;
        public int NPCItemDisplay1;
        public int NPCItemDisplay2;
        public int NPCItemDisplay3;
        public int NPCItemDisplay4;
        public int NPCItemDisplay5;
        public int NPCItemDisplay6;
        public int NPCItemDisplay7;
        public int NPCItemDisplay8;
        public int NPCItemDisplay9;
        public int NPCItemDisplay10;
        public int NPCItemDisplay11;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int fileDataID;
        public int hdFileDataID;
    }

    [DbFileInfo(18179, "CreatureDisplayInfo.dbc")]
    public sealed class CreatureDisplayInfoEntry
    {
        public int ID;
        public int modelID;
        public int soundID;
        public int extendedDisplayInfoID;
        public float creatureModelScale;
        public int creatureModelAlpha;
        public string textureVariation1;
        public string textureVariation2;
        public string textureVariation3;
        public string portraitTextureName;
        public int portraitCreatureDisplayInfoID;
        public int sizeClass;
        public int bloodID;
        public int NPCSoundID;
        public int particleColorID;
        public int creatureGeosetData;
        public int objectEffectPackageID;
        public int animReplacementSetID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int gender;
        public int stateSpellVisualKitID;
    }

    [DbFileInfo(18179, "CreatureFamily.dbc")]
    public sealed class CreatureFamilyEntry
    {
        public int ID;
        public float minScale;
        public int minScaleLevel;
        public float maxScale;
        public int maxScaleLevel;
        public int skillLine1;
        public int skillLine2;
        public int petFoodMask;
        public int petTalentType;
        public int categoryEnumID;
        public string name_lang;
        public string iconFile;
    }

    [DbFileInfo(18179, "CreatureImmunities.dbc")]
    public sealed class CreatureImmunitiesEntry
    {
        public int ID;
        public int school;
        public int dispelType;
        public int mechanicsAllowed;
        public int mechanic;
        public int effectsAllowed;
        public int effect1;
        public int effect2;
        public int effect3;
        public int effect4;
        public int effect5;
        public int effect6;
        public int effect7;
        public int statesAllowed;
        public int state1;
        public int state2;
        public int state3;
        public int state4;
        public int state5;
        public int state6;
        public int state7;
        public int state8;
        public int state9;
        public int state10;
        public int state11;
        public int state12;
        public int state13;
        public int state14;
        public int state15;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "CreatureModelData.dbc")]
    public sealed class CreatureModelDataEntry
    {
        public int ID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int fileDataID;
        public int sizeClass;
        public float modelScale;
        public int bloodID;
        public int footprintTextureID;
        public float footprintTextureLength;
        public float footprintTextureWidth;
        public float footprintParticleScale;
        public int foleyMaterialID;
        public int footstepShakeSize;
        public int deathThudShakeSize;
        public int soundID;
        public float collisionWidth;
        public float collisionHeight;
        public float mountHeight;
        public float geoBoxMin1;
        public float geoBoxMin2;
        public float geoBoxMin3;
        public float geoBoxMax1;
        public float geoBoxMax2;
        public float geoBoxMax3;
        public float worldEffectScale;
        public float attachedEffectScale;
        public float missileCollisionRadius;
        public float missileCollisionPush;
        public float missileCollisionRaise;
        public float overrideLootEffectScale;
        public float overrideNameScale;
        public float overrideSelectionRadius;
        public float tamedPetBaseScale;
        public int creatureGeosetDataID;
        public float hoverHeight;
    }

    [DbFileInfo(18179, "CreatureMovementInfo.dbc")]
    public sealed class CreatureMovementInfoEntry
    {
        public int ID;
        public float smoothFacingChaseRate;
    }

    [DbFileInfo(18179, "CreatureSoundData.dbc")]
    public sealed class CreatureSoundDataEntry
    {
        public int ID;
        public int soundExertionID;
        public int soundExertionCriticalID;
        public int soundInjuryID;
        public int soundInjuryCriticalID;
        public int soundInjuryCrushingBlowID;
        public int soundDeathID;
        public int soundStunID;
        public int soundStandID;
        public int soundFootstepID;
        public int soundAggroID;
        public int soundWingFlapID;
        public int soundWingGlideID;
        public int soundAlertID;
        public int soundFidget1;
        public int soundFidget2;
        public int soundFidget3;
        public int soundFidget4;
        public int soundFidget5;
        public int customAttack1;
        public int customAttack2;
        public int customAttack3;
        public int customAttack4;
        public int NPCSoundID;
        public int loopSoundID;
        public int creatureImpactType;
        public int soundJumpStartID;
        public int soundJumpEndID;
        public int soundPetAttackID;
        public int soundPetOrderID;
        public int soundPetDismissID;
        public float fidgetDelaySecondsMin;
        public float fidgetDelaySecondsMax;
        public int birthSoundID;
        public int spellCastDirectedSoundID;
        public int submergeSoundID;
        public int submergedSoundID;
        public int creatureSoundDataIDPet;
        public int transformSoundID;
        public int transformAnimatedSoundID;
    }

    [DbFileInfo(18179, "CreatureSpellData.dbc")]
    public sealed class CreatureSpellDataEntry
    {
        public int ID;
        public int spells1;
        public int spells2;
        public int spells3;
        public int spells4;
        public int availability1;
        public int availability2;
        public int availability3;
        public int availability4;
    }

    [DbFileInfo(18179, "CreatureType.dbc")]
    public sealed class CreatureTypeEntry
    {
        public int ID;
        public string name_lang;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "Criteria.dbc")]
    public sealed class CriteriaEntry
    {
        public int ID;
        public int type;
        public int asset;
        public int start_event;
        public int start_asset;
        public int start_timer;
        public int fail_event;
        public int fail_asset;
        public int modifier_tree_id;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int eligibility_world_state_ID;
        public int eligibility_world_state_value;
    }

    [DbFileInfo(18179, "CriteriaTree.dbc")]
    public sealed class CriteriaTreeEntry
    {
        public int ID;
        public int criteriaID;
        public float amount1;
        public float amount2;
        public int _operator;
        public int parent;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public string description_lang;
        public int orderIndex;
    }

    [DbFileInfo(18179, "CriteriaTreeXEffect.dbc")]
    public sealed class CriteriaTreeXEffectEntry
    {
        public int ID;
        public int criteriaTreeID;
        public int worldEffectID;
    }

    [DbFileInfo(18179, "CurrencyCategory.dbc")]
    public sealed class CurrencyCategoryEntry
    {
        public int ID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public string name_lang;
    }

    [DbFileInfo(18179, "CurrencyTypes.dbc")]
    public sealed class CurrencyTypesEntry
    {
        public int ID;
        public int categoryID;
        public string name_lang;
        public string inventoryIcon1;
        public string inventoryIcon2;
        public int spellWeight;
        public int spellCategory;
        public int maxQty;
        public int maxEarnablePerWeek;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int quality;
        public string description_lang;
    }

    [DbFileInfo(18179, "DeathThudLookups.dbc")]
    public sealed class DeathThudLookupsEntry
    {
        public int ID;
        public int SizeClass;
        public int TerrainTypeSoundID;
        public int SoundEntryID;
        public int SoundEntryIDWater;
    }

    [DbFileInfo(18179, "DeclinedWordCases.dbc")]
    public sealed class DeclinedWordCasesEntry
    {
        public int ID;
        public int declinedWordID;
        public int caseIndex;
        public string declinedWord;
    }

    [DbFileInfo(18179, "DeclinedWord.dbc")]
    public sealed class DeclinedWordEntry
    {
        public int ID;
        public string word;
    }

    [DbFileInfo(18179, "DestructibleModelData.dbc")]
    public sealed class DestructibleModelDataEntry
    {
        public int ID;
        public int state0Wmo;
        public int state0ImpactEffectDoodadSet;
        public int state0AmbientDoodadSet;
        public int state0NameSet;
        public int state1Wmo;
        public int state1DestructionDoodadSet;
        public int state1ImpactEffectDoodadSet;
        public int state1AmbientDoodadSet;
        public int state1NameSet;
        public int state2Wmo;
        public int state2DestructionDoodadSet;
        public int state2ImpactEffectDoodadSet;
        public int state2AmbientDoodadSet;
        public int state2NameSet;
        public int state3Wmo;
        public int state3InitDoodadSet;
        public int state3AmbientDoodadSet;
        public int state3NameSet;
        public int ejectDirection;
        public int repairGroundFx;
        public int doNotHighlight;
        public int healEffect;
        public int healEffectSpeed;
    }

    [DbFileInfo(18179, "Difficulty.dbc")]
    public sealed class DifficultyEntry
    {
        public int ID;
        public int fallbackDifficultyID;
        public int instanceType;
        public int minPlayers;
        public int maxPlayers;
        public int oldEnumValue;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int toggleDifficultyID;
        public int groupSizeHealthCurveID;
        public int groupSizeDmgCurveID;
        public int groupSizeSpellPointsCurveID;
        public string name_lang;
    }

    [DbFileInfo(18179, "DungeonEncounter.dbc")]
    public sealed class DungeonEncounterEntry
    {
        public int ID;
        public int mapID;
        public int difficultyID;
        public int orderIndex;
        public int Bit;
        public string name_lang;
        public int CreatureDisplayID;
        public int spellIconID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "DungeonMapChunk.dbc")]
    public sealed class DungeonMapChunkEntry
    {
        public int ID;
        public int mapID;
        public int wmoGroupID;
        public int dungeonMapID;
        public float minZ;
        public int doodadPlacementID;
    }

    [DbFileInfo(18179, "DungeonMap.dbc")]
    public sealed class DungeonMapEntry
    {
        public int ID;
        public int mapID;
        public int floorIndex;
        public float min1;
        public float min2;
        public float max1;
        public float max2;
        public int parentWorldMapID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "DurabilityCosts.dbc")]
    public sealed class DurabilityCostsEntry
    {
        public int ID;
        public int weaponSubClassCost1;
        public int weaponSubClassCost2;
        public int weaponSubClassCost3;
        public int weaponSubClassCost4;
        public int weaponSubClassCost5;
        public int weaponSubClassCost6;
        public int weaponSubClassCost7;
        public int weaponSubClassCost8;
        public int weaponSubClassCost9;
        public int weaponSubClassCost10;
        public int weaponSubClassCost11;
        public int weaponSubClassCost12;
        public int weaponSubClassCost13;
        public int weaponSubClassCost14;
        public int weaponSubClassCost15;
        public int weaponSubClassCost16;
        public int weaponSubClassCost17;
        public int weaponSubClassCost18;
        public int weaponSubClassCost19;
        public int weaponSubClassCost20;
        public int weaponSubClassCost21;
        public int armorSubClassCost1;
        public int armorSubClassCost2;
        public int armorSubClassCost3;
        public int armorSubClassCost4;
        public int armorSubClassCost5;
        public int armorSubClassCost6;
        public int armorSubClassCost7;
        public int armorSubClassCost8;
    }

    [DbFileInfo(18179, "DurabilityQuality.dbc")]
    public sealed class DurabilityQualityEntry
    {
        public int ID;
        public float data;
    }

    [DbFileInfo(18179, "Emotes.dbc")]
    public sealed class EmotesEntry
    {
        public int ID;
        public string EmoteSlashCommand;
        public int AnimID;
        public int EmoteFlags;
        public int EmoteSpecProc;
        public int EmoteSpecProcParam;
        public int EventSoundID;
        public int SpellVisualKitID;
    }

    [DbFileInfo(18179, "EmotesTextData.dbc")]
    public sealed class EmotesTextDataEntry
    {
        public int ID;
        public string text_lang;
    }

    [DbFileInfo(18179, "EmotesText.dbc")]
    public sealed class EmotesTextEntry
    {
        public int ID;
        public string name;
        public int emoteID;
        public int emoteText1;
        public int emoteText2;
        public int emoteText3;
        public int emoteText4;
        public int emoteText5;
        public int emoteText6;
        public int emoteText7;
        public int emoteText8;
        public int emoteText9;
        public int emoteText10;
        public int emoteText11;
        public int emoteText12;
        public int emoteText13;
        public int emoteText14;
        public int emoteText15;
        public int emoteText16;
    }

    [DbFileInfo(18179, "EmotesTextSound.dbc")]
    public sealed class EmotesTextSoundEntry
    {
        public int ID;
        public int emotesTextID;
        public int raceID;
        public int sexID;
        public int soundID;
    }

    [DbFileInfo(18179, "EnvironmentalDamage.dbc")]
    public sealed class EnvironmentalDamageEntry
    {
        public int ID;
        public int EnumID;
        public int VisualkitID;
    }

    [DbFileInfo(18179, "Exhaustion.dbc")]
    public sealed class ExhaustionEntry
    {
        public int ID;
        public int xp;
        public float factor;
        public float outdoorHours;
        public float innHours;
        public string name_lang;
        public float threshold;
        public string combatLogText;
    }

    [DbFileInfo(18179, "FactionGroup.dbc")]
    public sealed class FactionGroupEntry
    {
        public int ID;
        public int maskID;
        public string internalName;
        public string name_lang;
    }

    [DbFileInfo(18179, "Faction.dbc")]
    public sealed class FactionEntry
    {
        public int ID;
        public int reputationIndex;
        public int reputationRaceMask1;
        public int reputationRaceMask2;
        public int reputationRaceMask3;
        public int reputationRaceMask4;
        public int reputationClassMask1;
        public int reputationClassMask2;
        public int reputationClassMask3;
        public int reputationClassMask4;
        public int reputationBase1;
        public int reputationBase2;
        public int reputationBase3;
        public int reputationBase4;
        public int reputationFlags1;
        public int reputationFlags2;
        public int reputationFlags3;
        public int reputationFlags4;
        public int parentFactionID;
        public float parentFactionMod1;
        public float parentFactionMod2;
        public int parentFactionCap1;
        public int parentFactionCap2;
        public string name_lang;
        public string description_lang;
        public int expansion;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int friendshipRepID;
    }

    [DbFileInfo(18179, "FactionTemplate.dbc")]
    public sealed class FactionTemplateEntry
    {
        public int ID;
        public int faction;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int factionGroup;
        public int friendGroup;
        public int enemyGroup;
        public int enemies1;
        public int enemies2;
        public int enemies3;
        public int enemies4;
        public int friend1;
        public int friend2;
        public int friend3;
        public int friend4;
    }

    [DbFileInfo(18179, "FootstepTerrainLookup.dbc")]
    public sealed class FootstepTerrainLookupEntry
    {
        public int ID;
        public int CreatureFootstepID;
        public int TerrainSoundID;
        public int SoundID;
        public int SoundIDSplash;
    }

    [DbFileInfo(18179, "FriendshipRepReaction.dbc")]
    public sealed class FriendshipRepReactionEntry
    {
        public int ID;
        public int friendshipRepID;
        public int reactionThreshold;
        public string reaction_lang;
    }

    [DbFileInfo(18179, "FriendshipReputation.dbc")]
    public sealed class FriendshipReputationEntry
    {
        public int ID;
        public int factionID;
        public int textureFileID;
        public string description_lang;
    }

    [DbFileInfo(18179, "GameObjectArtKit.dbc")]
    public sealed class GameObjectArtKitEntry
    {
        public int ID;
        public string textureVariation1;
        public string textureVariation2;
        public string textureVariation3;
        public string attachModel1;
        public string attachModel2;
        public string attachModel3;
        public string attachModel4;
    }

    [DbFileInfo(18179, "GameObjectDiffAnimMap.dbc")]
    public sealed class GameObjectDiffAnimMapEntry
    {
        public int ID;
        public int gameObjectDiffAnimID;
        public int difficultyID;
        public int animation;
        public int attachmentDisplayID;
    }

    [DbFileInfo(18179, "GameObjectDisplayInfo.dbc")]
    public sealed class GameObjectDisplayInfoEntry
    {
        public int ID;
        public int fileDataID;
        public int Sound1;
        public int Sound2;
        public int Sound3;
        public int Sound4;
        public int Sound5;
        public int Sound6;
        public int Sound7;
        public int Sound8;
        public int Sound9;
        public int Sound10;
        public float geoBoxMin1;
        public float geoBoxMin2;
        public float geoBoxMin3;
        public float geoBoxMax1;
        public float geoBoxMax2;
        public float geoBoxMax3;
        public int objectEffectPackageID;
        public float overrideLootEffectScale;
        public float overrideNameScale;
    }

    [DbFileInfo(18179, "GameTables.dbc")]
    public sealed class GameTablesEntry
    {
        public string name;
        public int numRows;
        public int numColumns;
    }

    [DbFileInfo(18179, "GameTips.dbc")]
    public sealed class GameTipsEntry
    {
        public int ID;
        public string text_lang;
        public int min_level;
        public int max_level;
    }

    [DbFileInfo(18179, "GarrUiAnimClassInfo.dbc")]
    public sealed class GarrUiAnimClassInfoEntry
    {
        public int ID;
        public int garrClassSpecID;
        public int spellVisualID;
        public int movementType;
        public float impactDelaySecs;
    }

    [DbFileInfo(18179, "GarrUiAnimRaceInfo.dbc")]
    public sealed class GarrUiAnimRaceInfoEntry
    {
        public int ID;
        public int chrRaceID;
        public float scale;
        public float height;
        public float singleModelScale;
        public float singleModelHeight;
    }

    [DbFileInfo(18179, "GemProperties.dbc")]
    public sealed class GemPropertiesEntry
    {
        public int id;
        public int enchant_id;
        public int maxcount_inv;
        public int maxcount_item;
        public int type;
        public int min_item_level;
    }

    [DbFileInfo(18179, "GlueScreenEmote.dbc")]
    public sealed class GlueScreenEmoteEntry
    {
        public int ID;
        public int classId;
        public int raceId;
        public int sexId;
        public int leftHandItemType;
        public int rightHandItemType;
        public int animKitId;
        public int spellVisualKitId;
    }

    [DbFileInfo(18179, "GlyphProperties.dbc")]
    public sealed class GlyphPropertiesEntry
    {
        public int id;
        public int spellID;
        public int glyphType;
        public int spellIconID;
        public int glyphExclusiveCategoryID;
    }

    [DbFileInfo(18179, "GlyphSlot.dbc")]
    public sealed class GlyphSlotEntry
    {
        public int id;
        public int type;
        public int tooltip;
    }

    [DbFileInfo(18179, "GMSurveyAnswers.dbc")]
    public sealed class GMSurveyAnswersEntry
    {
        public int ID;
        public int Sort_Index;
        public int GMSurveyQuestionID;
        public string Answer_lang;
    }

    [DbFileInfo(18179, "GMSurveyCurrentSurvey.dbc")]
    public sealed class GMSurveyCurrentSurveyEntry
    {
        public int LANGID;
        public int GMSURVEY_ID;
    }

    [DbFileInfo(18179, "GMSurveyQuestions.dbc")]
    public sealed class GMSurveyQuestionsEntry
    {
        public int ID;
        public string Question_lang;
    }

    [DbFileInfo(18179, "GMSurveySurveys.dbc")]
    public sealed class GMSurveySurveysEntry
    {
        public int ID;
        public int Q1;
        public int Q2;
        public int Q3;
        public int Q4;
        public int Q5;
        public int Q6;
        public int Q7;
        public int Q8;
        public int Q9;
        public int Q10;
        public int Q11;
        public int Q12;
        public int Q13;
        public int Q14;
        public int Q15;
    }

    [DbFileInfo(18179, "GMTicketCategory.dbc")]
    public sealed class GMTicketCategoryEntry
    {
        public int ID;
        public string category_lang;
    }

    [DbFileInfo(18179, "GroundEffectTexture.dbc")]
    public sealed class GroundEffectTextureEntry
    {
        public int ID;
        public int doodadId1;
        public int doodadId2;
        public int doodadId3;
        public int doodadId4;
        public int doodadWeight1;
        public int doodadWeight2;
        public int doodadWeight3;
        public int doodadWeight4;
        public int density;
        public int sound;
    }

    [DbFileInfo(18179, "gtArmorMitigationByLvl.dbc")]
    public sealed class gtArmorMitigationByLvlEntry
    {
        public float data;
    }

    [DbFileInfo(18179, "gtBarberShopCostBase.dbc")]
    public sealed class gtBarberShopCostBaseEntry
    {
        public float data;
    }

    [DbFileInfo(18179, "gtBattlePetTypeDamageMod.dbc")]
    public sealed class gtBattlePetTypeDamageModEntry
    {
        public float data;
    }

    [DbFileInfo(18179, "gtBattlePetXP.dbc")]
    public sealed class gtBattlePetXPEntry
    {
        public float data;
    }

    [DbFileInfo(18179, "gtChanceToMeleeCritBase.dbc")]
    public sealed class gtChanceToMeleeCritBaseEntry
    {
        public float data;
    }

    [DbFileInfo(18179, "gtChanceToMeleeCrit.dbc")]
    public sealed class gtChanceToMeleeCritEntry
    {
        public float data;
    }

    [DbFileInfo(18179, "gtChanceToSpellCritBase.dbc")]
    public sealed class gtChanceToSpellCritBaseEntry
    {
        public float data;
    }

    [DbFileInfo(18179, "gtChanceToSpellCrit.dbc")]
    public sealed class gtChanceToSpellCritEntry
    {
        public float data;
    }

    [DbFileInfo(18179, "gtCombatRatings.dbc")]
    public sealed class gtCombatRatingsEntry
    {
        public float data;
    }

    [DbFileInfo(18179, "gtItemSocketCostPerLevel.dbc")]
    public sealed class gtItemSocketCostPerLevelEntry
    {
        public float data;
    }

    [DbFileInfo(18179, "gtNPCManaCostScaler.dbc")]
    public sealed class gtNPCManaCostScalerEntry
    {
        public float data;
    }

    [DbFileInfo(18179, "gtOCTBaseHPByClass.dbc")]
    public sealed class gtOCTBaseHPByClassEntry
    {
        public float data;
    }

    [DbFileInfo(18179, "gtOCTBaseMPByClass.dbc")]
    public sealed class gtOCTBaseMPByClassEntry
    {
        public float data;
    }

    [DbFileInfo(18179, "gtOCTClassCombatRatingScalar.dbc")]
    public sealed class gtOCTClassCombatRatingScalarEntry
    {
        public int ID;
        public float data;
    }

    [DbFileInfo(18179, "gtOCTHpPerStamina.dbc")]
    public sealed class gtOCTHpPerStaminaEntry
    {
        public float data;
    }

    [DbFileInfo(18179, "gtOCTLevelExperience.dbc")]
    public sealed class gtOCTLevelExperienceEntry
    {
        public float data;
    }

    [DbFileInfo(18179, "gtRegenMPPerSpt.dbc")]
    public sealed class gtRegenMPPerSptEntry
    {
        public float data;
    }

    [DbFileInfo(18179, "gtResilienceDR.dbc")]
    public sealed class gtResilienceDREntry
    {
        public float data;
    }

    [DbFileInfo(18179, "gtSpellScaling.dbc")]
    public sealed class gtSpellScalingEntry
    {
        public float data;
    }

    [DbFileInfo(18179, "GuildColorBackground.dbc")]
    public sealed class GuildColorBackgroundEntry
    {
        public int colorID;
        public int red;
        public int green;
        public int blue;
    }

    [DbFileInfo(18179, "GuildColorBorder.dbc")]
    public sealed class GuildColorBorderEntry
    {
        public int colorID;
        public int red;
        public int green;
        public int blue;
    }

    [DbFileInfo(18179, "GuildColorEmblem.dbc")]
    public sealed class GuildColorEmblemEntry
    {
        public int colorID;
        public int red;
        public int green;
        public int blue;
    }

    [DbFileInfo(18179, "GuildPerkSpells.dbc")]
    public sealed class GuildPerkSpellsEntry
    {
        public int id;
        public int guildLevel;
        public int spellID;
    }

    [DbFileInfo(18179, "HelmetAnimScaling.dbc")]
    public sealed class HelmetAnimScalingEntry
    {
        public int ID;
        public int helmetGeosetVisDataID;
        public int raceID;
        public float amount;
    }

    [DbFileInfo(18179, "HelmetGeosetVisData.dbc")]
    public sealed class HelmetGeosetVisDataEntry
    {
        public int ID;
        public int hideGeoset1;
        public int hideGeoset2;
        public int hideGeoset3;
        public int hideGeoset4;
        public int hideGeoset5;
        public int hideGeoset6;
        public int hideGeoset7;
    }

    [DbFileInfo(18179, "HolidayDescriptions.dbc")]
    public sealed class HolidayDescriptionsEntry
    {
        public int ID;
        public string description_lang;
    }

    [DbFileInfo(18179, "HolidayNames.dbc")]
    public sealed class HolidayNamesEntry
    {
        public int ID;
        public string name_lang;
    }

    [DbFileInfo(18179, "Holidays.dbc")]
    public sealed class HolidaysEntry
    {
        public int ID;
        public int duration1;
        public int duration2;
        public int duration3;
        public int duration4;
        public int duration5;
        public int duration6;
        public int duration7;
        public int duration8;
        public int duration9;
        public int duration10;
        public int date1;
        public int date2;
        public int date3;
        public int date4;
        public int date5;
        public int date6;
        public int date7;
        public int date8;
        public int date9;
        public int date10;
        public int date11;
        public int date12;
        public int date13;
        public int date14;
        public int date15;
        public int date16;
        public int date17;
        public int date18;
        public int date19;
        public int date20;
        public int date21;
        public int date22;
        public int date23;
        public int date24;
        public int date25;
        public int date26;
        public int region;
        public int looping;
        public int calendarFlags1;
        public int calendarFlags2;
        public int calendarFlags3;
        public int calendarFlags4;
        public int calendarFlags5;
        public int calendarFlags6;
        public int calendarFlags7;
        public int calendarFlags8;
        public int calendarFlags9;
        public int calendarFlags10;
        public int holidayNameID;
        public int holidayDescriptionID;
        public string textureFilename;
        public int priority;
        public int calendarFilterType;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "ImportPriceArmor.dbc")]
    public sealed class ImportPriceArmorEntry
    {
        public int ID;
        public float ClothModifier;
        public float LeatherModifier;
        public float ChainModifier;
        public float PlateModifier;
    }

    [DbFileInfo(18179, "ImportPriceQuality.dbc")]
    public sealed class ImportPriceQualityEntry
    {
        public int ID;
        public float data;
    }

    [DbFileInfo(18179, "ImportPriceShield.dbc")]
    public sealed class ImportPriceShieldEntry
    {
        public int ID;
        public float data;
    }

    [DbFileInfo(18179, "ImportPriceWeapon.dbc")]
    public sealed class ImportPriceWeaponEntry
    {
        public int ID;
        public float data;
    }

    [DbFileInfo(18179, "ItemArmorQuality.dbc")]
    public sealed class ItemArmorQualityEntry
    {
        public int ID;
        public float qualitymod1;
        public float qualitymod2;
        public float qualitymod3;
        public float qualitymod4;
        public float qualitymod5;
        public float qualitymod6;
        public float qualitymod7;
        public int itemLevel;
    }

    [DbFileInfo(18179, "ItemArmorShield.dbc")]
    public sealed class ItemArmorShieldEntry
    {
        public int ID;
        public int itemLevel;
        public float quality1;
        public float quality2;
        public float quality3;
        public float quality4;
        public float quality5;
        public float quality6;
        public float quality7;
    }

    [DbFileInfo(18179, "ItemArmorTotal.dbc")]
    public sealed class ItemArmorTotalEntry
    {
        public int ID;
        public int itemLevel;
        public float cloth;
        public float leather;
        public float mail;
        public float plate;
    }

    [DbFileInfo(18179, "ItemBagFamily.dbc")]
    public sealed class ItemBagFamilyEntry
    {
        public int ID;
        public string name_lang;
    }

    [DbFileInfo(18179, "ItemClass.dbc")]
    public sealed class ItemClassEntry
    {
        public int classID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public float priceModifier;
        public string className_lang;
    }

    [DbFileInfo(18179, "ItemDamageAmmo.dbc")]
    public sealed class ItemDamageAmmoEntry
    {
        public int ID;
        public float quality1;
        public float quality2;
        public float quality3;
        public float quality4;
        public float quality5;
        public float quality6;
        public float quality7;
        public int itemLevel;
    }

    [DbFileInfo(18179, "ItemDamageOneHandCaster.dbc")]
    public sealed class ItemDamageOneHandCasterEntry
    {
        public int ID;
        public float quality1;
        public float quality2;
        public float quality3;
        public float quality4;
        public float quality5;
        public float quality6;
        public float quality7;
        public int itemLevel;
    }

    [DbFileInfo(18179, "ItemDamageOneHand.dbc")]
    public sealed class ItemDamageOneHandEntry
    {
        public int ID;
        public float quality1;
        public float quality2;
        public float quality3;
        public float quality4;
        public float quality5;
        public float quality6;
        public float quality7;
        public int itemLevel;
    }

    [DbFileInfo(18179, "ItemDamageRanged.dbc")]
    public sealed class ItemDamageRangedEntry
    {
        public int ID;
        public float quality1;
        public float quality2;
        public float quality3;
        public float quality4;
        public float quality5;
        public float quality6;
        public float quality7;
        public int itemLevel;
    }

    [DbFileInfo(18179, "ItemDamageThrown.dbc")]
    public sealed class ItemDamageThrownEntry
    {
        public int ID;
        public float quality1;
        public float quality2;
        public float quality3;
        public float quality4;
        public float quality5;
        public float quality6;
        public float quality7;
        public int itemLevel;
    }

    [DbFileInfo(18179, "ItemDamageTwoHandCaster.dbc")]
    public sealed class ItemDamageTwoHandCasterEntry
    {
        public int ID;
        public float quality1;
        public float quality2;
        public float quality3;
        public float quality4;
        public float quality5;
        public float quality6;
        public float quality7;
        public int itemLevel;
    }

    [DbFileInfo(18179, "ItemDamageTwoHand.dbc")]
    public sealed class ItemDamageTwoHandEntry
    {
        public int ID;
        public float quality1;
        public float quality2;
        public float quality3;
        public float quality4;
        public float quality5;
        public float quality6;
        public float quality7;
        public int itemLevel;
    }

    [DbFileInfo(18179, "ItemDamageWand.dbc")]
    public sealed class ItemDamageWandEntry
    {
        public int ID;
        public float quality1;
        public float quality2;
        public float quality3;
        public float quality4;
        public float quality5;
        public float quality6;
        public float quality7;
        public int itemLevel;
    }

    [DbFileInfo(18179, "ItemDisenchantLoot.dbc")]
    public sealed class ItemDisenchantLootEntry
    {
        public int ID;
        public int itemClass;
        public int subclass;
        public int quality;
        public int minLevel;
        public int maxLevel;
        public int skillRequired;
    }

    [DbFileInfo(18179, "ItemDisplayInfo.dbc")]
    public sealed class ItemDisplayInfoEntry
    {
        public int ID;
        public string modelName1;
        public string modelName2;
        public string modelTexture1;
        public string modelTexture2;
        public int geosetGroup1;
        public int geosetGroup2;
        public int geosetGroup3;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int spellVisualID;
        public int helmetGeosetVis1;
        public int helmetGeosetVis2;
        public string texture1;
        public string texture2;
        public string texture3;
        public string texture4;
        public string texture5;
        public string texture6;
        public string texture7;
        public string texture8;
        public string texture9;
        public int itemVisual;
        public int particleColorID;
    }

    [DbFileInfo(18179, "ItemGroupSounds.dbc")]
    public sealed class ItemGroupSoundsEntry
    {
        public int ID;
        public int sound1;
        public int sound2;
        public int sound3;
        public int sound4;
    }

    [DbFileInfo(18179, "ItemLimitCategory.dbc")]
    public sealed class ItemLimitCategoryEntry
    {
        public int ID;
        public string name_lang;
        public int quantity;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "ItemNameDescription.dbc")]
    public sealed class ItemNameDescriptionEntry
    {
        public int ID;
        public string description_lang;
        public int color;
    }

    [DbFileInfo(18179, "ItemPetFood.dbc")]
    public sealed class ItemPetFoodEntry
    {
        public int ID;
        public string Name_lang;
    }

    [DbFileInfo(18179, "ItemPriceBase.dbc")]
    public sealed class ItemPriceBaseEntry
    {
        public int ID;
        public int itemLevel;
        public float armor;
        public float weapon;
    }

    [DbFileInfo(18179, "ItemPurchaseGroup.dbc")]
    public sealed class ItemPurchaseGroupEntry
    {
        public int ID;
        public int itemID1;
        public int itemID2;
        public int itemID3;
        public int itemID4;
        public int itemID5;
        public int itemID6;
        public int itemID7;
        public int itemID8;
        public string name_lang;
    }

    [DbFileInfo(18179, "ItemRandomProperties.dbc")]
    public sealed class ItemRandomPropertiesEntry
    {
        public int ID;
        public string Name;
        public int Enchantment1;
        public int Enchantment2;
        public int Enchantment3;
        public int Enchantment4;
        public int Enchantment5;
        public string name_lang;
    }

    [DbFileInfo(18179, "ItemRandomSuffix.dbc")]
    public sealed class ItemRandomSuffixEntry
    {
        public int ID;
        public string name_lang;
        public string internalName;
        public int enchantment1;
        public int enchantment2;
        public int enchantment3;
        public int enchantment4;
        public int enchantment5;
        public int allocationPct1;
        public int allocationPct2;
        public int allocationPct3;
        public int allocationPct4;
        public int allocationPct5;
    }

    [DbFileInfo(18179, "ItemSet.dbc")]
    public sealed class ItemSetEntry
    {
        public int ID;
        public string name_lang;
        public int itemID1;
        public int itemID2;
        public int itemID3;
        public int itemID4;
        public int itemID5;
        public int itemID6;
        public int itemID7;
        public int itemID8;
        public int itemID9;
        public int itemID10;
        public int itemID11;
        public int itemID12;
        public int itemID13;
        public int itemID14;
        public int itemID15;
        public int itemID16;
        public int itemID17;
        public int requiredSkill;
        public int requiredSkillRank;
    }

    [DbFileInfo(18179, "ItemSetSpell.dbc")]
    public sealed class ItemSetSpellEntry
    {
        public int ID;
        public int itemSetID;
        public int spellID;
        public int threshold;
        public int chrSpecID;
    }

    [DbFileInfo(18179, "ItemSpecOverride.dbc")]
    public sealed class ItemSpecOverrideEntry
    {
        public int ID;
        public int itemID;
        public int specID;
    }

    [DbFileInfo(18179, "ItemSpec.dbc")]
    public sealed class ItemSpecEntry
    {
        public int ID;
        public int minLevel;
        public int maxLevel;
        public int itemType;
        public int primaryStat;
        public int secondaryStat;
        public int specializationID;
    }

    [DbFileInfo(18179, "ItemSubClassMask.dbc")]
    public sealed class ItemSubClassMaskEntry
    {
        public int classID;
        public int mask;
        public string name_lang;
    }

    [DbFileInfo(18179, "ItemSubClass.dbc")]
    public sealed class ItemSubClassEntry
    {
        public int classID;
        public int subClassID;
        public int prerequisiteProficiency;
        public int postrequisiteProficiency;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int displayFlags;
        public int weaponParrySeq;
        public int weaponReadySeq;
        public int weaponAttackSeq;
        public int WeaponSwingSize;
        public string displayName_lang;
        public string verboseName_lang;
    }

    [DbFileInfo(18179, "ItemUpgradePath.dbc")]
    public sealed class ItemUpgradePathEntry
    {
        public int id;
    }

    [DbFileInfo(18179, "ItemVisualEffects.dbc")]
    public sealed class ItemVisualEffectsEntry
    {
        public int ID;
        public string Model;
    }

    [DbFileInfo(18179, "ItemVisuals.dbc")]
    public sealed class ItemVisualsEntry
    {
        public int ID;
        public int Slot1;
        public int Slot2;
        public int Slot3;
        public int Slot4;
        public int Slot5;
    }

    [DbFileInfo(18179, "JournalEncounterCreature.dbc")]
    public sealed class JournalEncounterCreatureEntry
    {
        public int ID;
        public int journalEncounterID;
        public int creatureDisplayInfoID;
        public int orderIndex;
        public int fileDataID;
        public string name_lang;
        public string description_lang;
    }

    [DbFileInfo(18179, "JournalEncounterItem.dbc")]
    public sealed class JournalEncounterItemEntry
    {
        public int ID;
        public int journalEncounterID;
        public int itemID;
        public int difficultyMask;
        public int factionMask;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "JournalEncounter.dbc")]
    public sealed class JournalEncounterEntry
    {
        public int ID;
        public int dungeonMapID;
        public int worldMapAreaID;
        public float map1;
        public float map2;
        public int firstSectionID;
        public int journalInstanceID;
        public int orderIndex;
        public int difficultyMask;
        public string name_lang;
        public string description_lang;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "JournalEncounterSection.dbc")]
    public sealed class JournalEncounterSectionEntry
    {
        public int ID;
        public int journalEncounterID;
        public int nextSiblingSectionID;
        public int firstChildSectionID;
        public int parentSectionID;
        public int orderIndex;
        public int type;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int iconFlags;
        public string title_lang;
        public string bodyText_lang;
        public int difficultyMask;
        public int iconCreatureDisplayInfoID;
        public int spellID;
        public int iconFileDataID;
    }

    [DbFileInfo(18179, "JournalEncounterXDifficulty.dbc")]
    public sealed class JournalEncounterXDifficultyEntry
    {
        public int ID;
        public int journalEncounterID;
        public int difficultyID;
    }

    [DbFileInfo(18179, "JournalInstance.dbc")]
    public sealed class JournalInstanceEntry
    {
        public int ID;
        public int mapID;
        public int areaID;
        public int buttonFiledataID;
        public int buttonSmallFileDataID;
        public int backgroundFiledataID;
        public int loreFileDataID;
        public string name_lang;
        public string description_lang;
    }

    [DbFileInfo(18179, "JournalItemXDifficulty.dbc")]
    public sealed class JournalItemXDifficultyEntry
    {
        public int ID;
        public int journalEncounterItemID;
        public int difficultyID;
    }

    [DbFileInfo(18179, "JournalSectionXDifficulty.dbc")]
    public sealed class JournalSectionXDifficultyEntry
    {
        public int ID;
        public int journalEncounterSectionID;
        public int difficultyID;
    }

    [DbFileInfo(18179, "JournalTier.dbc")]
    public sealed class JournalTierEntry
    {
        public int ID;
        public string name_lang;
    }

    [DbFileInfo(18179, "JournalTierXInstance.dbc")]
    public sealed class JournalTierXInstanceEntry
    {
        public int journalTierID;
        public int journalInstanceID;
    }

    [DbFileInfo(18179, "Languages.dbc")]
    public sealed class LanguagesEntry
    {
        public int ID;
        public string name_lang;
    }

    [DbFileInfo(18179, "LanguageWords.dbc")]
    public sealed class LanguageWordsEntry
    {
        public int ID;
        public int languageID;
        public string word;
    }

    [DbFileInfo(18179, "LfgDungeonExpansion.dbc")]
    public sealed class LfgDungeonExpansionEntry
    {
        public int ID;
        public int lfg_id;
        public int expansion_level;
        public int random_id;
        public int hard_level_min;
        public int hard_level_max;
        public int target_level_min;
        public int target_level_max;
    }

    [DbFileInfo(18179, "LfgDungeonGroup.dbc")]
    public sealed class LfgDungeonGroupEntry
    {
        public int ID;
        public string name_lang;
        public int order_index;
        public int parent_group_id;
        public int typeid;
    }

    [DbFileInfo(18179, "LfgDungeonsGroupingMap.dbc")]
    public sealed class LfgDungeonsGroupingMapEntry
    {
        public int ID;
        public int lfgDungeonsID;
        public int random_lfgDungeonsID;
        public int group_id;
    }

    [DbFileInfo(18179, "LfgDungeons.dbc")]
    public sealed class LfgDungeonsEntry
    {
        public int ID;
        public string name_lang;
        public int minLevel;
        public int maxLevel;
        public int target_level;
        public int target_level_min;
        public int target_level_max;
        public int mapID;
        public int difficultyID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int typeID;
        public int faction;
        public string textureFilename;
        public int expansionLevel;
        public int order_index;
        public int group_id;
        public string description_lang;
        public int random_id;
        public int count_tank;
        public int count_healer;
        public int count_damage;
        public int min_count_tank;
        public int min_count_healer;
        public int min_count_damage;
        public int scenarioID;
        public int subtype;
        public int bonus_reputation_amount;
        public int mentorCharLevel;
        public int mentorItemLevel;
    }

    [DbFileInfo(18179, "LoadingScreens.dbc")]
    public sealed class LoadingScreensEntry
    {
        public int ID;
        public string name;
        public string fileName;
        public int hasWideScreen;
    }

    [DbFileInfo(18179, "LoadingScreenTaxiSplines.dbc")]
    public sealed class LoadingScreenTaxiSplinesEntry
    {
        public int ID;
        public int PathID;
        public float Locx1;
        public float Locx2;
        public float Locx3;
        public float Locx4;
        public float Locx5;
        public float Locx6;
        public float Locx7;
        public float Locx8;
        public float Locx9;
        public float Locx10;
        public float Locy1;
        public float Locy2;
        public float Locy3;
        public float Locy4;
        public float Locy5;
        public float Locy6;
        public float Locy7;
        public float Locy8;
        public float Locy9;
        public float Locy10;
        public int LegIndex;
        public int LoadingScreenID;
    }

    [DbFileInfo(18179, "Lock.dbc")]
    public sealed class LockEntry
    {
        public int ID;
        public int Type1;
        public int Type2;
        public int Type3;
        public int Type4;
        public int Type5;
        public int Type6;
        public int Type7;
        public int Type8;
        public int Index1;
        public int Index2;
        public int Index3;
        public int Index4;
        public int Index5;
        public int Index6;
        public int Index7;
        public int Index8;
        public int Skill1;
        public int Skill2;
        public int Skill3;
        public int Skill4;
        public int Skill5;
        public int Skill6;
        public int Skill7;
        public int Skill8;
        public int Action1;
        public int Action2;
        public int Action3;
        public int Action4;
        public int Action5;
        public int Action6;
        public int Action7;
        public int Action8;
    }

    [DbFileInfo(18179, "LockType.dbc")]
    public sealed class LockTypeEntry
    {
        public int ID;
        public string name_lang;
        public string resourceName_lang;
        public string verb_lang;
        public string cursorName;
    }

    [DbFileInfo(18179, "MailTemplate.dbc")]
    public sealed class MailTemplateEntry
    {
        public int ID;
        public string subject_lang;
        public string body_lang;
    }

    [DbFileInfo(18179, "ManifestInterfaceActionIcon.dbc")]
    public sealed class ManifestInterfaceActionIconEntry
    {
        public int ID;
    }

    [DbFileInfo(18179, "ManifestInterfaceData.dbc")]
    public sealed class ManifestInterfaceDataEntry
    {
        public int ID;
        public string FilePath;
        public string FileName;
    }

    [DbFileInfo(18179, "ManifestInterfaceItemIcon.dbc")]
    public sealed class ManifestInterfaceItemIconEntry
    {
        public int ID;
    }

    [DbFileInfo(18179, "ManifestInterfaceTOCData.dbc")]
    public sealed class ManifestInterfaceTOCDataEntry
    {
        public int ID;
        public string FilePath;
    }

    [DbFileInfo(18179, "MapDifficulty.dbc")]
    public sealed class MapDifficultyEntry
    {
        public int ID;
        public int mapID;
        public int difficultyID;
        public string message_lang;
        public int raidDuration;
        public int maxPlayers;
        public int lockID;
    }

    [DbFileInfo(18179, "Material.dbc")]
    public sealed class MaterialEntry
    {
        public int ID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int foleySoundID;
        public int sheatheSoundID;
        public int unsheatheSoundID;
    }

    [DbFileInfo(18179, "MinorTalent.dbc")]
    public sealed class MinorTalentEntry
    {
        public int ID;
        public int chrSpecializationID;
        public int spellID;
        public int orderIndex;
    }

    [DbFileInfo(18179, "ModifierTree.dbc")]
    public sealed class ModifierTreeEntry
    {
        public int ID;
        public int type;
        public int asset;
        public int secondaryAsset;
        public int _operator;
        public int amount;
        public int parent;
    }

    [DbFileInfo(18179, "MountCapability.dbc")]
    public sealed class MountCapabilityEntry
    {
        public int ID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int reqRidingSkill;
        public int reqAreaID;
        public int reqSpellAuraID;
        public int reqSpellKnownID;
        public int modSpellAuraID;
        public int reqMapID;
    }

    [DbFileInfo(18179, "MountType.dbc")]
    public sealed class MountTypeEntry
    {
        public int ID;
        public int capability1;
        public int capability2;
        public int capability3;
        public int capability4;
        public int capability5;
        public int capability6;
        public int capability7;
        public int capability8;
        public int capability9;
        public int capability10;
        public int capability11;
        public int capability12;
        public int capability13;
        public int capability14;
        public int capability15;
        public int capability16;
        public int capability17;
        public int capability18;
        public int capability19;
        public int capability20;
        public int capability21;
        public int capability22;
        public int capability23;
        public int capability24;
    }

    [DbFileInfo(18179, "MovieFileData.dbc")]
    public sealed class MovieFileDataEntry
    {
        public int FileDataID;
        public int resolution;
    }

    [DbFileInfo(18179, "MovieOverlays.dbc")]
    public sealed class MovieOverlaysEntry
    {
        public int movieID;
        public int localeMask;
        public int overlayRangeBegin;
        public int overlayRangeEnd;
    }

    [DbFileInfo(18179, "Movie.dbc")]
    public sealed class MovieEntry
    {
        public int ID;
        public int volume;
        public int keyID;
        public int audioFileDataID;
        public int subtitleFileDataID;
    }

    [DbFileInfo(18179, "MovieVariation.dbc")]
    public sealed class MovieVariationEntry
    {
        public int ID;
        public int movieID;
        public int fileDataID;
        public int OverlayFileDataID;
    }

    [DbFileInfo(18179, "NameGen.dbc")]
    public sealed class NameGenEntry
    {
        public int ID;
        public string name;
        public int raceID;
        public int sex;
    }

    [DbFileInfo(18179, "NamesProfanity.dbc")]
    public sealed class NamesProfanityEntry
    {
        public int ID;
        public string Name;
        public int Language;
    }

    [DbFileInfo(18179, "NamesReservedLocale.dbc")]
    public sealed class NamesReservedLocaleEntry
    {
        public int ID;
        public string Name;
        public int LocaleMask;
    }

    [DbFileInfo(18179, "NamesReserved.dbc")]
    public sealed class NamesReservedEntry
    {
        public int ID;
        public string Name;
    }

    [DbFileInfo(18179, "NPCSounds.dbc")]
    public sealed class NPCSoundsEntry
    {
        public int ID;
        public int SoundID1;
        public int SoundID2;
        public int SoundID3;
        public int SoundID4;
    }

    [DbFileInfo(18179, "ObjectEffectGroup.dbc")]
    public sealed class ObjectEffectGroupEntry
    {
        public int ID;
        public string name;
    }

    [DbFileInfo(18179, "ObjectEffectModifier.dbc")]
    public sealed class ObjectEffectModifierEntry
    {
        public int ID;
        public int inputType;
        public int mapType;
        public int outputType;
        public float param1;
        public float param2;
        public float param3;
        public float param4;
    }

    [DbFileInfo(18179, "ObjectEffectPackageElem.dbc")]
    public sealed class ObjectEffectPackageElemEntry
    {
        public int ID;
        public int objectEffectPackageID;
        public int objectEffectGroupID;
        public int stateType;
    }

    [DbFileInfo(18179, "ObjectEffectPackage.dbc")]
    public sealed class ObjectEffectPackageEntry
    {
        public int ID;
        public string name;
    }

    [DbFileInfo(18179, "ObjectEffect.dbc")]
    public sealed class ObjectEffectEntry
    {
        public int ID;
        public string name;
        public int objectEffectGroupID;
        public int triggerType;
        public int eventType;
        public int effectRecType;
        public int effectRecID;
        public int attachment;
        public float offset1;
        public float offset2;
        public float offset3;
        public int objectEffectModifierID;
    }

    [DbFileInfo(18179, "OverrideSpellData.dbc")]
    public sealed class OverrideSpellDataEntry
    {
        public int ID;
        public int spells1;
        public int spells2;
        public int spells3;
        public int spells4;
        public int spells5;
        public int spells6;
        public int spells7;
        public int spells8;
        public int spells9;
        public int spells10;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int playerActionbarFileDataID;
    }

    [DbFileInfo(18179, "Package.dbc")]
    public sealed class PackageEntry
    {
        public int ID;
        public string icon;
        public int cost;
        public string name_lang;
    }

    [DbFileInfo(18179, "PageTextMaterial.dbc")]
    public sealed class PageTextMaterialEntry
    {
        public int ID;
        public string name;
    }

    [DbFileInfo(18179, "PaperDollItemFrame.dbc")]
    public sealed class PaperDollItemFrameEntry
    {
        public string ItemButtonName;
        public string SlotIcon;
        public int SlotNumber;
    }

    [DbFileInfo(18179, "ParticleColor.dbc")]
    public sealed class ParticleColorEntry
    {
        public int ID;
        public int start1;
        public int start2;
        public int start3;
        public int mid1;
        public int mid2;
        public int mid3;
        public int end1;
        public int end2;
        public int end3;
    }

    [DbFileInfo(18179, "Phase.dbc")]
    public sealed class PhaseEntry
    {
        public int ID;
        public string name;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "PhaseShiftZoneSounds.dbc")]
    public sealed class PhaseShiftZoneSoundsEntry
    {
        public int ID;
        public int AreaID;
        public int WMOAreaID;
        public int PhaseID;
        public int PhaseGroupID;
        public int PhaseUseFlags;
        public int ZoneIntroMusicID;
        public int ZoneMusicID;
        public int SoundAmbienceID;
        public int SoundProviderPreferencesID;
        public int UWZoneIntroMusicID;
        public int UWZoneMusicID;
        public int UWSoundAmbienceID;
        public int UWSoundProviderPreferencesID;
    }

    [DbFileInfo(18179, "PhaseXPhaseGroup.dbc")]
    public sealed class PhaseXPhaseGroupEntry
    {
        public int ID;
        public int phaseID;
        public int phaseGroupID;
    }

    [DbFileInfo(18179, "PlayerCondition.dbc")]
    public sealed class PlayerConditionEntry
    {
        public int ID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int minLevel;
        public int maxLevel;
        public int raceMask;
        public int classMask;
        public int gender;
        public int nativeGender;
        public int skillID1;
        public int skillID2;
        public int skillID3;
        public int skillID4;
        public int minSkill1;
        public int minSkill2;
        public int minSkill3;
        public int minSkill4;
        public int maxSkill1;
        public int maxSkill2;
        public int maxSkill3;
        public int maxSkill4;
        public int skillLogic;
        public int languageID;
        public int minLanguage;
        public int maxLanguage;
        public int minFactionID1;
        public int minFactionID2;
        public int minFactionID3;
        public int maxFactionID;
        public int minReputation1;
        public int minReputation2;
        public int minReputation3;
        public int maxReputation;
        public int reputationLogic;
        public int minPVPRank;
        public int maxPVPRank;
        public int pvpMedal;
        public int prevQuestLogic;
        public int prevQuestID1;
        public int prevQuestID2;
        public int prevQuestID3;
        public int prevQuestID4;
        public int currQuestLogic;
        public int currQuestID1;
        public int currQuestID2;
        public int currQuestID3;
        public int currQuestID4;
        public int currentCompletedQuestLogic;
        public int currentCompletedQuestID1;
        public int currentCompletedQuestID2;
        public int currentCompletedQuestID3;
        public int currentCompletedQuestID4;
        public int spellLogic;
        public int spellID1;
        public int spellID2;
        public int spellID3;
        public int spellID4;
        public int itemLogic;
        public int itemID1;
        public int itemID2;
        public int itemID3;
        public int itemID4;
        public int itemCount1;
        public int itemCount2;
        public int itemCount3;
        public int itemCount4;
        public int itemFlags;
        public int explored1;
        public int explored2;
        public int time1;
        public int time2;
        public int auraSpellLogic;
        public int auraSpellID1;
        public int auraSpellID2;
        public int auraSpellID3;
        public int auraSpellID4;
        public int worldStateExpressionID;
        public int weatherID;
        public int partyStatus;
        public int lifetimeMaxPVPRank;
        public int achievementLogic;
        public int achievement1;
        public int achievement2;
        public int achievement3;
        public int achievement4;
        public int lfgLogic;
        public int lfgStatus1;
        public int lfgStatus2;
        public int lfgStatus3;
        public int lfgStatus4;
        public int lfgCompare1;
        public int lfgCompare2;
        public int lfgCompare3;
        public int lfgCompare4;
        public int lfgValue1;
        public int lfgValue2;
        public int lfgValue3;
        public int lfgValue4;
        public int areaLogic;
        public int areaID1;
        public int areaID2;
        public int areaID3;
        public int areaID4;
        public int currencyLogic;
        public int currencyID1;
        public int currencyID2;
        public int currencyID3;
        public int currencyID4;
        public int currencyCount1;
        public int currencyCount2;
        public int currencyCount3;
        public int currencyCount4;
        public int questKillID;
        public int questKillLogic;
        public int questKillMonster1;
        public int questKillMonster2;
        public int questKillMonster3;
        public int questKillMonster4;
        public int minExpansionLevel;
        public int maxExpansionLevel;
        public int minExpansionTier;
        public int maxExpansionTier;
        public int minGuildLevel;
        public int maxGuildLevel;
        public int phaseUseFlags;
        public int phaseID;
        public int phaseGroupID;
        public int minAvgItemLevel;
        public int maxAvgItemLevel;
        public int minAvgEquippedItemLevel;
        public int maxAvgEquippedItemLevel;
        public int chrSpecializationIndex;
        public int chrSpecializationRole;
        public string failure_description_lang;
        public int powerType;
        public int powerTypeComp;
        public int powerTypeValue;
    }

    [DbFileInfo(18179, "PowerDisplay.dbc")]
    public sealed class PowerDisplayEntry
    {
        public int ID;
        public int actualType;
        public string globalStringBaseTag;
        public int red;
        public int green;
        public int blue;
    }

    [DbFileInfo(18179, "PvpDifficulty.dbc")]
    public sealed class PvpDifficultyEntry
    {
        public int ID;
        public int mapID;
        public int rangeIndex;
        public int minLevel;
        public int maxLevel;
    }

    [DbFileInfo(18179, "QuestFactionReward.dbc")]
    public sealed class QuestFactionRewardEntry
    {
        public int ID;
        public int Difficulty1;
        public int Difficulty2;
        public int Difficulty3;
        public int Difficulty4;
        public int Difficulty5;
        public int Difficulty6;
        public int Difficulty7;
        public int Difficulty8;
        public int Difficulty9;
        public int Difficulty10;
    }

    [DbFileInfo(18179, "QuestFeedbackEffect.dbc")]
    public sealed class QuestFeedbackEffectEntry
    {
        public int ID;
        public int fileDataID;
        public int attachPoint;
        public int minimapobject;
        public int priority;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "QuestInfo.dbc")]
    public sealed class QuestInfoEntry
    {
        public int ID;
        public string InfoName_lang;
    }

    [DbFileInfo(18179, "QuestMoneyReward.dbc")]
    public sealed class QuestMoneyRewardEntry
    {
        public int ID;
        public int difficulty1;
        public int difficulty2;
        public int difficulty3;
        public int difficulty4;
        public int difficulty5;
        public int difficulty6;
        public int difficulty7;
        public int difficulty8;
        public int difficulty9;
        public int difficulty10;
    }

    [DbFileInfo(18179, "QuestPOIBlob.dbc")]
    public sealed class QuestPOIBlobEntry
    {
        public int ID;
        public int NumPoints;
        public int MapID;
        public int WorldMapAreaID;
    }

    [DbFileInfo(18179, "QuestPOIPoint.dbc")]
    public sealed class QuestPOIPointEntry
    {
        public int ID;
        public int X;
        public int Y;
        public int QuestPOIBlobID;
    }

    [DbFileInfo(18179, "QuestSort.dbc")]
    public sealed class QuestSortEntry
    {
        public int ID;
        public string SortName_lang;
    }

    [DbFileInfo(18179, "QuestV2.dbc")]
    public sealed class QuestV2Entry
    {
        public int ID;
        public int UniqueBitFlag;
    }

    [DbFileInfo(18179, "QuestXP.dbc")]
    public sealed class QuestXPEntry
    {
        public int ID;
        public int difficulty1;
        public int difficulty2;
        public int difficulty3;
        public int difficulty4;
        public int difficulty5;
        public int difficulty6;
        public int difficulty7;
        public int difficulty8;
        public int difficulty9;
        public int difficulty10;
    }

    [DbFileInfo(18179, "RacialMounts.dbc")]
    public sealed class RacialMountsEntry
    {
        public int ID;
        public int race;
        public int spell_id;
    }

    [DbFileInfo(18179, "RandPropPoints.dbc")]
    public sealed class RandPropPointsEntry
    {
        public int ID;
        public int Epic1;
        public int Epic2;
        public int Epic3;
        public int Epic4;
        public int Epic5;
        public int Superior1;
        public int Superior2;
        public int Superior3;
        public int Superior4;
        public int Superior5;
        public int Good1;
        public int Good2;
        public int Good3;
        public int Good4;
        public int Good5;
    }

    [DbFileInfo(18179, "ResearchBranch.dbc")]
    public sealed class ResearchBranchEntry
    {
        public int ID;
        public string name_lang;
        public int researchFieldID;
        public int currencyID;
        public string texture;
        public int itemID;
    }

    [DbFileInfo(18179, "ResearchField.dbc")]
    public sealed class ResearchFieldEntry
    {
        public int ID;
        public string name_lang;
        public int slot;
    }

    [DbFileInfo(18179, "ResearchProject.dbc")]
    public sealed class ResearchProjectEntry
    {
        public int ID;
        public string name_lang;
        public string description_lang;
        public int rarity;
        public int researchBranchID;
        public int spellID;
        public int numSockets;
        public string texture;
        public int requiredWeight;
    }

    [DbFileInfo(18179, "ResearchSite.dbc")]
    public sealed class ResearchSiteEntry
    {
        public int ID;
        public int mapID;
        public int QuestPOIBlobID;
        public string name_lang;
        public int areaPOIIconEnum;
    }

    [DbFileInfo(18179, "Resistances.dbc")]
    public sealed class ResistancesEntry
    {
        public int ID;
        public int Flags;
        public int FizzleSoundID;
        public string name_lang;
    }

    [DbFileInfo(18179, "RulesetRaidOverride.dbc")]
    public sealed class RulesetRaidOverrideEntry
    {
        public int ID;
        public int mapID;
        public int difficultyID;
        public int rulesetID;
        public int sharedLock;
        public int raidduration;
    }

    [DbFileInfo(18179, "ScalingStatDistribution.dbc")]
    public sealed class ScalingStatDistributionEntry
    {
        public int ID;
        public int statID1;
        public int statID2;
        public int statID3;
        public int statID4;
        public int statID5;
        public int statID6;
        public int statID7;
        public int statID8;
        public int statID9;
        public int statID10;
        public int bonus1;
        public int bonus2;
        public int bonus3;
        public int bonus4;
        public int bonus5;
        public int bonus6;
        public int bonus7;
        public int bonus8;
        public int bonus9;
        public int bonus10;
        public int minlevel;
        public int maxlevel;
    }

    [DbFileInfo(18179, "ScalingStatValues.dbc")]
    public sealed class ScalingStatValuesEntry
    {
        public int ID;
        public int charlevel;
        public int effectiveLevel;
        public int weaponDPS1H;
        public int weaponDPS2H;
        public int spellcasterDPS1H;
        public int spellcasterDPS2H;
        public int rangedDPS;
        public int wandDPS;
        public int spellPower;
        public int budgetPrimary;
        public int budgetSecondary;
        public int budgetTertiary;
        public int budgetSub;
        public int budgetTrivial;
        public int armorShoulder1;
        public int armorShoulder2;
        public int armorShoulder3;
        public int armorShoulder4;
        public int armorChest1;
        public int armorChest2;
        public int armorChest3;
        public int armorChest4;
        public int armorHead1;
        public int armorHead2;
        public int armorHead3;
        public int armorHead4;
        public int armorLegs1;
        public int armorLegs2;
        public int armorLegs3;
        public int armorLegs4;
        public int armorFeet1;
        public int armorFeet2;
        public int armorFeet3;
        public int armorFeet4;
        public int armorWaist1;
        public int armorWaist2;
        public int armorWaist3;
        public int armorWaist4;
        public int armorHands1;
        public int armorHands2;
        public int armorHands3;
        public int armorHands4;
        public int armorWrists1;
        public int armorWrists2;
        public int armorWrists3;
        public int armorWrists4;
        public int armorBack;
        public int armorShield;
    }

    [DbFileInfo(18179, "ScenarioEventEntry.dbc")]
    public sealed class ScenarioEventEntryEntry
    {
        public int ID;
        public int triggerType;
        public int triggerAsset;
    }

    [DbFileInfo(18179, "Scenario.dbc")]
    public sealed class ScenarioEntry
    {
        public int ID;
        public string name_lang;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "ScenarioStep.dbc")]
    public sealed class ScenarioStepEntry
    {
        public int ID;
        public int criteriatreeid;
        public int scenarioID;
        public int orderIndex;
        public string description_lang;
        public string title_lang;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int relatedStep;
        public int supersedes;
        public int rewardQuestID;
    }

    [DbFileInfo(18179, "ScreenEffect.dbc")]
    public sealed class ScreenEffectEntry
    {
        public int id;
        public string name;
        public int effect;
        public int param1;
        public int param2;
        public int param3;
        public int param4;
        public int lightParamsID;
        public int lightParamsFadeIn;
        public int lightParamsFadeOut;
        public int lightFlags;
        public int soundAmbienceID;
        public int zoneMusicID;
        public int timeOfDayOverride;
        public int effectMask;
    }

    [DbFileInfo(18179, "ScreenLocation.dbc")]
    public sealed class ScreenLocationEntry
    {
        public int ID;
        public string name;
    }

    [DbFileInfo(18179, "ServerMessages.dbc")]
    public sealed class ServerMessagesEntry
    {
        public int ID;
        public string Text_lang;
    }

    [DbFileInfo(18179, "SkillLineAbility.dbc")]
    public sealed class SkillLineAbilityEntry
    {
        public int ID;
        public int skillLine;
        public int spell;
        public int raceMask;
        public int classMask;
        public int minSkillLineRank;
        public int supercedesSpell;
        public int acquireMethod;
        public int trivialSkillLineRankHigh;
        public int trivialSkillLineRankLow;
        public int numSkillUps;
        public int uniqueBit;
        public int tradeSkillCategoryID;
    }

    [DbFileInfo(18179, "SkillLineAbilitySortedSpell.dbc")]
    public sealed class SkillLineAbilitySortedSpellEntry
    {
        public int ID;
        public int spell;
    }

    [DbFileInfo(18179, "SkillLine.dbc")]
    public sealed class SkillLineEntry
    {
        public int ID;
        public int categoryID;
        public string displayName_lang;
        public string description_lang;
        public int spellIconID;
        public string alternateVerb_lang;
        public int canLink;
        public int parentSkillLineID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "SkillRaceClassInfo.dbc")]
    public sealed class SkillRaceClassInfoEntry
    {
        public int ID;
        public int skillID;
        public int raceMask;
        public int classMask;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int availability;
        public int minLevel;
        public int skillTierID;
    }

    [DbFileInfo(18179, "SkillTiers.dbc")]
    public sealed class SkillTiersEntry
    {
        public int ID;
        public int value1;
        public int value2;
        public int value3;
        public int value4;
        public int value5;
        public int value6;
        public int value7;
        public int value8;
        public int value9;
        public int value10;
        public int value11;
        public int value12;
        public int value13;
        public int value14;
        public int value15;
        public int value16;
    }

    [DbFileInfo(18179, "SoundAmbienceFlavor.dbc")]
    public sealed class SoundAmbienceFlavorEntry
    {
        public int ID;
        public int SoundAmbienceID;
        public int SoundEntriesIDDay;
        public int SoundEntriesIDNight;
    }

    [DbFileInfo(18179, "SoundAmbience.dbc")]
    public sealed class SoundAmbienceEntry
    {
        public int ID;
        public int AmbienceID1;
        public int AmbienceID2;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "SoundFilterElem.dbc")]
    public sealed class SoundFilterElemEntry
    {
        public int ID;
        public int soundFilterID;
        public int orderIndex;
        public int filterType;
        public float params1;
        public float params2;
        public float params3;
        public float params4;
        public float params5;
        public float params6;
        public float params7;
        public float params8;
        public float params9;
    }

    [DbFileInfo(18179, "SoundFilter.dbc")]
    public sealed class SoundFilterEntry
    {
        public int ID;
        public string name;
    }

    [DbFileInfo(18179, "SoundOverride.dbc")]
    public sealed class SoundOverrideEntry
    {
        public int ID;
        public int WowEditLock;
        public string WowEditLockUser;
        public int ZoneIntroMusicID;
        public int ZoneMusicID;
        public int SoundAmbienceID;
        public int SoundProviderPreferencesID;
    }

    [DbFileInfo(18179, "SoundProviderPreferences.dbc")]
    public sealed class SoundProviderPreferencesEntry
    {
        public int ID;
        public string Description;
        public int Flags;
        public int EAXEnvironmentSelection;
        public float EAXDecayTime;
        public float EAX2EnvironmentSize;
        public float EAX2EnvironmentDiffusion;
        public int EAX2Room;
        public int EAX2RoomHF;
        public float EAX2DecayHFRatio;
        public int EAX2Reflections;
        public float EAX2ReflectionsDelay;
        public int EAX2Reverb;
        public float EAX2ReverbDelay;
        public float EAX2RoomRolloff;
        public float EAX2AirAbsorption;
        public int EAX3RoomLF;
        public float EAX3DecayLFRatio;
        public float EAX3EchoTime;
        public float EAX3EchoDepth;
        public float EAX3ModulationTime;
        public float EAX3ModulationDepth;
        public float EAX3HFReference;
        public float EAX3LFReference;
    }

    [DbFileInfo(18179, "SpamMessages.dbc")]
    public sealed class SpamMessagesEntry
    {
        public int ID;
        public string text;
    }

    [DbFileInfo(18179, "SpecializationSpells.dbc")]
    public sealed class SpecializationSpellsEntry
    {
        public int ID;
        public int specID;
        public int spellID;
        public int overridesSpellID;
        public string description_lang;
    }

    [DbFileInfo(18179, "SpellActivationOverlay.dbc")]
    public sealed class SpellActivationOverlayEntry
    {
        public int ID;
        public int spellID;
        public int overlayFileDataID;
        public int screenLocationID;
        public int color;
        public float scale;
        public int iconHighlightSpellClassMask1;
        public int iconHighlightSpellClassMask2;
        public int iconHighlightSpellClassMask3;
        public int iconHighlightSpellClassMask4;
        public int triggerType;
        public int soundEntriesID;
    }

    [DbFileInfo(18179, "SpellAuraOptions.dbc")]
    public sealed class SpellAuraOptionsEntry
    {
        public int ID;
        public int spellID;
        public int difficultyID;
        public int cumulativeAura;
        public int procChance;
        public int procCharges;
        public int procTypeMask;
        public int procCategoryRecovery;
        public int spellProcsPerMinuteID;
    }

    [DbFileInfo(18179, "SpellAuraVisibility.dbc")]
    public sealed class SpellAuraVisibilityEntry
    {
        public int ID;
        public int spellID;
        public int type;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "SpellAuraVisXChrSpec.dbc")]
    public sealed class SpellAuraVisXChrSpecEntry
    {
        public int ID;
        public int spellAuraVisibilityID;
        public int chrSpecializationID;
    }

    [DbFileInfo(18179, "SpellCastingRequirements.dbc")]
    public sealed class SpellCastingRequirementsEntry
    {
        public int ID;
        public int facingCasterFlags;
        public int minFactionID;
        public int minReputation;
        public int requiredAreasID;
        public int requiredAuraVision;
        public int requiresSpellFocus;
    }

    [DbFileInfo(18179, "SpellCastTimes.dbc")]
    public sealed class SpellCastTimesEntry
    {
        public int ID;
        public int baseTime;
        public int perLevel;
        public int minimum;
    }

    [DbFileInfo(18179, "SpellCategories.dbc")]
    public sealed class SpellCategoriesEntry
    {
        public int ID;
        public int spellID;
        public int difficultyID;
        public int category;
        public int defenseType;
        public int dispelType;
        public int mechanic;
        public int preventionType;
        public int startRecoveryCategory;
        public int chargeCategory;
    }

    [DbFileInfo(18179, "SpellCategory.dbc")]
    public sealed class SpellCategoryEntry
    {
        public int ID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int usesPerWeek;
        public string name_lang;
        public int maxCharges;
        public int chargeRecoveryTime;
    }

    [DbFileInfo(18179, "SpellCooldowns.dbc")]
    public sealed class SpellCooldownsEntry
    {
        public int ID;
        public int spellID;
        public int difficultyID;
        public int categoryRecoveryTime;
        public int recoveryTime;
        public int startRecoveryTime;
    }

    [DbFileInfo(18179, "SpellDescriptionVariables.dbc")]
    public sealed class SpellDescriptionVariablesEntry
    {
        public int ID;
        public string variables;
    }

    [DbFileInfo(18179, "SpellDispelType.dbc")]
    public sealed class SpellDispelTypeEntry
    {
        public int ID;
        public string name_lang;
        public int mask;
        public int immunityPossible;
        public string internalName;
    }

    [DbFileInfo(18179, "SpellDuration.dbc")]
    public sealed class SpellDurationEntry
    {
        public int ID;
        public int duration;
        public int durationPerLevel;
        public int maxDuration;
    }

    [DbFileInfo(18179, "SpellEffect.dbc")]
    public sealed class SpellEffectEntry
    {
        public int ID;
        public int difficultyID;
        public int effect;
        public float effectAmplitude;
        public int effectAura;
        public int effectAuraPeriod;
        public int effectBasePoints;
        public float effectBonusCoefficient;
        public float effectChainAmplitude;
        public int effectChainTargets;
        public int effectDieSides;
        public int effectItemType;
        public int effectMechanic;
        public int effectMiscValue1;
        public int effectMiscValue2;
        public float effectPointsPerResource;
        public int effectRadiusIndex1;
        public int effectRadiusIndex2;
        public float effectRealPointsPerLevel;
        public int effectSpellClassMask1;
        public int effectSpellClassMask2;
        public int effectSpellClassMask3;
        public int effectSpellClassMask4;
        public int effectTriggerSpell;
        public float effectPos_facing;
        public int implicitTarget1;
        public int implicitTarget2;
        public int spellID;
        public int effectIndex;
        public int effectAttributes;
        public float bonusCoefficientFromAP;
    }

    [DbFileInfo(18179, "SpellEffectScaling.dbc")]
    public sealed class SpellEffectScalingEntry
    {
        public int ID;
        public float coefficient;
        public float variance;
        public float resourceCoefficient;
        public int spellEffectID;
    }

    [DbFileInfo(18179, "SpellEquippedItems.dbc")]
    public sealed class SpellEquippedItemsEntry
    {
        public int ID;
        public int spellID;
        public int difficultyID;
        public int equippedItemClass;
        public int equippedItemInvTypes;
        public int equippedItemSubclass;
    }

    [DbFileInfo(18179, "SpellFlyoutItem.dbc")]
    public sealed class SpellFlyoutItemEntry
    {
        public int ID;
        public int spellFlyoutID;
        public int spellID;
        public int slot;
    }

    [DbFileInfo(18179, "SpellFlyout.dbc")]
    public sealed class SpellFlyoutEntry
    {
        public int ID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int raceMask;
        public int classMask;
        public int spellIconID;
        public string name_lang;
        public string description_lang;
    }

    [DbFileInfo(18179, "SpellFocusObject.dbc")]
    public sealed class SpellFocusObjectEntry
    {
        public int ID;
        public string name_lang;
    }

    [DbFileInfo(18179, "SpellIcon.dbc")]
    public sealed class SpellIconEntry
    {
        public int ID;
        public string textureFilename;
    }

    [DbFileInfo(18179, "SpellInterrupts.dbc")]
    public sealed class SpellInterruptsEntry
    {
        public int ID;
        public int spellID;
        public int difficultyID;
        public int auraInterruptFlags1;
        public int auraInterruptFlags2;
        public int channelInterruptFlags1;
        public int channelInterruptFlags2;
        public int interruptFlags;
    }

    [DbFileInfo(18179, "SpellItemEnchantmentCondition.dbc")]
    public sealed class SpellItemEnchantmentConditionEntry
    {
        public int ID;
        public int lt_operandType1;
        public int lt_operand1;
        public int lt_operand2;
        public int lt_operand3;
        public int lt_operand4;
        public int lt_operand5;
        public int operator1;
        public int rt_operandType1;
        public int rt_operand1;
        public int rt_operand2;
        public int rt_operand3;
        public int rt_operand4;
        public int rt_operand5;
        public int logic1;
    }

    [DbFileInfo(18179, "SpellItemEnchantment.dbc")]
    public sealed class SpellItemEnchantmentEntry
    {
        public int ID;
        public int charges;
        public int effect1;
        public int effect2;
        public int effect3;
        public int effectPointsMin1;
        public int effectPointsMin2;
        public int effectPointsMin3;
        public int effectArg1;
        public int effectArg2;
        public int effectArg3;
        public string name_lang;
        public int itemVisual;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int src_itemID;
        public int condition_id;
        public int requiredSkillID;
        public int requiredSkillRank;
        public int minLevel;
        public int maxLevel;
        public int itemLevel;
        public int scalingClass;
        public int scalingClassRestricted;
        public float effectScalingPoints1;
        public float effectScalingPoints2;
        public float effectScalingPoints3;
    }

    [DbFileInfo(18179, "SpellKeyboundOverride.dbc")]
    public sealed class SpellKeyboundOverrideEntry
    {
        public int ID;
        public string function;
    }

    [DbFileInfo(18179, "SpellLearnSpell.dbc")]
    public sealed class SpellLearnSpellEntry
    {
        public int ID;
        public int learnSpellID;
        public int overridesSpellID;
        public int spellID;
    }

    [DbFileInfo(18179, "SpellLevels.dbc")]
    public sealed class SpellLevelsEntry
    {
        public int ID;
        public int spellID;
        public int difficultyID;
        public int baseLevel;
        public int maxLevel;
        public int spellLevel;
    }

    [DbFileInfo(18179, "SpellMechanic.dbc")]
    public sealed class SpellMechanicEntry
    {
        public int ID;
        public string stateName_lang;
    }

    [DbFileInfo(18179, "SpellMisc.dbc")]
    public sealed class SpellMiscEntry
    {
        public int ID;
        public int spellID;
        public int difficultyID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint attributes1;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint attributes2;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint attributes3;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint attributes4;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint attributes5;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint attributes6;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint attributes7;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint attributes8;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint attributes9;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint attributes10;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint attributes11;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint attributes12;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint attributes13;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint attributes14;
        public int castingTimeIndex;
        public int durationIndex;
        public int rangeIndex;
        public float speed;
        public int spellVisualID1;
        public int spellVisualID2;
        public int spellIconID;
        public int activeIconID;
        public int schoolMask;
    }

    [DbFileInfo(18179, "SpellProcsPerMinuteMod.dbc")]
    public sealed class SpellProcsPerMinuteModEntry
    {
        public int ID;
        public int type;
        public int param;
        public float coeff;
        public int spellProcsPerMinuteID;
    }

    [DbFileInfo(18179, "SpellProcsPerMinute.dbc")]
    public sealed class SpellProcsPerMinuteEntry
    {
        public int ID;
        public float baseProcRate;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "SpellRadius.dbc")]
    public sealed class SpellRadiusEntry
    {
        public int ID;
        public float radius;
        public float radiusPerLevel;
        public float radiusMin;
        public float radiusMax;
    }

    [DbFileInfo(18179, "SpellRange.dbc")]
    public sealed class SpellRangeEntry
    {
        public int ID;
        public float rangeMin1;
        public float rangeMin2;
        public float rangeMax1;
        public float rangeMax2;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public string displayName_lang;
        public string displayNameShort_lang;
    }

    [DbFileInfo(18179, "Spell.dbc")]
    public sealed class SpellEntry
    {
        public int ID;
        public string name_lang;
        public string nameSubtext_lang;
        public string description_lang;
        public string auraDescription_lang;
        public int runeCostID;
        public int spellMissileID;
        public int descriptionVariablesID;
        public int scalingID;
        public int auraOptionsID;
        public int auraRestrictionsID;
        public int castingRequirementsID;
        public int categoriesID;
        public int classOptionsID;
        public int cooldownsID;
        public int equippedItemsID;
        public int interruptsID;
        public int levelsID;
        public int reagentsID;
        public int shapeshiftID;
        public int targetRestrictionsID;
        public int totemsID;
        public int requiredProjectID;
        public int miscID;
    }

    [DbFileInfo(18179, "SpellRuneCost.dbc")]
    public sealed class SpellRuneCostEntry
    {
        public int ID;
        public int blood;
        public int unholy;
        public int frost;
        public int chromatic;
        public int runicPower;
    }

    [DbFileInfo(18179, "SpellScaling.dbc")]
    public sealed class SpellScalingEntry
    {
        public int ID;
        public int castTimeMin;
        public int castTimeMax;
        public int castTimeMaxLevel;
        public int scalingClass;
        public float nerfFactor;
        public int nerfMaxLevel;
        public int maxScalingLevel;
        public int scalesFromItemLevel;
    }

    [DbFileInfo(18179, "SpellShapeshiftForm.dbc")]
    public sealed class SpellShapeshiftFormEntry
    {
        public int ID;
        public int bonusActionBar;
        public string name_lang;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int creatureType;
        public int attackIconID;
        public int combatRoundTime;
        public int creatureDisplayID1;
        public int creatureDisplayID2;
        public int creatureDisplayID3;
        public int creatureDisplayID4;
        public int presetSpellID1;
        public int presetSpellID2;
        public int presetSpellID3;
        public int presetSpellID4;
        public int presetSpellID5;
        public int presetSpellID6;
        public int presetSpellID7;
        public int presetSpellID8;
        public int mountTypeID;
        public int exitSoundEntriesID;
    }

    [DbFileInfo(18179, "SpellShapeshift.dbc")]
    public sealed class SpellShapeshiftEntry
    {
        public int ID;
        public int shapeshiftExclude1;
        public int shapeshiftExclude2;
        public int shapeshiftMask1;
        public int shapeshiftMask2;
        public int stanceBarOrder;
    }

    [DbFileInfo(18179, "SpellSpecialUnitEffect.dbc")]
    public sealed class SpellSpecialUnitEffectEntry
    {
        public int enumID;
        public int spellVisualEffectNameID;
    }

    [DbFileInfo(18179, "SpellTargetRestrictions.dbc")]
    public sealed class SpellTargetRestrictionsEntry
    {
        public int ID;
        public int spellID;
        public int difficultyID;
        public float coneAngle;
        public float width;
        public int maxTargets;
        public int maxTargetLevel;
        public int targetCreatureType;
        public int targets;
    }

    [DbFileInfo(18179, "SpellTotems.dbc")]
    public sealed class SpellTotemsEntry
    {
        public int ID;
        public int requiredTotemCategoryID1;
        public int requiredTotemCategoryID2;
        public int totem1;
        public int totem2;
    }

    [DbFileInfo(18179, "Stationery.dbc")]
    public sealed class StationeryEntry
    {
        public int ID;
        public int itemID;
        public string texture;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "StringLookups.dbc")]
    public sealed class StringLookupsEntry
    {
        public int ID;
        public string String;
    }

    [DbFileInfo(18179, "SummonProperties.dbc")]
    public sealed class SummonPropertiesEntry
    {
        public int id;
        public int control;
        public int faction;
        public int title;
        public int slot;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "Talent.dbc")]
    public sealed class TalentEntry
    {
        public int ID;
        public int specID;
        public int tierID;
        public int columnIndex;
        public int spellID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int categoryMask1;
        public int categoryMask2;
        public int classID;
        public int overridesSpellID;
        public string description_lang;
    }

    [DbFileInfo(18179, "TaxiNodes.dbc")]
    public sealed class TaxiNodesEntry
    {
        public int ID;
        public int ContinentID;
        public float pos1;
        public float pos2;
        public float pos3;
        public string Name_lang;
        public int MountCreatureID1;
        public int MountCreatureID2;
        public int conditionID;
        public int Flags;
        public float MapOffset1;
        public float MapOffset2;
    }

    [DbFileInfo(18179, "TaxiPathNode.dbc")]
    public sealed class TaxiPathNodeEntry
    {
        public int ID;
        public int PathID;
        public int NodeIndex;
        public int ContinentID;
        public float Loc1;
        public float Loc2;
        public float Loc3;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int delay;
        public int arrivalEventID;
        public int departureEventID;
    }

    [DbFileInfo(18179, "TaxiPath.dbc")]
    public sealed class TaxiPathEntry
    {
        public int ID;
        public int FromTaxiNode;
        public int ToTaxiNode;
        public int Cost;
    }

    [DbFileInfo(18179, "TerrainTypeSounds.dbc")]
    public sealed class TerrainTypeSoundsEntry
    {
        public int ID;
    }

    [DbFileInfo(18179, "TotemCategory.dbc")]
    public sealed class TotemCategoryEntry
    {
        public int ID;
        public string name_lang;
        public int totemCategoryType;
        public int totemCategoryMask;
    }

    [DbFileInfo(18179, "TradeSkillCategory.dbc")]
    public sealed class TradeSkillCategoryEntry
    {
        public int id;
        public int skilllineid;
        public int parenttradeskillcategoryid;
        public int orderindex;
        public string name_lang;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "TransportAnimation.dbc")]
    public sealed class TransportAnimationEntry
    {
        public int ID;
        public int TransportID;
        public int TimeIndex;
        public float Pos1;
        public float Pos2;
        public float Pos3;
        public int SequenceID;
    }

    [DbFileInfo(18179, "TransportPhysics.dbc")]
    public sealed class TransportPhysicsEntry
    {
        public int ID;
        public float waveAmp;
        public float waveTimeScale;
        public float rollAmp;
        public float rollTimeScale;
        public float pitchAmp;
        public float pitchTimeScale;
        public float maxBank;
        public float maxBankTurnSpeed;
        public float speedDampThresh;
        public float speedDamp;
    }

    [DbFileInfo(18179, "TransportRotation.dbc")]
    public sealed class TransportRotationEntry
    {
        public int ID;
        public int GameObjectsID;
        public int TimeIndex;
        public float Rot1;
        public float Rot2;
        public float Rot3;
        public float Rot4;
    }

    [DbFileInfo(18179, "UnitBloodLevels.dbc")]
    public sealed class UnitBloodLevelsEntry
    {
        public int ID;
        public int Violencelevel1;
        public int Violencelevel2;
        public int Violencelevel3;
    }

    [DbFileInfo(18179, "UnitBlood.dbc")]
    public sealed class UnitBloodEntry
    {
        public int ID;
        public int CombatBloodSpurtFront1;
        public int CombatBloodSpurtFront2;
        public int CombatBloodSpurtBack1;
        public int CombatBloodSpurtBack2;
        public string GroundBlood1;
        public string GroundBlood2;
        public string GroundBlood3;
        public string GroundBlood4;
        public string GroundBlood5;
    }

    [DbFileInfo(18179, "UnitCondition.dbc")]
    public sealed class UnitConditionEntry
    {
        public int ID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int variable1;
        public int variable2;
        public int variable3;
        public int variable4;
        public int variable5;
        public int variable6;
        public int variable7;
        public int variable8;
        public int op1;
        public int op2;
        public int op3;
        public int op4;
        public int op5;
        public int op6;
        public int op7;
        public int op8;
        public int value1;
        public int value2;
        public int value3;
        public int value4;
        public int value5;
        public int value6;
        public int value7;
        public int value8;
    }

    [DbFileInfo(18179, "UnitPowerBar.dbc")]
    public sealed class UnitPowerBarEntry
    {
        public int ID;
        public int minPower;
        public int maxPower;
        public int startPower;
        public int centerPower;
        public float regenerationPeace;
        public float regenerationCombat;
        public int barType;
        public int fileDataID1;
        public int fileDataID2;
        public int fileDataID3;
        public int fileDataID4;
        public int fileDataID5;
        public int fileDataID6;
        public int color1;
        public int color2;
        public int color3;
        public int color4;
        public int color5;
        public int color6;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public string name_lang;
        public string cost_lang;
        public string outOfError_lang;
        public string toolTip_lang;
        public float startInset;
        public float endInset;
    }

    [DbFileInfo(18179, "Vehicle.dbc")]
    public sealed class VehicleEntry
    {
        public int ID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int flagsB;
        public float turnSpeed;
        public float pitchSpeed;
        public float pitchMin;
        public float pitchMax;
        public int seatID1;
        public int seatID2;
        public int seatID3;
        public int seatID4;
        public int seatID5;
        public int seatID6;
        public int seatID7;
        public int seatID8;
        public float mouseLookOffsetPitch;
        public float cameraFadeDistScalarMin;
        public float cameraFadeDistScalarMax;
        public float cameraPitchOffset;
        public float facingLimitRight;
        public float facingLimitLeft;
        public float msslTrgtTurnLingering;
        public float msslTrgtPitchLingering;
        public float msslTrgtMouseLingering;
        public float msslTrgtEndOpacity;
        public float msslTrgtArcSpeed;
        public float msslTrgtArcRepeat;
        public float msslTrgtArcWidth;
        public float msslTrgtImpactRadius1;
        public float msslTrgtImpactRadius2;
        public string msslTrgtArcTexture;
        public string msslTrgtImpactTexture;
        public string msslTrgtImpactModel1;
        public string msslTrgtImpactModel2;
        public float cameraYawOffset;
        public int uiLocomotionType;
        public float msslTrgtImpactTexRadius;
        public int vehicleUIIndicatorID;
        public int powerDisplayID1;
        public int powerDisplayID2;
        public int powerDisplayID3;
    }

    [DbFileInfo(18179, "VehicleSeat.dbc")]
    public sealed class VehicleSeatEntry
    {
        public int ID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int attachmentID;
        public float attachmentOffset1;
        public float attachmentOffset2;
        public float attachmentOffset3;
        public float enterPreDelay;
        public float enterSpeed;
        public float enterGravity;
        public float enterMinDuration;
        public float enterMaxDuration;
        public float enterMinArcHeight;
        public float enterMaxArcHeight;
        public int enterAnimStart;
        public int enterAnimLoop;
        public int rideAnimStart;
        public int rideAnimLoop;
        public int rideUpperAnimStart;
        public int rideUpperAnimLoop;
        public float exitPreDelay;
        public float exitSpeed;
        public float exitGravity;
        public float exitMinDuration;
        public float exitMaxDuration;
        public float exitMinArcHeight;
        public float exitMaxArcHeight;
        public int exitAnimStart;
        public int exitAnimLoop;
        public int exitAnimEnd;
        public float passengerYaw;
        public float passengerPitch;
        public float passengerRoll;
        public int passengerAttachmentID;
        public int vehicleEnterAnim;
        public int vehicleExitAnim;
        public int vehicleRideAnimLoop;
        public int vehicleEnterAnimBone;
        public int vehicleExitAnimBone;
        public int vehicleRideAnimLoopBone;
        public float vehicleEnterAnimDelay;
        public float vehicleExitAnimDelay;
        public int vehicleAbilityDisplay;
        public int enterUISoundID;
        public int exitUISoundID;
        public int flagsB;
        public float cameraEnteringDelay;
        public float cameraEnteringDuration;
        public float cameraExitingDelay;
        public float cameraExitingDuration;
        public float cameraOffset1;
        public float cameraOffset2;
        public float cameraOffset3;
        public float cameraPosChaseRate;
        public float cameraFacingChaseRate;
        public float cameraEnteringZoom;
        public float cameraSeatZoomMin;
        public float cameraSeatZoomMax;
        public int enterAnimKitID;
        public int rideAnimKitID;
        public int exitAnimKitID;
        public int vehicleEnterAnimKitID;
        public int vehicleRideAnimKitID;
        public int vehicleExitAnimKitID;
        public int cameraModeID;
        public int flagsC;
        public int uiSkinFileDataID;
    }

    [DbFileInfo(18179, "VehicleUIIndicator.dbc")]
    public sealed class VehicleUIIndicatorEntry
    {
        public int ID;
        public string backgroundTexture;
    }

    [DbFileInfo(18179, "VehicleUIIndSeat.dbc")]
    public sealed class VehicleUIIndSeatEntry
    {
        public int ID;
        public int vehicleUIIndicatorID;
        public int virtualSeatIndex;
        public float xPos;
        public float yPos;
    }

    [DbFileInfo(18179, "VocalUISounds.dbc")]
    public sealed class VocalUISoundsEntry
    {
        public int ID;
        public int vocalUIEnum;
        public int raceID;
        public int NormalSoundID1;
        public int NormalSoundID2;
        public int PissedSoundID1;
        public int PissedSoundID2;
    }

    [DbFileInfo(18179, "WeaponImpactSounds.dbc")]
    public sealed class WeaponImpactSoundsEntry
    {
        public int ID;
        public int WeaponSubClassID;
        public int ParrySoundType;
        public int impactSoundID1;
        public int impactSoundID2;
        public int impactSoundID3;
        public int impactSoundID4;
        public int impactSoundID5;
        public int impactSoundID6;
        public int impactSoundID7;
        public int impactSoundID8;
        public int impactSoundID9;
        public int impactSoundID10;
        public int critImpactSoundID1;
        public int critImpactSoundID2;
        public int critImpactSoundID3;
        public int critImpactSoundID4;
        public int critImpactSoundID5;
        public int critImpactSoundID6;
        public int critImpactSoundID7;
        public int critImpactSoundID8;
        public int critImpactSoundID9;
        public int critImpactSoundID10;
    }

    [DbFileInfo(18179, "WeaponSwingSounds2.dbc")]
    public sealed class WeaponSwingSounds2Entry
    {
        public int ID;
        public int SwingType;
        public int Crit;
        public int SoundID;
    }

    [DbFileInfo(18179, "World_PVP_Area.dbc")]
    public sealed class WorldPVPAreaEntry
    {
        public int ID;
        public int area_ID;
        public int next_time_worldstate;
        public int game_time_worldstate;
        public int battle_populate_time;
        public int min_level;
        public int max_level;
    }

    [DbFileInfo(18179, "WorldChunkSounds.dbc")]
    public sealed class WorldChunkSoundsEntry
    {
        public int MapID;
        public int ChunkX;
        public int ChunkY;
        public int SubchunkX;
        public int SubchunkY;
        public int SoundOverrideID;
    }

    [DbFileInfo(18179, "WorldEffect.dbc")]
    public sealed class WorldEffectEntry
    {
        public int ID;
        public int targetType;
        public int targetAsset;
        public int questFeedbackEffectID;
        public int playerConditionID;
        public int combatConditionID;
        public int whenToDisplay;
    }

    [DbFileInfo(18179, "WorldElapsedTimer.dbc")]
    public sealed class WorldElapsedTimerEntry
    {
        public int ID;
        public string name_lang;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int type;
    }

    [DbFileInfo(18179, "WorldMapArea.dbc")]
    public sealed class WorldMapAreaEntry
    {
        public int ID;
        public int mapID;
        public int areaID;
        public string areaName;
        public float locLeft;
        public float locRight;
        public float locTop;
        public float locBottom;
        public int displayMapID;
        public int defaultDungeonFloor;
        public int parentWorldMapID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int levelRangeMin;
        public int levelRangeMax;
    }

    [DbFileInfo(18179, "WorldMapContinent.dbc")]
    public sealed class WorldMapContinentEntry
    {
        public int ID;
        public int mapID;
        public int leftBoundary;
        public int rightBoundary;
        public int topBoundary;
        public int bottomBoundary;
        public float continentOffset1;
        public float continentOffset2;
        public float scale;
        public float taxiMin1;
        public float taxiMin2;
        public float taxiMax1;
        public float taxiMax2;
        public int worldMapID;
    }

    [DbFileInfo(18179, "WorldMapOverlay.dbc")]
    public sealed class WorldMapOverlayEntry
    {
        public int ID;
        public int mapAreaID;
        public int areaID1;
        public int areaID2;
        public int areaID3;
        public int areaID4;
        public string textureName;
        public int textureWidth;
        public int textureHeight;
        public int offsetX;
        public int offsetY;
        public int hitRectTop;
        public int hitRectLeft;
        public int hitRectBottom;
        public int hitRectRight;
        public int playerConditionID;
    }

    [DbFileInfo(18179, "WorldMapTransforms.dbc")]
    public sealed class WorldMapTransformsEntry
    {
        public int ID;
        public int mapID;
        public float regionMin1;
        public float regionMin2;
        public float regionMin3;
        public float regionMax1;
        public float regionMax2;
        public float regionMax3;
        public int newMapID;
        public float regionOffset1;
        public float regionOffset2;
        public int newDungeonMapID;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int newAreaID;
        public float regionScale;
    }

    [DbFileInfo(18179, "WorldSafeLocs.dbc")]
    public sealed class WorldSafeLocsEntry
    {
        public int ID;
        public int continent;
        public float loc1;
        public float loc2;
        public float loc3;
        public float facing;
        public string areaName_lang;
    }

    [DbFileInfo(18179, "WorldStateExpression.dbc")]
    public sealed class WorldStateExpressionEntry
    {
        public int ID;
        public string expression;
    }

    [DbFileInfo(18179, "WorldState.dbc")]
    public sealed class WorldStateEntry
    {
        public int ID;
    }

    [DbFileInfo(18179, "WorldStateUI.dbc")]
    public sealed class WorldStateUIEntry
    {
        public int ID;
        public int mapID;
        public int areaID;
        public int phaseUseFlags;
        public int phaseID;
        public int phaseGroupID;
        public string icon;
        public string string_lang;
        public string tooltip_lang;
        public int stateVariable;
        public int type;
        public string dynamicIcon;
        public string dynamicTooltip_lang;
        public string extendedUI;
        public int extendedUIStateVariable1;
        public int extendedUIStateVariable2;
        public int extendedUIStateVariable3;
    }

    [DbFileInfo(18179, "WorldStateZoneSounds.dbc")]
    public sealed class WorldStateZoneSoundsEntry
    {
        public int WorldStateID;
        public int WorldStateValue;
        public int AreaID;
        public int WMOAreaID;
        public int ZoneIntroMusicID;
        public int ZoneMusicID;
        public int SoundAmbienceID;
        public int SoundProviderPreferencesID;
    }

    [DbFileInfo(18179, "ZoneIntroMusicTable.dbc")]
    public sealed class ZoneIntroMusicTableEntry
    {
        public int ID;
        public string Name;
        public int SoundID;
        public int Priority;
        public int MinDelayMinutes;
    }

    [DbFileInfo(18179, "ZoneMusic.dbc")]
    public sealed class ZoneMusicEntry
    {
        public int ID;
        public string SetName;
        public int SilenceIntervalMin1;
        public int SilenceIntervalMin2;
        public int SilenceIntervalMax1;
        public int SilenceIntervalMax2;
        public int Sounds1;
        public int Sounds2;
    }

    [DbFileInfo(18179, "AnimationData.dbc")]
    public sealed class AnimationDataEntry
    {
        public int ID;
        public string Name;
        public int Flags;
        public int Fallback;
        public int BehaviorID;
        public int BehaviorTier;
    }

    [DbFileInfo(18179, "AreaTable.dbc")]
    public sealed class AreaTableEntry
    {
        public int ID;
        public int ContinentID;
        public int ParentAreaID;
        public int AreaBit;
        public int flags1;
        public int flags2;
        public int SoundProviderPref;
        public int SoundProviderPrefUnderwater;
        public int AmbienceID;
        public int ZoneMusic;
        public string ZoneName;
        public int IntroSound;
        public int ExplorationLevel;
        public string AreaName_lang;
        public int factionGroupMask;
        public int liquidTypeID1;
        public int liquidTypeID2;
        public int liquidTypeID3;
        public int liquidTypeID4;
        public float minElevation;
        public float ambient_multiplier;
        public int lightid;
        public int mountFlags;
        public int uwIntroSound;
        public int uwZoneMusic;
        public int uwAmbience;
        public int world_pvp_id;
        public int pvpCombatWorldStateID;
        public int wildBattlePetLevelMin;
        public int wildBattlePetLevelMax;
        public int windSettingsID;
    }

    [DbFileInfo(18179, "FileData.dbc")]
    public sealed class FileDataEntry
    {
        public int ID;
        public string filename;
        public string filepath;
    }

    [DbFileInfo(18179, "FootprintTextures.dbc")]
    public sealed class FootprintTexturesEntry
    {
        public int ID;
        public string FootstepFilename;
    }

    [DbFileInfo(18179, "GroundEffectDoodad.dbc")]
    public sealed class GroundEffectDoodadEntry
    {
        public int ID;
        public string doodadpath;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public float animscale;
        public float pushscale;
    }

    [DbFileInfo(18179, "LightData.dbc")]
    public sealed class LightDataEntry
    {
        public int ID;
        public int lightParamID;
        public int time;
        public int directColor;
        public int ambientColor;
        public int skyTopColor;
        public int skyMiddleColor;
        public int skyBand1Color;
        public int skyBand2Color;
        public int skySmogColor;
        public int skyFogColor;
        public int sunColor;
        public int cloudSunColor;
        public int cloudEmissiveColor;
        public int cloudLayer1AmbientColor;
        public int cloudLayer2AmbientColor;
        public int oceanCloseColor;
        public int oceanFarColor;
        public int riverCloseColor;
        public int riverFarColor;
        public int shadowOpacity;
        public float fogEnd;
        public float fogScaler;
        public float cloudDensity;
        public float fogDensity;
    }

    [DbFileInfo(18179, "LightParams.dbc")]
    public sealed class LightParamsEntry
    {
        public int ID;
        public int highlightSky;
        public int lightSkyboxID;
        public int cloudTypeID;
        public float glow;
        public float waterShallowAlpha;
        public float waterDeepAlpha;
        public float oceanShallowAlpha;
        public float oceanDeepAlpha;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "Light.dbc")]
    public sealed class LightEntry
    {
        public int ID;
        public int continentID;
        public float x;
        public float y;
        public float z;
        public float falloffStart;
        public float falloffEnd;
        public int lightParamsID1;
        public int lightParamsID2;
        public int lightParamsID3;
        public int lightParamsID4;
        public int lightParamsID5;
        public int lightParamsID6;
        public int lightParamsID7;
        public int lightParamsID8;
    }

    [DbFileInfo(18179, "LightSkybox.dbc")]
    public sealed class LightSkyboxEntry
    {
        public int ID;
        public string name;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "LiquidMaterial.dbc")]
    public sealed class LiquidMaterialEntry
    {
        public int ID;
        public int LVF;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
    }

    [DbFileInfo(18179, "LiquidObject.dbc")]
    public sealed class LiquidObjectEntry
    {
        public int ID;
        public float flowDirection;
        public float flowSpeed;
        public int liquidTypeID;
        public int fishable;
        public int reflection;
    }

    [DbFileInfo(18179, "LiquidType.dbc")]
    public sealed class LiquidTypeEntry
    {
        public int ID;
        public string name;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int soundBank;
        public int soundID;
        public int spellID;
        public float maxDarkenDepth;
        public float fogDarkenIntensity;
        public float ambDarkenIntensity;
        public float dirDarkenIntensity;
        public int lightID;
        public float particleScale;
        public int particleMovement;
        public int particleTexSlots;
        public int materialID;
        public string texture1;
        public string texture2;
        public string texture3;
        public string texture4;
        public string texture5;
        public string texture6;
        public int color1;
        public int color2;
        public float float1;
        public float float2;
        public float float3;
        public float float4;
        public float float5;
        public float float6;
        public float float7;
        public float float8;
        public float float9;
        public float float10;
        public float float11;
        public float float12;
        public float float13;
        public float float14;
        public float float15;
        public float float16;
        public float float17;
        public float float18;
        public int int1;
        public int int2;
        public int int3;
        public int int4;
    }

    [DbFileInfo(18179, "Map.dbc")]
    public sealed class MapEntry
    {
        public int ID;
        public string Directory;
        public int InstanceType;
        public int Flags;
        public int MapType;
        public string MapName_lang;
        public int areaTableID;
        public string MapDescription0_lang;
        public string MapDescription1_lang;
        public int LoadingScreenID;
        public float minimapIconScale;
        public int corpseMapID;
        public float corpse1;
        public float corpse2;
        public int timeOfDayOverride;
        public int expansionID;
        public int raidOffset;
        public int maxPlayers;
        public int parentMapID;
        public int cosmeticParentMapID;
        public int timeOffset;
    }

    [DbFileInfo(18179, "SoundBusName.dbc")]
    public sealed class SoundBusNameEntry
    {
        public int EnumID;
        public string Name;
    }

    [DbFileInfo(18179, "SoundBus.dbc")]
    public sealed class SoundBusEntry
    {
        public int ID;
        public int Parent;
        public int DefaultPriority;
        public int DefaultPriorityPenalty;
        public int RaidPriority;
        public int RaidPriorityPenalty;
        public float DefaultVolume;
        public float RaidVolume;
        public int DefaultPlaybackLimit;
        public int RaidPlaybackLimit;
        public int BusEnumID;
    }

    [DbFileInfo(18179, "SoundEmitterPillPoints.dbc")]
    public sealed class SoundEmitterPillPointsEntry
    {
        public int ID;
        public int soundEmittersID;
        public float position1;
        public float position2;
        public float position3;
    }

    [DbFileInfo(18179, "SoundEmitters.dbc")]
    public sealed class SoundEmittersEntry
    {
        public int ID;
        public float position1;
        public float position2;
        public float position3;
        public float direction1;
        public float direction2;
        public float direction3;
        public int soundEntriesID;
        public int mapID;
        public string name;
        public int emitterType;
        public int PhaseID;
        public int PhaseGroupID;
        public int PhaseUseFlags;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int worldStateExpressionID;
    }

    [DbFileInfo(18179, "SoundEntriesAdvanced.dbc")]
    public sealed class SoundEntriesAdvancedEntry
    {
        public int ID;
        public int soundEntryID;
        public float innerRadius2D;
        public int timeA;
        public int timeB;
        public int timeC;
        public int timeD;
        public int randomOffsetRange;
        public int usage;
        public int timeIntervalMin;
        public int timeIntervalMax;
        public int volumeSliderCategory;
        public float duckToSFX;
        public float duckToMusic;
        public float duckToAmbience;
        public float innerRadiusOfInfluence;
        public float outerRadiusOfInfluence;
        public int timeToDuck;
        public int timeToUnduck;
        public float insideAngle;
        public float outsideAngle;
        public float outsideVolume;
        public float outerRadius2D;
        public int minRandomPosOffset;
        public int maxRandomPosOffset;
        public float duckToDialog;
        public float duckToSuppressors;
        public int msOffset;
        public float volume1;
        public float volume2;
        public float volume3;
        public float volume4;
        public float volume5;
        public float volume6;
        public float volume7;
        public float volume8;
        public float volume9;
        public float volume10;
        public float volume11;
        public float volume12;
        public float volume13;
        public float volume14;
        public float volume15;
        public float volume16;
        public float volume17;
        public float volume18;
        public float volume19;
        public float volume20;
    }

    [DbFileInfo(18179, "SoundEntriesFallbacks.dbc")]
    public sealed class SoundEntriesFallbacksEntry
    {
        public int ID;
        public int soundEntriesID;
        public int fallbackSoundEntriesID;
    }

    [DbFileInfo(18179, "SoundEntries.dbc")]
    public sealed class SoundEntriesEntry
    {
        public int ID;
        public int soundType;
        public string name;
        public int FileDataID1;
        public int FileDataID2;
        public int FileDataID3;
        public int FileDataID4;
        public int FileDataID5;
        public int FileDataID6;
        public int FileDataID7;
        public int FileDataID8;
        public int FileDataID9;
        public int FileDataID10;
        public int FileDataID11;
        public int FileDataID12;
        public int FileDataID13;
        public int FileDataID14;
        public int FileDataID15;
        public int FileDataID16;
        public int FileDataID17;
        public int FileDataID18;
        public int FileDataID19;
        public int FileDataID20;
        public int Freq1;
        public int Freq2;
        public int Freq3;
        public int Freq4;
        public int Freq5;
        public int Freq6;
        public int Freq7;
        public int Freq8;
        public int Freq9;
        public int Freq10;
        public int Freq11;
        public int Freq12;
        public int Freq13;
        public int Freq14;
        public int Freq15;
        public int Freq16;
        public int Freq17;
        public int Freq18;
        public int Freq19;
        public int Freq20;
        public float volumeFloat;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public float minDistance;
        public float distanceCutoff;
        public int EAXDef;
        public int soundEntriesAdvancedID;
        public float volumevariationplus;
        public float volumevariationminus;
        public float pitchvariationplus;
        public float pitchvariationminus;
        public float pitchAdjust;
        public int dialogtype;
        public int busOverwriteID;
    }

    [DbFileInfo(18179, "SpellChainEffects.dbc")]
    public sealed class SpellChainEffectsEntry
    {
        public int ID;
        public float AvgSegLen;
        public float Width;
        public float NoiseScale;
        public float TexCoordScale;
        public int SegDuration;
        public int SegDelay;
        public int Flags;
        public int JointCount;
        public float JointOffsetRadius;
        public int JointsPerMinorJoint;
        public int MinorJointsPerMajorJoint;
        public float MinorJointScale;
        public float MajorJointScale;
        public float JointMoveSpeed;
        public float JointSmoothness;
        public float MinDurationBetweenJointJumps;
        public float MaxDurationBetweenJointJumps;
        public float WaveHeight;
        public float WaveFreq;
        public float WaveSpeed;
        public float MinWaveAngle;
        public float MaxWaveAngle;
        public float MinWaveSpin;
        public float MaxWaveSpin;
        public float ArcHeight;
        public float MinArcAngle;
        public float MaxArcAngle;
        public float MinArcSpin;
        public float MaxArcSpin;
        public float DelayBetweenEffects;
        public float MinFlickerOnDuration;
        public float MaxFlickerOnDuration;
        public float MinFlickerOffDuration;
        public float MaxFlickerOffDuration;
        public float PulseSpeed;
        public float PulseOnLength;
        public float PulseFadeLength;
        public int Alpha;
        public int Red;
        public int Green;
        public int Blue;
        public int BlendMode;
        public int RenderLayer;
        public float TextureLength;
        public float WavePhase;
        public int SpellChainEffectID1;
        public int SpellChainEffectID2;
        public int SpellChainEffectID3;
        public int SpellChainEffectID4;
        public int SpellChainEffectID5;
        public int SpellChainEffectID6;
        public int SpellChainEffectID7;
        public int SpellChainEffectID8;
        public int SpellChainEffectID9;
        public int SpellChainEffectID10;
        public int SpellChainEffectID11;
        public string Texture;
    }

    [DbFileInfo(18179, "Startup_Strings.dbc")]
    public sealed class StartupStringsEntry
    {
        public int ID;
        public string name;
        public string message_lang;
    }

    [DbFileInfo(18179, "TerrainMaterial.dbc")]
    public sealed class TerrainMaterialEntry
    {
        public int ID;
        public string name;
        public int shader;
        public string envMapPath;
    }

    [DbFileInfo(18179, "TerrainType.dbc")]
    public sealed class TerrainTypeEntry
    {
        public int TerrainID;
        public string TerrainDesc;
        public int FootstepSprayRun;
        public int FootstepSprayWalk;
        public int SoundID;
        public int Flags;
    }

    [DbFileInfo(18179, "VideoHardware.dbc")]
    public sealed class VideoHardwareEntry
    {
        public int ID;
        public int vendorID;
        public int deviceID;
        public int farclipIdx;
        public int terrainLODDistIdx;
        public int terrainShadowLOD;
        public int detailDoodadDensityIdx;
        public int detailDoodadAlpha;
        public int animatingDoodadIdx;
        public int trilinear;
        public int numLights;
        public int specularity;
        public int waterLODIdx;
        public int particleDensityIdx;
        public int unitDrawDistIdx;
        public int smallCullDistIdx;
        public int resolutionIdx;
        public int baseMipLevel;
        public string oglOverrides;
        public string d3dOverrides;
        public int fixLag;
        public int multisample;
        public int atlasdisable;
    }

    [DbFileInfo(18179, "Weather.dbc")]
    public sealed class WeatherEntry
    {
        public int ID;
        public int ambienceID;
        public int type;
        public int effectType;
        public float intensity1;
        public float intensity2;
        public float transitionSkyBox;
        public float effectColor1;
        public float effectColor2;
        public float effectColor3;
        public string effectTexture;
        public int soundAmbienceID;
        public int windSettingsID;
    }

    [DbFileInfo(18179, "WMOAreaTable.dbc")]
    public sealed class WMOAreaTableEntry
    {
        public int ID;
        public int WMOID;
        public int NameSetID;
        public int WMOGroupID;
        public int SoundProviderPref;
        public int SoundProviderPrefUnderwater;
        public int AmbienceID;
        public int ZoneMusic;
        public int IntroSound;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Flags;
        public int AreaTableID;
        public string AreaName_lang;
        public int uwIntroSound;
        public int uwZoneMusic;
        public int uwAmbience;
    }

    [DbFileInfo(18179, "ZoneLightPoint.dbc")]
    public sealed class ZoneLightPointEntry
    {
        public int ID;
        public int zoneLightID;
        public float pos1;
        public float pos2;
        public int pointOrder;
    }

    [DbFileInfo(18179, "ZoneLight.dbc")]
    public sealed class ZoneLightEntry
    {
        public int ID;
        public string name;
        public int mapID;
        public int lightID;
    }
}

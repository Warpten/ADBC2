using System;
using DBFilesClient.NET;
using BrightIdeasSoftware;

namespace ADBC2.Structures.Version15595
{
    [DbFileInfo(15595, "Spell.dbc")]
    public sealed class SpellEntry
    {
        public uint Id;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint Attributes;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint AttributesEx;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint AttributesEx2;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint AttributesEx3;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint AttributesEx4;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint AttributesEx5;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint AttributesEx6;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint AttributesEx7;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint AttributesEx8;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint AttributesEx9;
        [OLVColumn(AspectToStringFormat = "0x{0:X8}")]
        public uint AttributesEx10;
        public uint CastingTimeIndex;
        public uint DurationIndex;
        public uint PowerType;
        public uint RangeIndex;
        public float Speed;
        public uint SpellVisual_0;
        public uint SpellVisual_1;
        public uint SpellIconID;
        public uint ActiveIconID;
        public string SpellName;
        public string Rank;
        public string Description;
        public string ToolTip;
        public uint SchoolMask;
        public uint RuneCostID;
        public uint SpellMissileID;
        public uint SpellDescriptionVariableID;
        public uint SpellDifficultyId;
        public float Unknown3; // AP coefficient ? filter with 0.04
        public uint SpellScalingId;
        public uint SpellAuraOptionsId;
        public uint SpellAuraRestrictionsId;
        public uint SpellCastingRequirementsId;
        public uint SpellCategoriesId;
        public uint SpellClassOptionsId;
        public uint SpellCooldownsId;
        public uint Unknown4; // Always zero
        public uint SpellEquippedItemsId;
        public uint SpellInterruptsId;
        public uint SpellLevelsId;
        public uint SpellPowerId;
        public uint SpellReagentsId;
        public uint SpellShapeshiftId;
        public uint SpellTargetRestrictionsId;
        public uint SpellTotemsId;
        public uint ResearchProject;
    }
}

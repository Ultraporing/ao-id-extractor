using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ao_id_extractor.obfClasses
{
    public enum ItemContainerErrorCode
    {
        Ok,
        OkWithRest,
        NoFreeSlot,
        StackInSlotIsAlreadyFull,
        MaxStackInSlotIsToSmall,
        WeightLimitExceeded,
        ItemTypeRestrictionNotMet,
        ItemIsLocked,
        ItemIsNotLocked,
        NotEnoughFreeSlots,
        ReplaceFallbackNoFreeSlot,
        ItemNotUnlockedToEquip,
        ItemAccessLevelRequirementNotMet,
        BlockedByTwoHanded,
        LockedInCombat,
        RemoveItemNotAlowed,
        PutItemNotAllowed,
        PutNotPossibleInReadOnly,
        SwapNotPossible,
        InvalidSpell,
        SpellNotAvaliableForSlot,
        SpellNotUnlocked,
        SpellSelectionOnlyOnSingleItems,
        MergeItemGroupMismatch,
        MergeEnchantmentLevelMismatch,
        MergeDurabilityMisMatch,
        MergeQualityLevelMismatch,
        MergeFameMismatch,
        MergeFameOnlyFullOrEmpty,
        InvalidItem,
        InvalidSlot,
        InternalError
    }
}
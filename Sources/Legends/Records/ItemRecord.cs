﻿using Legends.Core.Attributes;
using Legends.Core.IO.Inibin;
using SmartORM;
using SmartORM.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legends.Records
{
    [Table("/Database/Items/")]
    public class ItemRecord : ITable
    {
        [JsonCache]
        private static List<ItemRecord> Items = new List<ItemRecord>();

        [JsonFileName]
        [InibinFieldFileName]
        public int ItemId
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_Price)]
        public float Price
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_Description)]
        public string Description
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_FlatArmorMod)]
        public float FlatArmorMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_FlatAttackSpeedMod)]
        public float FlatAttackSpeedMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_FlatCritChanceMod)]
        public float FlatCritChanceMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_FlatCritDamageMod)]
        public float FlatCritDamageMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_FlatDodgeMod)]
        public float FlatDodgeMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_FlatEnergyPoolMod)]
        public float FlatEnergyPoolMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_FlatEnergyRegenMod)]
        public float FlatEnergyRegenMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_FlatHPPoolMod)]
        public float FlatHpPoolMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_FlatHPRegenMod)]
        public float FlatHpRegenMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_FlatMPPoolMod)]
        public float FlatMpPoolMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_FlatMPRegenMod)]
        public float FlatMpRegenMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_FlatMagicDamageMod)]
        public float FlatAbilityPowerMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_FlatMovementSpeedMod)]
        public float FlatMovementSpeedMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_FlatPhysicalDamageMod)]
        public float FlatPhysicalDamageMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_FlatSpellBlockMod)]
        public float FlatMagicResistMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_InStore)]
        public string InStore
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_IsRecipe)]
        public string IsRecipe
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_ItemClass)]
        public string ItemClass
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_ItemType)]
        public string ItemType
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_MaxStack)]
        public float MaxStack
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_PercentArmorMod)]
        public float PercentArmorMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_PercentAttackSpeedMod)]
        public float PercentAttackSpeedMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_PercentCritChanceMod)]
        public float PercentCritChanceMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_PercentCritDamageMod)]
        public float PercentCritDamageMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_PercentEXPBonus)]
        public float PercentExpBonus
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_PercentHPPoolMod)]
        public float PercentHpPoolMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_PercentHPRegenMod)]
        public float PercentHpRegenMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_PercentLifeStealMod)]
        public float PercentLifeStealMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_PercentMPRegenMod)]
        public float PercentMpRegenMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_PercentMagicDamageMod)]
        public float PercentAbilityPowerMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_rPercentMagicPenetrationMod)]
        public float PercentMagicPenetrationMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_PercentMovementSpeedMod)]
        public float PercentMovementSpeedMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_PercentPhysicalDamageMod)]
        public float PercentPhysicalDamageMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_PercentSpellBlockMod)]
        public float PercentMagicResistMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_PercentSpellVampMod)]
        public float PercentSpellVampMod
        {
            get;
            set;
        }
        [InibinField(InibinHashEnum.ITEMS_RecipeItem1)]
        public int RecipeItem1
        {
            get;
            set;
        }
        /*
        ITEMS_RecipeItem2 = 973644273,
        ITEMS_RecipeItem3 = 973644274,
        ITEMS_RecipeItem4 = 973644275,
        ITEMS_SellBackModifier = 3760373072,
        ITEMS_SpellName = 4262394835,
        ITEMS_UsableInStore = 883270180,
        ITEMS_UseWhenAcquired = 3803087215,
        ITEMS_flatBlockMod = 3562272462,
        ITEMS_flatEXPBonus = 1416335451,
        ITEMS_imagePath = 2414666880,
        ITEMS_percentBlockMod = 4121104762,
        ITEMS_percentDodgeMod = 3269962320,
        ITEMS_PercentMPPoolMod = 3816180446,
        ITEMS_rFlatArmorModPerLevel = 2237961173,
        ITEMS_rFlatArmorPenetrationMod = 1666342795,
        ITEMS_rFlatArmorPenetrationModPerLevel = 1604870802,
        ITEMS_rFlatCritChanceModPerLevel = 600405488,
        ITEMS_rFlatCritDamageModPerLevel = 3195832213,
        ITEMS_rFlatDodgeMod = 250160022,
        ITEMS_rFlatDodgeModPerLevel = 651317405,
        ITEMS_rFlatEnergyModPerLevel = 1919127670,
        ITEMS_rFlatEnergyRegenModPerLevel = 2827316447,
        ITEMS_rFlatGoldPer10Mod = 3596459249,
        ITEMS_rFlatHPModPerLevel = 2503536726,
        ITEMS_rFlatHPRegenModPerLevel = 3470517503,
        ITEMS_rFlatMPModPerLevel = 2481029467,
        ITEMS_rFlatMPRegenModPerLevel = 3022420538,
        ITEMS_rFlatMagicDamageModPerLevel = 2904354520,
        ITEMS_rFlatMagicPenetrationMod = 1105291097,
        ITEMS_rFlatMagicPenetrationModPerLevel = 4078980704,
        ITEMS_rFlatMovementSpeedModPerLevel = 4241001276,
        ITEMS_rFlatPhysicalDamageModPerLevel = 3408390072,
        ITEMS_rFlatSpellBlockModPerLevel = 1201590105,
        ITEMS_rFlatTimeDeadMod = 2152238374,
        ITEMS_rFlatTimeDeadModPerLevel = 1738185261,
        ITEMS_rPercentArmorPenetrationMod = 1489771843,
        ITEMS_rPercentArmorPenetrationModPerLevel = 3739791434,
        ITEMS_rPercentAttackSpeedModPerLevel = 1289862173,
        ITEMS_rPercentCooldownMod = 331225348,
        ITEMS_rPercentCooldownModPerLevel = 3683445259,
        ITEMS_rPercentMagicPenetrationMod = 928720145,
        ITEMS_rPercentMagicPenetrationModPerLevel = 1918934040,
        ITEMS_rPercentMovementSpeedModPerLevel = 4064342916,
        ITEMS_rPercentTimeDeadMod = 450607838,
        ITEMS_rPercentTimeDeadModPerLevel = 1561614309,
        ITEMS_PlatformEnabled = 3086385998,
        ITEMS_UseEffect = 3899547640,
        ITEMS_AvatarUniqueEffect = 539696123,
        ITEMS_Item5 = 1652767517,
        ITEMS_Item6 = 1652767518,
        ITEMS_Item7 = 1652767519,
        ITEMS_Item8 = 1652767520,
        ITEMS_Item9 = 1652767521,
        ITEMS_Item10 = 2036632407,
        ITEMS_Item11 = 2036632408,
        ITEMS_Item12 = 2036632409,
        ITEMS_CriticalStrike = 4138078719,
        ITEMS_Consumable = 3723078833,
        ITEMS_CooldownReduction = 1836107546,
        ITEMS_Health = 3444378282,
        ITEMS_HealthRegen = 4123527635,
        ITEMS_Mana = 577028501,
        ITEMS_ManaRegen = 2236684456,
        ITEMS_SpellDamage = 771952745,
        
    */
        public ItemRecord()
        {

        }

        public static ItemRecord GetItemRecord(int id)
        {
            return Items.FirstOrDefault(x => x.ItemId == id);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGamewithpatternsandso.Items.Armours
{
    class SteelArmour : ItemBase
    {
        public SteelArmour(ItemSlot slot = ItemSlot.ARMOUR,string name = "SteelArmour", ItemRarity rarity = ItemRarity.COMMON, 
            int price = 100, int attackBonus = 0, int armourBonus = 3, int healthBonus = 10) 
            : base(slot,name, rarity, price, attackBonus, armourBonus, healthBonus)
        {
        }
    }
}

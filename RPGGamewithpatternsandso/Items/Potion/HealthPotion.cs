using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGamewithpatternsandso.Items.Potion
{
    class HealthPotion : ItemBase
    {
        public HealthPotion(Items.ItemSlot slot = ItemSlot.POTION ,string name = "HealthPotion", ItemRarity rarity = ItemRarity.COMMON, 
            int price = 5, int attackBonus = 0, int armourBonus = 0, int healthBonus = 50) 
            : base(slot,name, rarity, price, attackBonus, armourBonus, healthBonus)
        {
        }
    }
}

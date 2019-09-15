using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGamewithpatternsandso.Items.Weapons
{
    class SimpleBow : ItemBase
    {
        public SimpleBow(Items.ItemSlot slot = ItemSlot.WEAPON, string name = "SimpleBow", ItemRarity rarity = ItemRarity.COMMON, int price = 5, int attackBonus = 3, 
            int armourBonus = 0, int healthBonus = 0) : base(slot,name, rarity, price, attackBonus, armourBonus, healthBonus)
        {
        }
    }
}

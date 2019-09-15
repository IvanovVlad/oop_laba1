using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGamewithpatternsandso.Items.Spells
{
    class Fireball : ItemBase
    {
        public Fireball(Items.ItemSlot slot = ItemSlot.SPELL, string name = "Fireball", ItemRarity rarity = ItemRarity.COMMON, 
            int price = 4, int attackBonus = 6, int armourBonus = 0, int healthBonus = 0) 
            : base(slot, name, rarity, price, attackBonus, armourBonus, healthBonus)
        {
        }
    }
}

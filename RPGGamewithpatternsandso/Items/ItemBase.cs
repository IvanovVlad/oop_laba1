using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGamewithpatternsandso.Items
{
    public enum ItemSlot
        {
            ARMOUR,
            WEAPON,
            SPELL,
            POTION
        }

    class ItemBase
    {
        public enum ItemRarity
        {COMMON,
        RARE,
        EPIC}

        public ItemRarity Rarity;
        public ItemSlot itemSlot;
        public string Name;
        public int Price;

        public int AttackBonus;
        public int ArmourBonus;
        public int HealthBonus;

        public ItemBase(ItemSlot slot, string name = "NoName", ItemRarity rarity = ItemRarity.COMMON, int price = 0,
            int attackBonus = 0, int armourBonus = 0, int healthBonus = 0)
        {
            itemSlot = slot;
            Name = name;
            Rarity = rarity;
            Price = price;
            AttackBonus = attackBonus;
            ArmourBonus = armourBonus;
            HealthBonus = healthBonus;
        }
        public override string ToString()
        {
            return $"{Name} {Rarity}, cost {Price} gold \nstats: <{AttackBonus} attackb> <{HealthBonus} hb> <{ArmourBonus} armourb>";
        }

        public static bool operator ==(ItemBase item1, ItemBase item2)
        {
            return item1.Equals(item2);
        }

        public static bool operator !=(ItemBase item1, ItemBase item2)
        {
            return !item1.Equals(item2);
        }

        public bool Equals(ItemBase item)
        {
            if (Name == item.Name && Rarity == item.Rarity && Price == item.Price)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Price.GetHashCode();
        }
    }
}

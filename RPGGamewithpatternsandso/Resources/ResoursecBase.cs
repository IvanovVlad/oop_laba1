using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGGamewithpatternsandso.Items;

namespace RPGGamewithpatternsandso.Resources
{
    class ResourcesBase
    {
        public int gold;
        public List<Items.ItemBase> ItemList = new List<Items.ItemBase>();

        public ResourcesBase(int gold)
        {
            this.gold = gold;
            ItemList.Add(new Items.Potion.HealthPotion());
        }

        public void ShowResources()
        {
            Console.WriteLine("You have {0} gold. Items in your stash:", gold);
            foreach (Items.ItemBase item in ItemList)
            {
                Console.WriteLine("    "+item.ToString());
            }
        }
    }
}

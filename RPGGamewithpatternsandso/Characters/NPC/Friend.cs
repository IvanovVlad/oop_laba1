using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGamewithpatternsandso.Characters.NPC
{
    class Friend:BaseCharacter
    {
        public Quests.QuestBase quest;
        public Resources.ResourcesBase resources = new Resources.ResourcesBase(999);

        public Friend(ClassSpec @class = ClassSpec.WARRIOR, string name = "NoName", int healthPoint = 100, int armour = 0, 
            int attackPower = 0) : base(@class, name, healthPoint, armour, attackPower)
        {
        }

        public void GiveQuest()
        {
            Console.WriteLine(quest.ToString());
            Characters.Hero.GetInstance(ClassSpec.WARRIOR).QuestList.Add(quest);
        }

        public void TradeSell(Items.ItemBase ItemToSell)
        {
            int tmp = 0;
            Characters.Hero hero = Characters.Hero.GetInstance(Hero.ClassSpec.WARRIOR);
            foreach (Items.ItemBase item in resources.ItemList)
            {
                if (item == ItemToSell && item.Price <= hero.heroresources.gold)
                {
                    hero.heroresources.gold -= item.Price;
                    hero.heroresources.ItemList.Add(item);
                    resources.gold += item.Price;
                    resources.ItemList.Remove(item);
                    Console.WriteLine($"You have bought '{item.Name}' for {item.Price} gold. Current gold: {hero.heroresources.gold}");
                    tmp++;
                    break;
                }
                
            }
            if (tmp==0) { Console.WriteLine("Something gone wrong. Mb you are cut on money))"); }
        }
        public void TradeBuy(Items.ItemBase ItemToBuy)
        {
            Characters.Hero hero = Characters.Hero.GetInstance(Hero.ClassSpec.WARRIOR);
            foreach (Items.ItemBase item in resources.ItemList)
            {
                if (item == ItemToBuy && item.Price <= resources.gold)
                {
                    hero.heroresources.gold += item.Price;
                    resources.ItemList.Add(item);
                    resources.gold -= item.Price;
                    hero.heroresources.ItemList.Remove(item);
                    Console.WriteLine($"You have sold '{item.Name}' for {item.Price} gold. Current gold: {hero.heroresources.gold}");
                    break;
                }
                else { Console.WriteLine("Something gone wrong"); }
            }
        }
    }
}

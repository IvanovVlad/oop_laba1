using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGamewithpatternsandso.Characters
{
    //синглтон
    class Hero:BaseCharacter
    {
        public List<Quests.QuestBase> QuestList = new List<Quests.QuestBase>();
        public int Expirience;
        public int Level;
        public int maxHP;
        public Resources.ResourcesBase heroresources = new Resources.ResourcesBase(100);

        private static Hero instance;

        private Hero(ClassSpec @class, string name, int healthPoint, int armour, int attackPower) 
            : base(@class, name, healthPoint, armour, attackPower)
        {
            //attackBehaviour = new CharactersActions.AttackWithWeapon();

            maxHP = healthPoint;
            Expirience = 0;
            Level = 0;
        }

        public static Hero GetInstance(ClassSpec classSpec)
        {
            if (instance == null)
            {
                switch (classSpec)
                {
                    case ClassSpec.WARRIOR:
                        instance = new Hero(ClassSpec.WARRIOR, "HeroWarrior", 120, 0, 10);
                        break;
                    case ClassSpec.RANGER:
                        instance = new Hero(ClassSpec.RANGER, "HeroRanger", 100, 2, 5);
                        break;
                    case ClassSpec.MAGE:
                        instance = new Hero(ClassSpec.RANGER, "HeroMage", 80, 1, 2);
                        break;
                }
            }
            return instance;
        }

        public void Fight(Characters.NPC.Enemy target)
        {
            Console.WriteLine($"{Name} start fight to death with {target.Name}");
            while (target.HealthPoint > 0)
            {
                Attack(target);
                if (target.HealthPoint > 0)
                    target.Attack(this);
                if (GameOver())
                    break;
            }
            if (!GameOver())
            {
                foreach (Quests.QuestBase q in QuestList)
                {
                    if (q.questType == Quests.QuestBase.QuestType.ASSASINATION)
                        q.GiveReward();
                }
                target.Restore();
                GetExpirience(target.ExpReward);
            }
        }


        public void GetExpirience(int exp)
        {
            Expirience += exp;
            CheckLevelUp();
        }

        public void TakeWeapon()
        {
            attackBehaviour = new CharactersActions.AttackWithWeapon();
        }

        public void ShowAcceptedQuest()
        {
            foreach (Quests.QuestBase q in QuestList)
            {
                q.ToString();
            }
        }

        public void SowEquippedItems()
        {
            foreach (string key in EquipedItems.Keys)
            {
                Console.WriteLine("    In your {0} slot equipped {1}", 
                    EquipedItems[key].itemSlot,EquipedItems[key].Name);
                Console.WriteLine(EquipedItems[key].ToString());
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{@Class}, {Name}, <hp {HealthPoint}>, <armor {Armour}>, <attackpower {AttackPower}> it");
            heroresources.ShowResources();
            SowEquippedItems();
        }

        public void EquipItem(Items.ItemBase item)
        {
            int tmp = 0;
            foreach (Items.ItemBase i in heroresources.ItemList)
            {
                if (i == item)
                {
                    Console.WriteLine("you have equiped a {0} in {1} slot", i.Name, i.itemSlot);
                    attackBehaviour = new CharactersActions.AttackWithWeapon();
                    heroresources.ItemList.Remove(i);
                    tmp++;
                    break;
                }
                
            }
            if (tmp == 0) { Console.WriteLine("You dont have such an item: {0}", item.Name); }
        }

        private void CheckLevelUp()
        {
            if (Expirience >= 100)
            {
                Level = Level++;
                maxHP += 10;
                HealthPoint = maxHP;
                Console.WriteLine("You get level up. HP restored");
            }
        }

        private bool GameOver()
        {
            if (HealthPoint <= 0)
            {
                Console.WriteLine("Your Hero is dead. Game over!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

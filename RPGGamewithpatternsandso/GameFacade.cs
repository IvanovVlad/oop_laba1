using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGamewithpatternsandso
{
    class GameFacade
    {
        //типа комплексные бои прописать
        private Characters.Hero _hero;
        public Characters.NPC.EnemyOrcWarrior OrcWarrior = new Characters.NPC.EnemyOrcWarrior();
        public Characters.NPC.EnemyOrcRanger OrcRanger = new Characters.NPC.EnemyOrcRanger();
        public Characters.NPC.EnemyOrcMage OrcMage = new Characters.NPC.EnemyOrcMage();
        public Characters.NPC.FriendlyArmorer Armorer = new Characters.NPC.FriendlyArmorer();
        public Items.Armours.SteelArmour SteelArmour = new Items.Armours.SteelArmour();
        public Items.Weapons.SteelSword SteelSword = new Items.Weapons.SteelSword();

        public GameFacade(Characters.Hero hero)
        {
            Console.WriteLine($"Game is started you are <{hero.Name}>");
            _hero = hero;
        }

        public void FightEnemy(Characters.NPC.Enemy enemy)
        {
            _hero.Fight(enemy);
        }

        public void ShowHeroInfo()
        {
            _hero.ShowInfo();
        }

        public void TradeBuy(Characters.NPC.Friend Trader, Items.ItemBase item)
        {
            Trader.TradeSell(item);
        }
        public void TradeSell(Characters.NPC.Friend Trader, Items.ItemBase item)
        {
            Trader.TradeBuy(item);
        }

        public void GetQuestFromNPC(Characters.NPC.Friend friend)
        {
            friend.GiveQuest();
        }

        public void Scenario1()
        {
            Console.WriteLine("You are in the Armorer Shop");
            Armorer.TradeSell(SteelSword);
            Armorer.TradeSell(SteelArmour);
            _hero.EquipItem(SteelSword);
            _hero.EquipItem(SteelArmour);
            Console.WriteLine("--------------------");
            ShowHeroInfo();
            Console.WriteLine("--------------------");
            GetQuestFromNPC(Armorer);
            Console.WriteLine("--------------------");
            FightEnemy(OrcWarrior);
            
        }
    }
}

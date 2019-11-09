using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGamewithpatternsandso.Characters.NPC
{
    class FriendlyTrader : Friend
    {
        public FriendlyTrader(ClassSpec @class = ClassSpec.WARRIOR, string name = "Trader", int healthPoint = 100, int armour = 0, int attackPower = 0)
            : base(@class, name, healthPoint, armour, attackPower)
        {
            attackBehaviour = new CharactersActions.NoAttack();
            quest = new Quests.AssasinationQuest();

            for (int i = 0; i <= 10; i++)
            {
                resources.ItemList.Add(new Items.Armours.SteelArmour());
                resources.ItemList.Add(new Items.Weapons.SimpleBow());
                resources.ItemList.Add(new Items.Weapons.SteelSword());
            }
        }
    }
}

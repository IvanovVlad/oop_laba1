using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGamewithpatternsandso.Characters.NPC
{
    class FriendlyTrader : BaseCharacter
    {
        public FriendlyTrader(ClassSpec @class, string name, int healthPoint, int armour, int attackPower) 
            : base(@class, "GoodsTrader", healthPoint, armour, attackPower)
        {
            attackBehaviour = new CharactersActions.NoAttack();
        }
    }
}

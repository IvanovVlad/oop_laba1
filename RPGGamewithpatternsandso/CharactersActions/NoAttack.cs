using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGamewithpatternsandso.CharactersActions
{
    class NoAttack:IAttackable
    {
        public void Attack(Characters.BaseCharacter Attacker, Characters.BaseCharacter Target)
        {
            Console.WriteLine("This character can not attack");
        }
    }
}

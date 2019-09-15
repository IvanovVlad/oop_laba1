using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGamewithpatternsandso.CharactersActions
{
    interface IAttackable
    {
        void Attack(Characters.BaseCharacter Attacker,Characters.BaseCharacter Target);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGamewithpatternsandso.CharactersActions
{
    class BasicAttack:IAttackable
    {
        public void Attack(Characters.BaseCharacter Attacker, Characters.BaseCharacter Target)
        {
            Target.HealthPoint = Target.HealthPoint - (Attacker.AttackPower - Target.Armour);
            Console.WriteLine("    {1} attack {0} with basicAttack. {0} <{2} HP>"
                ,Target.Name,Attacker.Name,Target.HealthPoint);
        }
    }
}

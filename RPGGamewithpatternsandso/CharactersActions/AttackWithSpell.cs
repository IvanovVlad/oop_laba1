using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGamewithpatternsandso.CharactersActions
{
    class AttackWithSpell:IAttackable
    {
        public void Attack(Characters.BaseCharacter Attacker, Characters.BaseCharacter Target)
        {
            Target.HealthPoint = Target.HealthPoint - (Attacker.AttackPower * Attacker.EquipedItems["Spell"].AttackBonus - Target.Armour);
            Console.WriteLine("    {1} cast {0} on {3}. {0} <{2} HP>",
                Target.Name, Attacker.Name, Target.HealthPoint, Attacker.EquipedItems["Spell"].Name);
        }
    }
}

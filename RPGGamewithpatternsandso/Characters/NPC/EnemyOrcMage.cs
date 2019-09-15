using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGamewithpatternsandso.Characters.NPC
{
    class EnemyOrcMage : Enemy
    {
        public EnemyOrcMage(int expReward = 10, ClassSpec @class = ClassSpec.MAGE, string name = "OrcsmerMage", 
            int healthPoint = 25, int armour = 0, int attackPower = 2) 
            : base(expReward, @class, name, healthPoint, armour, attackPower)
        {
            EquipedItems["Spell"] = new Items.Spells.Fireball();
            attackBehaviour = new CharactersActions.AttackWithSpell();
        }
    }
}

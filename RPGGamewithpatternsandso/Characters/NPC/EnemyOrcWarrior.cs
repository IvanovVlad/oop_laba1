using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGamewithpatternsandso.Characters.NPC
{
    class EnemyOrcWarrior : Enemy
    {
        public EnemyOrcWarrior(int expReward = 99, ClassSpec @class = ClassSpec.WARRIOR, string name = "OrcsmerWarrior", 
            int healthPoint = 30, int armour = 2, int attackPower = 5) 
            : base(expReward, @class, name, healthPoint, armour, attackPower)
        {
        }
    }
}

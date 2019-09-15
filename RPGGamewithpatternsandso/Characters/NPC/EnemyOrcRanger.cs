using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGamewithpatternsandso.Characters.NPC
{
    class EnemyOrcRanger:Enemy
    {
        public EnemyOrcRanger(int expReward = 10, ClassSpec @class = ClassSpec.RANGER, string name = "OrcsmerRanger",
            int healthPoint = 20, int armour = 1, int attackPower = 3)
            : base(expReward, @class, name, healthPoint, armour, attackPower)
        {
            EquipedItems["Weapon"] = new Items.Weapons.SimpleBow();
            attackBehaviour = new CharactersActions.AttackWithWeapon();
        }
    }
}

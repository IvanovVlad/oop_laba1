using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGamewithpatternsandso.Characters.NPC
{
    class Enemy:BaseCharacter
    {
        public int ExpReward;
        protected int maxHP;

        public Enemy(int expReward, ClassSpec @class = ClassSpec.WARRIOR, string name = "NoName", int healthPoint = 100, int armour = 0, int attackPower = 0) : base(@class, name, healthPoint, armour, attackPower)
        {
            ExpReward = expReward;
            maxHP = healthPoint;
        }

        public void Restore()
        {
            HealthPoint = maxHP;
        }
    }
}

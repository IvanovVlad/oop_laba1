using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGamewithpatternsandso.Characters
{
    abstract class BaseCharacter
    {
        public enum ClassSpec
        {
            WARRIOR,
            RANGER,
            MAGE
        }
        public ClassSpec Class;

        public Dictionary<string, Items.ItemBase> EquipedItems = new Dictionary<string, Items.ItemBase>();

        public string Name;
        public int HealthPoint;
        public int Armour;
        public int AttackPower;

        protected CharactersActions.IAttackable attackBehaviour;

        public BaseCharacter(ClassSpec @class = ClassSpec.WARRIOR, string name = "NoName", 
            int healthPoint = 100, int armour = 0, int attackPower = 0)
        {
            EquipedItems.Add("Weapon", new Items.Weapons.SteelSword());
            EquipedItems.Add("Armour", new Items.Armours.SteelArmour());
            EquipedItems.Add("Spell", new Items.Spells.Fireball());
            EquipedItems.Add("Potion", new Items.Potion.HealthPotion());

            Class = @class;
            Name = name;
            HealthPoint = healthPoint;
            Armour = armour;
            AttackPower = attackPower;

            attackBehaviour = new CharactersActions.BasicAttack();
        }

        public void setAttackBehaviour(CharactersActions.IAttackable newAttackBehaviour)
        {
            attackBehaviour = newAttackBehaviour;
        }

        public void Attack(BaseCharacter baseCharacter)
        {
            attackBehaviour.Attack(this, baseCharacter);
        }

        public void Display()
        {
            Console.WriteLine("This character is <{0} {1}> with <{2} HP>, <{3} Armour>, <{4} AP>", 
                Name,Class,HealthPoint,Armour,AttackPower);
        }
    }
}

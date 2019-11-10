using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//система персонажей реализует шаблон пр-я "стратегия" -- паттерн поведения
//гг "синглтон" -- порождающий паттерн
//фасад -- структурный паттерн

namespace RPGGamewithpatternsandso
{
    class Program
    {
        static void Main(string[] args)
        {
            var Hero = Characters.Hero.GetInstance(Characters.BaseCharacter.ClassSpec.WARRIOR);

            GameFacade game = new GameFacade(Hero);

            game.Scenario1();
            game.FightEnemy(game.OrcWarrior);
            game.TradeBuy(game.Armorer, new Items.Weapons.SteelSword());
            game.ShowHeroInfo();
            Console.ReadKey();
        }
    }
}

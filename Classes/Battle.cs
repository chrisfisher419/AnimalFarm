using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Battle
    {
        public static void IsHeroDead(Hero hero)
        {
            if (hero.HP <= 0)
            {
                Console.Clear();
                Console.WriteLine("Oh dear, you are dead.");
                Console.WriteLine("Game over!");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        public static void NoMana(Hero hero)
        {
            if (hero.Mana == 0)
            {
                Console.WriteLine("Not enough mana, hero!");
                
            }
        }
        public static void Stats(Human human1, Human human2)
        {
            human1.PrintStats();
            Console.WriteLine("");
            human2.PrintStats();
            Console.WriteLine("");
        }


        public static void WithGrunt(Hero hero, Grunt grunt)
        {
            while (grunt.HP > 0 && hero.HP > 0)
            {
                Stats(grunt, hero);

                hero.YourTurn(hero.Choice(), grunt);

                if (grunt.HP > 0)
                {
                    grunt.GruntTurn(grunt.EChoice(), hero);
                    IsHeroDead(hero);
                }

            }

            Console.WriteLine("{0} was killed!", grunt.Name);
            Console.ReadLine();
            Console.Clear();
        }

        public static void WithKnight(Hero hero, Knight knight)
        {
            while (knight.HP > 0 && hero.HP > 0)
            {
                Stats(knight, hero);

                hero.YourTurn(hero.Choice(), knight);

                if (knight.HP > 0)
                {
                    knight.KnightTurn(knight.EChoice(), hero);
                    IsHeroDead(hero);
                
                }
            }

            Console.WriteLine("{0} was killed!", knight.Name);
            Console.ReadLine();
            Console.Clear();
        }

        public static void WithDragon(Hero hero, Dragon dragon)
        {
            while (dragon.HP > 0 && hero.HP > 0)
            {
                Stats(dragon, hero);

                hero.YourTurn(hero.Choice(), dragon);

                if (dragon.HP > 0)
                {
                    dragon.DragonTurn(dragon.EChoice(), hero);
                    IsHeroDead(hero);
                }
            }

            Console.WriteLine("{0} was killed !", dragon.Name);
            Console.ReadLine();
            Console.Clear();
        }
        public static void WithPig(Hero hero, DemonPig demonpig)
        {
            while (demonpig.HP > 0 && hero.HP > 0)
            {
                Stats(demonpig, hero);

                hero.YourTurn(hero.Choice(), demonpig);

                if (demonpig.HP > 0)
                {
                    demonpig.PigTurn(demonpig.EChoice(), hero);
                    IsHeroDead(hero);
                }

            }

            Console.WriteLine("{0} was killed!", demonpig.Name);
            Console.ReadLine();
            Console.Clear();
        }
    }
} 

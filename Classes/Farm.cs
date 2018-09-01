using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{ 
    class Farm 
    
    {

        static void Main(string[] args)
        {
           
            Console.WriteLine("NOTE: The reading experience is more enjoyable if you play in full screen, and change your console font size to at least 20...");
            Console.WriteLine("Right click top bar of cmd window, go to properties, fonts, update the font size");
            Console.ReadLine();

            Console.WriteLine("Hello, welcome to Animal Farm, there are four stories you can play. You can just visit the Farm, You can go on an Adventure and save the farm from Orcs & Dragons, or you can unleash your darkside and raze the Farm to the ground! Feel free to check out Survival Mode too!");
            Console.WriteLine("1. Visit The Farm (Default)"); //THE CLASS EXERCISE
            Console.WriteLine("2. Go On An Adventure!");
            Console.WriteLine("3. Destruction!");
            Console.WriteLine("4. Take On Napoleon And His Army In Survival Mode!");
            string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Visit();
                        break;
                    case "2":
                        Adventure();
                        break;
                    case "3":
                        Destruction();
                        break;
                case "4":
                    Army();
                    break;
                    default:
                    Environment.Exit(0);
                    break;


                }


        }
        static void Visit() 
        {
            Console.WriteLine("YOU CHOSE TO VISIT THE FARM");
            Console.ReadLine();

            //CONSTRUCTORS
            Pig Napoleon = new Pig("Napoleon");
            Horse Clover = new Horse("Clover");
            Dog Dog = new Dog("Dog");
            Pig Snowball = new Pig("Snowball");
            Horse Mollie = new Horse("Mollie");
            Pig Piggie = new Pig("Piggie");
            Horse Horsey = new Horse("Horsey");
            Cat Cat = new Cat("Cat");
            Chicken Dave = new Chicken("Dave");
            Pig Pig = new Pig("Pig");
            Chicken Chicken = new Chicken("Chicken");
            Sheep Sheep = new Sheep("Sheep");
            Horse Horse = new Horse("Horse");



            FarmStory.Intro();
            Console.WriteLine("<Napoleon escorts you to the farm>");
            Console.ReadLine();

            //SOME OF THE METHODS
            Dog.Talk();
            Cat.Meow();
            Horsey.Neigh();
            Horsey.Speak("Horsey");
            Piggie.Oink();
            Sheep sheep = new Sheep("Sheepie");
            sheep.Speak("Sheepie");
            sheep.Eat();
            Dave.Cluck("Dave");
            Console.ReadLine();

            FarmStory.Scene1();
            Console.ReadLine();
            string input = "";
            do   //THESE METHODS ARE FOUND IN ANIMAL.CS
            {
                Console.WriteLine("What would you like to learn about?");
                Console.WriteLine("1. The Pigs");
                Console.WriteLine("2. The Horses");
                Console.WriteLine("3. The Cat");
                Console.WriteLine("4. The Dog");
                Console.WriteLine("5. The Sheep");
                Console.WriteLine("6. The Chickens");
                Console.WriteLine("<When you are ready to move on, enter any other value>");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Piggie.GetInfo("Pigs", 4, 2, "pink");
                        break;
                    case "2":
                        Horse.GetInfo("Horses", 4, 2, "Brown");
                        break;
                    case "3":
                        Cat.GetInfo("cat", 4, 2, "black");
                        break;
                    case "4":
                        Dog.GetInfo("dog", 4, 2, "tan");
                        break;
                    case "5":
                        Dog.GetInfo("sheep", 4, 2, "white");
                        break;
                    case "6":
                        Dog.GetInfo("chickens", 2, 2, "tan");
                        break;
                    default:
                        break;

                }
            } while (input == "1" || input == "2" || input == "3" || input == "4" || input == "5" || input == "6");

            Console.ReadLine();



            
            do   //THESE METHODS ARE FOUND IN ANIMAL.CS
            {
                Console.WriteLine("Who would you like to talk to?");
                Console.WriteLine("1. Piggie");
                Console.WriteLine("2. Horsey");
                Console.WriteLine("3. The Cat");
                Console.WriteLine("4. The Dog");
                Console.WriteLine("<When you are ready to move on, enter any other value>");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Piggie.Dialogue("Piggie");
                        break;
                    case "2":
                        Horsey.Dialogue(4, 2, "Horsey");
                        break;
                    case "3":
                        Cat.Dialogue();
                            break;
                    case "4":
                        Dog.Dialogue("Dog");
                        break;
                    default:
                        break;

                }
            } while (input == "1" || input == "2" || input == "3" || input == "4");


            FarmStory.Scene2();

            FarmStory.EndScene();



        }
        static void Adventure() 
        {
            Hero You = new Hero("Hero", 50, 250, 100);


            Grunt Orc1 = new Grunt("Orc1", 20, 100, 0);
            Grunt Orc2 = new Grunt("Orc2", 20, 100, 0);

            Knight OrcKnight1 = new Knight("Orc Knight1", 40, 200, 0);
            Knight OrcKnight2 = new Knight("Orc Knight2", 40, 200, 0);

            Dragon BlueDrag = new Dragon("Blue Dragon", 50, 300, 30, 0);
            Dragon RedDrag = new Dragon("Red Dragon", 70, 400, 40, 0);
            Dragon BlackDrag = new Dragon("Black Dragon", 80, 500, 50, 0);
            Dragon Boss = new Dragon("Fenrir", 100, 5000, 100, 0);

            DemonPig Piggie = new DemonPig("Piggie", 100, 500, 0);
            DemonPig OldMajor = new DemonPig("OldMajor", 100, 600, 0);
            DemonPig Piglet = new DemonPig("Piglet", 100, 800, 0);

            Console.WriteLine("ADVENTURE MODE, +500 LIGHTSIDE POINTS");
            Console.ReadLine();

            Story.Intro();


            Story.One();
            Battle.WithGrunt(You, Orc1);
            Battle.WithGrunt(You, Orc2);



            You.LevelUp();

            Story.Two();
            Battle.WithKnight(You, OrcKnight1);
            Battle.WithKnight(You, OrcKnight2);

            You.LevelUp();
            You.LevelUp();

            Story.Three();
            Battle.WithDragon(You, BlueDrag);
            You.LevelUp();
            Battle.WithDragon(You, RedDrag);
            You.LevelUp();
            Battle.WithDragon(You, BlackDrag);

            You.LevelUp();
            You.LevelUp();
            You.LevelUp();
            You.LevelUp();
            You.LevelUp();
            You.LevelUp();
            You.LevelUp();
            You.LevelUp();
            You.LevelUp();
            You.LevelUp();

            Story.Interlude();

            Battle.WithDragon(You, Boss);

            Console.WriteLine("You defeated King Fenrir!");
            Console.ReadLine();


            Story.End();

            Story.EpisodeTwo();

            Battle.WithPig(You, Piggie);
            Battle.WithPig(You, OldMajor);
            Battle.WithPig(You, Piglet);

            Story.Cliffhanger();

            Environment.Exit(0);
        } 
        static void Destruction() 
        {

            Console.WriteLine("+500 DARKSIDE POINTS");
            Console.ReadLine();
            DestructionStory.Scene1();
        } 
        public static void Army() 
        {
            Hero You = new Hero("Hero", 50, 250, 100);

            Grunt Pig = new Grunt("Pig", 50, 250, 200);
            Grunt Pig1 = new Grunt("Pig", 60, 250, 200);
            Grunt Pig2 = new Grunt("Pig", 70, 250, 200);
            Grunt Pig3 = new Grunt("Pig", 80, 300, 200);
            Grunt Pig4 = new Grunt("Pig", 90, 300, 200);
            Grunt Pig5 = new Grunt("Pig", 50, 300, 200);
            Grunt Pig6 = new Grunt("Pig", 60, 400, 200);
            Grunt Pig7 = new Grunt("Pig", 70, 400, 200);
            Grunt Pig8 = new Grunt("Pig", 80, 400, 200);
            Grunt Pig9 = new Grunt("Pig", 90, 400, 200);
            Grunt Pig10 = new Grunt("Pig", 100, 400, 200);
            Grunt Pig11 = new Grunt("Pig", 100, 500, 200);
            Grunt Pig12 = new Grunt("Pig", 100, 600, 200);
            Grunt Pig13 = new Grunt("Pig", 100, 600, 200);
            Grunt Pig14 = new Grunt("Pig", 150, 700, 200);
            Dragon Ultima = new Dragon("Ultima", 250, 20000, 500, 500);
            Dragon Napoleon = new Dragon("Napoleon, Dragon Form", 1000, 100000, 1000, 1000);
            Dragon NapoleonX = new Dragon("Napoleon, Ascended", 3000, 300000, 3000, 3000);
            Dragon NapoleonXZ = new Dragon("Napoleon, Lord Of Time", 6000, 800000, 8000, 8000);
            Dragon NapoleonXXX = new Dragon("Napoleon, Infinite", 50000, 1000000000, 50000, 50000);


            Console.WriteLine("SURVIVAL MODE, GOOD LUCK");
            Console.ReadLine();
            Console.WriteLine("NAPOLEON: We meet once again....if you can break through my army, you get to face me. Too bad you won't get close");

           
            Battle.WithGrunt(You, Pig);
            You.LevelUp();
            Battle.WithGrunt(You, Pig1);
            You.LevelUp();
            Battle.WithGrunt(You, Pig2);
            You.LevelUp();
            Battle.WithGrunt(You, Pig3);
            You.LevelUp();
            Battle.WithGrunt(You, Pig4);
            You.LevelUp();
            Battle.WithGrunt(You, Pig5);
            You.LevelUp();
            Battle.WithGrunt(You, Pig6);
            You.LevelUp();
            You.LevelUp();
            Battle.WithGrunt(You, Pig7);
            You.LevelUp();
            You.LevelUp();
            Battle.WithGrunt(You, Pig8);
            You.LevelUp();
            You.LevelUp();
            Battle.WithGrunt(You, Pig9);
            You.LevelUp();
            You.LevelUp();
            Battle.WithGrunt(You, Pig10);
            You.LevelUp();
            You.LevelUp();
            Battle.WithGrunt(You, Pig11);
            You.LevelUp();
            You.LevelUp();
            Battle.WithGrunt(You, Pig12);
            You.LevelUp();
            You.LevelUp();
            Battle.WithGrunt(You, Pig13);
            You.LevelUp();
            You.LevelUp();
            Battle.WithGrunt(You, Pig14);
            for (int i = 0; i < 20; i++)
            {
                You.LevelUp();
            }
            Console.WriteLine("<The smoke clears the battlefield...all the orcs are gone. You think it's all clear, when a bright, golden dragon shines in the horizon...>");
            Console.ReadLine();
            Battle.WithDragon(You, Ultima);
            for (int i = 0; i < 20; i++)
            {
                You.AdvLevelUp();
            }
            Console.WriteLine("<With Ultima defeated you can now reach Napoleon.>");
            Console.WriteLine("NAPOLEON: Fool, you have only seen a glimpse of my power. Watch this!!! <Ultima's body begins to reassemble itself around Napoleon...> ");
            Console.WriteLine("NAPOLEON: WITNESS, MY TRUE FORM!");
            Console.ReadLine();
            Battle.WithDragon(You, Napoleon);
            for (int i = 0; i < 50; i++)
            {
                You.AdvLevelUp();
            }
            Console.WriteLine("NAPOLEON: This isn't even my final form!");
            Console.ReadLine();
            Battle.WithDragon(You, NapoleonX);
            for (int i = 0; i < 100; i++)
            {
                You.AdvLevelUp();
            }
            Console.WriteLine("NAPOLEON: Hahaha, no one has ever gotten me to my second form before..");
            Console.ReadLine();
            Battle.WithDragon(You, NapoleonXZ);
            for (int i = 0; i < 500; i++)
            {
                You.AdvLevelUp();
            }
            You.MasterLevelUp();
            Console.WriteLine("NAPOLEON: And this is to go...even further....beyond!!! YOU CANNOT WIN!");
            Console.ReadLine();
            Battle.WithDragon(You, NapoleonXXX);

        }  
        public static void Army2()
        {
            Hero You = new Hero("Hero", 5000, 25000, 10000);

            Grunt Pig = new Grunt("Pig", 500, 2500, 2000);
            Grunt Pig1 = new Grunt("Pig", 600, 2500, 2000);
            Grunt Pig2 = new Grunt("Pig", 700, 2500, 2000);
            Grunt Pig3 = new Grunt("Pig", 800, 3000, 2000);
            Grunt Pig4 = new Grunt("Pig", 900, 3000, 2000);
            Grunt Pig5 = new Grunt("Pig", 500, 3000, 2000);
            Grunt Pig6 = new Grunt("Pig", 600, 4000, 2000);
            Grunt Pig7 = new Grunt("Pig", 700, 4000, 2000);
            Grunt Pig8 = new Grunt("Pig", 800, 4000, 2000);
            Grunt Pig9 = new Grunt("Pig", 900, 4000, 2000);
            Grunt Pig10 = new Grunt("Pig", 1000, 4000, 2000);
            Grunt Pig11 = new Grunt("Pig", 1000, 5000, 2000);
            Grunt Pig12 = new Grunt("Pig", 1000, 6000, 2000);
            Grunt Pig13 = new Grunt("Pig", 1000, 6000, 2000);
            Grunt Pig14 = new Grunt("Pig", 1500, 7000, 2000);
            Dragon Ultima = new Dragon("Ultima", 2050, 200000, 5000, 5000);
            Dragon Napoleon = new Dragon("Napoleon, Dragon Form", 1000, 1000000, 10000, 10000);
            Dragon NapoleonX = new Dragon("Napoleon, Ascended", 30000, 3000000, 30000, 30000);
            Dragon NapoleonXZ = new Dragon("Napoleon, Lord Of Time", 60000, 8000000, 80000, 80000);
            Dragon NapoleonXXX = new Dragon("Napoleon, Infinite", 500000, 1000000000, 500000, 500000);


            Console.WriteLine("SURVIVAL MODE, GOOD LUCK");
            Console.ReadLine();
            Console.WriteLine("NAPOLEON: We meet once again....if you can break through my army, you get to face me. Too bad you won't get close");
            Console.ReadLine();

            Console.WriteLine("EASTER EGG MODE!");
            Console.ReadLine();
            for (int i = 0; i < 200; i++)
            {
                You.MasterLevelUp();
            }

            Battle.WithGrunt(You, Pig);
            Battle.WithGrunt(You, Pig1);
            Battle.WithGrunt(You, Pig2);
            Battle.WithGrunt(You, Pig3);
            Battle.WithGrunt(You, Pig4);
            Battle.WithGrunt(You, Pig5);
            Battle.WithGrunt(You, Pig6);
            Battle.WithGrunt(You, Pig7);
            Battle.WithGrunt(You, Pig8);
            Battle.WithGrunt(You, Pig9);
            Battle.WithGrunt(You, Pig10);
            Battle.WithGrunt(You, Pig11);
            Battle.WithGrunt(You, Pig12);
            Battle.WithGrunt(You, Pig13);
            Battle.WithGrunt(You, Pig14);
            Console.WriteLine("<The smoke clears the battlefield...all the orcs are gone. You think it's all clear, when a bright, golden dragon shines in the horizon...>");
            Console.ReadLine();
            Battle.WithDragon(You, Ultima);
            Console.WriteLine("<With Ultima defeated you can now reach Napoleon.>");
            Console.WriteLine("NAPOLEON: Fool, you have only seen a glimpse of my power. Watch this!!! <Ultima's body begins to reassemble itself around Napoleon...> ");
            Console.WriteLine("NAPOLEON: WITNESS, MY TRUE FORM!");
            Console.ReadLine();
            Battle.WithDragon(You, Napoleon);
            Console.WriteLine("NAPOLEON: This isn't even my final form!");
            Console.ReadLine();
            Battle.WithDragon(You, NapoleonX);
            Console.WriteLine("NAPOLEON: Hahaha, no one has ever gotten me to my second form before..");
            Console.ReadLine();
            Battle.WithDragon(You, NapoleonXZ);
            Console.WriteLine("NAPOLEON: And this is to go...even further....beyond!!! YOU CANNOT WIN!");
            Console.ReadLine();
            Battle.WithDragon(You, NapoleonXXX);
            Console.WriteLine("NAPOLEON: COMRADE. I AM THE KING OF ALL ANIMALS. I SHALL RETURN!!");
            Console.WriteLine("He vanishes...");
            Console.WriteLine("Congrats, you won the game....for now");
            Console.ReadLine();
                

        } 

    }
}

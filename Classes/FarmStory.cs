using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes 
{
    class FarmStory
    {


        public static void Intro()
        {
            Console.WriteLine("NAPOLEON: Hello, welcome to the Animal Farm! We are currently undergoing some diplomatic changes. Allow me to show you around.");
            Console.ReadLine();
            Console.WriteLine("<You will be prompted with decision choices throughout this experience, enter the corrosponding number to make the dialogue decision>");
            Console.ReadLine();
            Console.WriteLine("1. Woaaah wait a minute, you're a pig, you can talk?");
            Console.WriteLine("2. A talking pig, I've seen it all....");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("NAPOLEON: ah, where are my manners. Yes, every animal here can speak, we are a special kind, only found in the heart of the motherland, now follow me, let me take you on a tour!");
                Console.ReadLine();
                
            }
            else if (input == "2")
            {
                Console.WriteLine("NAPOLEON: You'll get used to it my friend, now come, follow me!");
                Console.ReadLine();
                
            }
            else
            {
                Console.WriteLine("INVALID INPUT, STARTING SCENE OVER");
                Console.ReadLine();
                Intro();
            }
            
        } 
        public static void Scene1()
        {
            Console.WriteLine("NAPOLEON: Here are all the animals! We have the generic horses, pigs, chickens, dogs, there's a cat around here somewhere, and some useless donkey, don't mind him");
            Console.ReadLine();
            Console.WriteLine("1. Useless donkey? Sounds like you really love your people...");
            Console.WriteLine("2. I'm very enthused Sir Napoleon, these animals are quite intriguing, may I check the rest of the farm out?");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("NAPOLEON: Are you doubting my leadership good sir? I'm warning you now, if you go against me I will rage war on your land! Now, go check out the other animals, quickly!");
                Console.ReadLine();
                
            }
            else if (input == "2")
            {
                Console.WriteLine("NAPOLEON: Yes yes, take a look around!");
                Console.ReadLine();
                
                
            }
            else
            {
                Console.WriteLine("INVALID INPUT, STARTING SCENE OVER");
                Console.ReadLine();
                Scene1();
            }

        }
        public static void Scene2()
        {
            Console.WriteLine("NAPOLEON: So comrade, do you like the farm?");
            Console.ReadLine();
            Console.WriteLine("1. Ummm, well the animals look very unhappy and one was complaining about a 20 hour work day...I think you need to let these animals relax a bit");
            Console.WriteLine("2. Comrade! I love it! This is how everything should be! You sir, are a fantastic leader, I know your farm will be successful.");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("NAPOLEON: I warned you, now you will suffer!");
                Console.ReadLine();
                Console.WriteLine("<Suddenly you are surrounded by hounds, you hear Napoleon shouting commands and the hounds charge at you. There's nothing you can do...>");
                Console.ReadLine();
                Console.WriteLine("YOU HAVE DIED");
                Console.ReadLine();
                Environment.Exit(0);

            }
            else if (input == "2")
            {
                Console.WriteLine("NAPOLEON: I'm so glad you like it...I'm very fond of you comrade, would you like to join my council?");
                Console.ReadLine();
                Console.WriteLine("1. Yes, I would very much like to.");
                Console.WriteLine("2. Umm, this is all happening so fast. Give me a week to think about it, I'm a little short on time right now, and there's a princess who needs to be saved");
                string input1 = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("NAPOLEON: Very good friend, welcome to the Farm!");
                    Console.ReadLine();
                    Console.WriteLine("<You join Napoleon on his quest for glory, over time you become more brutal, unkind. After 10 years the farm fails economically, you and the rest of the animals succumb to the cold of winter.>");
                    Console.ReadLine();
                    Console.WriteLine("Thanks for playing");
                    Console.ReadLine();
                    Environment.Exit(0);

                }
                else if (input == "2")
                {
                    Console.WriteLine("NAPOLEON: Yes my good sir. Let me escort you out. I do hope you come see us again soon.");
                    Console.ReadLine();
                    EndScene();

                }
                else
                {
                    Console.WriteLine("INVALID INPUT, STARTING SCENE OVER");
                    Console.ReadLine();
                    Scene1();
                }


            }
            else
            {
                Console.WriteLine("INVALID INPUT, STARTING SCENE OVER");
                Console.ReadLine();
                Scene2();
            }
        }
        public static void EndScene()
        {
            Chicken Beerus = new Chicken("Lord Beerus");
            Console.WriteLine("<And thus you depart the farm, there's a princess who needs to be saved after all. What will you decide on, will you join Napoleon? Will you forget about all that you saw? Maybe raze the farm to the ground?>");
            Console.ReadLine();
            Console.WriteLine("Thanks for playing, stay tuned for the prologue release![ENTER TO CONTINUE]");
            string input = Console.ReadLine();
            if (input == "chicken")
            {
                Beerus.Dialogue("Lord Beerus");
                Farm.Army2();
                Environment.Exit(0);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}

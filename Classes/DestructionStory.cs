using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class DestructionStory
    {
        public static void Scene1()
        {
            Console.WriteLine("Welcome to the darkside! After rescuing the princess, you decide that the Animal Farm is not meant to be in this world");
            Console.WriteLine("How would you like to destroy it?");
            Console.WriteLine("1. Send in an army of Orcs");
            Console.WriteLine("2. Morph into a dragon and burn it to the ground");
            Console.WriteLine("3. Just the farm? Why not the whole planet? [USE THE DEATH STAR]");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Turns out you're actually Sauron. You command your Orc army to pillage the farm. Soon Middle Earth will be yours...");
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("[SPOILERS IF YOU DIDN'T PLAY THE ADVENTURE] Remember when you killed Fenrir? Turns out you absorbed his soul and now you can turn into a dragon. Napoleon and his farm won't even stand a chance");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("You reveal your true personality, you are The Emperor. Now is time to test out your brand new Death Star. Who liked Earth anyway?");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("These directions have specific instructions! Pressing the wrong button will cost you!");
                    Console.ReadLine();
                    Console.WriteLine("You spontaneously combust, game over...");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                    

            }
        }
    }
} 

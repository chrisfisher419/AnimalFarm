using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Story
    {
        public static void Intro()
        {
            Console.WriteLine("<You are on your adventure to rescue the princess when you stop at an isolated farm>");
            Console.WriteLine("<The farm seems to have been taken over by Communist animals, holding other animals in captivity>");
            Console.WriteLine("<You make your way to the barn where you see a horse locked away in chains.>");

        }
        public static void One()
        {
            Console.WriteLine("CLOVER: Help us! They have sided with an Orc cult and are going to raze the entire farm with an army of dragons!");
            Console.WriteLine("<Before you can fully acknowledge her, two Orcs approach you>. ORC1: We are gonna eat ya!");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Two()
        {
            Console.WriteLine("YOU: What an easy fight. Here you go girl, let me free you. <You free Clover>");
            Console.WriteLine("CLOVER: Oh thank you my good sir! They slaughtered most of us already. Napoleon turned on us. He has Snowball inside the house, please rescue him!");
            Console.WriteLine("You make your way to the house, which is being guarded by two Orc Knights");
            Console.WriteLine("YOU: Move or be moved.");
            Console.WriteLine("ORC KNIGHT1: <grunts>");
            Console.ReadLine();
            Console.WriteLine("They raise their weapons at you...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Three()
        {
            Console.WriteLine("With the orc knights defeated you manuever into the house. YOU: Napoleon, where are you!!");
            Console.WriteLine("NAPOLEON: Comrade, I am the king of all animals, this is my land, you do not belong here...");
            Console.WriteLine("<You hear a rumbling in the distance, three dragons fly over head and breathe fire upon the land>");
            Console.WriteLine("NAPOLEON: Now face my dragons!");
            Console.ReadLine();
            Console.Clear();
        }
        public static void Interlude()
        {
            Console.WriteLine("NAPOLEON: You may have won this time, but I'll be back! <Napoleon vanishes>");
            Console.WriteLine("<You look around, you see a pig laying dead on the ground, it's Snowball>");
            Console.WriteLine("<You go outside> YOU: Sorry Clover, he didn't make it... <Clover whines> CLOVER: Thank you anyway, thanks for saving what's left of the farm");
            Console.WriteLine("<You bid your adieu, there's a princess to save>");
            Console.WriteLine("<You continue your way to the castle, you're almost there, when you hear a lound rumble....a large dragon flies over head....it's King Fenrir!>");
            Console.WriteLine("<Prepare yourself for battle, this will be tough!!!>");
        }

        public static void End()
        {
            Console.WriteLine("You saved the farm, stopped King Fenrir and rescued the princess!");
            Console.WriteLine("Congratulations!");
            Console.ReadLine();
        }
        public static void EpisodeTwo()
        {
            Console.WriteLine("But wait...there's more! What's going on at the farm?!");
            Console.WriteLine("<You can the Princess walk up to the farmland, something doesn't feel right");
            Console.WriteLine("YOU: I've got a bad feeling about this...");
            Console.WriteLine("<You notice there is something wrong with the animals, they're all looking at you menacingly! A group of pigs surrounds you and the princess, looks like you've got a fight on your hands");
            Console.ReadLine();
        }
        public static void Cliffhanger()
        {
            Console.WriteLine("<You wipe the blood off your face and look at the pigs, these poor animals have been possessed by demons>");
            Console.WriteLine("PRINCESS: Hero, what's happening to me?! <Her body shakes rapidly, then her eyes turn red.>");
            Console.ReadLine();
            Console.WriteLine("YOU: Are you okay? What happened? <You got no response. Instead her body stands straight up and she looks at you, but the face is longer hers..you look closer, you recognize those eyes...");
            Console.WriteLine("??????: It's been a long time, Hero.... ");
            Console.ReadLine();
            Console.WriteLine("To be continued.....");
            Console.ReadLine();
        }
    }
} 

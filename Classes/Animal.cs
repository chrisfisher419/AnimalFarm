using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes 
{
    class Animal
    {

        //NOT ALL ARE IMPLEMENTED YET
        public int Legs { get; set; }
        public int Age { get; set; }
        public int Eyes { get; set; }
        public string Color { get; set; }
        public string Eyecolor { get; set; }
        public string Name { get; set; }
        public int Food = 100;


        public Animal()
        {
            
        }
        public virtual void Talk(string name)
        {
            
            Console.WriteLine($"{Name}: I'm a talking animal!");
        }
    }


    class Dog : Animal //NOT ALL METHODS ARE USED WITHIN MAIN
    {
        public int HP = 20;

        public Dog(string name) 
        {
            

        }
        public void Bark()
        {
            Console.WriteLine("DOG: Woof!");

        }
        public void Talk()
        {
            Console.WriteLine("DOG: I'm a dog who can speak!");
        }
        public void Eat()
        {

            Food = Food - 25;
            Console.WriteLine($"After the dogs ate, the food is now at {Food} units");
        }
        public void Dialogue(string name)
        {
           
            Console.WriteLine($"{Name}: If you haven't talked to the cat yet, do so, he's right, this place is terrible! I just got off a 20 hour shift, and he still wants to feed me to the hounds!");
            Console.ReadLine();
            Console.WriteLine("YOU: I'm sorry little guy...");
            Console.ReadLine();
        }
        public void GetInfo(string name, int legs, int eyes, string color)
        {
            Name = name;
            Legs = legs;
            Eyes = eyes;
            Color = color;
            Console.WriteLine($"It's a {name}, it has {legs} legs, {eyes} eyes, and it is {color}");
            Console.ReadLine();
        }

    }



    class Cat : Animal //NOT ALL METHODS ARE USED WITHIN MAIN
    {
        
        public Cat(string name)
        {

        }
        public void Meow()
        {
            Console.WriteLine("CAT: Meow");
        }
        public void Eat()
        {

            Food = Food - 25;
            Console.WriteLine($"After the cat ate, the food is now at {Food} units");
        }
        public void Bite(Dog target)
        {
            target.HP -= 5;
            target.Legs -= 1;
        }
        public void Dialogue()
        {
            Console.WriteLine("CAT: You should probably leave while you can man, it's not safe here. If I were you I would book it ASAP..");
            Console.ReadLine();
            Console.WriteLine("YOU: Uhhhh thanks?");
            Console.ReadLine();
        }
        public void GetInfo(string name, int legs, int eyes, string color)
        {
            Name = name;
            Legs = legs;
            Eyes = eyes;
            Color = color;
            Console.WriteLine($"It's a {name}, it has {legs} legs, {eyes} eyes, and it is {color}");
            Console.ReadLine();
        }


    }




    class Horse : Animal //NOT ALL METHODS ARE USED WITHIN MAIN
    {
        public Horse(string name)
        {

        }
        public void Neigh()
        {
            Console.WriteLine("HORSE: Neiggghhh!");
        }
        public void Speak(string name)
        {
            Name = name;
        }
        public void Eat()
        {

            Food = Food - 25;
            Console.WriteLine($"After the horses ate, the food is now at {Food} units");
        }
        public void Dialogue(int legs, int age, string name)
        {

            Console.WriteLine($"{Name}: Neigghhh, my neeeeiggghhhhhh-me is {Name}, I have {Legs} Legs and I'm {Age} years old!");
            Console.ReadLine();
            Console.WriteLine("YOU: I think we ought to go for a ride later, no?");
            Console.ReadLine();
            
        }
        public void GetInfo(string name, int legs, int eyes, string color)
        {
            Name = name;
            Legs = legs;
            Eyes = eyes;
            Color = color;
            Console.WriteLine($"They are {name}, they have {legs} legs, {eyes} eyes, and they are {color}");
            Console.ReadLine();
        }
    }




    class Pig : Animal  //NOT ALL METHODS ARE USED WITHIN MAIN
    {
        public Pig(string name)
        {

        }
        public void Oink()
        {
            Console.WriteLine("PIG: Oink!");
        }
        public void Eat()
        {

            Food = Food - 25;
            Console.WriteLine($"After the pigs ate, the food is now at {Food} units");
        }
        public void Dialogue(string name)
        {
            Food = 75;
            
            Console.WriteLine($"{Name}: Hello, my name is {Name}, nice to meet you. Watch us eat!");
            Console.ReadLine();
            Eat();
            Console.WriteLine($"YOU: Pleased to meet you, {Name}. Interesting choice of food!");
            Console.ReadLine();
        }
        public void GetInfo(string name, int legs, int eyes, string color)
        {
            Name = name;
            Legs = legs;
            Eyes = eyes;
            Color = color;
            Console.WriteLine($"They are {name}, they have {legs} legs, {eyes} eyes, and they are {color}");
            Console.ReadLine();
        }

    }

    class DemonPig : Orc
        {
            public DemonPig(string name, int attack, int hp, int mana)
                : base(name, attack, hp, mana)
            {
                numOfAttack = 2;

            }



            public virtual void Bite(Hero target)
            {
                target.HP -= 50;
            }

            public void PigTurn(int choice, Hero target)
            {
                if (choice == 1)
                {
                    NormAttack(target);
                    Console.WriteLine("The pig clawed you!");

                }

                if (choice == 2)
                {
                    Bite(target);
                    Console.WriteLine("The pig bit you!");

                }

                Console.ReadLine();
                Console.Clear();
            }
        }
    




    class Sheep : Animal //NOT ALL METHODS ARE USED WITHIN MAIN
    {
        public Sheep(string name)
        {
            
        }
        public void Baa()
        {
            Console.WriteLine("Baaaaaa!");

        }
        public void Eat()
        {

            Food = Food - 25;
            Console.WriteLine($"After the sheep ate, the food is now at {Food} units");
        }
        public void Speak(String name)
        {
            
            Console.WriteLine($"{Name}: My name is {Name}");
        }
        public void GetInfo(string name, int legs, int eyes, string color)
        {
            Name = name;
            Legs = legs;
            Eyes = eyes;
            Color = color;
            Console.WriteLine($"They are {name}, they have {legs} legs, {eyes} eyes, and they are {color}");
            Console.ReadLine();
        }

    }




    class Chicken : Animal //NOT ALL METHODS ARE USED WITHIN MAIN
    {
        
        public Chicken(string name)
        {
            Name = name;
        }
        public void Eat()
        {

            Food = Food - 25;
            Console.WriteLine($"After the chickens ate, the food is now at {Food} units");
        }
        public void Cluck(string name)
        {
            Console.WriteLine($"{name}: Cluck!");
        }
        public void Dialogue(string name) //HIDDEN EASTER EGG
        {
            Console.WriteLine($"{name}: This dialogue is an easter egg, good on you if you found it! Here's a gift for you!");
            Console.ReadLine();
        }
        public void GetInfo(string name, int legs, int eyes, string color)
        {
            Name = name;
            Legs = legs;
            Eyes = eyes;
            Color = color;
            Console.WriteLine($"They are {name}, they have {legs} legs, {eyes} eyes, and they are {color}");
            Console.ReadLine();
        }

    }
}





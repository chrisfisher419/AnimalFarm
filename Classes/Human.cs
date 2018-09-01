using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Human
    {
        //NOT ALL ARE USED YET
        public bool HatesHumans { get; set; }
        public bool HatesAnimals { get; set; }
        public bool HatesOrcs { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }
        public string Religion { get; set; }
        public int HP { get; set; }
        public int Mana { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Willpower { get; set; }
        public int Charisma { get; set; }
        public int Luck { get; set; }
        public int Attack { get; set; }

        public Human(string name, int attack, int hp, int mana)
        {
            Name = name;
            Attack = attack;
            HP = hp;
            Mana = mana;

        }
        public Human(bool hateshumans)
        {
            HatesHumans = hateshumans;
        }
        public virtual void PrintStats()
        {
            Console.WriteLine($"{Name} stats:");
            Console.WriteLine($"Current attack is {Attack}, Current HP is {HP}");

        }
        public virtual void NormAttack(Human target)
        {
            target.HP -= Attack;
        }


        public virtual void Disposition(bool hateshumans)
        {
            HatesHumans = hateshumans;
            if (HatesHumans == true)
            {
                Console.WriteLine("I hate other people");
                
            }
            else
            {
                Console.WriteLine("Yeah I like people!");
            }

            
        }
            


    }
    public class Farmer : Human //NOT USED YET
    {
        public Farmer(string name, int attack, int hp, int mana) : base(name, attack, hp, mana)
        {
            
        }
        public Farmer(bool hateshumans) : base(hateshumans)
        {

        }
    }



        public class Hero : Human
    {
            public int Heal = 50, MaxHP = 250, MaxMana = 100;
            public Hero(string name, int attack, int hp, int mana) : base(name, attack, hp, mana)
            {

            }
        public virtual void LevelUp()
        {
            Console.WriteLine("You leveled up! +50 HP, +50 Mana, +10 Attack, +10 Heal");
            Attack += 10;
            MaxHP += 50;
            HP += 50;
            Mana += 10;
            MaxMana += 50;
            Heal += 10;
        }
        public virtual void AdvLevelUp()
        {
            Console.WriteLine("You leveled up! +500 HP, +500 Mana, +100 Attack, +100 Heal");
            Attack += 100;
            MaxHP += 500;
            HP += 500;
            Mana += 100;
            MaxMana += 500;
            Heal += 100;
        }
        public virtual void MasterLevelUp()
        {
            Console.WriteLine("You feel the power of the gods course through your veins! You can do this! +500000 HP, +500000 Mana, +100000 Attack, +100000 Heal");
            Attack += 100000;
            MaxHP += 500000;
            HP += 500000;
            Mana += 100000;
            MaxMana += 500000;
            Heal += 100000;
        }
        public virtual void Healing()
        {
            HP += Heal;
            if (HP > MaxHP)
            {
                HP = MaxHP;
            }

        }
        public virtual void Slash(Orc target)
        {
            target.HP -= ((Attack - 2) * 3);
        }
        public virtual void Stab(Orc target)
        {
            target.HP -= Attack * 2;
        }
        public int Choice() 
        {
            bool correctInput = true;
            int choice = 0, choice2;
            while (correctInput)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Heal");
                Console.WriteLine("3. Special");

                bool test = int.TryParse(Console.ReadLine(), out choice);
                if (!test || choice > 3 || choice <= 0)
                {
                    Console.WriteLine("Not an option! Try again!");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                if (choice == 3) 
                {
                    Console.WriteLine("Choose Special:");
                    Console.WriteLine("1. Slash(20 Mana)");
                    Console.WriteLine("2. Stab(10 Mana)");
                    Console.WriteLine("3. <--- Go back");

                    bool test2 = int.TryParse(Console.ReadLine(), out choice2);
                    if (!test2 || choice2 > 3 || choice2 <= 0)
                    {
                        Console.WriteLine("Not an option ! Try again!");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                    if (choice2 == 1)
                    {
                        choice = 4;
                    }

                    if (choice2 == 2)
                    {
                        choice = 5;
                    }
                }

                if (choice == 1 || choice == 2 || choice == 4 || choice == 5)
                {
                    break;
                }
            }
            return choice;
        }

        public void YourTurn(int decision, Orc target)
        {
            if (decision == 1)
            {
                NormAttack(target);
                Console.WriteLine("Basic attack!");
            }

            if (decision == 2)
            {
                Healing();
                Console.WriteLine($"You healed for {Heal} HP");
            }

            if (decision == 4)
            {
                Slash(target);
                Console.WriteLine("Slash!");
            }

            if (decision == 5)
            {
                Stab(target);
                Console.WriteLine("Stab!");
            }

        }
    }

} //EXTRA
        

  
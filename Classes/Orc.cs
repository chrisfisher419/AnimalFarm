using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Orc : Human
    {
        public int numOfAttack { get; set; }

        public Orc(string name, int attack, int hp, int mana)
            : base(name, attack, hp, mana)
        {
        }

        // Battle

        public int EChoice()
        {
            int eChoice;
            Random ran = new Random();
            eChoice = ran.Next(1, numOfAttack + 1);
            return eChoice;
        }
    }

    public class Grunt : Orc
    {
        public Grunt(string name, int attack, int hp, int mana)
            : base(name, attack, hp, mana)
        {
            numOfAttack = 2;
            
        }


        public virtual void Steal(Hero target)
        {
            target.HP -= Attack + 2;
        }

        public void GruntTurn(int choice, Hero target)
        {
            if (choice == 1)
            {
                NormAttack(target);
                Console.WriteLine("It whacked you!");

            }

            if (choice == 2)
            {
                Steal(target);
                Console.WriteLine("It stole from you!");

            }

            Console.ReadLine();
            Console.Clear();
        }
    }

    public class Knight : Orc
    {
        public Knight(string name, int attack, int hp, int mana)
            : base(name, attack, hp, mana)
        {
            numOfAttack = 3;
        }


        public void Slash(Hero target)
        {
            target.HP -= Attack + 5;
        }

        public void ShieldSlam(Hero target)
        {
            target.HP -= HP + 2;
        }

        public void KnightTurn(int choice, Hero target)
        {
            if (choice == 1)
            {
                NormAttack(target);
                Console.WriteLine("The orc punched you!");
            }

            if (choice == 2)
            {
                Slash(target);
                Console.WriteLine("The orc slashed you!");
            }

            if (choice == 3)
            {
                ShieldSlam(target);
                Console.WriteLine("The orc slammed you with his shield!");
            }

            Console.ReadLine();
            Console.Clear();
        }
    }

    public class Dragon : Orc
    {
        public int Armor { get; set; }

        public Dragon(string name, int attack, int hp, int armor, int mana)
            : base(name, attack, hp, mana)
        {
            numOfAttack = 4;
            Armor = armor;
        }


        public void FireBreath(Hero target)
        {
            target.HP -= Attack * 2;
        }

        public void Claw(Hero target)
        {
            target.HP -= Attack + 3;
        }

        public void Bite(Hero target)
        {
            target.HP -= Attack + 4;
        }

        public void DragonTurn(int choice, Hero target)
        {
            if (choice == 1)
            {
                NormAttack(target);
                Console.WriteLine("Dragon sneezed on you!");
            }

            if (choice == 2)
            {
                FireBreath(target);
                Console.WriteLine("Dragon used flamethrower on you!");
            }

            if (choice == 3)
            {
                Claw(target);
                Console.WriteLine("Dragon clawed you!");
            }

            if (choice == 4)
            {
                Bite(target);
                Console.WriteLine("Dragon bit you!");
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
} 
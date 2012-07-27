using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial1
{
    class Program
    {
        static void Main(string[] args)
        {
            var monster = new Character();
            monster.Health = 40000;
            monster.Damage = 400;
            monster.Name = "Monster";
            var hero = new Character();
            hero.Health = 100000;
            hero.Damage = 800;
            hero.Name = "Batman";
            var monster2 = new Character();
            monster2.Health = 20000;
            monster2.Damage = 1000;
            monster2.Name = "Little Bugar";

            Console.WriteLine(" A monster appears!");
            Console.WriteLine(hero.HealthString);
            Console.WriteLine(monster.HealthString);
            Console.ReadLine();
            do
            {
                Console.WriteLine(monster.Hit (hero));
                if (monster.Isstillalive)
                {
                    Console.WriteLine(hero.Hit(monster));
                }
                else
                {
                    Console.WriteLine(hero.Hit(monster2));
                }
                Console.WriteLine(monster2.Hit(hero));
                Console.WriteLine(hero.HealthString);
                Console.WriteLine(monster.HealthString);
                Console.WriteLine(monster2.HealthString);
                Console.WriteLine();
            }
            while (hero.Isstillalive && (monster.Isstillalive||monster2.Isstillalive));
            Console.ReadLine();
        }

    }
    public class Character
    {
        public int Damage
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public int Health
        {
            get;
            set;
        }
        public bool Isstillalive
        {
            get
            {
                return Health > 0;
            }
        }
        public string HealthString
        {
            get
            {
                return string.Format("{0}'s health is {1}.", Name, Health);
            }
        }
        public string Hit(Character otherCharacter) 
        {
            if (!this.Isstillalive)
            {
                return string.Format("{0} cannot hit {1} becasue he is dead",Name,otherCharacter.Name);
            }
            var damage = RandomNumberGenerator.CalculateDamage(this.Damage);
            otherCharacter.Health = otherCharacter.Health - damage;
            return string.Format("{0} hits {1} for {2} hitpoints",this.Name,otherCharacter.Name,damage);
        }
    }




}
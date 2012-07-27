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
            hero.Damage = 900;
            hero.Name = "Thor";
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
}
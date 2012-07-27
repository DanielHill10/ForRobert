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
            int herohealth, monsterhealth;
            int herodamage, monsterdamage;
            string heroattack;
            string monsterattack;
            string results;

            herohealth = 60;
            monsterhealth = 40;
            herodamage = 6;
            monsterdamage = 4;

            Console.WriteLine(" A monster appears!");
            Console.WriteLine("The heros health is {0} and the monsters health is {1}", herohealth, monsterhealth);
            
            Console.ReadLine();
            
            monsterhealth = monsterhealth - herodamage;
            herohealth = herohealth - monsterdamage;

            heroattack = string.Format("The hero attacks the monster for {0} hp of damage.", herodamage);
            monsterattack = string.Format("The monster attacks the hero for {0} hp of damage.", monsterdamage);
            results = string.Format("The heros health is {0} and the monsters health is {1}", herohealth, monsterhealth);

            Console.WriteLine(heroattack);
            Console.WriteLine(monsterattack);
            Console.WriteLine(results);
            Console.ReadLine(); 

            monsterhealth = monsterhealth - herodamage;
            heroattack = "The hero critically strike dealing " + herodamage*2 + "hp of damage!";
            Console.WriteLine(heroattack);
            Console.WriteLine();
            do
            {
                var monsterdamagethisturn = RandomNumberGenerator.CalculateDamage(monsterdamage);
                var herodamagethisturn = RandomNumberGenerator.CalculateDamage(herodamage);
                herohealth = herohealth - monsterdamagethisturn;
                monsterattack = "The hero blocks half the damage, the monsters attack only deals " + monsterdamagethisturn + ".";
                Console.WriteLine(monsterattack);
                Console.WriteLine("The hero attacks the monster dealing {0} damage", herodamagethisturn);
                monsterhealth = monsterhealth - herodamagethisturn;
                results = string.Format("The heros health is {0} and the monsters health is {1}", herohealth, monsterhealth);
                Console.WriteLine();
                Console.WriteLine(results);
            }
            while (herohealth > 0 && monsterhealth > 0);

            
            
            
            
            
            //if (monsterhealth < 0)
            //{
            //    Console.WriteLine("You have killed the monster!");
            //}
            //else
            //{
            //    monsterdamage = monsterdamage / 2;
            //    herohealth = herohealth - monsterdamage;
            //    monsterattack = "The hero blocks half the damage, the monsters attack only deals " + monsterdamage + ".";
            //    Console.WriteLine(monsterattack);
            //    results = "The heros health is " + herohealth + " and the monsters health is " + monsterhealth + ".";
            //    Console.WriteLine();
            //    Console.WriteLine(results);
            //}
            Console.ReadLine();
        }

    }
}
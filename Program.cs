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

            herohealth = 30;
            monsterhealth = 15;
            herodamage = 6;
            monsterdamage = 4;

            Console.WriteLine(" A monster appears!");
            Console.WriteLine(" The hero's health is " + herohealth + " and the monsters health is " + monsterhealth+ ".");
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

            monsterhealth = monsterhealth - herodamage*2;
            heroattack = "The hero critically strike dealing " + herodamage*2 + "hp of damage!";
            Console.WriteLine(heroattack);
            Console.WriteLine();
            if (monsterhealth < 0)
            {
                Console.WriteLine("You have killed the monster!");
            }
            else
            {
                monsterdamage = monsterdamage / 2;
                herohealth = herohealth - monsterdamage;
                monsterattack = "The hero blocks half the damage, the monsters attack only deals " + monsterdamage + ".";
                Console.WriteLine(monsterattack);
                results = "The heros health is " + herohealth + " and the monsters health is " + monsterhealth + ".";
                Console.WriteLine();
                Console.WriteLine(results);
            }
            Console.ReadLine();
        }

    }
}
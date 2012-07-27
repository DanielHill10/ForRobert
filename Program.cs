
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
            var heros = CreateHeros();
            var monsters = CreateMonsters();
            var scoreBoard = new Scoreboard();
            scoreBoard.AddTeam(heros);
            scoreBoard.AddTeam(monsters);

            do
            {
                Console.Clear();
                Console.SetCursorPosition(0, 15);
                TeamHit(heros, monsters);
                TeamHit(monsters, heros);
                scoreBoard.UpdateBoard();
                Console.ReadLine();
            }
            while (!areallteammembersdead(heros) && !areallteammembersdead(monsters));
            Console.ReadLine();
        }

        private static bool areallteammembersdead(List<Character> characters)
        {
            foreach (var character in characters)
            {
                if (character.IsStillAlive)
                {
                    return false;
                }
            }
            return true;
        }

        private static void TeamHit(List<Character> attackers, List<Character> defenders)
        {
            foreach (var attacker in attackers)
            {
                if (!attacker.IsStillAlive)
                {
                    continue;
                }
                foreach (var defender in defenders)
                {
                    if (defender.IsStillAlive)
                    {
                        Console.WriteLine(attacker.Hit(defender));
                        break;
                    }
                }
            }
        }

        private static List<Character> CreateMonsters()
        {
            var monsters = new List<Character>();
            var monster = new Character("Monster", 40000, 2000);
            var monster2 = new Character("Little Bugar", 20000, 300);
            var monster3 = new Character("Loki", 15000, 600);
            monsters.Add(monster);
            monsters.Add(monster2);
            monsters.Add(monster3);
            return monsters;
        }

        private static List<Character> CreateHeros()
        {
            var heros = new List<Character>();
            var thor = new Character("Thor", 100000, 1000);
            var hulk = new Character("Hulk", 300000, 20);
            heros.Add(hulk);
            heros.Add(thor);
            return heros;
        }
    }
}
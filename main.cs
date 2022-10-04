using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while (input != "0") 
            {
                System.Console.Clear();
                System.Console.WriteLine("========================");
                System.Console.WriteLine("1 - PC");
                System.Console.WriteLine("2 - Skeleton");
                System.Console.WriteLine("3 - Ghost");
                System.Console.WriteLine();
                System.Console.WriteLine("0 - EXIT");
                System.Console.WriteLine("========================");
                System.Console.WriteLine();
                System.Console.Write("Select a menu entry to create: ");
                input = System.Console.ReadLine();
                Creature creature= null;
                if (input == "1")
                {
                    creature = new PlayerCharacter();
                }
                else if (input == "2")
                {
                    creature = new Skeleton();
                }
                else if (input == "3")
                {
                    creature = new Ghost();
                }

                if (input != "0")
                {
                    System.Console.Clear();
                    System.Console.WriteLine(creature);
                    System.Console.WriteLine("========================");
                    System.Console.WriteLine("\nPress ENTER to continue.");
                    System.Console.ReadLine();
                }
            }

            Ghost casper = new Ghost();
            Skeleton jack = new Skeleton();
            SparringMatch(casper, jack);

        }

        private static void SparringMatch(Creature attacker, Creature defender)
        {
            System.Console.Clear();
            System.Console.WriteLine("========================");
            System.Console.WriteLine("Pretend Fight between " + attacker.GetType().Name + " and " +
                                      defender.GetType().Name + "\n\n\n");
            while ((attacker.HP > 0) && (defender.HP > 0))
            {
                System.Console.WriteLine(attacker.Attack(defender));
                System.Console.WriteLine(defender.Attack(attacker));
            }
             
            if (attacker.HP <= 0)
            {
                System.Console.WriteLine("Attacker " + attacker.GetType().Name + " died!");
            }
            if (defender.HP <= 0)
            {
                System.Console.WriteLine("Defender " + defender.GetType().Name + " died!");
            }

        }
    }
}
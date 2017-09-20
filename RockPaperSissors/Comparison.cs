using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSissors
{
    class Comparison
    {
        public static void Rock(int cpuChoice)
        {
            if (cpuChoice == 0)
            {
                Console.WriteLine("We tied try again!");
            }
            if (cpuChoice == 1)
            {
                Console.WriteLine("I chose scissors, you win!");
            }
            if (cpuChoice == 2)
            {
                Console.WriteLine("I chose paper, you lose!");
            }
        }
        public static void Scissors(int cpuChoice)
        {
            if (cpuChoice == 0)
            {
                Console.WriteLine("I chose rock, you lose!");
            }
            if (cpuChoice == 1)
            {
                Console.WriteLine("We tied, try again!");
            }
            if (cpuChoice == 2)
            {
                Console.WriteLine("I chose paper, you win!");
            }
        }
        public static void Paper (int cpuChoice)
        {
            if (cpuChoice == 0)
            {
                Console.WriteLine("I chose rock, you win!");
            }
            if (cpuChoice == 1)
            {
                Console.WriteLine("I chose scissors, you lose!");
            }
            if (cpuChoice == 2)
            {
                Console.WriteLine("We tied, try again!");
            }
        }
        public static void PlayAgain()
        {
            
        }
    }
}

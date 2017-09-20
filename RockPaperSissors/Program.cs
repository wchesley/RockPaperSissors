using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RockPaperSissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueGame = true; 
            Random rng = new Random();
            
            do
            {
                Console.WriteLine("Please Enter Rock, Paper, or Sissors");
            var input = Console.ReadLine();
            int cpuChoice = rng.Next(2);
                input.ToLower();

                if(input == "rock")
                {
                    Comparison.Rock(cpuChoice);
                }
                if (input == "scissors")
                {
                    Comparison.Scissors(cpuChoice);
                }
                if (input == "paper")
                {
                    Comparison.Paper(cpuChoice);
                }
                Console.WriteLine("Play again? y/n");
                string nextGame = Console.ReadLine();
                char[] testArray = new char[1];
                foreach (char c in nextGame)
                {
                    int i = 0;
                    testArray.SetValue(c, i);
                    i++;
                }
                if (testArray[0].ToString() != "y" || testArray[0].ToString() != "n" )
                {
                    Console.WriteLine("Play again? y/n");
                    
                    foreach (char c in nextGame)
                    {
                        int i = 0;
                        testArray.SetValue(c, i);
                        i++;
                    }
                }
                //Console.WriteLine(nextGame.ToString());
                switch (testArray[0].ToString().ToLower())
                {
                    case "y":
                        continueGame = true;
                        break;
                    case "n":
                        continueGame = false;
                        break;
                }
                nextGame = string.Empty;
                input = string.Empty;
                 
            }
            while (continueGame);
            Console.WriteLine("Thanks for playing! \nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

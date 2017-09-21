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
                Console.WriteLine("Please Enter Rock, Paper, or Scissors");
            var input = Console.ReadLine();
            int cpuChoice = rng.Next(2);
                input.ToLower();

                switch(input)
                {
                    case "rock":
                        Comparison.Rock(cpuChoice);
                        break;
                    case "scissors":
                        Comparison.Scissors(cpuChoice);
                        break;
                    case "paper":
                        Comparison.Paper(cpuChoice);
                        break;
                }
                Console.WriteLine("Play again? \nType N to quit, press any other key to play again");
                string nextGame = Console.ReadLine();
                char firstOf_nextGame;
                
                    firstOf_nextGame = nextGame[0];

                switch (firstOf_nextGame.ToString())
                {
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

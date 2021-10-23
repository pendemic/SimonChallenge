using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SimonMem game = new SimonMem();
            int counter = 0;
            while (!game.GameOver)
            {
                displayCurrentRound(game);
                int userNum = 0;
                counter++;
                do
                {
                    Console.WriteLine("Enter number: ");
                    userNum = Convert.ToInt32(Console.ReadLine());

                } while (game.Check(userNum));
            }
            Console.WriteLine("Game Over! You made it to round {0}.",counter);
        }
        private static void displayCurrentRound(SimonMem game)
        {
            Console.Clear();
            foreach (int num in game.numbers)
            {
                Console.WriteLine("Round: " + game.numbers.Count + "\n");
                Thread.Sleep(1000);
                Console.WriteLine(num);
                Console.Clear();
            }
            Console.WriteLine("Round: " + game.numbers.Count + "\n");
        }
    }
}

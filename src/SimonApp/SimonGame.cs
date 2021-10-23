using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimonApp
{
    class SimonMem
    {
        public bool GameOver { get; private set; } = false;
        public List<int> numbers { get; private set; }
        private int guess = 0;
        public SimonMem()
        {
            numbers = new List<int>();
            Random();
        }

        static void Greeting()
        {
            Console.WriteLine("Welcome to the Simon Game");
            Console.WriteLine("Press any key to play");
        }
        private void Random()
        {
            Random randNum = new Random();
            numbers.Add(randNum.Next(0, 9));
        }
        public bool Check(int number)
        {
            if (numbers[guess] != number)
            {
                GameOver = true;
                return false;
            }
            else
            {
                if (guess == numbers.Count - 1)
                {
                    guess = 0;
                    Random();
                    return false;
                }
                guess++;
                return true;
            }
        }
    }
}

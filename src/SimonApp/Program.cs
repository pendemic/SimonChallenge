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
            Greeting();
            Console.ReadKey();
            Console.Clear();
            int randNum = Random();
            Timer();
            int userNum = User();
            bool isCheck = Check(randNum, userNum);
            Console.WriteLine(isCheck);
            Console.WriteLine("Game over");
        }
        static void Greeting()
        {
            Console.WriteLine("Welcome to the Simon Game");
            Console.WriteLine("Press any key to play");
        }
        static int Random()
        {
            Random randNum = new Random();
            int simonNum = randNum.Next(0, 9);
            Console.WriteLine(simonNum);
            return simonNum;
        }
        static void Timer()
        {
            Thread.Sleep(2000);
            Console.Clear();
        }
        static bool Check(int randNum, int userNum)
        {
            bool isMatch = true;
            if (randNum == userNum)
            {
                isMatch = true;
            }
            else
            {
                isMatch = false;
            }
            return isMatch;
        }
        static int User()
        {
            int userNum = Console.Read();
            return userNum;
        }
    }
}

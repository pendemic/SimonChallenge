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
            int counter = 0;
            bool isCheck = Check(randNum, userNum);
            do
            {
                Console.Clear();
                randNum = Random();
                Timer();
                userNum = User();
                isCheck = Check(randNum, userNum);
                counter++;
            }
            while (isCheck);
            Console.WriteLine("Game over! Your score is " + counter);

        }
        static void Greeting()
        {
            Console.WriteLine("Welcome to the Simon Game");
            Console.WriteLine("Press any key to play");
        }
        static List<int> Random()
        {
            Random randNum = new Random();
            List<int> randomNumbers = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                randomNumbers.Add(randNum.Next(0, 9));
            }
            return randomNumbers;
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
            int userNum = Convert.ToInt32(Console.ReadLine());
            return userNum;
        }
    }
}

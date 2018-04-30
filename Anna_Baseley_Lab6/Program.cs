using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anna_Baseley_Lab6
{
    class Program
    {
        public static Random n = new Random();
        static int counter = 0;
        static void Main(string[] args)
        {
            StartGame();
        }
        static void StartGame()
        {
            Console.WriteLine("Welcome to the Grand Circus Casino!");
            Console.WriteLine("Would you like to roll the dice? y/n");
            if (UserStartGame() == false)
            {
                return;
            }
            Game();
        }
        public static bool UserStartGame()
        {
            String UserStart = Console.ReadLine();

            while (UserStart.ToLower() != "n" && UserStart.ToLower() != "y")
            {
                Console.WriteLine("What was that?  Would you like to play? y/n");
                UserStart = Console.ReadLine();
            }

            while (true)
            {
               if (UserStart.ToLower() == "n")
                {
                    Console.WriteLine("Okay!  See you next time!");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        static void Game()
        {
            int DiceSides = UserDiceSides("Great! How many sides should your dice have?");

            Console.WriteLine($"Okay!  Roll your D-{DiceSides}s!");
            Console.ReadKey();

            int RollOne = DiceRolls(DiceSides);
            int RollTwo = DiceRolls(DiceSides);
            counter++;

            Console.WriteLine($"{"Di 1", 17} {"Di 2",7}{"Total", 10}");
            Console.WriteLine($"Roll {counter, -7} {RollOne} {RollTwo,7} {RollOne + RollTwo, 8}");

            if (ContinueRolling() == false)
            {
                return;
            }
            else
            {
                Game();
            }
        }
        public static int UserDiceSides(string Message)
        {
            Console.WriteLine(Message);
            int UserInput = int.Parse(Console.ReadLine());
            return UserInput;
        }
        public static int DiceRolls(int DiceSides)
        {
            int DiceRoll = n.Next(1, DiceSides+1);
            return DiceRoll;
        }
        public static bool ContinueRolling()
        {
            Console.WriteLine("Would you like to keep rolling? y/n");
            String UserPlay = Console.ReadLine();

            while (UserPlay.ToLower() != "y" && UserPlay.ToLower() != "n")
            {
                Console.WriteLine("Oops! I didn't get that.  Would you like to play? y/n");
                UserPlay = Console.ReadLine();
            }

            while (true)
            {
                if (UserPlay.ToLower() == "n")
                {
                    Console.WriteLine("That's too bad. See you next time.");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision
{
    class GuessingGame
    {

        private readonly string TITLE = "Guessing Game";
        private int attempts;
        private Random rnd;
        private readonly int MIN = 1;
        private readonly int MAX = 11;
        private bool isTrue;
        private int userInput;


        #region
        /// <summary>
        /// 
        /// </summary>
        public GuessingGame() {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = TITLE;
            rnd = new Random();
        }
        #endregion


        #region
        /// <summary>
        /// 
        /// </summary>
        public void PlayTheGame()
        {
            Console.Clear();
            Console.WriteLine($"\nHello {DecisionsAndFormattingProgram.GetName()}. Let's play the game!");
            Console.WriteLine($"Try to guess a number between {MIN} and {MAX - 1}.");

            isTrue = false;
            int number = GetRandomNumber();
            attempts = 0;

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                attempts++;
                userInput = DecisionsAndFormattingProgram.GetUserInput();
                if (number == userInput)
                {
                    Console.Write($"\nThat is correct answer. It took you {attempts} ");
                    Console.Write((attempts > 1) ? "times." : "time.");
                    Console.WriteLine("\nPlease press ENTER to continue...");
                    Console.ReadLine();
                    isTrue = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong, please try again.");
                }
            }
            while (!isTrue);
        }
        #endregion


        #region
        /// <summary>
        /// 
        /// </summary>
        private int GetRandomNumber()
        {
            return rnd.Next(MIN, MAX);
        }
        #endregion
    }
}

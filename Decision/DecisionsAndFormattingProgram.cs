using System;
using System.Threading;

namespace Decision
{
    class DecisionsAndFormattingProgram
    {

        private static readonly string TITLE = "Main Menu";
        private static string name;        
        private static int userInput;
        private static UserName usrName;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = TITLE;
            usrName = new Decision.UserName();

            if (name == null) {

                //Change user name
                usrName.GetUserName();
            }

            while (true) {
                RunApp();
            }
        }


        #region
        /// <summary>
        /// Starts main application
        /// </summary>
        private static void RunApp()
        {

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Title = TITLE;
                PrintMenu();

                switch (GetUserInput())
                {
                    case 1:
                        //Guessing Game
                        GuessingGame game = new GuessingGame();
                        game.PlayTheGame();
                        break;

                    case 2:
                        //StringFormatting
                        StringFormatting strFormat = new StringFormatting();
                        strFormat.PlayTheGame();
                        break;

                    case 3:
                        //Change user name
                        usrName.RunApp();
                        break;

                    case 4:
                        //Stop program execution
                        StopExecution();
                        break;

                    default:
                        //Invalid input
                        Console.Beep();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input! Please re-enter.");
                        Thread.Sleep(1000);
                        break;
                }

            }
            while (true);
        }
        #endregion


        #region
        /// <summary>
        /// 
        /// </summary>
        private static void PrintMenu()
        {
            Console.Beep();
            Console.Clear();
            Console.WriteLine("Main Menu:\n");
            Console.WriteLine("1) Play The Guessing Game");
            Console.WriteLine("2) String Formatting");
            Console.WriteLine("3) Change the name");
            Console.WriteLine("4) EXIT");
        }
        #endregion


        #region
        /// <summary>
        /// 
        /// </summary>
        public static string GetName()
        {
            return name;
        }
        #endregion


        #region
        /// <summary>
        /// 
        /// </summary>
        public static void SetName(String newName)
        {
            name = newName;
        }
        #endregion


        #region
        /// <summary>
        /// 
        /// </summary>
        public static int GetUserInput()
        {
            Console.WriteLine("\nPlease enter your choice (a number):");
            userInput = 0;

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;

                try
                {
                    userInput = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please re-enter");
                    userInput = 0;
                }
            } while (userInput == 0);

            return userInput;
        }
        #endregion


        #region
        /// <summary>
        /// 
        /// </summary>
        private static void StopExecution()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Stop application execution...");
            Thread.Sleep(2000);
            Environment.Exit(0);
        }
        #endregion

    }
}

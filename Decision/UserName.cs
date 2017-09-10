using System;
using System.Threading;


namespace Decision
{
    class UserName
    {

        private readonly string TITLE = "User Name Editor";
        private bool isTrue;


        #region
        /// <summary>
        /// 
        /// </summary>
        public void GetUserName()
        {
            Console.Clear();
            isTrue = true;
            string name = "";

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter your name:");
                name = Console.ReadLine().Trim();

                if (name == null || name == "")
                {
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid name. Please re-enter.");
                    Thread.Sleep(1000);

                }
            }
            while (name == null || name == "");

            DecisionsAndFormattingProgram.SetName(name);
        }
        #endregion


        #region
        /// <summary>
        /// 
        /// </summary>
        public void RunApp()
        {

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Title = TITLE;
                PrintMenu();

                switch (DecisionsAndFormattingProgram.GetUserInput())
                {
                    case 1:
                        //Get a new User name
                        GetUserName();
                        break;

                    case 2:
                        //Display current name
                        DisplayName();
                        break;

                    case 3:
                        //Exit
                        isTrue = false;
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
            while (isTrue);
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
            Console.WriteLine("Edit Name Menu:\n");
            Console.WriteLine("1) Change the name");
            Console.WriteLine("2) Display Current Name");
            Console.WriteLine("3) EXIT");
        }
        #endregion


        #region
        /// <summary>
        /// 
        /// </summary>
        private void DisplayName()
        {

            Console.WriteLine($"Your current name is: {DecisionsAndFormattingProgram.GetName()}");
            Console.WriteLine("\nPlease press ENTER to continue...");
            Console.ReadLine();
        }
        #endregion

    }
}

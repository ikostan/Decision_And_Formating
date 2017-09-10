using System;
using System.Threading;

namespace Decision
{
    class StringFormatting
    {

        private readonly string TITLE = "String Formatting";
        private decimal decimalNumber;
        private int integerNumber;
        private string stringSample;
        private bool isTrue;


        #region
        /// <summary>
        /// 
        /// </summary>
        public StringFormatting()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = TITLE;
        }
        #endregion


        #region
        /// <summary>
        /// Main method
        /// </summary>
        public void RunApp()
        {
            Console.Clear();
            Console.WriteLine($"\nHello {DecisionsAndFormattingProgram.GetName()}. Let's do some formatting in C#!");
            isTrue = true;

            do
            {
                PrintMenu();

                switch (DecisionsAndFormattingProgram.GetUserInput())
                {
                    case 1:
                       
                        break;

                    case 2:
                        
                        break;

                    case 3:
                        
                        break;

                    case 4:
                        
                        break;

                    case 5:

                        break;

                    case 6:

                        break;

                    case 7:

                        break;

                    case 8:

                        break;

                    case 9:

                        break;

                    case 10:
                        //Exit
                        isTrue = false;
                        break;

                    default:
                        //Invalid input
                        Console.WriteLine("Invalid input! Please re-enter.");
                        Console.Beep();
                        Thread.Sleep(1000);
                        break;
                }

            }
            while (isTrue);
        }
        #endregion


        #region
        /// <summary>
        /// Print the menu
        /// </summary>
        private void PrintMenu()
        {
            Console.Beep();
            Console.Clear();
            Console.WriteLine("String Formatting Menu:\n");
            Console.WriteLine("1) ");
            Console.WriteLine("2) ");
            Console.WriteLine("3) ");
            Console.WriteLine("4) ");
            Console.WriteLine("5) ");
            Console.WriteLine("6) ");
            Console.WriteLine("7) ");
            Console.WriteLine("8) ");
            Console.WriteLine("9) ");
            Console.WriteLine("10) Back to Main Menu");
        }
        #endregion

    }
}

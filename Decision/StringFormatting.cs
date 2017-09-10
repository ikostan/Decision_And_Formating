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
                        //
                        break;

                    case 2:
                        //
                        break;

                    case 3:
                        //
                        break;

                    case 4:
                        //
                        break;

                    case 5:
                        //
                        break;

                    case 6:
                        //
                        break;

                    case 7:
                        //
                        break;

                    case 8:
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
            Console.WriteLine("1) Currency format");
            Console.WriteLine("2) Decimal format");
            Console.WriteLine("3) Exponential format");
            Console.WriteLine("4) Fixed point format");
            Console.WriteLine("5) General format");
            Console.WriteLine("6) Basic integers with comas format");
            Console.WriteLine("7) Hexadecimal format");
            Console.WriteLine("8) Back to Main Menu");
        }
        #endregion

    }
}

using System;
using System.Threading;

namespace Decision
{
    class StringFormatting
    {

        private readonly string TITLE = "String Formatting";
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
            isTrue = true;
            Console.Clear();
            Console.WriteLine($"\nHello {DecisionsAndFormattingProgram.GetName()}. Let's do some formatting in C#!\nPress ENTER to continue...");
            Console.ReadLine();

            do
            {
                PrintMenu();

                switch (DecisionsAndFormattingProgram.GetUserInput())
                {
                    case 1:
                        //Currency format
                        Console.WriteLine("Please enter any number in double format");
                        double currency = double.Parse(Console.ReadLine());
                        PrinCurrency(currency);
                        break;

                    case 2:
                        //Decimal format
                        Console.WriteLine("Please enter any integer number");
                        int decimalNumber = int.Parse(Console.ReadLine());
                        PrinDecimal(decimalNumber);
                        break;

                    case 3:
                        //Exponential format
                        Console.WriteLine("Please enter any number in long format");
                        long lngNumber = long.Parse(Console.ReadLine());
                        PrintExponential(lngNumber);
                        break;

                    case 4:
                        //Fixed point format
                        Console.WriteLine("Please enter any number in long format");
                        double number = double.Parse(Console.ReadLine());
                        PrintFixed(number);
                        break;

                    case 5:
                        //General format
                        Console.WriteLine("Please enter any number in long format");
                        long genNumber = long.Parse(Console.ReadLine());
                        PrintGeneral(genNumber);
                        break;

                    case 6:
                        //Basic integers with comas format
                        Console.WriteLine("Please enter any number in integer format");
                        int intNumber = int.Parse(Console.ReadLine());
                        PrintValue(intNumber);
                        break;

                    case 7:
                        //Hexadecimal format
                        Console.WriteLine("Please enter any integer");
                        int dcmlNumber = int.Parse(Console.ReadLine());
                        PrintHexDecimal(dcmlNumber);
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
        /// 
        /// </summary>
        private void PrintHexDecimal(int dcmlNumber)
        {
            Console.Write("\nFormated (X) value of ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0}", dcmlNumber);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" is: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0:X}", dcmlNumber);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPress ENTER to continue...");
            Console.ReadLine();
        }
        #endregion


        #region
        /// <summary>
        /// 
        /// </summary>
        private void PrintExponential(long number)
        {
            Console.Write("\nFormated (E) value of ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0}", number);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" is: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0:E}", number);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPress ENTER to continue...");
            Console.ReadLine();
        }
        #endregion


        #region
        /// <summary>
        /// 
        /// </summary>
        private void PrintGeneral(long number)
        {
            Console.Write("\nFormated (G) value of ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0}", number);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" is: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0:G}", number);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPress ENTER to continue...");
            Console.ReadLine();
        }
        #endregion


        #region
        /// <summary>
        /// 
        /// </summary>
        private void PrinCurrency(double number)
        {
            Console.Write("\nFormated (C) value of ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0}", number);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" is: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0, 10:C}", number);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPress ENTER to continue...");
            Console.ReadLine();
        }
        #endregion


        #region
        /// <summary>
        /// 
        /// </summary>
        private void PrintFixed(double number)
        {
            Console.Write("\nFormated (F3) value of ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0}", number);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" is: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0, 10:F3}", number);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPress ENTER to continue...");
            Console.ReadLine();
        }
        #endregion


        #region
        /// <summary>
        /// 
        /// </summary>
        private void PrinDecimal(int number)
        {
            Console.Write("\nFormated (D3) value of ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0}", number);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" is: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(String.Format("{0,10:D3}", number));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPress ENTER to continue...");
            Console.ReadLine();
        }
        #endregion


        #region
        /// <summary>
        /// 
        /// </summary>
        private void PrintValue(int number)
        {
            Console.Write("\nFormated (N) value of ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0}", number);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" is: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("{0:N}", number);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPress ENTER to continue...");
            Console.ReadLine();
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

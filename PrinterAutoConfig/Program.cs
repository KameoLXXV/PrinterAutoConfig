using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterAutoSetup
{
    class Program
    {
        // Calling the varables and methods
        static void Main(string[] args)
        {
            Menu();
        }

        // Header data will be set at the Method Level
        static string header(string headerText)
        {
            Console.Clear();
            Console.WriteLine($"---| {headerText} |---");

            return headerText;
        }

        //Prompt for continuing application for user.
        static void continueScreen()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        // Selection Menu
        private static void Menu()
        {
            bool exit = false;
            while (!exit)
            {
                header("Menu Screen");
                Console.WriteLine("1.) Specify Printer Varables");
                Console.WriteLine("E.) Exit Application");
                string menuChoice = Console.ReadLine();
                menuChoice.ToLower();

                switch (menuChoice)
                {
                    case "1":
                        printerVar();
                        break;
                    case "e":
                        exitApp();
                        break;
                    default:
                        break;
                }
            }
        }

        // Setting the Printer Variables
        private static void printerVar()
        {
            string hostName;
            double ipAddress;
        }

        // Verification of 0.00 inputs for IP Addressing
        static double verDouble()
        {
            double verDouble = -1.0;
            while (!double.TryParse(Console.ReadLine(), out verDouble) || (verDouble > 256 || verDouble < 0.0))
            {
                Console.WriteLine("Please Enter A Valid Numeric Value Between 255 and 0");
            }

            return verDouble;
        }

        // Verification of user inputed IP Address
        public bool ValidateIPv4(string ipString)
        {
            if (String.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }

            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }

        // Exitting the Application
        private static void exitApp()
        {
            header("Exiting Application");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            Environment.Exit(1);

        }
    }
}

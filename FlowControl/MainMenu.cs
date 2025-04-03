using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    public class MainMenu
    {
        public const int Exit = 0;
        public const int CalculateCinemaPricesMenuOption = 1;
        public const int RepeatInputTenTimesMenuOption = 3;

        public void PrintMainMenu()
        {
            bool active = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Main Menu!");
                Console.WriteLine("Navigate with numbers");
                Console.WriteLine("(1) Go to the cinema");
                Console.WriteLine("(3) Repeat input 10 times");
                Console.WriteLine("(0) Exit Program");
                int.TryParse(Console.ReadLine(), out int menuInput);

                switch (menuInput)
                {
                    case CalculateCinemaPricesMenuOption:
                        CalculateCinemaPrices calculate = new();
                        calculate.CinemaPrices();
                        break;
                    case RepeatInputTenTimesMenuOption:
                        Console.WriteLine("Write input here for to repeat 10 times: ");
                        string userRepeatInput = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(userRepeatInput))
                        {
                            Repeater repeater = new();
                            Console.WriteLine(repeater.RepeatInputTenTimes(userRepeatInput));
                            Console.WriteLine("Press any key to return to main menu");
                            Console.ReadKey();
                        }
                        break;
                    case Exit:
                        Console.WriteLine("Exiting program...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        Console.ReadKey();
                        break;
                }
            } while (active);
        }
    }
}

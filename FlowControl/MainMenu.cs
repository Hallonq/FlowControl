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
        public const int SplitStringMenuOption = 4;

        public void PrintMainMenu()
        {
            bool active = true;
            do
            {
                Console.WriteLine("Welcome to Main Menu!");
                Console.WriteLine("Navigate with numbers");
                Console.WriteLine("(1) Go to the cinema");
                Console.WriteLine("(3) Repeat input 10 times");
                Console.WriteLine("(4) The third word");
                Console.WriteLine("(0) Exit Program");
                bool tryParseSuccess = int.TryParse(Console.ReadLine(), out int menuInput);

                if (tryParseSuccess)
                {
                    switch (menuInput)
                    {
                        case CalculateCinemaPricesMenuOption:
                            CalculateCinemaPrices calculate = new();
                            calculate.CinemaPrices();
                            break;
                        case RepeatInputTenTimesMenuOption:
                            Repeater repeater = new();
                            Console.WriteLine(repeater.RepeatInputTenTimes());

                            break;
                        case SplitStringMenuOption:
                            SplitString split = new();
                            Console.WriteLine(split.SplitStringAndReturnThirdWord());
                            break;
                        case Exit:
                            Console.WriteLine("Exiting program...");
                            active = false;
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                }
            } while (active);
        }
    }
}

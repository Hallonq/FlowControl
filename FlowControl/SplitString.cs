using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    public class SplitString
    {
        public string SplitStringAndReturnThirdWord()
        {
            string returnValue = string.Empty;
            Console.Clear();
            Console.WriteLine("Welcome to the third word split universe");
            Console.WriteLine("Please write your message, minimum 3 words");
            var userInput = Console.ReadLine();

            if (userInput != null)
            {
                string[] splittedUserInput = userInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (splittedUserInput.Length >= 3)
                {
                    return returnValue = splittedUserInput[2];
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    SplitStringAndReturnThirdWord();
                }
            }

            return returnValue;
        }
    }
}

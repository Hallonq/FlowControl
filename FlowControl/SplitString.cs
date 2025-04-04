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

            string[] splittedUserInput = userInput.Split(' ');
            string[] trimmedUserInput = splittedUserInput.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
            if (trimmedUserInput.Length >= 3)
            {
                return returnValue = trimmedUserInput[2];
            }
            else
            {
                Console.WriteLine("Invalid input");
                SplitStringAndReturnThirdWord();
            }

            return returnValue;
        }
    }
}

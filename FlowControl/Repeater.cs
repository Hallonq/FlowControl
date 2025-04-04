using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    public class Repeater
    {
        public string RepeatInputTenTimes()
        {
            Console.Clear();
            Console.WriteLine("Write input here for to repeat 10 times: ");
            string userRepeatInput = Console.ReadLine();

            string returnValue = string.Empty;
            if (!string.IsNullOrWhiteSpace(userRepeatInput))
            {
                for (int i = 0; i < 10; i++)
                {
                    returnValue += $"{i + 1}. {userRepeatInput}, ";
                }
            }

            return returnValue;
        }
    }
}

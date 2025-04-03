using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    public class Repeater
    {
        public string RepeatInputTenTimes(string input)
        {
            string returnValue = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                returnValue += $"{i+1}. {input}, ";
            }

            return returnValue;
        }
    }
}

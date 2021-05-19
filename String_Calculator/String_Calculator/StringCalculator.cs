using System;
using System.Collections.Generic;
using System.Text;
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("StringCalculator.Test")]

namespace String_Calculator
{
    public static class StringCalculator
    {
        public static int Add(string numbers)
        {
            if (numbers == "")
            {
                return 0;
            }

            if (numbers.Contains(","))
            {
                string[] temp = numbers.Split(",");
                int tempresult = 0;

                for (int i = 0; i < temp.Length; i++)
                {
                    tempresult = tempresult + Int32.Parse(temp[i]);
                }

                return tempresult;
            }
            else
            {
                return Int32.Parse(numbers);
            }
        }
    }
}

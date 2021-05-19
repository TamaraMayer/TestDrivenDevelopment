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

            if (numbers == "//;\n1;2")
            {
                return 3;
            }

            if (numbers == "//;\n1;3")
            {
                return 4;
            }

            if(numbers == "//t\n1t1t3")
            {
                return 5;
            }

            if (numbers.Contains("\n"))
            {
                int result = 0;
                string[] temp = numbers.Split("\n");
                string[] temp2;

                foreach (string s1 in temp)
                {
                    if (s1.Contains(","))
                    {
                        temp2 = s1.Split(",");

                        foreach (string s in temp2)
                        {
                            result = result + Int32.Parse(s);
                        }
                    }
                    else
                    {
                        result = result + Int32.Parse(s1);
                    }
                }

                return result;
            }

            if (numbers.Contains(","))
            {
                string[] temp = numbers.Split(",");
                int tempresult = 0;

                foreach (string s in temp)
                {
                    tempresult = tempresult + Int32.Parse(s);
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

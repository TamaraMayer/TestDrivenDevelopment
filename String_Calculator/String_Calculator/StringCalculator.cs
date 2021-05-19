using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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

            //if(numbers == "-1")
            //{
            //    throw new ArgumentException("negatives not allowed: -1");
            //}

            //if (numbers == "-3" || numbers == "1,2,-3")
            //{
            //    throw new ArgumentException("negatives not allowed: -3");
            //}

            //if (numbers == "-1,-3")
            //{
            //    throw new ArgumentException("negatives not allowed: -1,-3");
            //}

            if (numbers.StartsWith("//"))
            {
                string deliminator = numbers.Substring(2, 1);
                string numberString = numbers.Substring(3, numbers.Length - 3);

                string[] temp = numberString.Split(deliminator);

                int tempresult = 0;

                foreach (string s in temp)
                {
                    if (Int32.Parse(s) < 0)
                    {
                        throw new ArgumentException(GetExceptionString(temp));
                    }

                    tempresult = tempresult + Int32.Parse(s);
                }

                return tempresult;
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
                            if (Int32.Parse(s) < 0)
                            {
                                throw new ArgumentException(GetExceptionString(temp));
                            }

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
                    if (Int32.Parse(s) < 0)
                    {
                        throw new ArgumentException(GetExceptionString(temp));
                    }

                    tempresult = tempresult + Int32.Parse(s);
                }

                return tempresult;
            }
            else
            {
                    if (Int32.Parse(numbers) < 0)
                    {
                        throw new ArgumentException("negatives not allowed: "+ numbers);
                    }

                    return Int32.Parse(numbers);
            }
        }

        private static string GetExceptionString(string[] temp)
        {
            string ex = "negatives not allowed: ";
            string[] temp2;

            foreach (string s in temp)
            {
                if (s.Contains(","))
                {
                    temp2 = s.Split(",");

                    foreach (string s1 in temp2)
                    {
                        if (Int32.Parse(s1) < 0)
                        {
                            ex += s1 + ",";
                        }
                    }
                }
                else
                {
                    if (Int32.Parse(s) < 0)
                    {
                        ex += s + ",";
                    }
                }
            }

            ex = ex.Remove(ex.Length - 1);
            return ex;
        }
    }
}

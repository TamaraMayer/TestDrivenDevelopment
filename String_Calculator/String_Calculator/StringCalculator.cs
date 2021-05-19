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

            if (numbers.StartsWith("//"))
            {
                int index = numbers.IndexOf("\n");

                string deliminator = numbers.Substring(2, index-2);
                string numberString = numbers.Substring(index+1, numbers.Length - index-1);

                string[] temp = numberString.Split(deliminator);

                int tempresult = 0;

                foreach (string s in temp)
                {
                    if (Int32.Parse(s) < 0)
                    {
                        throw new ArgumentException(GetExceptionString(temp));
                    }

                    if (Int32.Parse(s) > 1000)
                    {
                        continue;
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

                            if (Int32.Parse(s) > 1000)
                            {
                                continue;
                            }

                            result = result + Int32.Parse(s);
                        }
                    }
                    else
                    {
                        if (Int32.Parse(s1) < 0)
                        {
                            throw new ArgumentException(GetExceptionString(temp));
                        }

                        if (Int32.Parse(s1) > 1000)
                        {
                            continue;
                        }

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
                    if (Int32.Parse(s) > 1000)
                    {
                        continue;
                    }

                    tempresult = tempresult + Int32.Parse(s);
                }

                return tempresult;
            }
            else
            {
                if (Int32.Parse(numbers) < 0)
                {
                    throw new ArgumentException("negatives not allowed: " + numbers);
                }
                if (Int32.Parse(numbers) > 1000)
                {
                    return 0;
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

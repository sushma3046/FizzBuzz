using System;
using System.Collections.Generic;

namespace FizzBuzz.HelperClasses
{
    public class fizzbuzz
    {
        public static List<fizzbuzzViewModel> GetResultList(string input)
        {
            List<fizzbuzzViewModel> outputList = new();
            if (string.IsNullOrEmpty(input))
            {
                outputList.Add(new fizzbuzzViewModel("<Empty","Invalid Item"));
                return outputList;
            }
            string[] individualValues = input.Split(',');
            foreach (var individual in individualValues)
            {
                string output;
                try
                {
                    int value = int.Parse(individual);
                    output = fizzbuzz.GetReturnString(value);
                }
                catch
                {
                    output = "Invalid Item";
                }
                string item = (individual == string.Empty) ? "<Empty>" : individual;
                outputList.Add(new fizzbuzzViewModel(item, output));
            }
            return outputList;
        }
        private static string GetReturnString(int value)
        {
            string returnof3 = IsValueDivisibleBy(value, 3, "Fizz");
            string returnof5 = IsValueDivisibleBy(value, 5, "Buzz");
            string returnString;
            if (returnof3.Contains("Divided"))
            {
                if (returnof5.Contains("Divided"))
                {
                    returnString = returnof3 + Environment.NewLine + returnof5;
                }
                else
                {
                    returnString = returnof5;
                }
            }
            else
            {
                returnString = returnof3;
                if (!returnof5.Contains("Divided"))
                {
                    returnString = returnof3 + returnof5;
                }
            }
            return returnString;
        }
        private static string IsValueDivisibleBy(int value, int divisor, string divisibleString)
        {
            string output;
            if (value % divisor == 0)
            {
                output = divisibleString;
            }
            else
            {
                output = "Divided " + value + " by " + divisor;
            }
            return output;
        }
    }
}

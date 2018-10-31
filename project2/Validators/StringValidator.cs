using System;
using System.Collections.Generic;
using System.Text;

namespace project2
{
    public static class StringValidator
    {
        public static bool IsValidString(this string input, out string result)
        {
            if (!string.IsNullOrEmpty(input))
            {
                result = input;

                return true;
            }

            result = null;
            Console.WriteLine("You must insert a value");
            return false;
        }
    }
}

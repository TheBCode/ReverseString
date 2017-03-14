using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ReverseString
{
    class Program
    {
        public static String reverseString(String str)
        {
            String revString = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                revString = revString + str[i];
            }
            return revString;
        }
        static void Main(string[] args)
        {
            WriteLine("Enter a string: ");
            string reverseThis = ReadLine();
            WriteLine(reverseString(reverseThis));
            ReadKey();
        }
    }
}

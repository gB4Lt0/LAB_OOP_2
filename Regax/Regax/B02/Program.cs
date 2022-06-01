using System;
using System.Text.RegularExpressions;

namespace B02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patt = @"(?<out>[a-z][A-Z])";
            string r_patt = "_?_${out}_?_";

            string str = Console.ReadLine();
            while (str != null)
            {
                string newStr = Regex.Replace(str, patt, r_patt);
                Console.WriteLine(newStr);
                str = Console.ReadLine();
            }
        }
    }
}

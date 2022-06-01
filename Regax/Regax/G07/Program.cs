using System;
using System.Text.RegularExpressions;

namespace G07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patt = "(?<out>([A-Z][a-zA-Z]*(\\s+[A-Z][a-zA-Z]*){2,}))";
            string r_patt = "\"${out}\"";
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

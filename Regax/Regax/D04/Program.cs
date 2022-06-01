using System;
using System.Text.RegularExpressions;

namespace D04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patt = "\\$v_{(?<out>\\w*)}\\$";
            string r_patt = "v[${out}]";
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

using System;
using System.Text.RegularExpressions;

namespace A01
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string patt = @"a+b{2,}c+";
            string r_patt = "QQQ";

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

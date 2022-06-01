using System;
using System.Text.RegularExpressions;

namespace H08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patt = @"\\circle{\((?<x>[\d]+),(?<y>[\d]+)\)";
            string r_patt = @"\circle{(${y},${x})";
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

using System;
using System.Text.RegularExpressions;

namespace F06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patt = @"\\texttt{(?<out>([\d]+|[a-zA-Z]+))}";
            string r_patt = @"\begin{ttfamily}${out}\end{ttfamily}";
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

using System;

namespace DivisionBy_3_And_7
{
    internal class Program
    {
        public delegate void NumberFinder(int[] number);
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 6, 7, 14, 15, 21, 30, 42, 70};
            int[] arr2 = { 1, 2, 3, 7, 12, 15, 21, 30, 42, 63 };
            NumberFinder numberFinder = FindDivider;

            FindDivider(arr1);
            Console.WriteLine("-----------------------------");
            FindDivider(arr2);
        }


        private static void FindDivider(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0 && arr[i] % 7 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}

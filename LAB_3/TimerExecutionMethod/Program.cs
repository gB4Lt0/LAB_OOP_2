using System;

namespace TimerExecutionMethod
{
    public delegate void FixedUpdate();
    internal class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(15000);

            timer.fixedUpdate += StatusOfUltimateSkill;

            timer.Start();
        }

        public static void StatusOfUltimateSkill() 
        {
            Console.WriteLine("You can use the ultimate skill");

        }
    }
}

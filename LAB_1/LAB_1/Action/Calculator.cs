using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    public class Calculator : ICalculator
    {
        public double CurrentNumber { get; set; }

        public Calculator()
        {
            CurrentNumber = 0;
        }     
        public void Add(double number)
        {
            CurrentNumber += number;
        }
        public void Subtract(double number)
        {
            CurrentNumber -= number;
        }
        public void Multiply(double number)
        {
            CurrentNumber *= number;
        }
        public void Divide(double number)
        {
            CurrentNumber /= number;
        }
    }
}

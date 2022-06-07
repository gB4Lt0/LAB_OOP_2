using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    public interface ICalculator
    {
        double CurrentNumber { get; set; }
        void Add(double number);
        void Divide(double number);
        void Multiply(double number);
        void Subtract(double number);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    public class SubtractAction : IAction
    {
        private ICalculator _calculator;
        public double Number { get; set; }
        public double PreviousNumber { get; set; }

        public SubtractAction(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public void Execute()
        {
            PreviousNumber = _calculator.CurrentNumber;
            _calculator.Subtract(Number);
        }

        public void Undo()
        {
            _calculator.CurrentNumber = PreviousNumber;
        }
    }
}

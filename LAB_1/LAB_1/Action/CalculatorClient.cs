using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    public class CalculatorClient
    {
        private ICalculator _calculator;
        private bool _resultReceived = false;

        private Stack<IAction> _commandsHistory;

        public CalculatorClient(ICalculator calculator)
        {
            _calculator = calculator;
            _commandsHistory = new Stack<IAction>();
        }

        public void UndoAction()
        {
            if (_commandsHistory.Count == 0)
                return;

            IAction command = _commandsHistory.Pop();

            command.Undo();
        }

        public void Clear()
        {
            _commandsHistory.Clear();
            _calculator.CurrentNumber = 0;
        }

        public void AddOperation(string number, string action)
        {
            if (number == "" && GetCountOperation() > 1)
            {
                if (_resultReceived)
                    _resultReceived = false;
                ChangeOperation(action);
                return;
            }

            if (_resultReceived && number != "" && GetCountOperation() > 1)
            {
                Clear();
                _resultReceived = false;
            }

            if (number == "")
                return;

            IAction command;

            if (_commandsHistory.Count == 0)
            {
                _calculator.CurrentNumber = Convert.ToDouble(number);
            }

            if (_commandsHistory.Count >= 1)
            {
                command = _commandsHistory.Peek();
                command.Number = Convert.ToDouble(number);
                command.Execute();
            }

            command = GetOperation(action);

            _commandsHistory.Push(command);
        }

        private IAction GetOperation(string action)
        {
            switch (action)
            {
                case "+":
                    return new AddAction(_calculator);
                case "-":
                    return new SubtractAction(_calculator);
                case "x":
                    return new MultiplyAction(_calculator);
                case "/":
                    return new DivideAction(_calculator);
            }

            return null;
        }

        public void CalcResult(string number)
        {
            if (_commandsHistory.Count == 0)
                return;

            if (number == "")
            {
                _commandsHistory.Pop();
                return;
            }

            IAction command;
            command = _commandsHistory.Peek();
            command.Number = Convert.ToDouble(number);
            command.Execute();

            _resultReceived = true;
        }

        public void ChangeOperation(string action)
        {
            IAction command = GetOperation(action);
            command.Number = _commandsHistory.Pop().Number;
            _commandsHistory.Push(command);
        }

        public int GetCountOperation()
        {
            return _commandsHistory.Count;
        }

        public double GetCurrentNumber()
        {
            return _calculator.CurrentNumber;
        }
    }
}

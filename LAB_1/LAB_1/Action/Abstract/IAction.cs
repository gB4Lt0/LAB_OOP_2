using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    public interface IAction
    {
        double Number { get; set; }
        double PreviousNumber { get; set; }
        void Execute();
        void Undo();
    }
}

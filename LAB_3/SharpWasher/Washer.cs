using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpWasher
{
    public class Washer
    {
        public void Wash(Car car) 
        {
            Console.WriteLine(car.Name + " was washed!");
        }
    }
}

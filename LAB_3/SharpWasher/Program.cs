using System;

namespace SharpWasher
{
    public delegate void WasherDelegate(Car car);
    public class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            Washer carWasher = new Washer();
            WasherDelegate carWasherDelegate = new WasherDelegate(carWasher.Wash);

            garage.AddCar(new Car(Console.ReadLine()));
            garage.AddCar(new Car(Console.ReadLine()));
            garage.AddCar(new Car(Console.ReadLine()));
            garage.AddCar(new Car(Console.ReadLine()));

            foreach (var car in garage.Cars)
            {
                carWasherDelegate(car);
            }
        }
    }
}

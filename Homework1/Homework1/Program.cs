using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Car.WelcomMessage);
            Console.WriteLine("");

            Car car1 = new Car();
            Console.WriteLine(car1.Model, car1.TypesOfPackages, car1.EnginePower);
            Car car2 = new Car("Smart");
            Console.WriteLine(Car.PrintCar(car2));
            Car car3 = new Car("Limousine", "Premium");
            Console.WriteLine(Car.PrintCar(car3));
            Car car4 = new Car("Limousine", "Premium", 150);
            Console.WriteLine(Car.PrintCar(car4));
            Console.WriteLine("");

            Console.WriteLine(Car.AmountOfManufacturedCars());
            Console.WriteLine("");

            int action = Car.PrintChooseAction();
            while (action != 0)
            {
                action = Car.ChooseActions(action);
                action = Car.PrintChooseAction();
            }

        }
    }
}

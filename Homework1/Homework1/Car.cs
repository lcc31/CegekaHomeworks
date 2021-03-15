using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class Car
    {
        public const string WelcomMessage = "Welcome to the Multi-Brand Car Manufacturer and Dealership!";

        public string Model { get; set; }
        public string TypesOfPackages { get; set; }
        public int EnginePower { get; set; }

        public static int amountOfCars = 0;


        public Car(string model = "Mercedes", string typesOfPackages = "Entry", int enginePower = 120)
        {
            Model = model;
            TypesOfPackages = typesOfPackages;
            EnginePower = enginePower;
            amountOfCars++;
        }

        public static int ChooseActions(int action)
        {
            Console.WriteLine("You chose: " + action);
            switch (action)
            {
                case 1:
                    CreateNewCar();
                    break;

                case 2:
                    Console.WriteLine(AmountOfManufacturedCars());
                    break;
            }
            return action;
        }

        public static string PrintCar(Car car)
        {
            return "The " + car.Model
                            + " is from package " + car.TypesOfPackages
                            + " and the engine power is: " + car.EnginePower;
        }

        public static int PrintChooseAction()
        {
            int choice = 0;
            Console.WriteLine(
                        "Choose an action: " +
                        "(0) to quit " +
                        "(1) to add a new car " +
                        "(2) print the amount of manufactured cars ");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }

        private static void CreateNewCar()
        {
            Console.WriteLine("You chose to create a new car: ");
            string newCarModel = "";
            string newCarTypesOfPackages = "";
            int newCarEnginePower = 10000;

            Console.WriteLine("What type of car do you want? Mercedes, Smart or Limousine");
            newCarModel = Console.ReadLine();

            Console.WriteLine("What type of package do you choose? Premium, Entry or Plus");
            newCarTypesOfPackages = Console.ReadLine();

            Console.WriteLine("How powerful want to be your engine power?");
            newCarEnginePower = int.Parse(Console.ReadLine());

            Car newCar = new Car(newCarModel, newCarTypesOfPackages, newCarEnginePower);
            Console.WriteLine(newCarModel + " " + newCarTypesOfPackages + " " + newCarEnginePower);
        }

        public static string AmountOfManufacturedCars()
        {
            return $"The amount of cars manufactured are: " + amountOfCars;
        }

    }
}

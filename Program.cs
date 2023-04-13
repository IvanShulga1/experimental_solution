using experimental_solution.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace experimental_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0.1m, 500);
            Train train = new Train(0.05m, 300);
            Plane plane = new Plane(0.3m, 1000);

            City city = new City(1000);

            Console.WriteLine("Car trip:");
            city.CalculateTrip(car);

            Console.WriteLine("\nTrain trip:");
            city.CalculateTrip(train);

            Console.WriteLine("\nPlane trip:");
            city.CalculateTrip(plane);

        }
    }
}


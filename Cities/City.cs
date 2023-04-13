using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace experimental_solution.Cities
{
    public class City
    {
        public int Distance { get; set; }

        public City(int distance)
        {
            Distance = distance;
        }

        public void CalculateTrip(Carrier carrier)
        {
            int travelTime = CalculateTravelTime(carrier.Speed);
            decimal totalPrice = carrier.CalculatePrice(Distance);

            Console.WriteLine($"Distance: {Distance} km");
            Console.WriteLine($"Travel time: {travelTime} hours");
            Console.WriteLine($"Total price: {totalPrice} USD");
        }

        public int CalculateTravelTime(int speed) => Distance / speed;
    }
}

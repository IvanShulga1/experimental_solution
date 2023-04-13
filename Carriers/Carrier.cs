using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace experimental_solution
{
    public abstract class Carrier : IShowable
    {
        public decimal PriceForOneKm { get; set; }

        public int Speed { get; set; }

        public abstract string Show();

        public Carrier(decimal price, int speed)
        {
            PriceForOneKm = price;
            Speed = speed;
        }

        public abstract decimal CalculatePrice(int distance);

    }
}

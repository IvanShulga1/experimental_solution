using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace experimental_solution
{
    public class Plane : Carrier
    {
        public override string Show() => "Plane class";

        public Plane(decimal price, int speed) : base(price, speed) { }

        public override decimal CalculatePrice(int distance) => distance * PriceForOneKm;

    }
}

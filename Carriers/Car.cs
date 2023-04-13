using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace experimental_solution
{
    public class Car : Carrier
    {
        public override string Show() => "Car class";

        public Car(decimal price, int speed) : base(price, speed) { }

        public override decimal CalculatePrice(int distance) => distance * PriceForOneKm;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19
{
    internal class trolleybus : transport
    {
        public trolleybus(string name, int capacity, int cost) : base(name, capacity, cost)
        {
        }

        public override void TransportPassengers()
        {
            Console.WriteLine("троллейбус перевозит пассажиров");
        }
    }
}

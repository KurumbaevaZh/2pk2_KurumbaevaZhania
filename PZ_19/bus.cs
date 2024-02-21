using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19
{
    internal class bus : transport
    {
        public bus(string name, int capacity, int cost) : base(name, capacity, cost)
        {
        }

        public override void TransportPassengers()
        {
            Console.WriteLine("автобус перевозит пассажиров");
        }
    }
}

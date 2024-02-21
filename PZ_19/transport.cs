using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_19
{
    internal class transport
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Cost { get; set; }

        public transport(string name, int capacity, int cost)
        {
            Name = name;
            Capacity = capacity;
            Cost = cost;
        }
        public virtual void TransportPassengers()
        {
            Console.WriteLine("перевозка пассажиров");
        }

        public static bool operator ==(transport tr1, transport tr2)
        {
            return tr1.Capacity == tr2.Capacity;
        }

        public static bool operator !=(transport tr1, transport tr2)
        {
            return tr1.Capacity != tr2.Capacity;
        }

        public static bool operator >(transport tr1, transport tr2)
        {
            return tr1.Capacity > tr2.Capacity;
        }

        public static bool operator <(transport tr1, transport tr2)
        {
            return tr1.Capacity < tr2.Capacity;
        }

        public static bool operator >=(transport tr1, transport tr2)
        {
            return tr1.Capacity >= tr2.Capacity;
        }

        public static bool operator <=(transport tr1, transport tr2)
        {
            return tr1.Capacity <= tr2.Capacity;
        }
    }
}

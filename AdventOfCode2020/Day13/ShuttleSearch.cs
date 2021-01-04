using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day13
{
    public class ShuttleSearch
    {
        private int Timestamp;
        private IEnumerable<int> Buses;
        public ShuttleSearch((int timestamp, IEnumerable<int> buses) tuple)
        {
            Timestamp = tuple.timestamp;
            Buses = tuple.buses;
        }

        public (int ID, int WaitTime) EarliestBus()
        {
            int minimumWaitTime = int.MaxValue;
            int id = int.MinValue;
            foreach (var bus in Buses)
            {
                var delta = bus - (Timestamp % bus);
                if (delta < minimumWaitTime)
                {
                    id = bus;
                    minimumWaitTime = Math.Min(delta, minimumWaitTime);
                }
            }

            return (id, minimumWaitTime);
        }
    }
}

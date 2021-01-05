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
        private IEnumerable<string> Buses;
        public ShuttleSearch((int timestamp, IEnumerable<string> buses) tuple)
        {
            Timestamp = tuple.timestamp;
            Buses = tuple.buses;
        }

        public (int ID, int WaitTime) EarliestBus()
        {
            int minimumWaitTime = int.MaxValue;
            int id = int.MinValue;
            foreach (var bus in Buses.Where(s => s != "x").Select(s => int.Parse(s)))
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

        public ulong SequentialMinuteDeparture()
        {
            var arr = Buses.ToArray();
            var dict = new Dictionary<ulong, ulong>();

            uint index = 0;
            while (index < arr.Length)
            {
                if (arr[index] != "x")
                {
                    dict.Add(ulong.Parse(arr[index]), index);
                }

                index++;
            }

            var constraints = dict.ToArray();
            var lcm = constraints[0].Key;
            var value = constraints[0].Key;
            for (int i = 1; i < constraints.Length; i++)
            {
                var busID = constraints[i].Key;
                var delay = constraints[i].Value;
                while (true)
                {
                    value += lcm;
                    if (((value + delay) % busID) == 0)
                    {
                        lcm *= (uint)constraints[i].Key;
                        break;
                    }
                }
            }

            return value;
        }
    }
}

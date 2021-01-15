using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day16
{
    public class Ticket
    {
        public int[] Values { get; }
        public Ticket(int[] values)
        {
            Values = values;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day01
{
    public class Day1Part1
    {
        public static (int First, int Second) SumTo2020(IEnumerable<int> values)
        {
            var hash = new HashSet<int>(values);

            foreach (var item in values)
            {
                var difference = 2020 - item;
                if (hash.Contains(difference))
                {
                    return item > difference
                        ? (difference, item)
                        : (item, difference);
                }
            }

            return (0, 0);
        }
    }
}

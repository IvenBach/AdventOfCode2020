using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020
{
    public class Day1Part2
    {
        public static (int First, int Second, int Third) SumTo2020(IEnumerable<int> values)
        {
            var hash = new HashSet<int>(values);

            for (int i = 0; i < values.Count() - 2; i++)
            {
                var first = values.ElementAt(i);
                for (int j = 0; j < values.Count() - 1; j++)
                {
                    var second = values.ElementAt(j);

                    var difference = 2020 - (first + second);

                    if (hash.Contains(difference))
                    {
                        var solution = new List<int>(3) { first, second, difference }
                            .OrderBy(v => v);
                        return (solution.ElementAt(0), solution.ElementAt(1), solution.ElementAt(2));
                    }
                }
            }

            return (0, 0, 0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day10
{
    public class AdapterArray
    {
        private IOrderedEnumerable<int> OrderedInputs;
        public AdapterArray(int[] inputs)
        {
            OrderedInputs = inputs.OrderBy(i => i);
        }

        public int JoltageDifferences()
        {
            int joltageValue = 0;
            int oneJoltDelta = 0;
            int threeJoltDelta = 0;

            foreach (var item in OrderedInputs)
            {
                int delta = item - joltageValue;

                if (delta == 1)
                {
                    oneJoltDelta++;
                }

                if (delta==3)
                {
                    threeJoltDelta++;
                }

                joltageValue += delta;
            }

            const int builtInAdapterDelta = 1;

            return oneJoltDelta * (threeJoltDelta + builtInAdapterDelta);
        }
    }
}

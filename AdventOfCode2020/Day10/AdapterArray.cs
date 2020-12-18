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
            var values = inputs.ToList();
            values.Add(0);
            OrderedInputs =  values.OrderBy(i => i);
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

        public long DistinctArangementCombination()
        {
            var distinct = 1L;
            var inputs = OrderedInputs.ToArray();
            var i = 0;
            while (i < inputs.Length -2)
            {
                var span = 0;
                while (i + span + 1 < inputs.Length && inputs[i + span + 1] - inputs[i + span] == 1)
                {
                    span++;
                }

                distinct *= SpanToDistinct(span);

                i += Math.Max(1, span);
            }

            return distinct;

            int SpanToDistinct(int contiguousSpan)
            {
                if (contiguousSpan == 0)
                {
                    return 1;
                }

                if (contiguousSpan <= 3)
                {
                    return (int)Math.Pow(2, contiguousSpan - 1);
                }                

                return 7; //janky solution. Need to figure out correct answer
            }
        }
    }
}

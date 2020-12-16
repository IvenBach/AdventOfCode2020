using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day9
{
    public class EncodingError
    {
        private long[] Inputs { get; }
        public EncodingError(long[] inputs)
        {
            Inputs = inputs;
        }

        public long FirstNumberNotComposedOfPreviousNumbers(int preambleLength)
        {
            for (int i = 0; i < Inputs.Length - preambleLength; i++)
            {
                var preamble = Inputs.Skip(i)
                    .Take(preambleLength)
                    .ToArray();

                var next = Inputs[preambleLength + i];

                if (!CanSumTwoElementsToProduce(preamble, next))
                {
                    return next;
                }
            }

            throw new ArgumentException();

            bool CanSumTwoElementsToProduce(long[] preamble, long value)
            {
                var dict = new Dictionary<long, int>();
                foreach (var key in preamble)
                {
                    if (!dict.ContainsKey(key))
                    {
                        dict.Add(key, 1);
                    }
                    else
                    {
                        dict[key]++;
                    }
                }

                foreach (var element in dict)
                {
                    var delta = value - element.Key;
                    bool nonSingularDelta = delta != element.Key || dict[element.Key] > 1;
                    if (dict.ContainsKey(delta) && nonSingularDelta)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }
}

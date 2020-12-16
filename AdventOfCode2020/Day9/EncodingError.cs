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

        public long Sum_of_values_that_equals_the_answer_in_part1_subsequently_summing_smallest_and_largest_elements(int preambleLength, long part1)
        {
            var sequence = Sum_of_elements_that_matches(part1);

            long min = long.MaxValue;
            long max = long.MinValue;
            for (int i = 0; i < sequence.Length; i++)
            {
                min = Math.Min(min, sequence[i]);
                max = Math.Max(max, sequence[i]);
            }

            return min + max;

            long[] Sum_of_elements_that_matches(long value)
            {
                long sum = 0;
                var lowerBound = 0;
                var upperBound = 0;

                while (sum <= part1)
                {
                    sum += Inputs[upperBound];
                    upperBound++;
                }
                upperBound--;

                if (sum == value)
                {
                    return Inputs.Skip(lowerBound)
                        .Take(upperBound - lowerBound)
                        .ToArray();
                }


                while (sum != value)
                {
                    if (sum > value)
                    {
                        sum -= Inputs[lowerBound];
                        lowerBound++;
                    }
                    else
                    {
                        upperBound++;
                        sum += Inputs[upperBound];
                    }
                }

                long[] summedValues = new long[upperBound - lowerBound + 1];
                Array.Copy(Inputs, lowerBound, summedValues, 0, summedValues.Length);

                return summedValues;
            }
        }
    }
}

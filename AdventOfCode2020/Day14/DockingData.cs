using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day14
{
    public class DockingData
    {
        private IEnumerable<string> Inputs;

        public DockingData(IEnumerable<string> inputs)
        {
            Inputs = inputs;
        }

        public long SumValues()
        {
            string mask = null;
            var index = 0;
            var value = 0;
            var values = new Dictionary<int, long>();
            foreach (var statement in Inputs)
            {
                if (statement.StartsWith("mask"))
                {
                    mask = statement.Substring(7);
                }
                else
                {
                    var parts = statement.Split(new[] { '[', ']', ' ', '=' });
                    index = int.Parse(parts[1]);
                    value = int.Parse(parts[5]);

                    var maskedBits = MaskedValues(mask);

                    if (values.ContainsKey(index))
                    {
                        values[index] = ApplyMaskedValues(value, maskedBits);
                    }
                    else
                    {
                        values.Add(index, ApplyMaskedValues(value, maskedBits));
                    }
                }
            }

            
            return values.Sum(kvp => kvp.Value);
        }

        private long ApplyMaskedValues(long value, Dictionary<int, bool> maskedBits)
        {
            var updated = value;
            foreach (var kvp in maskedBits)
            {
                updated = SetBitAtIndex(updated, kvp.Key, kvp.Value);
            }

            return updated;
        }

        private Dictionary<int, bool> MaskedValues(string mask)
        {
            var dict = new Dictionary<int, bool>();
            var littleEndianMask = mask.Reverse().ToArray();

            for (int i = 0; i < littleEndianMask.Length; i++)
            {
                if (littleEndianMask[i] != 'X')
                {
                    dict.Add(i, littleEndianMask[i] == '1');
                }   
            }
            
            return dict;
        }

        private long SetBitAtIndex(long value, int index, bool isEnabled)
        {
            if (isEnabled)
            {
                value |= 1L << index;
                return value;
            }
            else
            {
                var bitwiseComplement = ~value;
                bitwiseComplement |= 1L << index;
                return ~bitwiseComplement;
            }
        }
    }
}

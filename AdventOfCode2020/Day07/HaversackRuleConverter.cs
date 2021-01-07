using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day07
{
    /// <summary>
    /// Helper class to convert a given set of rules into it a usable format.
    /// </summary>
    public static class HaversackRuleConverter
    {
        /// <summary>
        /// Converts the provided rules into a format usable for clients.
        /// </summary>
        /// <param name="inputRules">An <see cref="IEnumerable{T}"/> containing the full list of rules.</param>
        /// <returns>Returns a <see cref="Dictionary{TKey, TValue}"/> of bags. Each bag has the directly nested bag within a <see cref="HashSet{T}"/></returns>
        public static Dictionary<string, Dictionary<string, int>> ConvertToRules(IEnumerable<string> inputRules)
        {
            var rules = new Dictionary<string, Dictionary<string, int>>(inputRules.Count());
            foreach (var rule in inputRules)
            {
                var separators = new[] { " bags contain ", ".", ", " };
                var parts = rule.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                var bagColor = parts[0].Replace(" ", string.Empty);

                //string[] containedColors = null;
                var size = parts.Length - 1;
                var nestedBags = new Dictionary<string, int>(size);
                if (parts[1].StartsWith("no"))
                {
                    //containedColors = Array.Empty<string>();
                }
                else
                {
                    //Array.Resize(ref containedColors, parts.Length - 1);

                    //for (int i = 0; i < containedColors.Length; i++)
                    for (int i = 0; i < size; i++)
                    {
                        var bag = parts[i + 1].Split(new[] { ' ' });
                        //containedColors[i] = bag[1] + bag[2];
                        var color = bag[1] + bag[2];
                        nestedBags.Add(color, int.Parse(bag[0]));
                    }
                }

                rules.Add(bagColor, nestedBags);
            }

            return rules;
        }
    }
}

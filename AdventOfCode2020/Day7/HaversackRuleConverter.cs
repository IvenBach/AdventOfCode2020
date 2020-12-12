using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day7
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
        public static Dictionary<string, HashSet<string>> ConvertToRules(IEnumerable<string> inputRules)
        {
            var rules = new Dictionary<string, HashSet<string>>(inputRules.Count());
            foreach (var rule in inputRules)
            {
                var separators = new[] { " bags contain ", ".", ", " };
                var parts = rule.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                var bagColor = parts[0].Replace(" ", string.Empty);

                string[] containedColors = null;
                if (parts[1].StartsWith("no"))
                {
                    containedColors = Array.Empty<string>();
                }
                else
                {
                    Array.Resize(ref containedColors, parts.Length - 1);
                    for (int i = 0; i < containedColors.Length; i++)
                    {
                        var bag = parts[i + 1].Split(new[] { ' ' });
                        containedColors[i] = bag[1] + bag[2];
                    }
                }

                rules.Add(bagColor, new HashSet<string>(containedColors));
            }

            return rules;
        }
    }
}

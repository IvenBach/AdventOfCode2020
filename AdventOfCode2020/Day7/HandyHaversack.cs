using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day7
{
    public class HandyHaversack
    {
        private readonly string Color;
        private readonly Dictionary<string, Dictionary<string, int>> Rules;

        /// <summary>
        /// Represents a bag which can contain other bags, which can contain other bags, which can contain ...
        /// It's bags all the way down.
        /// </summary>
        public HandyHaversack(Dictionary<string, Dictionary<string, int>> rules, string color)
        {
            Rules = rules;
            Color = color;
        }

        /// <summary>
        /// Determines whether the nested bag color is found by recursively checking each bag and
        /// its respective contents.
        /// </summary>
        /// <param name="nestedColor">The color of the nested bag.</param>
        /// <returns>Value indicating whether the bag may eventually contain the nested bag color.</returns>
        public bool CanContain(string nestedColor)
        {
            if (Rules[Color].ContainsKey(nestedColor))
            {
                return true;
            }

            var queue = new Queue<string>();

            foreach (var color in Rules[Color])
            {
                queue.Enqueue(color.Key);
            }

            var previouslyCheckedBags = new HashSet<string>() { nestedColor };

            while (queue.Count > 0)
            {
                var currentlyChecking = queue.Dequeue();

                if (!previouslyCheckedBags.Contains(currentlyChecking))
                {
                    if (Rules[currentlyChecking].ContainsKey(nestedColor))
                    {
                        return true;
                    }

                    foreach (var interiorBag in Rules[currentlyChecking])
                    {
                        if (!previouslyCheckedBags.Contains(interiorBag.Key))
                        {
                            queue.Enqueue(interiorBag.Key);
                        }
                    }

                    previouslyCheckedBags.Add(currentlyChecking);
                }
            }

            return false;
        }

        /// <summary>
        /// Calculates the total number of bags nested this bag itself contains.
        /// </summary>
        /// <returns>Number of nested bags.</returns>
        public int NestedCount()
        {
            var nested = NestedCount(1, Color);
            return nested - 1; // remove initial containing bag
        }

        private int NestedCount(int multiplier, string nestedColor)
        {
            int nestedCount = 0;
            foreach (var nestedBag in Rules[nestedColor])
            {
                nestedCount += NestedCount(multiplier * nestedBag.Value, nestedBag.Key);
            }

            //var omitFirstBagMultiplier = multiplier == 1
            //    ? 0
            //    : multiplier;

            //return nestedCount == 0
            //    ? omitFirstBagMultiplier
            //    : nestedCount + omitFirstBagMultiplier;

            return nestedCount == 0
                ? multiplier
                : nestedCount + multiplier;
        }
    }
}

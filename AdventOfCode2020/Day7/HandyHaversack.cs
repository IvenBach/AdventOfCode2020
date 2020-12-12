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
        private readonly Dictionary<string, HashSet<string>> Rules;

        /// <summary>
        /// Represents a bag which can contain other bags, which can contain other bags, which can contain ...
        /// It's bags all the way down.
        /// </summary>
        public HandyHaversack(Dictionary<string, HashSet<string>> rules, string color)
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
        public bool CanCanContain(string nestedColor)
        {
            if (Rules[Color].Contains(nestedColor))
            {
                return true;
            }

            var queue = new Queue<string>();

            foreach (var color in Rules[Color])
            {
                queue.Enqueue(color);
            }

            var previouslyCheckedBags = new HashSet<string>() { nestedColor };

            while (queue.Count > 0)
            {
                var currentlyChecking = queue.Dequeue();

                if (!previouslyCheckedBags.Contains(currentlyChecking))
                {
                    if (Rules[currentlyChecking].Contains(nestedColor))
                    {
                        return true;
                    }

                    foreach (var interiorBag in Rules[currentlyChecking])
                    {
                        if (!previouslyCheckedBags.Contains(interiorBag))
                        {
                            queue.Enqueue(interiorBag);
                        }
                    }

                    previouslyCheckedBags.Add(currentlyChecking);
                }
            }

            return false;
        }
    }
}

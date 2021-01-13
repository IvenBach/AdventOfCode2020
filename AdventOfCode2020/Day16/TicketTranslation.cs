using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day16
{
    public class TicketTranslation
    {
        private List<ValueTuple<ValueTuple<int, int>, ValueTuple<int, int>>> Constraints = new List<((int, int), (int, int))>();
        private IEnumerable<int> NearbyTickets;

        public TicketTranslation(string rawInput)
        {
            AssignBackingFields(rawInput);
        }

        private void AssignBackingFields(string rawInput)
        {
            var raw = rawInput.Split(new[] { Environment.NewLine + Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            var constraints = raw[0].Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var constraint in constraints)
            {
                Constraints.Add(ExtractBoundaries(constraint));
            }

            NearbyTickets = ExtractTickets(raw[2]);
        }

        private IEnumerable<int> ExtractTickets(string raw)
        {
            return raw.Replace(Environment.NewLine, ",")
                .Split(new[] { ":," }, StringSplitOptions.RemoveEmptyEntries)[1]
                .Split(new[] { ',' })
                .Select(s => int.Parse(s));
        }

        private ValueTuple<ValueTuple<int, int>, ValueTuple<int, int>> ExtractBoundaries(string constraint)
        {
            var vals = constraint.Split(new[] { ": ", " or ", "-" }, StringSplitOptions.RemoveEmptyEntries);
            var lowerConstraint = (int.Parse(vals[1]), int.Parse(vals[2]));
            var upperConstraint = (int.Parse(vals[3]), int.Parse(vals[4]));

            return (lowerConstraint, upperConstraint);
        }

        public int ErrorRate()
        {
            int errorRate = 0;
            foreach (var ticket in NearbyTickets)
            {
                var passesOneOrMoreConstraint = false;
                foreach (var constraint in Constraints)
                {
                    var lowerSpan = constraint.Item1;
                    var upperSpan = constraint.Item2;
                    passesOneOrMoreConstraint |= lowerSpan.Item1 <= ticket && ticket <= lowerSpan.Item2
                        || upperSpan.Item1 <= ticket && ticket <= upperSpan.Item2;
                    if (passesOneOrMoreConstraint)
                    {
                        break;
                    }
                }

                if (!passesOneOrMoreConstraint)
                {
                    errorRate += ticket;
                }                
            }

            return errorRate;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day16
{
    public class TicketTranslation
    {
        private List<TicketConstraint> Constraints = new List<TicketConstraint>();
        private Ticket[] NearbyTickets;
        private Ticket PersonalTicket;

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

            var ticketValues = raw[1].Split(new[] { Environment.NewLine, ":" }, StringSplitOptions.RemoveEmptyEntries)[1]
                .Split(new[] { ',' })
                .Select(s => int.Parse(s))
                .ToArray();
            PersonalTicket = new Ticket(ticketValues);

            NearbyTickets = ExtractTickets(raw[2]);
        }

        private Ticket[] ExtractTickets(string raw)
        {
            var arr = raw.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            var rows = arr.Length - 1;
            var tickets = new Ticket[rows];

            for (int r = 0; r < rows; r++)
            {
                tickets[r] = new Ticket(arr[r + 1]
                    .Split(new[] { ',' })
                    .Select(s => int.Parse(s))
                    .ToArray());
            }

            return tickets;
        }

        private TicketConstraint ExtractBoundaries(string constraint)
        {
            var vals = constraint.Split(new[] { ": ", " or ", "-" }, StringSplitOptions.RemoveEmptyEntries);
            var category = vals[0].Split(new[] { ':' })[0];
            var lowerConstraint = (int.Parse(vals[1]), int.Parse(vals[2]));
            var upperConstraint = (int.Parse(vals[3]), int.Parse(vals[4]));

            return new TicketConstraint(category, lowerConstraint, upperConstraint);
        }

        public int ErrorRate()
        {
            int errorRate = 0;
            foreach (var ticket in NearbyTickets)
            {
                if (!IsValidTicket(ticket, Constraints, out int? invalid))
                {
                    errorRate += invalid.Value;
                }
            }

            return errorRate;
        }

        private bool IsValidTicket(Ticket ticket, IEnumerable<TicketConstraint> constraints, out int? invalidValue)
        {
            foreach (var value in ticket.Values)
            {
                if (!PassesSingleConstraint(value))
                {
                    invalidValue = value;
                    return false;
                }
            }

            invalidValue = null;
            return true;

            bool PassesSingleConstraint(int val)
            {
                foreach (var constraint in constraints)
                {
                    if (constraint.LowerSpan.LowerValue <= val && val <= constraint.LowerSpan.UpperValue
                        || constraint.UpperSpan.LowerValue <= val && val <= constraint.UpperSpan.UpperValue)
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        public ulong DepartureValueProduct(string categoryPrefix)
        {
            var validTickets = new List<Ticket>();
            foreach (var ticket in NearbyTickets)
            {
                if (IsValidTicket(ticket, Constraints, out _))
                {
                    validTickets.Add(ticket);
                }
            }

            var categoryConstraints = Constraints.ToArray();
            var passingCategories = new List<ValueTuple<string, List<int>>>(categoryConstraints.Length);
            foreach (var categoryConstraint in categoryConstraints)
            {
                var passingIndices = new List<int>();
                for (int ticketIndex = 0; ticketIndex < NearbyTickets[0].Values.Length; ticketIndex++)
                {
                    if (AllTicketValuesPassConstraintAtIndex(categoryConstraint, ticketIndex, validTickets))
                    {
                        passingIndices.Add(ticketIndex);
                    }                    
                }

                passingCategories.Add((categoryConstraint.Category, passingIndices));
            }

            var departures = passingCategories
                .OrderBy(tuple => tuple.Item2.Count)
                .Where(tuple => tuple.Item1.StartsWith(categoryPrefix));

            var elementBeforeFirstDepartureIndex = passingCategories.Where(tuple => tuple.Item2.Count == departures.First().Item2.Count - 1);

            var indices = departures.Last().Item2.Except(elementBeforeFirstDepartureIndex.First().Item2);
            var retVal = 1UL;

            foreach (var i in indices)
            {
                retVal *= (ulong)PersonalTicket.Values[i];
            }

            return retVal;

            bool AllTicketValuesPassConstraintAtIndex(TicketConstraint constraint, int ticketIndex, List<Ticket> valdTickets)
            {
                foreach (var ticket in valdTickets)
                {
                    var ticketIndexValue = ticket.Values[ticketIndex];
                    if (!(constraint.LowerSpan.LowerValue <= ticketIndexValue && ticketIndexValue <= constraint.LowerSpan.UpperValue
                        || constraint.UpperSpan.LowerValue <= ticketIndexValue && ticketIndexValue <= constraint.UpperSpan.UpperValue))
                    {
                        return false;
                    }

                }

                return true;
            }
        }
    }
}

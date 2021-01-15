using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestsForAdventOfCode2020.Day16
{
    [TestFixture]
    public class TestTicketTranslation
    {
        [Test]
        public void Part1_sample_input_matches_expected_output()
        {
            var tt = new AdventOfCode2020.Day16.TicketTranslation(AdventOfCode2020.Inputs.Day16Part1SampleRaw);

            var actual = tt.ErrorRate();

            Assert.AreEqual(71, actual);
        }

        [Test]
        public void Part1_actual_input_matches_expected_output()
        {
            var tt = new AdventOfCode2020.Day16.TicketTranslation(AdventOfCode2020.Inputs.Day16);

            var actual = tt.ErrorRate();

            Assert.AreEqual(21071, actual);
        }

        [Test]
        public void Part2_multiplying_departure_values()
        {
            var tt = new AdventOfCode2020.Day16.TicketTranslation(AdventOfCode2020.Inputs.Day16);

            var actual = tt.DepartureValueProduct("departure");

            Assert.AreEqual(-1, actual);
        }
    }
}

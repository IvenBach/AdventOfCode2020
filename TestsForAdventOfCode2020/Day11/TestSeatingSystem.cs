using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2020.Day11;

namespace TestsForAdventOfCode2020.Day11
{
    [TestClass]
    public class TestSeatingSystem
    {
        [TestMethod]
        public void Part1_input_code_produces_expected_output()
        {
            var ss = new AdventOfCode2020.Day11.SeatingSystem(AdventOfCode2020.Inputs.Day11Sample(), OccupancyConcern.Adjacent, 4);

            var actual = ss.OccupiedSeats();

            Assert.AreEqual(37, actual);
        }

        [TestMethod]
        public void Part2_input_code_produces_expected_output()
        {
            var ss = new AdventOfCode2020.Day11.SeatingSystem(AdventOfCode2020.Inputs.Day11Sample(), OccupancyConcern.Visible, 5);

            var actual = ss.OccupiedSeats();

            Assert.AreEqual(26, actual);
        }
    }
}

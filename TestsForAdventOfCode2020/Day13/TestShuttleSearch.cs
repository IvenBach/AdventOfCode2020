using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsForAdventOfCode2020.Day13
{
    [TestClass]
    public class TestShuttleSearch
    {
        [TestMethod]
        public void Part1_output_matched_expected_value()
        {
            var ss = new AdventOfCode2020.Day13.ShuttleSearch(AdventOfCode2020.Inputs.Day13Sample());

            var (id, waitTime) = ss.EarliestBus();
            var actual = id * waitTime;

            Assert.AreEqual(295, actual);
        }

        [TestMethod]
        public void Part2_output_matches_expected_value()
        {
            var ss = new AdventOfCode2020.Day13.ShuttleSearch(AdventOfCode2020.Inputs.Day13Sample());

            var timestamp = ss.SequentialMinuteDeparture();

            Assert.AreEqual(1068781u, timestamp);
        }

        [TestMethod]
        [DataRow("-1\r\n17,x,13,19", 3417u)]
        [DataRow("-1\r\n67,7,59,61", 754018u)]
        [DataRow("-1\r\n67,x,7,59,61", 779210u)]
        [DataRow("-1\r\n67,7,x,59,61", 1261476u)]
        [DataRow("-1\r\n1789,37,47,1889", 1202161486u)]
        public void Part2_extra_examples_matches_expected(string input, uint expected)
        {
            var ss = new AdventOfCode2020.Day13.ShuttleSearch(AdventOfCode2020.Inputs.Day13Converter(input));

            var actual = ss.SequentialMinuteDeparture();

            Assert.AreEqual(expected, actual);
        }
    }
}

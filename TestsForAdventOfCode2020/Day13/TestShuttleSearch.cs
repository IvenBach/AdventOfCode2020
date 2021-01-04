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
    }
}

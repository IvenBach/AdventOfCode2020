using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsForAdventOfCode2020.Day12
{
    [TestClass]
    public class TestRainRisk
    {
        [TestMethod]
        public void Part1_example_matches_expected_output()
        {
            var rr = new AdventOfCode2020.Day12.RainRisk(AdventOfCode2020.Inputs.Day12Sample());

            var actual = rr.RectilinearDestance();

            Assert.AreEqual(25, actual);
        }
    }
}

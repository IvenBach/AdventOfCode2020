using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsForAdventOfCode2020.Day10
{
    [TestClass]
    public class TestAdapterArray
    {
        [TestMethod]
        public void Part1_input_matches_expected_output()
        {
            var aa = new AdventOfCode2020.Day10.AdapterArray(AdventOfCode2020.Inputs.Day10Sample());
            var actual = aa.JoltageDifferences();

            Assert.AreEqual(35, actual);
        }

        [TestMethod]
        public void Part1_extended_input_matches_expected_output()
        {
            var aa = new AdventOfCode2020.Day10.AdapterArray(AdventOfCode2020.Inputs.Day10ExtendedSample());
            var actual = aa.JoltageDifferences();

            Assert.AreEqual(220, actual);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsForAdventOfCode2020.Day08
{
    [TestClass]
    public class TestHandheldHalting
    {
        [TestMethod]
        public void Part1_sample_input_matches_expected_result()
        {
            var hh = new AdventOfCode2020.Day08.HandheldHalting(AdventOfCode2020.Inputs.Day8Sample());

            var actual = hh.AccumulatorValueBeforeRepeatingStatement();

            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void Part2_sample_input_matches_expected_result()
        {
            var hh = new AdventOfCode2020.Day08.HandheldHalting(AdventOfCode2020.Inputs.Day8Sample());
            var actual = hh.ExecutionConcludesNormally();

            Assert.AreEqual( 8, actual);
        }
    }
}

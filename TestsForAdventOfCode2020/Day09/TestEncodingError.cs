using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsForAdventOfCode2020.Day09
{
    [TestClass]
    public class TestEncodingError
    {
        [TestMethod]
        public void Part1_output_matches_expected_on_sample()
        {
            var ee = new AdventOfCode2020.Day09.EncodingError(AdventOfCode2020.Inputs.Day9Sample());

            var actual = ee.FirstNumberNotComposedOfPreviousNumbers(5);

            Assert.AreEqual(127, actual);
        }

        [TestMethod]
        public void Part2_output_matches_expected_on_sample()
        {
            var ee = new AdventOfCode2020.Day09.EncodingError(AdventOfCode2020.Inputs.Day9Sample());
            const int preambleLength = 5;
            var part1 = ee.FirstNumberNotComposedOfPreviousNumbers(preambleLength);
            var actual = ee.Sum_of_values_that_equals_the_answer_in_part1_subsequently_summing_smallest_and_largest_elements(preambleLength, part1);

            Assert.AreEqual(62, actual);
        }
    }
}

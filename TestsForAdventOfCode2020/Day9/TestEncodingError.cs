using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsForAdventOfCode2020.Day9
{
    [TestClass]
    public class TestEncodingError
    {
        [TestMethod]
        public void Part1_output_matches_expected_on_sample()
        {
            var ee = new AdventOfCode2020.Day9.EncodingError(AdventOfCode2020.Inputs.Day9Sample());

            var actual = ee.FirstNumberNotComposedOfPreviousNumbers(5);

            Assert.AreEqual(127, actual);
        }
    }
}

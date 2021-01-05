using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsForAdventOfCode2020.Day14
{
    [TestClass]
    public class TestDockingData
    {
        [TestMethod]
        [DataRow(0b1011, 0b1001001)]
        [DataRow(0b1100101, 0b1100101)]
        [DataRow(0b0, 0b1000000)]
        public void Sample_mask_converts_given_number_to_expected(int given, int expected)
        {
            var input = new[]
            {
                "mask = " + AdventOfCode2020.Inputs.Day14SampleMask,
                "mem[8] = " + given.ToString()
            };
            var dd = new AdventOfCode2020.Day14.DockingData(input);

            var actual = dd.SumValues();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sample_inputs_match_expected_output()
        {
            var dd = new AdventOfCode2020.Day14.DockingData(AdventOfCode2020.Inputs.Day14Sample());

            var actual = dd.SumValues();

            Assert.AreEqual(165, actual);
        }
    }
}

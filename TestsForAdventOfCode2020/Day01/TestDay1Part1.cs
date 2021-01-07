using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestsForAdventOfCode2020.Day01
{
    [TestClass]
    public class TestDay1Part1
    {
        [TestMethod]
        [DataRow(new int[3] { 5, 2019, 1 })]
        public void SumTo2020_having_pair_returns_expected_results(IEnumerable<int> values)
        {
            var actual = AdventOfCode2020.Day01.Day1Part1.SumTo2020(values);

            Assert.AreEqual((1, 2019), actual);
        }

        [TestMethod]
        [DataRow(new int[] { })]
        [DataRow(new int[3] { 1, 1, 1 })]
        public void SumTo2020_has_no_pair_returns_default_values(IEnumerable<int> values)
        {
            var actual = AdventOfCode2020.Day01.Day1Part1.SumTo2020(values);

            Assert.AreEqual((0, 0), actual);
        }
    }
}

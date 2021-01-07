using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2020.Day01;

namespace TestsForAdventOfCode2020.Day01
{
    [TestClass]
    public class TestDay1Part2
    {
        [TestMethod]
        [DataRow(new int[] { 3, 4, 5 ,6 ,7, 2017, 1, 2 })]
        public void SumTo2020_having_triplet_returns_expected_results(IEnumerable<int> values)
        {
            var actual = Day1Part2.SumTo2020(values);

            Assert.AreEqual((1, 2, 2017), actual);
        }

        [TestMethod]
        [DataRow(new int[] { })]
        public void SumTo2020_not_having_triplet_returns_default_values(IEnumerable<int> values)
        {
            var actual = Day1Part2.SumTo2020(values);

            Assert.AreEqual((0, 0, 0), actual);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsForAdventOfCode2020.Day6
{
    [TestClass]
    public class TestCustomsDeclaration
    {
        [TestMethod]
        public void Part1_input_produces_exected_result()
        {
            var groups = AdventOfCode2020.Day6.CustomsDeclaration.ConvertToGroups(SampleInput());
            var actual = AdventOfCode2020.Day6.CustomsDeclaration.CountWhereAnyoneAnsweredTrue(groups);

            Assert.AreEqual(11, actual);
        }

        [TestMethod]
        [DataRow("abc", 3)]
        [DataRow("aaaaa", 1)]
        public void Count_matches_distinct_values(string input, int expected)
        {
            var cd = new AdventOfCode2020.Day6.CustomsDeclaration(input);

            var actual = cd.TrueAnswerCount;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Part2_input_produces_expected_result()
        {
            var groups = AdventOfCode2020.Day6.CustomsDeclaration.ConvertToGroups(SampleInput());
            var actual = AdventOfCode2020.Day6.CustomsDeclaration.CountWhereEveryoneInGroupAnsweredYes(groups);
            Assert.AreEqual(6, actual);
        }

        private string SampleInput() => @"abc

a
b
c

ab
ac

a
a
a
a

b";
    }
}

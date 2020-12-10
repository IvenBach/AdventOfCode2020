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
        public void Example_input_produces_exected_result()
        {
            const string input = @"abc

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

            var groups = AdventOfCode2020.Day6.CustomsDeclaration.ConvertRawInput(input);
            var actual = AdventOfCode2020.Day6.CustomsDeclaration.GroupCount(groups);

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
    }
}

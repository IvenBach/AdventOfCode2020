using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestsForAdventOfCode2020.Day18
{
    [TestFixture]
    public class TestOperationOrder
    {
        [Test]
        [TestCase("1 + 2 * 3 + 4 * 5 + 6", 71)]
        [TestCase("(2 * 3)", 6)]
        [TestCase("1 + (2 * 3)", 7)]
        [TestCase("2 * 3 + (4 * 5)", 26)]
        [TestCase("5 + (8 * 3 + 9 + 3 * 4 * 3)", 437)]
        [TestCase("5 * 9 * (7 * 3 * 3 + 9 * 3 + (8 + 6 * 4))", 12240)]
        [TestCase("((2 + 4 * 9) * (6 + 9 * 8 + 6) + 6) + 2 + 4 * 2", 13632)]
        [TestCase("3 + (6 * 9 * (4 * 4) * (7 + 2 + 9 * 3 + 5 + 8)) + (3 * (6 + 7 * 4 + 9 * 8) + 3 * 5 + 9 * (5 + 9))", 160707)]
        public void Part1_examples_produce_expected_output(string input, int expected)
        {
            var oo = new AdventOfCode2020.Day18.OperationOrder(new List<string>() { input }); ;

            var actual = oo.EvaluationSum();

            Assert.AreEqual(expected, actual);
        }
    }
}

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
        [TestCase("1 + 2 * 3 + 4 * 5 + 6", 71)]
        [TestCase("(2 * 3)", 6)]
        [TestCase("1 + (2 * 3)", 7)]
        [TestCase("1 + (2 * 3) + (4 * (5 + 6))", 51)]
        [TestCase("2 * 3 + (4 * 5)", 26)]
        [TestCase("5 + (8 * 3 + 9 + 3 * 4 * 3)", 437)]
        [TestCase("5 * 9 * (7 * 3 * 3 + 9 * 3 + (8 + 6 * 4))", 12240)]
        [TestCase("((2 + 4 * 9) * (6 + 9 * 8 + 6) + 6) + 2 + 4 * 2", 13632)]
        [TestCase("3 + (6 * 9 * (4 * 4) * (7 + 2 + 9 * 3 + 5 + 8)) + (3 * (6 + 7 * 4 + 9 * 8) + 3 * 5 + 9 * (5 + 9))", 160707)]
        public void Part1_examples_produce_expected_output(string input, int expected)
        {
            var precedence = new Dictionary<char, int>()
            {
                { '+', 1 },
                { '*', 1 }
            };

            var oo = new AdventOfCode2020.Day18.OperationOrder(new List<string>() { input }, precedence);

            var actual = oo.EvaluationSum();

            Assert.AreEqual(expected, actual);
        }

        [TestCase("1 + 2 * 3 + 4 * 5 + 6", 231UL)]
        [TestCase("1 + (2 * 3) + (4 * (5 + 6))", 51UL)]
        [TestCase("2 * 3 + (4 * 5)", 46UL)]
        [TestCase("5 + (8 * 3 + 9 + 3 * 4 * 3)", 1445UL)]
        [TestCase("5 * 9 * (7 * 3 * 3 + 9 * 3 + (8 + 6 * 4))", 669060UL)]
        [TestCase("((2 + 4 * 9) * (6 + 9 * 8 + 6) + 6) + 2 + 4 * 2", 23340UL)]
        [TestCase("3 * 4 * 2 * 5 * (3 + 4 * (6 + 3 + 2 + 8 + 4) + 5 * 7)", 164640UL)]
        [TestCase("8 * 4 * (3 * 2 + 2 + (6 + 9 * 8 + 4 * 5) + (6 + 8 + 4 + 5 + 7 * 3)) + 9 * 6 * ((6 + 4 * 9 * 7 + 7 + 2) * 8 * (3 + 6) + 6 + (3 + 2 + 9 + 5) * 4)", 899723427840UL)]
        [TestCase("((7 + 9 * 5 + 6 + 6 + 7) + 3 + (8 * 8 + 8 + 4 + 4 + 4) + 5 + 6 + 6) * 2 + 6 * (5 * 3 * 6 * (3 * 8 + 9 + 5 * 6) + 2) + ((7 * 3 + 9 + 5) * 3 * 7) + 8", 192554848UL)]
        public void Part2_examples_produce_expected_output(string input, ulong expected)
        {
            var precedence = new Dictionary<char, int>()
            {
                { '+', 2 },
                { '*', 1 }
            };

            var oo = new AdventOfCode2020.Day18.OperationOrder(new List<string>() { input }, precedence);

            var actual = oo.EvaluationSum();

            Assert.AreEqual(expected, actual);
        }
    }
}

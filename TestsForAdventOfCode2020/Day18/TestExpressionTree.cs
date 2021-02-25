using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestsForAdventOfCode2020.Day18
{
    [TestFixture]
    public class TestExpressionTree
    {
        [TestCase("1+2", 3)]
        public void Simple_addition_matches_expected_value(string input, int expected)
        {
            var root = AdventOfCode2020.Day18.Node.BuildTree(input, null);

            var actual = AdventOfCode2020.Day18.Node.Evaluate(root);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("1+2*5", 11)]
        [TestCase("4+6*(2+3)", 34)]
        public void Standard_operator_precedence_matches_expected_value(string input, int expected)
        {
            var root = AdventOfCode2020.Day18.Node.BuildTree(input, null);

            var actual = AdventOfCode2020.Day18.Node.Evaluate(root);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("1 + 2", 3)]
        public void Equation_evaluation_including_spaces_does_not_throw_error(string input, int expected)
        {
            var root = AdventOfCode2020.Day18.Node.BuildTree(input, null);
            var acutal = AdventOfCode2020.Day18.Node.Evaluate(root);

            Assert.AreEqual(expected, acutal);
        }

        [TestCase("1+2*3", 9)]
        [TestCase("4 + 6 * (2 + 3)", 50)]
        [TestCase("1 + 2 * 3 + 4 * 5 + 6", 71)]
        public void Addition_and_multiplication_with_equal_precedence_produce_expected_result(string input, int expected)
        {
            var priority = new Dictionary<char, int>() { { '+', 1 }, { '*', 1 } };
            var root = AdventOfCode2020.Day18.Node.BuildTree(input, priority);
            var actual = AdventOfCode2020.Day18.Node.Evaluate(root);

            Assert.AreEqual(expected, actual);
        }
    }
}

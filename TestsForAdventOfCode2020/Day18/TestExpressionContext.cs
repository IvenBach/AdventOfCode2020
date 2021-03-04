using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode2020.Day18.MDoerner_Example;
using NUnit.Framework;

namespace TestsForAdventOfCode2020.Day18
{
    [TestFixture]
    public class TestExpressionContext
    {
        [TestCase("3 + 2 * 5", 25UL)]
        [TestCase("3 * 4 * 2 * 5 * (3 + 4 * (6 + 3 + 2 + 8 + 4) + 5 + 7)", 20760UL)]
        [TestCase("3 * 4 * 2 * 5 * (3 + 4 * (6 + 3 + 2 + 8 + 4) + 5 * 7)", 139440UL)]
        public void Expression_evaluated_with_addition_and_multiplication_having_same_precedence_matches_expected_value(string input, ulong expected)
        {
            var parser = new AdventOfCode2020.Day18.MDoerner_Example.Parser.Concrete.Parser();
            var expression = parser.Parse(input);
            var precedence = new Dictionary<char, int>()
            {
                { '+', 1 },
                { '*', 1 }
            };

            var actual = expression.Evaluate(precedence);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("3 + 2 * 5", 25UL)]
        public void Expression_evaluated_with_addition_before_multiplication_matches_expected_value(string input, ulong expected)
        {
            var parser = new AdventOfCode2020.Day18.MDoerner_Example.Parser.Concrete.Parser();
            var expression = parser.Parse(input);
            var precedence = new Dictionary<char, int>()
            {
                { '+', 2 },
                { '*', 1 }
            };

            var actual = expression.Evaluate(precedence);

            Assert.AreEqual(expected, actual);
        }
    }
}

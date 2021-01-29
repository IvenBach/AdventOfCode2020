using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestsForAdventOfCode2020.Day18
{
    [TestFixture]
    public class TestShuntingYardAlgorithm
    {
        [TestCaseSource(nameof(Standard_precedence))]
        public void Standard_operator_precedence_produces_expected_result((string input, int expected) tuple)
        {
            var precedence = new Dictionary<char, int>
            {
                { '+', 1 },
                { '*', 2 }
            };

            var output = AdventOfCode2020.Day18.ShuntingYardAlgorithm.Execute(tuple.input, precedence);
            var actual = AdventOfCode2020.Day18.ReversePolishNotationEvaluator.Evaluate(output);

            Assert.AreEqual(tuple.expected, actual);
        }

        private static IEnumerable<(string Input, int expected)> Standard_precedence()
        {
            var values = new List<(string, int)>
            {
                ("4 + 6 / (9 - 3)", 5),
                ("1 + (2 * 3) + (4 * (5 + 6))", 51)
            };

            return values;
        }

        [TestCaseSource(nameof(Addition_and_multiplication_have_same_precedence))]
        public void Addition_and_Multiplication_with_same_precedence_produces_expected_result((string input, int expected) tuple)
        {
            var precedence = new Dictionary<char, int>
            {
                { '+', 1 },
                { '*', 1 }
            };

            var output = AdventOfCode2020.Day18.ShuntingYardAlgorithm.Execute(tuple.input, precedence);
            var actual = AdventOfCode2020.Day18.ReversePolishNotationEvaluator.Evaluate(output);

            Assert.AreEqual(tuple.expected, actual);
        }

        private static IEnumerable<(string Input, int Expected)> Addition_and_multiplication_have_same_precedence()
        {
            var values = new List<(string, int)>
            {
                ("4 + 6 * (2 + 3)", 50),
                ("1 + 2 * 3 + 4 * 5 + 6", 71)
            };
            return values;
        }

        [TestCaseSource(nameof(Addition_has_higher_precedence_than_multiplication))]
        public void When_addition_has_higher_precedence_than_multiplication_produces_expected_result((string input, int expected) tuple)
        {
            var precedence = new Dictionary<char, int>
            {
                { '+', 2 },
                { '*', 1 }
            };

            var output = AdventOfCode2020.Day18.ShuntingYardAlgorithm.Execute(tuple.input, precedence);
            var actual = AdventOfCode2020.Day18.ReversePolishNotationEvaluator.Evaluate(output);

            Assert.AreEqual(tuple.expected, actual);
        }

        private static IEnumerable<(string Input, int Expected)> Addition_has_higher_precedence_than_multiplication()
        {
            var values = new List<(string, int)>
            {
                ("4 + 6 * (4 * 2 + 3)", 200),
                ("1 + 2 * 3 + 4 * 5 + 6", 231),
                ("6 + 7 * 7 * 3 + 8 + 8", 1729),
                ("8 * 4 * ((4 + 7 * 7 * 7 + 4) * 8 + 3 * 6 * 5) * 9", 80498880)
            };
            return values;
        }
    }
}

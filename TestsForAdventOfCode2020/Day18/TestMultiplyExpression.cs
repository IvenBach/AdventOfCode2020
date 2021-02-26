using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AdventOfCode2020.Day18.Expressions.Abstract;
using AdventOfCode2020.Day18.Expressions.Concrete;

namespace TestsForAdventOfCode2020.Day18
{
    [TestFixture]
    public class TestMultiplyExpression
    {
        [TestCase(null, 1)]
        [TestCase(1, null)]
        [TestCase(null, null)]
        public void Error_thrown_when_null_argument_provided(object untypedLeft, object untypedRight)
        {
            try
            {
                Expression typedLeft = untypedLeft != null ? new IntegerExpression((int)untypedLeft) : null;
                Expression typedRight = untypedRight != null ? new IntegerExpression((int)untypedRight) : null;
                new AddExpression(typedLeft, typedRight);
            }
            catch (ArgumentNullException)
            {
                Assert.Pass();
                return;
            }

            Assert.Fail();
        }

        [TestCase(3, 5, 15)]
        [TestCase(3, -5, -15)]
        [TestCase(-3, 5, -15)]
        [TestCase(-3, -5, 15)]
        public void Values_match_expected(int left, int right, int expected)
        {
            var expr = new MultiplyExpression(new IntegerExpression(left), new IntegerExpression(right));
            var actual = expr.Value();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 5, "3*5")]
        [TestCase(-3, 5, "-3*5")]
        [TestCase(3, -5, "3*-5")]
        [TestCase(-3, -5, "-3*-5")]
        public void Text_matches_expected(int left, int right, string expected)
        {
            var expr = new MultiplyExpression(new IntegerExpression(left), new IntegerExpression(right));
            var actual = expr.GetText();

            Assert.AreEqual(expected, actual);
        }
    }
}

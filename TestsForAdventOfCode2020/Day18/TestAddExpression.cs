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
    public class TestAddExpression
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

        [TestCase]
        public void Value_matches_expected()
        {
            var expr = new AddExpression(new IntegerExpression(1), new IntegerExpression(2));
            var actual = expr.Value();
            Assert.AreEqual(3, actual);
        }

        [TestCase(10, 1, "10+1")]
        [TestCase(10, -1, "10-1")]
        [TestCase(-10, -1, "-10-1")]
        [TestCase(-10, 1, "-10+1")]
        public void Text_matches_expected(int left, int right, string expected)
        {
            var expr = new AddExpression(new IntegerExpression(left), new IntegerExpression(right));
            var actual = expr.GetText();

            Assert.AreEqual(expected, actual);
        }
    }
}

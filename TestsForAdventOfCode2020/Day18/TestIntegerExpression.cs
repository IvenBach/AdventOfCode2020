using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AdventOfCode2020.Day18.Expressions.Concrete;

namespace TestsForAdventOfCode2020.Day18
{
    [TestFixture]
    public class TestIntegerExpression
    {
        [TestCase]
        public void IntegerExpression_created()
        {
            var expr = new IntegerExpression(5);

            Assert.IsTrue(expr != null);
        }

        [TestCase]
        public void Value_returns_expected_value()
        {
            var expr = new IntegerExpression(3);

            Assert.AreEqual(3, expr.Value());
        }
    }
}

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
    public class TestParenthesizedExpression
    {
        [TestCase]
        public void Error_thrown_when_null_argument_provided()
        {
            try
            {
                var expr = new ParenthesizedExpression(null);
            }
            catch (ArgumentNullException)
            {
                Assert.Pass();
                return;
            }

            Assert.Fail();            
        }

        [TestCase]
        public void Text_matches_expected()
        {
            var expr = new ParenthesizedExpression(new AddExpression(new IntegerExpression(5), new IntegerExpression(4)));
            var actual = expr.GetText();

            Assert.AreEqual("(5+4)", actual);
        }
    }
}

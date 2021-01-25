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
        public void Part1_examples_produce_expected_output(string input, int expected)
        {
            var oo = new AdventOfCode2020.Day18.OperationOrder(new List<string>() { input }); ;

            var actual = oo.EvaluationSum();

            Assert.AreEqual(expected, actual);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestsForAdventOfCode2020.Day18
{
    [TestFixture]
    public class TestReversePolishNotationEvaluator
    {
        [TestCaseSource(nameof(Source))]
        public void Input_matches_output((Queue<char> input, int expected) tuple)
        {
            var actual = AdventOfCode2020.Day18.ReversePolishNotationEvaluator.Evaluate(tuple.input);

            Assert.AreEqual(tuple.expected, actual);
        }
        
        private static IEnumerable<(Queue<char> input, int expected)> Source()
        {
            var values = new List<(Queue<char>, int)>();
            
            var first = new Queue<char>();
            first.Enqueue('1');
            first.Enqueue('1');
            first.Enqueue('+');
            values.Add((first, 2));


            var second = new Queue<char>();
            second.Enqueue('1');
            second.Enqueue('2');
            second.Enqueue('3');
            second.Enqueue('x');
            second.Enqueue('+');
            second.Enqueue('4');
            second.Enqueue('5');
            second.Enqueue('6');
            second.Enqueue('+');
            second.Enqueue('x');
            second.Enqueue('+');
            values.Add((second, 51));


            return values;
        }
    }
}

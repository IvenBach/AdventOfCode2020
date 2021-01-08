using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestsForAdventOfCode2020.Day15
{
    [TestFixture]
    public class TestRambunctiousRecitation
    {
        [Test]
        [TestCase("0,3,6", 4, 0)]
        [TestCase("0,3,6", 5, 3)]
        [TestCase("0,3,6", 6, 3)]
        [TestCase("0,3,6", 7, 1)]
        [TestCase("0,3,6", 8, 0)]
        [TestCase("0,3,6", 9, 4)]
        [TestCase("0,3,6", 10, 0)]
        [TestCase("0,3,6", 11, 2)]
        [TestCase("0,3,6", 12, 0)]
        [TestCase("0,3,6", 2020, 436)]
        [TestCase("1,3,2", 4, 0)]
        [TestCase("1,3,2", 5, 0)]
        [TestCase("1,3,2", 6, 1)]
        [TestCase("1,3,2", 7, 5)]
        [TestCase("1,3,2", 8, 0)]
        [TestCase("1,3,2", 9, 3)]
        [TestCase("1,3,2", 10, 7)]
        [TestCase("1,3,2", 2020, 1)]
        [TestCase("2,1,3", 4, 0)]
        [TestCase("2,1,3", 5, 0)]
        [TestCase("2,1,3", 6, 1)]
        [TestCase("2,1,3", 7, 4)]
        [TestCase("2,1,3", 8, 0)]
        [TestCase("2,1,3", 9, 3)]
        [TestCase("2,1,3", 10, 6)]
        [TestCase("2,1,3", 11, 0)]
        [TestCase("2,1,3", 2020, 10)]
        [TestCase("1,2,3", 2020, 27)]
        [TestCase("2,3,1", 2020, 78)]
        [TestCase("3,2,1", 2020, 438)]
        [TestCase("3,1,2", 2020, 1836)]
        public void Part1_turns_match_expected(string input, int turn, int expected)
        {
            var rr = new AdventOfCode2020.Day15.RambunctiousRecitation(input.Split(new[] { ',' }).Select(s => int.Parse(s)));

            var actual = rr.NthSpokenNumber(turn);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase("0,3,6", 30000000, 175594)]
        [TestCase("1,3,2", 30000000, 2578)]
        [TestCase("2,1,3", 30000000, 3544142)]
        [TestCase("1,2,3", 30000000, 261214)]
        [TestCase("2,3,1", 30000000, 6895259)]
        [TestCase("3,2,1", 30000000, 18)]
        [TestCase("3,1,2", 30000000, 362)]

        public void Part2_turns_match_expected(string input, int turn, int expected)
        {
            var rr = new AdventOfCode2020.Day15.RambunctiousRecitation(input.Split(new[] { ',' }).Select(s => int.Parse(s)));

            var actual = rr.NthSpokenNumber(turn);

            Assert.AreEqual(expected, actual);
        }
    }
}

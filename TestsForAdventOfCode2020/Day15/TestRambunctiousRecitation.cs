using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsForAdventOfCode2020.Day15
{
    [TestClass]
    public class TestRambunctiousRecitation
    {
        [TestMethod]
        [DataRow("0,3,6", 4, 0)]
        [DataRow("0,3,6", 5, 3)]
        [DataRow("0,3,6", 6, 3)]
        [DataRow("0,3,6", 7, 1)]
        [DataRow("0,3,6", 8, 0)]
        [DataRow("0,3,6", 9, 4)]
        [DataRow("0,3,6", 10, 0)]
        [DataRow("0,3,6", 11, 2)]
        [DataRow("0,3,6", 12, 0)]
        [DataRow("0,3,6", 2020, 436)]
        public void Part1_turns_match_expected(string input, int turn, int expected)
        {
            var rr = new AdventOfCode2020.Day15.RambunctiousRecitation(input.Split(new[] { ',' }).Select(s => int.Parse(s)));

            var actual = rr.NthSpokenNumber(turn);

            Assert.AreEqual(expected, actual);
        }
    }
}

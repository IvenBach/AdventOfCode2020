using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2020;

namespace TestsForAdventOfCode2020.Day05
{
    [TestClass]
    public class TestBinaryBoarding
    {
        [TestMethod]
        [DataRow("FBFBBFFRLR", 44, 5, 357)]

        [DataRow("BFFFBBFRRR", 70, 7, 567)]
        [DataRow("FFFBBBFRRR", 14, 7, 119)]
        [DataRow("BBFFBBFRLL", 102, 4, 820)]
        public void Inputs_return_expected_result(string input, int row, int column, int seat)
        {
            var binaryBoarding = new AdventOfCode2020.Day05.BinaryBoarding(input);

            Assert.AreEqual(row, binaryBoarding.Row);
            Assert.AreEqual(column, binaryBoarding.Column);
            Assert.AreEqual(seat, binaryBoarding.Seat);
        }

        [TestMethod]
        [DataRow("FBFBBFFRL")]
        [DataRow("FBFBBFFRLRR")]
        public void Incorrect_input_length_throws_exception(string input)
        {
            try
            {
                var bb = new AdventOfCode2020.Day05.BinaryBoarding(input);
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.IsTrue(true);
                return;
            }

            Assert.Fail();
        }

        [TestMethod]
        [DataRow("FFFFFFFLLA")]
        public void Input_containing_unacceptable_characters_throws_exception(string input)
        {
            try
            {
                var bb = new AdventOfCode2020.Day05.BinaryBoarding(input);
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.IsTrue(true);
                return;
            }

            Assert.Fail();
        }

        [TestMethod]
        public void Null_input_throws_exception()
        {
            try
            {
                var bb = new AdventOfCode2020.Day05.BinaryBoarding(null);
            }
            catch (ArgumentNullException)
            {
                Assert.IsTrue(true);
                return;
            }

            Assert.Fail();
        }
    }
}

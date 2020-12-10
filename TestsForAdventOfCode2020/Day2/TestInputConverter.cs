using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsForAdventOfCode2020.Day2
{
    [TestClass]
    public class TestInputConverter
    {
        [TestMethod]
        public void InputConverter_converts_input_string_into_parts()
        {
            const string input = "1 - 3 m: wmmmmmttm";

            var converter = new AdventOfCode2020.Day2.InputConverter(input);

            Assert.AreEqual(1, converter.MinimumQuantity);
            Assert.AreEqual(3, converter.MaximumQuantity);
            Assert.AreEqual('m', converter.Character);
            Assert.AreEqual("wmmmmmttm", converter.Password);
        }
    }
}

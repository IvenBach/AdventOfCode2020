using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsForAdventOfCode2020.Day02
{
    [TestClass]
    public class TestPasswordValidator
    {
        [TestMethod]
        [DataRow("1 - 3 m: wmmmmmttm", false)]
        [DataRow("2 - 4 p: pgppp", true)]
        [DataRow("0 - 1 c: ody", true)]
        [DataRow("0 - 1 c: cody", true)]
        [DataRow("0 - 1 c: ccody", false)]
        public void Results_match_expected_values(string input, bool expected)
        {
            var converter = new AdventOfCode2020.Day02.InputConverter(input);
            var validator = new AdventOfCode2020.Day02.PasswordValidator(converter);

            var actual = validator.Part1IsValid();

            Assert.AreEqual(expected, actual);
        }
    }
}

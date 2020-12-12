using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode2020.Day7;

namespace TestsForAdventOfCode2020.Day7
{
    [TestClass]
    public class TestHaversackRuleConverter
    {
        [TestMethod]
        public void Output_matches_answer_for_example_input()
        {
            var rules = HaversackRuleConverter.ConvertToRules(Input);

            var redBag = rules["lightred"];
            Assert.AreEqual(2, redBag.Count);
            Assert.IsTrue(redBag.Contains("brightwhite"));
            Assert.IsTrue(redBag.Contains("mutedyellow"));

            var darkorange = rules["darkorange"];
            Assert.AreEqual(2, darkorange.Count);
            Assert.IsTrue(darkorange.Contains("brightwhite"));
            Assert.IsTrue(darkorange.Contains("mutedyellow"));

            var brightwhite = rules["brightwhite"];
            Assert.AreEqual(1, brightwhite.Count);
            Assert.IsTrue(brightwhite.Contains("shinygold"));

            var mutedyellow = rules["mutedyellow"];
            Assert.AreEqual(2, mutedyellow.Count);
            Assert.IsTrue(mutedyellow.Contains("shinygold"));
            Assert.IsTrue(mutedyellow.Contains("fadedblue"));

            var shinygold = rules["shinygold"];
            Assert.AreEqual(2, shinygold.Count);
            Assert.IsTrue(shinygold.Contains("darkolive"));
            Assert.IsTrue(shinygold.Contains("vibrantplum"));

            var darkolive = rules["darkolive"];
            Assert.AreEqual(2, darkorange.Count);
            Assert.IsTrue(darkolive.Contains("fadedblue"));
            Assert.IsTrue(darkolive.Contains("dottedblack"));

            var vibrantplum = rules["vibrantplum"];
            Assert.AreEqual(2, vibrantplum.Count);
            Assert.IsTrue(vibrantplum.Contains("fadedblue"));
            Assert.IsTrue(vibrantplum.Contains("dottedblack"));

            var fadedblue = rules["fadedblue"];
            Assert.AreEqual(0, fadedblue.Count);

            var dottedblack = rules["dottedblack"];
            Assert.AreEqual(0, dottedblack.Count);
        }

        private string[] Input => @"light red bags contain 1 bright white bag, 2 muted yellow bags.
dark orange bags contain 3 bright white bags, 4 muted yellow bags.
bright white bags contain 1 shiny gold bag.
muted yellow bags contain 2 shiny gold bags, 9 faded blue bags.
shiny gold bags contain 1 dark olive bag, 2 vibrant plum bags.
dark olive bags contain 3 faded blue bags, 4 dotted black bags.
vibrant plum bags contain 5 faded blue bags, 6 dotted black bags.
faded blue bags contain no other bags.
dotted black bags contain no other bags.".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
    }
}

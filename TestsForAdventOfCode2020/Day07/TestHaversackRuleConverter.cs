using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode2020.Day07;

namespace TestsForAdventOfCode2020.Day07
{
    [TestClass]
    public class TestHaversackRuleConverter
    {
        [TestMethod]
        public void Output_matches_answer_for_example_input()
        {
            var rules = HaversackRuleConverter.ConvertToRules(Input);
            const string lightRed = "lightred";
            const string brightWhite = "brightwhite";
            const string mutedYellow = "mutedyellow";
            const string darkOrange = "darkorange";
            const string shinyGold = "shinygold";
            const string fadedBlue = "fadedblue";
            const string darkOlive = "darkolive";
            const string vibrantPlum = "vibrantplum";
            const string dottedBlack = "dottedblack";

            var redBag = rules[lightRed];
            Assert.AreEqual(2, redBag.Count);
            Assert.AreEqual(1, redBag[brightWhite]);
            Assert.AreEqual(2, redBag[mutedYellow]);

            var darkorange = rules[darkOrange];
            Assert.AreEqual(2, darkorange.Count);
            Assert.AreEqual(3, darkorange[brightWhite]);
            Assert.AreEqual(4, darkorange[mutedYellow]);

            var brightwhite = rules[brightWhite];
            Assert.AreEqual(1, brightwhite.Count);
            Assert.AreEqual(1, brightwhite[shinyGold]);

            var mutedyellow = rules[mutedYellow];
            Assert.AreEqual(2, mutedyellow.Count);
            Assert.AreEqual(2, mutedyellow[shinyGold]);
            Assert.AreEqual(9, mutedyellow[fadedBlue]);

            var shinygold = rules[shinyGold];
            Assert.AreEqual(2, shinygold.Count);
            Assert.AreEqual(1, shinygold[darkOlive]);
            Assert.AreEqual(2, shinygold[vibrantPlum]);

            var darkolive = rules[darkOlive];
            Assert.AreEqual(2, darkorange.Count);
            Assert.AreEqual(3, darkolive[fadedBlue]);
            Assert.AreEqual(4, darkolive[dottedBlack]);

            var vibrantplum = rules[vibrantPlum];
            Assert.AreEqual(2, vibrantplum.Count);
            Assert.AreEqual(5, vibrantplum[fadedBlue]);
            Assert.AreEqual(6, vibrantplum[dottedBlack]);

            var fadedblue = rules[fadedBlue];
            Assert.AreEqual(0, fadedblue.Count);

            var dottedblack = rules[dottedBlack];
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

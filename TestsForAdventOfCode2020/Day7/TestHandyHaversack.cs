using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsForAdventOfCode2020.Day7
{
    [TestClass]
    public class TestHandyHaversack
    {
        [TestMethod]
        [DataRow("brightwhite", "shinygold", true)]
        [DataRow("mutedyellow", "shinygold", true)]
        [DataRow("darkorange", "shinygold", true)]
        [DataRow("lightred", "shinygold", true)]
        [DataRow("darkolive", "shinygold", false)]
        [DataRow("vibrantplum", "shinygold", false)]
        public void Bag_eventually_contains_nested_color(string outterColor, string nestedColor, bool expected)
        {
            var rules = AdventOfCode2020.Day7.HaversackRuleConverter.ConvertToRules(Inputs);
            var initialBag = new AdventOfCode2020.Day7.HandyHaversack(rules, outterColor);

            Assert.AreEqual(expected, initialBag.CanCanContain(nestedColor));
        }

        private string[] Inputs => @"light red bags contain 1 bright white bag, 2 muted yellow bags.
dark orange bags contain 3 bright white bags, 4 muted yellow bags.
bright white bags contain 1 shiny gold bag.
muted yellow bags contain 2 shiny gold bags, 9 faded blue bags.
shiny gold bags contain 1 dark olive bag, 2 vibrant plum bags.
dark olive bags contain 3 faded blue bags, 4 dotted black bags.
vibrant plum bags contain 5 faded blue bags, 6 dotted black bags.
faded blue bags contain no other bags.
dotted black bags contain no other bags."
        .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
    }
}

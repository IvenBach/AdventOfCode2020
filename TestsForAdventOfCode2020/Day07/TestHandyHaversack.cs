using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsForAdventOfCode2020.Day07
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
            var rules = AdventOfCode2020.Day07.HaversackRuleConverter.ConvertToRules(Part1Input);
            var initialBag = new AdventOfCode2020.Day07.HandyHaversack(rules, outterColor);

            var actual = initialBag.CanContain(nestedColor);

            Assert.AreEqual(expected, actual );
        }

        [TestMethod]
        public void Part2_outputs_match_provided_example()
        {
            var rules = AdventOfCode2020.Day07.HaversackRuleConverter.ConvertToRules(Part2Input);
            var bag = new AdventOfCode2020.Day07.HandyHaversack(rules, "shinygold");
            
            var actual = bag.NestedCount();

            Assert.AreEqual(126, actual);
        }

        [TestMethod]
        [DataRow("darkviolet", 0)]
        [DataRow("darkblue", 2)]
        [DataRow("darkgreen", 6)]
        [DataRow("darkyellow", 14)]
        [DataRow("darkorange", 30)]
        [DataRow("darkred", 62)]
        [DataRow("shinygold", 126)]
        public void Part2_colored_bag_contains_expected_ammount(string color, int expected)
        {
            var rules = AdventOfCode2020.Day07.HaversackRuleConverter.ConvertToRules(Part2Input);
            var bag = new AdventOfCode2020.Day07.HandyHaversack(rules, color);

            var actual = bag.NestedCount();

            Assert.AreEqual(expected, actual);
        }

        private string[] Part2Input => @"shiny gold bags contain 2 dark red bags.
dark red bags contain 2 dark orange bags.
dark orange bags contain 2 dark yellow bags.
dark yellow bags contain 2 dark green bags.
dark green bags contain 2 dark blue bags.
dark blue bags contain 2 dark violet bags.
dark violet bags contain no other bags.".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

        private string[] Part1Input => @"light red bags contain 1 bright white bag, 2 muted yellow bags.
dark orange bags contain 3 bright white bags, 4 muted yellow bags.
bright white bags contain 1 shiny gold bag.
muted yellow bags contain 2 shiny gold bags, 9 faded blue bags.
shiny gold bags contain 1 dark olive bag, 2 vibrant plum bags.
dark olive bags contain 3 faded blue bags, 4 dotted black bags.
vibrant plum bags contain 5 faded blue bags, 6 dotted black bags.
faded blue bags contain no other bags.
dotted black bags contain no other bags."
        .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

        [TestMethod]
        public void Part2_Iven_input_produces_expected_output()
        {
            var input = @"light red bags contain 1 bright white bag, 2 muted yellow bags.
dark orange bags contain 3 bright white bags, 4 muted yellow bags.
bright white bags contain 1 shiny gold bag.
muted yellow bags contain 2 shiny gold bags, 9 faded blue bags.
shiny gold bags contain 1 dark olive bag, 2 vibrant plum bags.
dark olive bags contain 3 faded blue bags, 4 dotted black bags.
vibrant plum bags contain 5 faded blue bags, 6 dotted black bags.
faded blue bags contain no other bags.
dotted black bags contain no other bags.".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            var rules = AdventOfCode2020.Day07.HaversackRuleConverter.ConvertToRules(input);
            var bag = new AdventOfCode2020.Day07.HandyHaversack(rules, "shinygold");

            var actual = bag.NestedCount();

            Assert.AreEqual(32, actual);
        }
    }
}

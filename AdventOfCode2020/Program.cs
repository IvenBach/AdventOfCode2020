using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020
{
    class Program
    {
        static void Main(string[] args)
        {
            var day1Part1 = Day1Part1(Inputs.Day1());
            var day1Part2 = Day1Part2(Inputs.Day1());

            var day2Part1 = Day2Part1_ValidPasswords(Inputs.Day2());
            var day2Part2 = Day2Part2_ValidPasswords(Inputs.Day2());

            var day3Sample = Day3Part2_TreesEncountered(Inputs.Day3SampleInput(), (1, 1), (3, 1), (5, 1), (7, 1), (1, 2));
            var day3Part1 = Day3Part1_TreesEncountered(Inputs.Day3(), (3, 1));
            var day3Part2 = Day3Part2_TreesEncountered(Inputs.Day3(), (1, 1), (3, 1), (5, 1), (7, 1), (1, 2));

            var day4Sample = Day4Part1_PassportProcessing(Inputs.Day4SampleInput());
            var day4Part1 = Day4Part1_PassportProcessing(Inputs.Day4());
            var day4Part2 = Day4Part2_PassportProcessing(Inputs.Day4());

            var day5Sample = new Day5.BinaryBoarding(Inputs.Day5SampleInput);
            var day5Part1 = Day5Part1_BinaryBoarding(Inputs.Day5());
            var day5Part2 = Day5Part2_BinaryBoarding(Inputs.Day5());

            var day6Part1 = Day6Part1_CustomsDeclarations(Inputs.Day6());
            var day6Part2 = Day6Part2_CustomsDeclarations(Inputs.Day6());

            var day7Part1 = Day7Part1_BagsThatCanContain(Day7.HaversackRuleConverter.ConvertToRules(Inputs.Day7()), "shinygold");
            var day7Part2 = Day7Part2_The_number_of_bags_contained_by(Day7.HaversackRuleConverter.ConvertToRules(Inputs.Day7()), "shinygold");
        }        

        static int Day7Part1_BagsThatCanContain(Dictionary<string, Dictionary<string, int>> rules, string bagColor)
        {
            int count = 0;

            foreach (var key in rules.Keys)
            {
                var bag = new Day7.HandyHaversack(rules, key);
                if (bag.CanContain(bagColor))
                {
                    count++;
                }
            }

            return count;
        }
        static int Day7Part2_The_number_of_bags_contained_by(Dictionary<string, Dictionary<string, int>> rules, string bagColor)
        {
            var container = new AdventOfCode2020.Day7.HandyHaversack(rules, bagColor);

            return container.NestedCount();
        }

        static int Day6Part1_CustomsDeclarations(IEnumerable<string> groups)
        {
            var count = Day6.CustomsDeclaration.CountWhereAnyoneAnsweredTrue(groups);
            return count;
        }
        static int Day6Part2_CustomsDeclarations(IEnumerable<string> groups)
        {
            var count = Day6.CustomsDeclaration.CountWhereEveryoneInGroupAnsweredYes(groups);
            return count;
        }

        static int Day5Part1_BinaryBoarding(IEnumerable<string> inputs)
        {
            int highestSeat = 0;

            foreach (var input in inputs)
            {
                var bb = new Day5.BinaryBoarding(input);
                highestSeat = Math.Max(highestSeat, bb.Seat);
            }

            return highestSeat;
        }

        static int Day5Part2_BinaryBoarding(IEnumerable<string> inputs)
        {
            var dict = new Dictionary<int, Day5.BinaryBoarding>();
            foreach (var input in inputs)
            {
                var bb = new Day5.BinaryBoarding(input);
                dict.Add(bb.Seat, bb);
            }

            foreach (var key in dict.Keys)
            {
                if (dict.ContainsKey(key + 2) && !dict.ContainsKey(key + 1))
                {
                    return key + 1;
                }
            }

            return -1;
        }

        static int Day4Part2_PassportProcessing(IEnumerable<string> inputs)
        {
            int valid = 0;

            foreach (var input in inputs)
            {
                var passport = new Day4.PassportPart2(input);
                if (passport.IsValid)
                {
                    valid++;
                }
            }

            return valid;
        }

        static int Day4Part1_PassportProcessing(IEnumerable<string> inputs)
        {
            int valid = 0;

            foreach (var input in inputs)
            {
                var passport = new Day4.Passport(input);
                if (passport.IsValid)
                {
                    valid++;
                }
            }

            return valid;
        }

        static int Day3Part1_TreesEncountered(char[,] input, (int right, int down) pathTaken)
        {
            var rows = input.GetUpperBound(0);
            var columns = input.GetUpperBound(1);
            int treesEncountered = 0;
            int col = 0;
            int row = 0;
            while (row <= rows)
            {
                if (input[row, col] == '#')
                {
                    treesEncountered++;
                }

                col = (col + pathTaken.right) % (columns + 1);

                row += pathTaken.down;
            }

            return treesEncountered;
        }

        static ulong Day3Part2_TreesEncountered(char[,] input, params (int right, int down)[] pathsTaken)
        {
            var treesEncountered = new ulong[pathsTaken.Length];
            for (int i = 0; i < pathsTaken.Length; i++)
            {
                treesEncountered[i] = (ulong)Day3Part1_TreesEncountered(input, pathsTaken[i]);
            }

            ulong totalTrees = 1;
            for (int i = 0; i < treesEncountered.Length; i++)
            {
                totalTrees *= treesEncountered[i];
            }

            return totalTrees;
        }

        static int Day2Part1_ValidPasswords(IEnumerable<string> values)
        {
            int count = 0;
            foreach (var value in values)
            {
                var converter = new Day2.InputConverter(value);
                var validator = new Day2.PasswordValidator(converter);

                if (validator.Part1IsValid())
                {
                    count++;
                }
            }

            return count;
        }

        static int Day2Part2_ValidPasswords(IEnumerable<string> values)
        {
            int count = 0;
            foreach (var value in values)
            {
                var converter = new Day2.InputConverter(value);
                var validator = new Day2.PasswordValidator(converter);

                if (validator.Part2IsValid())
                {
                    count++;
                }
            }

            return count;
        }

        static int Day1Part1(IEnumerable<int> values)
        {
            var (First, Second) = AdventOfCode2020.Day1Part1.SumTo2020(values);

            return First * Second;
        }

        static int Day1Part2(IEnumerable<int> values)
        {
            var (First, Second, Third) = AdventOfCode2020.Day1Part2.SumTo2020(values);

            return First * Second * Third;
        }
    }
}

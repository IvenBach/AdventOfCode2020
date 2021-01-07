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
            //var day1Part1 = Day1Part1(Inputs.Day1());
            //var day1Part2 = Day1Part2(Inputs.Day1());

            //var day2Part1 = Day2Part1_ValidPasswords(Inputs.Day2());
            //var day2Part2 = Day2Part2_ValidPasswords(Inputs.Day2());

            //var day3Sample = Day3Part2_TreesEncountered(Inputs.Day3SampleInput(), (1, 1), (3, 1), (5, 1), (7, 1), (1, 2));
            //var day3Part1 = Day3Part1_TreesEncountered(Inputs.Day3(), (3, 1));
            //var day3Part2 = Day3Part2_TreesEncountered(Inputs.Day3(), (1, 1), (3, 1), (5, 1), (7, 1), (1, 2));

            //var day4Sample = Day4Part1_PassportProcessing(Inputs.Day4SampleInput());
            //var day4Part1 = Day4Part1_PassportProcessing(Inputs.Day4());
            //var day4Part2 = Day4Part2_PassportProcessing(Inputs.Day4());

            //var day5Sample = new Day5.BinaryBoarding(Inputs.Day5SampleInput);
            //var day5Part1 = Day5Part1_BinaryBoarding(Inputs.Day5());
            //var day5Part2 = Day5Part2_BinaryBoarding(Inputs.Day5());

            //var day6Part1 = Day6Part1_CustomsDeclarations(Inputs.Day6());
            //var day6Part2 = Day6Part2_CustomsDeclarations(Inputs.Day6());

            //var day7Part1 = Day7Part1_BagsThatCanContain(Day7.HaversackRuleConverter.ConvertToRules(Inputs.Day7()), "shinygold");
            //var day7Part2 = Day7Part2_The_number_of_bags_contained_by(Day7.HaversackRuleConverter.ConvertToRules(Inputs.Day7()), "shinygold");

            //var day8Part1 = Day8Part1_InfiniteLoop(Inputs.Day8());
            //var day8Part2 = Day8Part2_ExecutionConcludesNormally(Inputs.Day8());

            //var day9Part1 = Day9Part1_Exploit_eXchange_Masking_Addition_System(Inputs.Day9(), 25);
            //var day9Part2 = Day9Part2(Inputs.Day9(), 25);

            //var day10Part1 = Day10Part1(Inputs.Day10());
            //var day10Part2 = Day10Part2(Inputs.Day10());

            //var day11Part1 = Day11Part1(Inputs.Day11());
            //var day11Part2 = Day11Part2(Inputs.Day11());

            //var day12Part1 = Day12Part1(Inputs.Day12());
            //var day12Part2 = Day12Part2(Inputs.Day12());

            //var day13Part1 = Day13Part1(Inputs.Day13());
            //var day13Part2 = Day13Part2(Inputs.Day13());

            //var day14Part1 = Day14Part1(Inputs.Day14());

            var day15Part1 = Day15Part1(Inputs.Day15(), 2020);
        }

        static int Day15Part1(IEnumerable<int> inputs, int turn)
        {
            var rr = new Day15.RambunctiousRecitation(inputs);
            return rr.NthSpokenNumber(turn);
        }

        static long Day14Part1(IEnumerable<string> inputs)
        {
            var dd = new Day14.DockingData(inputs);

            return dd.SumValues();
        }

        static ulong Day13Part2((int timestamp, IEnumerable<string> buses) tuple)
        {
            var ss = new Day13.ShuttleSearch(tuple);
            return ss.SequentialMinuteDeparture();
        }

        /// <summary>
        /// Find the earliest timestamp you can depart on a bus and returns the value of the bus' ID multiplied by its wait time.
        /// </summary>
        /// <param name="tuple">Tuple containing the initial timestamp and list of active busses.</param>
        /// <returns>Value of the bus ID multiplied by its wait time.</returns>
        static int Day13Part1((int Timestamp, IEnumerable<string> buses) tuple)
        {
            var ss = new Day13.ShuttleSearch(tuple);
            var (id, waitTime) = ss.EarliestBus();

            return id * waitTime;
        }

        static int Day12Part2(IEnumerable<string> instructions)
        {
            var rr = new Day12.RainRisk(instructions, (10, 1));
            return rr.WaypointMoving();
        }

        static int Day12Part1(IEnumerable<string> instructions)
        {
            var rr = new Day12.RainRisk(instructions);
            return rr.RectilinearDestance();
        }

        static long Day11Part2(char[,] inputs)
        {
            var ss = new Day11.SeatingSystem(inputs, Day11.OccupancyConcern.Visible, 5);
            return ss.OccupiedSeats();
        }
        static long Day11Part1(char[,] inputs)
        {
            var ss = new Day11.SeatingSystem(inputs, Day11.OccupancyConcern.Adjacent, 4);
            return ss.OccupiedSeats();
        }

        static long Day10Part2(int[] inputs)
        {
            var aa = new Day10.AdapterArray(inputs);
            return aa.DistinctArangementCombination();
        }
        static int Day10Part1(int[] inputs)
        {
            var aa = new Day10.AdapterArray(inputs);
            return aa.JoltageDifferences();
        }

        static long Day9Part2(long[] inputs, int preambleLength)
        {
            var ee = new Day09.EncodingError(inputs);
            var part1 = ee.FirstNumberNotComposedOfPreviousNumbers(preambleLength);
            return ee.Sum_of_values_that_equals_the_answer_in_part1_subsequently_summing_smallest_and_largest_elements(preambleLength, part1);
        }
        static long Day9Part1_Exploit_eXchange_Masking_Addition_System(long[] inputs, int preambleLength)
        {
            var ee = new Day09.EncodingError(inputs);
            return ee.FirstNumberNotComposedOfPreviousNumbers(preambleLength);
        }

        static int Day8Part2_ExecutionConcludesNormally(string[] statements)
        {
            var hh = new Day08.HandheldHalting(statements);
            return hh.ExecutionConcludesNormally();
        }

        /// <summary>
        /// Execution for the program is in an infinite loop. This will continue until just before the infinite
        /// loop starts.
        /// </summary>
        /// <param name="statements">Statements to be executed.</param>
        /// <returns>Value of the global accumulator before executing a statement for a second time.</returns>
        static int Day8Part1_InfiniteLoop(string[] statements)
        {
            var hh = new Day08.HandheldHalting(statements);
            return hh.AccumulatorValueBeforeRepeatingStatement();
        }
        static int Day7Part1_BagsThatCanContain(Dictionary<string, Dictionary<string, int>> rules, string bagColor)
        {
            int count = 0;

            foreach (var key in rules.Keys)
            {
                var bag = new Day07.HandyHaversack(rules, key);
                if (bag.CanContain(bagColor))
                {
                    count++;
                }
            }

            return count;
        }
        static int Day7Part2_The_number_of_bags_contained_by(Dictionary<string, Dictionary<string, int>> rules, string bagColor)
        {
            var container = new AdventOfCode2020.Day07.HandyHaversack(rules, bagColor);

            return container.NestedCount();
        }

        static int Day6Part1_CustomsDeclarations(IEnumerable<string> groups)
        {
            var count = Day06.CustomsDeclaration.CountWhereAnyoneAnsweredTrue(groups);
            return count;
        }
        static int Day6Part2_CustomsDeclarations(IEnumerable<string> groups)
        {
            var count = Day06.CustomsDeclaration.CountWhereEveryoneInGroupAnsweredYes(groups);
            return count;
        }

        static int Day5Part1_BinaryBoarding(IEnumerable<string> inputs)
        {
            int highestSeat = 0;

            foreach (var input in inputs)
            {
                var bb = new Day05.BinaryBoarding(input);
                highestSeat = Math.Max(highestSeat, bb.Seat);
            }

            return highestSeat;
        }

        static int Day5Part2_BinaryBoarding(IEnumerable<string> inputs)
        {
            var dict = new Dictionary<int, Day05.BinaryBoarding>();
            foreach (var input in inputs)
            {
                var bb = new Day05.BinaryBoarding(input);
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
                var passport = new Day04.PassportPart2(input);
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
                var passport = new Day04.Passport(input);
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
                var converter = new Day02.InputConverter(value);
                var validator = new Day02.PasswordValidator(converter);

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
                var converter = new Day02.InputConverter(value);
                var validator = new Day02.PasswordValidator(converter);

                if (validator.Part2IsValid())
                {
                    count++;
                }
            }

            return count;
        }

        static int Day1Part1(IEnumerable<int> values)
        {
            var (First, Second) = AdventOfCode2020.Day01.Day1Part1.SumTo2020(values);

            return First * Second;
        }

        static int Day1Part2(IEnumerable<int> values)
        {
            var (First, Second, Third) = AdventOfCode2020.Day01.Day1Part2.SumTo2020(values);

            return First * Second * Third;
        }
    }
}

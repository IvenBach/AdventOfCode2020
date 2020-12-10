﻿using System;
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
            //var day1Part1 = Day1Part1(Day1Input());
            //var day1Part2 = Day1Part2(Day1Input());

            //var day2Part1 = Day2Part1_ValidPasswords(Day2Input());
            //var day2Part2 = Day2Part2_ValidPasswords(Day2Input());

            //var day3Sample = Day3Part2_TreesEncountered(Day3SampleInput(), (1, 1), (3, 1), (5, 1), (7, 1), (1, 2));
            //var day3Part1 = Day3Part1_TreesEncountered(Day3Input(), (3, 1));
            //var day3Part2 = Day3Part2_TreesEncountered(Day3Input(), (1, 1), (3, 1), (5, 1), (7, 1), (1, 2));

            //var day4Sample = Day4Part1_PassportProcessing(Day4SampleInput());
            //var day4Part1 = Day4Part1_PassportProcessing(Day4Input());
            //var day4Part2 = Day4Part2_PassportProcessing(Day4Input());

            var day5Sample = new Day5.BinaryBoarding(Day5SampleInput());
            var day5Part1 = Day5Part1_BinaryBoarding(Day5Inputs());
            var day5Part2 = Day5Part2_BinaryBoarding(Day5Inputs());
        }

        static string Day5SampleInput() => "FBFBBFFRLR";
        static string[] Day5Inputs() => @"BBFFBFBRLL
FFFFBFBRLR
BFFBBFBRLR
BFBBBFBLLL
FFBBFBBLRR
BFBFFFFRRL
BBBBFFFRLR
BFFFBBFRLL
FFFFBFBRRL
BFBBFFFRRL
BBFBBBFRLL
FBFFBFFRLL
FBBBBBBLRL
FFFBBFBLRL
FFBBFFFLLR
FBBFFFBLLL
FFBFBBBRRL
FBFBBBFRRL
FFBBBFFLRL
BFBBBBFRLR
FBBBFFBRRL
FBBFBFFRLL
FBFBFBBLLL
BFBFFFFLRR
FFFBBFFLLL
FFFFBFFRLL
FBBBBFBRRR
FBBFBBBLRL
BBBBFFFLLL
FFFFBFBLLR
BFFFFBBRLL
BFFFFBBRLR
BFFFFFBRLL
BFFBBBFRRL
FBFFBBBLRR
BFBFFBFRRR
BBBBFFBLRR
FFFFFBBRLR
BFFFBBBRLR
BBFBFFBRRL
FBBFBFBLRR
BFBBFBFRLR
FFFFFBFRRR
BFFFFFBLRL
FFFBFBBLLR
BFFFBBBLRR
FFBFFBBRRL
FBBBBBBLLL
FBBBBFBLRL
BBFFFBFRRL
BBFFFBBRRL
FFBFBFBLRL
FFFFBBBRLR
FBBFFBFLRL
FBBBBFBRLR
BBFBFBBLRL
BBBBFFFLRR
BFBBFFBRLL
BFBBFBBRLR
FFFBBFBRRR
BFFBBBFRRR
BFBBFBBLRR
FBBFFBBLRL
FFFBFBBRRL
BFFFBFBRRR
FBBBFFBLRR
BBFFBBBLLR
BFFBBBBRLR
BBBBFBFRRR
BBBBFFFRRL
BBFFBBBRRL
FFBBBBBRRL
FFFFBBFRRL
BFFFFFBLLL
FFBFFBBLRL
FFFBBFFLRL
BFBFBFFLLR
FFFFBFFRRL
FBBBBFFRLR
FBBBBFBRRL
FBBBFBFLLR
FBBBBBBRRR
FBBFFFFRRL
FBFBFFFRLL
BBFFFBFRLL
BFFBFFFRLL
FFFFBFFLRL
FBBFFFFLLR
BBBBFFBRLL
FBFBFBBRLL
BBFBBBFLLL
FFBFBBBRRR
BFBBFBFRRR
BFBFBBFLRR
BBFBBBFLRL
BBFFFBBLRL
FBFFFBFRLR
FFBFFBBRLL
FFBFFBFRLR
BBBFBFFLLR
BBFBFBBLRR
FBBBBFFLLR
BFFBFBFLRL
FFFBFFFLRR
FBBFBBBRRL
FBFBBBBRRL
BFBFBBFLLL
BFBFBBFRLL
FBFBFFBLLR
FBFFFFBRLR
BBFBBBFRRL
BBBFFFFLLL
FFFFBFBLRL
FFBFFFBLLR
FFFBBBBRRL
FFBFFFBLRL
BBBBFBFRRL
FFFBFFFLLR
BBBBFBBRLR
BBFBBBBRRL
FBFBFFBRLL
FBBBFBFRLL
BFFBFBBRLR
FBFBFBBLRR
FBBFFFBLRR
FFFBBFFRLR
BBBFFFBRLR
BBFFBFFLLL
BFFFFBBLLR
BFBFBBFLRL
FFBFBFBRLL
FBBFBFBRRL
BBBFBFFLLL
FFBBFFFRRR
BFFBBFBLLL
BBBFFBFLLR
FFFBFBBLLL
FFBFBFFRLL
BFFBBBBLRL
FBFBBFFLRL
FBFFBFBLRL
BFBBBBFLRR
BBBFBFFRRR
FBFBBFFRLR
BFBBFFFLLR
BFFFBFBLRR
FBFBFBBRLR
FFFFFBFRLR
FFFFBBBRRL
FBBFFBFLLL
FBBBBBBRLR
FBBFFFBRLR
FBBBFBBRLL
FFFBFBFRLL
BFBFBBFLLR
FFBFFBFRRL
BBFBBBFRLR
FFBBBBBLRL
BBFBBFBRLL
FFBFFFBRLL
FFBBBFFRLR
BFFBBBFLRL
FFBFBFBRRL
FBBFFFBRRR
BBFBBFFLLL
FBFFFFFRLL
FBFFFFBLRL
FFFBFFBRRR
BBBFBFBRLL
BBBBFBBRLL
BFFBFBBLLR
BBBFFFBLRL
BFFBFFBRLL
BFFBBFBRRL
FBFFFFFRRL
FFBBFBBRRR
BBFFBBFLLR
FFBFFBBLRR
BBBFBFFLRL
BBBBBFFLLL
FFBBBBBLRR
BFFBFFBRLR
BFFBBFBLRL
BBFFBBFRRL
FFFBFFBRLR
BFBFBBBLLR
BFFBFFFLLL
FBBFBBBRLR
BFBFBBBRRL
FBFBFFBRRL
BBBFBFBLRL
BFFFBBBLLR
FBBBFBFLRR
FFBBBBBRLR
FFBFFBBLLL
BBFFBFBLRL
BFBFBFBRRL
BFBFFBFLRR
FFBBBFBLLR
BFBFBBBRRR
FBFFBBFLRR
BBBFBFFRLR
BFFFFBFRLL
FFFFBBFLRL
FBBBBFBLLR
BFBFFFFLLR
FFBBFBBRLL
FBFBBFFRRL
BFFFBBFLRR
BBBFFBFLRR
FBBBFFFLRR
BBFFFBFRLR
FFFBFBBRLR
FFBBFBBLRL
FBFFBBBRRR
BBFBBBBLLR
BFFFFFBRLR
BBFBFBFRLR
FBFBBBFLRR
BBFFFBBLLL
BBBFBFBLLR
BFFBBFFLRL
FFBFFFFRLR
BFFFFFBRRR
FFBBBFBLRR
BBBFBBBLRR
BBBBBFFLRL
FBFFFBFRRR
BFFFFFBLLR
FFBBFBFLRL
BBFFFBFRRR
BBBFBFBRLR
BBFBBFBLRL
FFFBFFBLRL
FFFBFFBRLL
BBBBFFFRLL
FBBFFFFLRR
FFBBFFBLLR
FBFFBFBRLL
FFBFBFFLLL
BFBBFFBLRR
BFBFFFBRLR
BBBFFBFRRL
FFBBFBBRLR
BBFFFFBRLL
BBFFBFBLLR
BBFFBFBRRL
FBBBFBBRRL
FFFFFBBRLL
FBFFFBFRRL
FBBFBFFLRL
FBFBBBFRLL
BFFFBFFLRR
BFFBBFBRRR
BFBBFBBLLL
BBFBFFFLRL
BFBFFFFRRR
FBBFBBBLRR
FFBBBBBLLR
FFFFBBFRRR
FFBBFFBRRR
BBFFFBBLLR
BFFBFFBLLR
BBBFFFFRLL
FFFBFBFLLR
BBFBFFBLRL
FFBBBFBRRL
BBFBBBBRRR
BBFBBFBRRR
FFFFBFBRLL
FFFBFFBLLR
FFBFBBBLLR
FBBBFBFLRL
BFBBBBBLLL
BFBBFBFRLL
BFBFBBBLRR
FFBFBFBLLL
BFBFFFBLLR
BBBBFBBRRL
FFBFFBFLRR
FBFBBFFLLL
BFBFBBBRLL
BFBFFFBRRR
FBBFBBFRRR
BFFBFBFRLL
BBFFFFBRRL
BFBFBFBLRL
FBBBFFBRRR
FFFFBBBLLR
BBBFFFFRRR
BBBFFFFLRR
FFBFBBFLLL
BFBFBFFRRR
BBFFFBBRLR
FBBBBBFLRR
FBFFBFBLLR
FFBFFFBLLL
BFFFFBBLRL
BBBFBBBRRR
BBBFFFBRRL
BFFFFBBLRR
BBFFBBBRLL
BFBFFFFLRL
BBFFFFFLRR
BBFFFBFLRR
FBFFBBFRRL
BFFFBBBLLL
BFBBBFFRRL
BFFFBFBLRL
FBBBBFFRLL
BFBFBBBLLL
BFBBFFBLLR
BBBBFBBLLL
FBFBFBFLRR
FBBBFFFRLR
BFFBFBFRRL
BFBBFFFRLR
FBBBFFFLRL
FBBBBFFLRR
FBFFFFBLLL
BBBFFBBRLL
FBBFBFFLLL
BFFBBFBRLL
BFFFFBFRLR
FFFBBFFRRR
FFFBBBFRLR
FBBFFBFRRR
FBFFFFBRRR
BFBFBFBRLL
BBBBBFFRLL
BFFFFBFLLL
BBFFBBFRRR
BFBFFFBLLL
FFFBFBFRRR
FBFBBFBRRL
BFBFFFBRRL
FFFBBBBRRR
BFBFFBBLLR
FBBBFBBLLR
BBFBBFBLLR
BFFFFFFLLL
FBBFBFFRLR
FFBBBBFLLL
BFBBFBFLRL
BFBFBFBLLL
FBBBFBBLLL
BFBFBFBRRR
FBFBFFFLRR
FBFBBFBLLL
FBFFFFBLRR
BBBFFBFRLL
FFFBFFBRRL
BBFBFBFRRR
FBBFFBFRLL
BBBFBBFRRR
FBFBBFFLRR
BBFBBBBLLL
FFBFFBBLLR
FBBBFFFRRR
FFFFFBBLLL
FBFFBBBRRL
BFFBBBFRLL
BFFFBFFLLR
FBFFBBBLLL
FFFBBBBRLR
BFBBBFFLLR
FBFBBBBLLR
FBBFBFBRRR
BBFFBFFRRR
FBBFFFFLRL
FBFBBBBLRR
FFBBFBFRRR
FBFBBFBRLR
BBFBFBFRRL
FBBBBBFLLL
FBFFBFFLLR
FBFBFBFLLL
BFFBFBFLRR
FBBBBBFRLL
BFFBBBFRLR
BBFFFFFLLL
FFFFBBFRLR
BFBBBBBLLR
BBFFFBBRLL
FBFFFFFLRR
BBBFFBBRRR
FFFBFFBLRR
BFFFFFFRLL
BBFFFBFLLR
BFFBBFFLLL
FBBBFFFRRL
BBBBFBFLLL
FBBFFFFRLL
FBFBBFBRRR
BFFFFFFRLR
BFBFFFFLLL
FBFBBFBLLR
BFBBFBFLLR
BFBBFBBLRL
BFFFBFFRLR
BBFBBFFRRR
FBFBFBFRLL
FFBBFBFRRL
BFFFBFFLRL
FBFFBBBLRL
BBBFFBFLRL
FFBBBFBRRR
BFFFBFBRRL
FFBBFBFLLR
BFFBFFFLRL
BBBFFFFLRL
FFBBFFBRLR
BFFBFBBRRR
BFFBFFBLRR
BFFFBBBLRL
FFBFBFFRRR
FFBFBBFRRL
FFBBBBFRLR
BBBFBBFLRR
BFBBFFFLRL
BFBBBBFRRR
FFBFFFBLRR
FFBFBFFLLR
FBFFBFBRRL
BFFFFFFLRR
FBBBBBBLRR
BBFFBBFLLL
BFBBBBFRRL
FFBFFFFLLR
BBFFFBFLLL
FFBFBFFLRR
FFBBBBFLRL
FFFBBBFRRR
FBBFFBFLRR
FBFBBBBRLL
FFFBBBBLLL
FFBBBBFRRL
FBBBBBBLLR
FBBFBFFLLR
BFBBFBFRRL
BBFFBFBLRR
FBFFBFFRRR
FFFBBBBRLL
BFFFFFFLLR
BFFFFBFLLR
FFFBBBFRRL
BFFBFFFLLR
FBFFFFFLLL
BBBBFBBLRR
BBFFBFFRRL
BFBBFFBLRL
FBBBBFFRRR
FFFBBFBLLR
FBBFFFFRLR
FFFBFBBLRL
BFBBBBFLLR
BBFFFBBRRR
BFBFBBFRRR
FFFBFFFRRL
BBFBFBFRLL
FBFFBFFRLR
BFFBFFBLLL
FFFFBFBRRR
BFFBBFFRLR
FBBBFBBLRL
FBFFBBBRLL
FBBBBBFRLR
FBBBFFBLLR
FBFBBFFRLL
FFBBBFFRRL
BBFBBBBLRR
BFFFFBBRRL
BFFFBFFRRL
FBBFBBFRRL
BFBBFFBRLR
BFFFFBFLRL
BBFFFFBLLR
FBFFFFFRRR
FFFFBBBRLL
FFFFBBFLLR
BBBFBBBLLR
FFBFFFFRLL
FBBBFFFLLR
FFFFBBBLRL
FBFBBBFLLL
FBFFFBFLLL
BBBFFBBLRR
FBBBFFFLLL
BBFBBFFRLR
FFFFBFFLLL
BBFFBFFLLR
BFBBBBFRLL
BFFBBFFRLL
BBFFFFBRLR
FBBBBFBRLL
BFBBFFBLLL
FBBFFFFLLL
FFBFFBBRRR
FBFFBBBLLR
BFBBBFBLRL
BBFFBBFRLR
FFBBBFFRRR
BBBBFBFRLL
BFFFBBBRRR
BBFFFFFRLR
FBFBFFFLLR
BBFFBBFRLL
BFFBBFFLLR
FFFFBBBRRR
FFFBFBFRRL
BBBFBBFRRL
FBBBFBBRLR
FBFBFFFRRR
BFFBBBBLLR
BBBFBFBLRR
FBFBBFBLRR
BBBFFBBRLR
FBFBFBBLRL
BBBFFBBLLR
BBFBFBBRLL
FBBBFFBRLL
FFBBFFFRLL
FBFFBFFRRL
BBBBFFBRRR
FBFBFFFLLL
FFFFBBFRLL
BFFBFFFRRR
BBFFBFBRLR
FFBBBFBRLL
BBFBFFFLLL
FBBFBBFRLR
FFFBFFFRLL
FBBFFBFRRL
BFBFFBFLRL
BBBFFFFRRL
BBFFBBBRRR
FFBFBFFRLR
FFBBFFFRLR
FBFBFBBRRL
FFBBFBBLLR
FBFFFFFRLR
BBBBFBBLRL
BBFFBFFRLL
FBBBFBFLLL
BBBFBFBLLL
BFFBFFFLRR
BFBFFBFRLL
BFBBBBFLRL
BBBBFFFLRL
FFFBFFBLLL
FFFFBFBLRR
FFFFFBBRRR
FFFBFBBLRR
BFFFBBFRRL
FFBFBBFLRR
BBFBBBBRLL
FBBBBBFRRR
BFFFFBFLRR
BFBFFBBRRL
FBFBBFBLRL
BBBFFBBLLL
FFBBBFFLRR
BBBBFBFLRL
BBBBFFBLLL
BFFFBBBRLL
FBBFFFBLLR
BFBBBFFRLL
FBBFFBFRLR
BBFBBFBRRL
BFBBFBBRLL
BBFBFFFRRR
FBBBFFBRLR
BBFFBBBLLL
BFFFBFBLLR
BBFBFFBRLR
FFBFFFBRRL
FFBFBFBRLR
BBFFBFBLLL
BFBFBBBRLR
FBFFFBFLRL
BFBFFFFRLR
BBFFFFFRLL
BBBFFFBRRR
FBFFBBFRRR
FFFBBFFLLR
FFFBFBFRLR
FFBBBBFLRR
BFFFBFBRLR
FFBFFBBRLR
FBBFFFBRLL
FBBFBFFLRR
BFFFFFFRRR
BBBFBBBRLL
FBFFFBBRRL
FFBBBFBLRL
FBFFBFBLLL
FFFFBFFRLR
FBFFBFFLRL
FFBFBFFRRL
FBBBFFBLLL
BFFFFBBRRR
BBBBFFBLLR
FFFFFBBLRL
FFBBBFFLLR
FBBBFFFRLL
FFBFFBFRRR
BBBBFFBRLR
FFBBFBFLRR
BFBBBBBRLL
BFBBBBBLRL
FFBFBBFRLR
FFBFBBBRLL
BFFBBFBLLR
BFBFFFFRLL
BBFBBFFRRL
BFBFFBFRLR
FFBBFFFLRL
FFBBBFFLLL
BFFBFBFLLL
BFBFBFBRLR
FBBFBFBLLR
BFBFFBBLRR
FFFFBFFLRR
BBFBBFBLLL
FBFFFFFLRL
BBBBFBFRLR
BFFFBBFRRR
BBFBBFFLRR
BFBBBFBRLL
BFFBFFBLRL
BFBFFFBLRR
BFFFBFFRRR
FBFFFBBLLL
FBFBBBBLRL
FBFBFFFRLR
BBFFBBFLRL
BFBFBFBLLR
FBFFFBFLRR
BFFBFBBRRL
FBFBBBFLLR
FBFBFFBLRL
BBFBFBBRRR
FBBFFBBLRR
BBFFFFBLLL
FBFFBBBRLR
FBFFFBFLLR
BFBBFFFLLL
BBBBFBFLRR
BFFBFBBRLL
BFFFFFFRRL
BFBFBFFRRL
FFBFBFBLRR
FFFBFBFLRR
FFFBFBBRRR
FBFFFBBRLR
FFBBFFBRRL
BBFBBBBRLR
FFFBBFBRLR
FBFFBBFLRL
BBBFFFBRLL
BBBFBBBRLR
FFBFFFFRRR
FBBFBFBLLL
BFBBBFBRRR
BFBBFFBRRL
FFFBBBFLLL
FBBBBFBLLL
FFBFBFBLLR
BFFBFFFRLR
BBBBFBFLLR
FBBFBBFLLL
FBFFFBBLRR
FFBFBBFRRR
FBFBFBBRRR
FFBFBFBRRR
FFBBFBFRLL
FBFBBBBLLL
BFBFFBBLLL
BBBFFFFRLR
BBBFBFBRRR
BFBFBFBLRR
BFBFBBFRLR
BFBBBFFLLL
FBBFFBBRRR
BFFFFFBLRR
BFFBFBFRLR
BBFFBFFRLR
BFBBBBBLRR
FBFFFBBLRL
BFFBFBFRRR
BFFFFBFRRL
FFBFBBBLLL
FBBBFBFRLR
FFFBBFBLLL
FBFBBBFRLR
BFBFFFBRLL
BFFBBBBLRR
BBFFBFFLRL
BBBFBBFRLL
BBBFFFBLRR
FBBFFBBRLR
FBBFBBFLRR
BBFBFBBRRL
FFBBBBBLLL
BFBBFBBLLR
BFBBBFFLRR
BBBFFFBLLL
FBFBBBBRLR
FBFBFFBLRR
FFFBBBFLRL
BBBFFBBLRL
FBBFBFBRLL
BBBBFBBLLR
FFBBBBBRRR
BBBFBBFLRL
BFBBBFBRLR
FFFBFFFRRR
BFFFBBFRLR
FBFFFFBRLL
BFFBFFBRRL
BBBFBBBRRL
FFBFFBFRLL
FBFBBFFRRR
FFBFFFBRLR
FFFFBFFLLR
FFBBFFFLLL
FBFFFBBLLR
FFBFBBFLRL
BFFBFBBLLL
FBBBFBBLRR
FFFBFBFLLL
FBBFBFBLRL
FFBBFFFRRL
BFBFBFFRLL
BFFFFBFRRR
BBBBFFFRRR
BFFBFFBRRR
FFFFBFFRRR
FFBBFBBRRL
FBBFBBBRLL
BBBBFFBLRL
FBBFBBFRLL
BFFBBBBRLL
BFBBBFBRRL
BBFBFBFLLR
FFFBBBBLLR
BFFBBFFLRR
BBBFBBBLRL
FBBFBFFRRL
BBFBFFFRRL
BBFBFFBLRR
BBBFBBFRLR
FBBBFBFRRR
BBFBFBFLRL
FBBFBBFLRL
FFBFFFFLRR
BFBBFBBRRL
FBBBBFFRRL
FBFBFFBRRR
BBBFFBFLLL
FFFBFFFLRL
FBFBBBFRRR
BBBFBFFRRL
BFBFFFBLRL
BBBFBFFLRR
BFFFBFFLLL
FFBFBBFLLR
FFBFBBFRLL
FBFBBBFLRL
BFFBBBBRRL
FBBBFBFRRL
FFBBBFBLLL
BFBBBFFLRL
BBBBBFFLLR
FBFBFFFRRL
BFFBFBBLRR
BBFFFFBLRR
FBFFBFBLRR
FBFFBBFRLR
FFBBFFBLRL
FFFFFBBLRR
BBBBBFFLRR
BFBBBBFLLL
FBBFBFFRRR
FFFFFBBLLR
FFBFFBFLLL
FFBFBBBLRR
FFBBFBFRLR
BFBBBFFRRR
FBFFBFBRLR
BBBFBBFLLR
BFBBFBFLRR
FBBBFFBLRL
BFBBBBBRLR
FBBFBBFLLR
BFBBBFFRLR
FBBBBBFLRL
BFBBBBBRRR
BFFBBBBRRR
BBFBFBFLRR
BFFBBBBLLL
BBFFFBFLRL
BFBBFBFLLL
FBFFFFBRRL
FFBBBBFRRR
FFBFBBBRLR
BBFBFBFLLL
FBFFBFBRRR
FFFBBBFLLR
FFFBFBFLRL
BFBFBBBLRL
FBBFFBBLLL
BBBFBFBRRL
FBFFFBBRRR
BFFFBFBLLL
FFFFBFBLLL
FFFBBFBRLL
FBBFFFBRRL
FFBBFBFLLL
FFBBFFBRLL
FBFBFBFLLR
BBFFFFBLRL
BFBFBBFRRL
FFFBFBBRLL
FBBFFBBRLL
BBFBFBBLLR
BFFFBFFRLL
BFBFBFFLRR
FBFFFFBLLR
FFFBBFBRRL
FFFBBBBLRL
FFBBFFBLRR
BFFFBBFLLL
FFFBFFFLLL
FBFBFBFRRR
BFBBBFBLLR
BFFBFFFRRL
FFFFBBFLRR
FBFBFBFRRL
BFBBFBBRRR
BFBFFBBLRL
FBFBBFBRLL
FBBBBFFLRL
FFBFBFFLRL
FBBFBBBRRR
FBFBFBFRLR
FFBFFFFLRL
BBFBFBBRLR
BFBFFBBRLL
BBFFBFBRRR
BFBBBBBRRL
BBFBBBFLLR
BBFFBBBRLR
BBFBFFFLLR
FFFFBBFLLL
FBBFFFFRRR
BBFBFFBRLL
FFBBFBBLLL
BFBBFFFRRR
BFBBFFFRLL
BFFBBFFRRL
BBFBBBFRRR
BFFFBFBRLL
BFFFBBBRRL
FBFBBFFLLR
FBFFBBFRLL
BBFBBFBLRR
BBBFFFFLLR
FBBFBBBLLL
FBFFBBFLLL
BFFBFBBLRL
BBFFFFFRRL
FFBBBBBRLL
FBFFBFFLLL
FFFFFBFRRL
BBBBFFBRRL
FBBFBFBRLR
BBFBBFBRLR
BFFBBFBLRR
BFFFFBBLLL
BBBBFBBRRR
BBBFFFBLLR
FFBFFFFLLL
FBBFFBFLLR
BBFFFFFLRL
FFFFBBBLRR
FBBBBFFLLL
FFBBFFBLLL
BBFBFFBRRR
FBFBFBFLRL
FFFBBBFLRR
BFBBBFBLRR
FBBBBBFLLR
BBFFBBBLRL
FFBFFBFLLR
FFFBBBFRLL
FBFFFBBRLL
BFFBFBFLLR
FFBBBFBRLR
BBFFFBBLRR
BFFFBBFLRL
FFFBBFFLRR
BBBFBBBLLL
BBFBFFFRLL
FFFBBFFRRL
BFBBFFFLRR
BBFFFFBRRR
BBFFFFFLLR
BBFBBBBLRL
FFBFBBBLRL
BBFFFFFRRR
FBFBFFBLLL
BFFBBBFLRR
FFFFFBBRRL
BFFFFFBRRL
BBBFBFFRLL
FBFFBBFLLR
BBBFFBFRRR
BBFBFFFLRR
BBFFBBFLRR
BFBFFBFRRL
FBBBFBBRRR
BBFFBFFLRR
BBFBFFFRLR
FBBBBBFRRL
BFFFBBFLLR
BBFBBFFLLR
FBFFFFFLLR
FFFBBFFRLL
BBFBBFFRLL
FFFFBBBLLL
BFBFFBBRLR
FBBFBBBLLR
BFFBBBFLLR
BFFFFFFLRL
BFFBBBFLLL
BFBFFBFLLL
BBFBFFBLLL
FFBBBBFRLL
FBFFBFFLRR
BBBFFBBRRL
BFFBBFFRRR
BBBBFFFLLR
BFBBFFBRRR
FBFFFBFRLL
FFBBBFFRLL
FBBBBFBLRR
FFFBBFBLRR
FFBBFFFLRR
BBFBBBFLRR
FBFBFFBRLR
FBBFFBBLLR
BBFFBBBLRR
BBFBFFBLLR
FBBFFFBLRL
BFBFBFFLRL
FFFBFFFRLR
FBFBFFFLRL
BBBFFBFRLR
BBBFBBFLLL
FBFBFBBLLR
BFBFBFFLLL
FFBFFFBRRR
BFBFBFFRLR
FFFBBBBLRR
BBFBBFFLRL
FFBFFFFRRL
BFBFFBFLLR
FFBBBBFLLR
FBFBBBBRRR
FFBFFBFLRL
FBBBBBBRLL
BBFBFBBLLL
FBBFFBBRRL
FBBBBBBRRL".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

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

        static string Day4SampleInput()
        {
            return @"ecl:gry pid:860033327 eyr:2020 hcl:#fffffd
byr:1937 iyr:2017 cid:147 hgt:183cm

iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884
hcl:#cfa07d byr:1929

hcl:#ae17e1 iyr:2013
eyr:2024
ecl:brn pid:760753108 byr:1931
hgt:179cm

hcl:#cfa07d eyr:2025 pid:166559648
iyr:2011 ecl:brn hgt:59in";
        }
        static string Day4Input()
        {
            return @"pid:827837505 byr:1976
hgt:187cm
iyr:2016
hcl:#fffffd
eyr:2024

hgt:189cm byr:1987 pid:572028668 iyr:2014 hcl:#623a2f
eyr:2028 ecl:amb

pid:#e9bf38 hcl:z iyr:2029 byr:2028 ecl:#18f71a hgt:174in eyr:2036

hcl:#cfa07d byr:1982 pid:573165334 ecl:gry eyr:2022 iyr:2012 hgt:180cm

cid:151 hcl:#c0946f
ecl:brn hgt:66cm iyr:2013 pid:694421369
byr:1980 eyr:2029

ecl:brn
pid:9337568136 eyr:2026
hcl:#6b5442
hgt:69cm iyr:2019 byr:2025

cid:66 hcl:#efcc98 pid:791118269 iyr:2013
eyr:2020 ecl:grn hgt:183cm byr:1993

eyr:2022
hgt:160cm iyr:2016 byr:1969 pid:767606888 ecl:gry hcl:#6b5442

hgt:157cm eyr:2026 ecl:oth hcl:#efcc98 byr:1938 iyr:2014

byr:1931 iyr:2015
ecl:gry
hgt:76in
cid:227 hcl:#09592c eyr:2024 pid:276365391

ecl:gry hgt:170cm iyr:2014 cid:285 pid:870052514
hcl:#866857 byr:1925 eyr:2025

eyr:2021
byr:1960 pid:569950896
iyr:2010 hgt:179cm hcl:#888785 cid:167

hgt:154in cid:194
pid:8142023665 byr:2010 hcl:7d22ff ecl:utc iyr:2026 eyr:1976

ecl:blu eyr:2030 hgt:192cm
pid:363860866 iyr:2019 hcl:#ceb3a1 byr:1963

byr:1947 hgt:167cm hcl:#7d3b0c ecl:amb
cid:70 eyr:2022 iyr:2019 pid:756932371

hgt:185cm pid:871945454
iyr:2020
hcl:#866857 ecl:amb
byr:1989 cid:184 eyr:2030

byr:1935 pid:322117407
hgt:153cm iyr:2011
cid:244 eyr:2022 hcl:#efcc98 ecl:hzl

ecl:blu hcl:#5e6c12
eyr:2029 iyr:2011 hgt:191cm byr:1992

hcl:#7d3b0c eyr:2029
hgt:163cm
pid:625292172 byr:1932 ecl:brn
iyr:2020

hgt:158cm
eyr:2030 iyr:2016 byr:1969
cid:173 pid:092921211 hcl:#602927 ecl:grn

hcl:#733820
iyr:2016 eyr:2029
ecl:hzl hgt:180cm pid:292904469 byr:1984

ecl:amb pid:901224456 hgt:190cm
iyr:2013
hcl:#733820
byr:1922

pid:262285164 iyr:2010
byr:2018 eyr:2026 hcl:#602927 hgt:179cm ecl:gmt cid:349

byr:1956 eyr:2027 pid:351551997 hgt:71in cid:277 hcl:#cfa07d iyr:2010 ecl:grn

eyr:2027 hcl:#602927 hgt:157cm ecl:gry
cid:128 byr:1953
pid:231551549 iyr:2012

iyr:2011 pid:771266976
cid:264 byr:1955 hcl:#b6652a
hgt:189cm ecl:blu
eyr:2030

eyr:2026 pid:698455242
byr:1949 ecl:gry hgt:190cm
iyr:2013 hcl:#efcc98 cid:139

ecl:blu hgt:181cm byr:1977 iyr:2011 eyr:2022
pid:454163967 hcl:#b6652a

pid:534506872 hgt:155cm iyr:2012
byr:1968
cid:333 eyr:2024 hcl:#623a2f
ecl:amb

hgt:162cm
iyr:2020
hcl:#733820 eyr:2027 byr:1995 ecl:gry pid:084994685

iyr:2016 byr:1990
ecl:amb pid:185689022 eyr:2025
hgt:184cm hcl:#866857

byr:2016 hcl:z iyr:2022 hgt:166in
eyr:2040

byr:1943 hgt:152cm hcl:#cfa07d ecl:hzl iyr:2016 cid:300 pid:376088014

iyr:2020 eyr:2026 hcl:#602927 ecl:gry byr:1962 pid:453907789 hgt:172cm

eyr:2023 hgt:185cm
hcl:#623a2f pid:963767258 byr:1977
iyr:2019 ecl:oth

hgt:159cm byr:1965 cid:349 ecl:blu pid:962908167
iyr:2013 eyr:2024
hcl:#fffffd

eyr:2026
pid:912822238 hgt:66in byr:1985 iyr:2018 hcl:#c0946f ecl:hzl

hgt:167cm hcl:#ceb3a1
byr:1990 eyr:2027 ecl:grn
iyr:2011 pid:642877667

hcl:#7d3b0c byr:1921 pid:976412756 hgt:192cm
iyr:2013 ecl:gry

iyr:2030 pid:283599139
eyr:2039 cid:203
hcl:f943cb
hgt:111

hgt:190cm
iyr:2027 ecl:blu hcl:z
byr:2004 eyr:2039
pid:734570034

hcl:#6b5442 hgt:191cm
ecl:oth byr:1989 pid:669414669 cid:196 iyr:2016 eyr:2023

ecl:brn eyr:2028 byr:1965 pid:630674502 hcl:#602927 iyr:2020 hgt:61in

iyr:2016 eyr:2022 cid:225
hcl:#733820 ecl:hzl hgt:166cm
byr:1934
pid:232742206

ecl:amb hcl:#602927 eyr:2029
pid:897535300
hgt:189cm byr:1952
iyr:2017

pid:853604345
hgt:161cm cid:269
hcl:#fffffd eyr:2030 iyr:2011 ecl:grn byr:1966

hgt:151cm hcl:#18171d eyr:2026 ecl:grn iyr:2016 pid:176cm
byr:2000

hcl:#341e13
eyr:2022
pid:536989527 cid:73 byr:1971
ecl:hzl

pid:739005658 hcl:#b6652a
eyr:2026 hgt:154cm ecl:hzl
iyr:2019 byr:1935

pid:373465835 ecl:oth byr:1932 cid:333 hgt:165cm
hcl:#b6652a eyr:2021 iyr:2014

byr:1967 pid:486658617 hcl:#18171d hgt:174cm
eyr:2021 iyr:2015 ecl:gry cid:53

eyr:2024
cid:124 iyr:2017 hgt:152cm pid:095649305 hcl:#341e13
byr:1920 ecl:oth

hcl:#623a2f
byr:1951 pid:993284548
cid:106
hgt:186cm
ecl:amb iyr:2017 eyr:2029

cid:308 pid:080673934
hgt:193cm
byr:1967 hcl:#623a2f iyr:2016 ecl:hzl
eyr:2021

iyr:2010 eyr:2024 byr:1946 hgt:156cm
cid:199
ecl:blu hcl:#866857

ecl:blu byr:1955 eyr:2022 cid:95 pid:139391569
iyr:2019 hgt:180cm
hcl:#efcc98

ecl:brn pid:579889368
eyr:2023 hgt:158cm byr:1935
iyr:2018 hcl:#cfa07d

byr:1920 pid:90919899 hcl:#18171d
hgt:152cm
eyr:2029 ecl:oth iyr:2014

byr:1961 eyr:2024
ecl:#d401e3 iyr:2011 hgt:172cm pid:919145070
cid:100
hcl:#efcc98

ecl:gry
hgt:168cm
hcl:#888785 byr:1942 pid:731032830 iyr:2014
eyr:2028

hcl:#6b5442 pid:265747619 hgt:191cm
cid:217
eyr:2028
iyr:2019 ecl:amb
byr:1948

iyr:2011 ecl:brn
hgt:183cm hcl:#fffffd cid:258 byr:1983
pid:835909246

byr:2030
iyr:2024 ecl:#f66808
hcl:fd548d cid:183
pid:#fced33
hgt:160in

ecl:utc hgt:183in hcl:a92c31 pid:0394222041
iyr:2008
eyr:1976 byr:2020

pid:126195650 iyr:2019 hcl:#341e13
ecl:blu
hgt:150cm
eyr:2025
byr:1964

cid:71 iyr:2016 hgt:157 ecl:grt
hcl:#18171d pid:#1ab5ea eyr:2027

eyr:2026 hcl:#b5266f
byr:1971
cid:269 hgt:192cm iyr:2012
pid:736578840 ecl:amb

pid:152109472 hcl:#ceb3a1 ecl:grn hgt:188cm eyr:2027
byr:1923

hcl:#341e13 pid:535175953 hgt:63in eyr:2028 iyr:2015 byr:1999 ecl:gry

hgt:183cm pid:611738968 byr:2001
eyr:2020 hcl:#a97842 iyr:2014
ecl:gry

eyr:2038 ecl:gmt pid:113210210 iyr:2012 byr:2011
hcl:z
hgt:157cm

hgt:157cm
pid:699449127
iyr:2014 ecl:gry byr:1980 hcl:#fffffd eyr:2029

iyr:2028 hcl:z pid:152cm
eyr:2039
ecl:#4760fb hgt:177in
byr:2017

eyr:2026 hcl:#efcc98
iyr:2020 hgt:180cm ecl:hzl pid:747449965 byr:2016

byr:1974 iyr:2019
cid:89 eyr:2023 pid:421418405
hcl:#fffffd hgt:192cm
ecl:gry

hcl:26c2ef eyr:2029 cid:309 byr:1931 ecl:grn pid:#4eb099 iyr:2024
hgt:174cm

ecl:gry
hgt:183cm
cid:281
eyr:2022 pid:050492569
byr:1968 hcl:c88145
iyr:2015

eyr:2028
iyr:2014 pid:712984515 hgt:187cm cid:206 hcl:#866857 byr:1927
ecl:brn

byr:1936 hgt:61in ecl:oth iyr:2012 pid:447813841
hcl:#c0946f
cid:126 eyr:2021

ecl:gry pid:791970272
eyr:2020
byr:1932 hcl:#623a2f hgt:161cm
iyr:2015

hcl:#c0946f
byr:1935 pid:721144576 eyr:2025 hgt:162cm
iyr:2017 ecl:oth

byr:1959
pid:551109135
ecl:hzl hgt:68in
eyr:1977 hcl:#888785
iyr:1955 cid:100

hgt:190in eyr:1993 pid:8358180772 iyr:1975
ecl:oth
byr:2024
hcl:3de172

eyr:2030 hgt:190cm hcl:#a40ef3 byr:1935 pid:484932501
ecl:amb iyr:2016

iyr:2015
byr:1964
hgt:176cm
pid:819552732 hcl:#c0946f ecl:amb cid:263
eyr:2024

hgt:65cm cid:59 eyr:2027 pid:074880819 ecl:utc iyr:2023
byr:1954 hcl:#623a2f

byr:1954 hgt:167cm iyr:2020
eyr:2023 hcl:#602927
pid:280295309
ecl:hzl cid:168

hgt:168cm pid:311043701 iyr:2017 byr:1965
ecl:hzl
eyr:2026 hcl:#fffffd

hcl:#fffffd ecl:grn pid:672987232 iyr:2012 eyr:2022 hgt:66in

iyr:2012 ecl:#6f4f9f
hgt:133 byr:1937
eyr:1953 pid:7177768428 hcl:#602927

iyr:2010
byr:1922 hcl:#c0946f
eyr:2029 ecl:gry
hgt:165cm
pid:893045052

iyr:2013 eyr:2028 hcl:#866857 pid:137143403
ecl:brn hgt:170cm byr:1940 cid:194

hgt:161cm
eyr:2027 pid:3966920279 ecl:gry iyr:2015 byr:1997 hcl:#cfa07d

ecl:amb
hgt:157cm byr:1971
pid:562746894 cid:305 hcl:#0b0e1a eyr:2021 iyr:2016

hcl:8b821d hgt:157cm pid:187cm cid:298 eyr:1926 iyr:2019
ecl:amb
byr:2030

hgt:155cm hcl:#341e13 byr:1924 pid:779847670
ecl:hzl iyr:2015
eyr:2024

pid:768590475 hcl:#a97842 iyr:2014 cid:128 eyr:2029
ecl:oth hgt:164cm byr:1990

iyr:2019 hgt:181cm cid:342
eyr:2020 ecl:gry byr:2001
hcl:#623a2f
pid:473165431

byr:1928 eyr:2026 hcl:#42a9cb iyr:2010
ecl:grn hgt:157cm pid:638074984

eyr:2028
byr:1951
pid:239781647 iyr:2020 hgt:156cm
ecl:hzl cid:215 hcl:#efcc98

pid:636605355 ecl:hzl
iyr:2017 cid:323 eyr:2025
byr:1995
hcl:#18171d hgt:187cm

byr:1933 hcl:#866857 hgt:152cm ecl:oth iyr:2014 pid:900790914 eyr:2030 cid:267

ecl:brn byr:1999 eyr:2027 hcl:#623a2f iyr:2017
pid:853165955
hgt:152cm

eyr:2030 pid:316704688 hcl:#c0946f ecl:brn iyr:2014 hgt:193cm

iyr:2012 byr:1928
hgt:154cm pid:570535769 hcl:#623a2f eyr:2026 ecl:hzl

iyr:2016 cid:252 eyr:2030 hcl:#888785
hgt:177cm ecl:grn byr:2002 pid:568715162

pid:570999226 iyr:2012 hgt:150cm
byr:2024
ecl:brn hcl:z eyr:2029

pid:174002299 iyr:2019 hcl:#cfa07d ecl:brn byr:1927
cid:77 hgt:159cm eyr:2027

ecl:#d16191 eyr:2022 pid:166cm hgt:165cm hcl:#18171d iyr:2015

pid:112585759
hcl:#341e13 eyr:2025 byr:1962 hgt:164cm ecl:hzl iyr:2018

pid:478415905 eyr:2025 cid:315
ecl:amb hgt:91
iyr:2014 hcl:#cc9d80
byr:1985

pid:561885837 hcl:#7d3b0c
hgt:169cm
byr:1921 iyr:2014 cid:178
eyr:2022 ecl:gry

ecl:#c87497 hcl:5321a2 eyr:2020 hgt:74in
pid:#7a62c6 iyr:1976

eyr:2037
pid:858202391 hgt:162cm
ecl:grn byr:2003
cid:278
iyr:2010 hcl:cbf662

ecl:blu iyr:2012 hgt:183cm hcl:#623a2f pid:848200472 byr:1997 eyr:2027

byr:1942
hgt:164cm
pid:464257339
iyr:2016
hcl:#7d3b0c ecl:gry

iyr:2012 hcl:#ceb3a1
hgt:193cm ecl:amb
pid:667987561 eyr:2024 byr:1960

hgt:187cm
pid:222340640
iyr:2018 eyr:2022
ecl:oth
byr:1957
hcl:#336667 cid:83

eyr:2025 iyr:2015 hcl:#733820
ecl:brn
pid:131195653

hgt:185cm eyr:2026
ecl:amb byr:1998 pid:938587659 hcl:#733820
iyr:2016

ecl:oth pid:300949722
eyr:2028 iyr:2016
byr:1933
hgt:179cm
hcl:#cfa07d

byr:1974 iyr:2019
ecl:hzl hcl:#c0946f eyr:2024 pid:484547079
cid:112
hgt:185cm

eyr:2022 iyr:2018 hcl:#fffffd pid:118568279
hgt:153cm ecl:gry byr:1941 cid:341

iyr:2018
eyr:2027 hcl:#888785
byr:1970 hgt:165cm pid:773715893
ecl:amb

hcl:#623a2f hgt:156cm byr:1938 iyr:2012 pid:745046822
ecl:amb
eyr:2030

iyr:2012
pid:097961857
eyr:2023 hgt:66in hcl:#fffffd byr:1962 ecl:utc

byr:1943 hgt:150cm
iyr:2012
pid:740693353 eyr:2023
hcl:#18171d cid:101 ecl:blu

iyr:2018 pid:183728523 byr:1924 hgt:154cm eyr:2030
cid:167 ecl:blu hcl:#ceb3a1

hgt:69cm
eyr:2025 hcl:z ecl:brn byr:1982 pid:250782159
iyr:2011

byr:1998 iyr:2018 hcl:#341e13 eyr:2022 hgt:157cm pid:497100444 cid:266 ecl:gry

eyr:2027 iyr:2011 hcl:#6b5442 hgt:156cm pid:494073085
byr:1998
ecl:hzl

byr:1947 hcl:#b6652a
iyr:2011 pid:228986686 eyr:2030 hgt:175cm cid:70 ecl:brn

eyr:2026 hgt:159cm
byr:1946 pid:534291476
iyr:2018 ecl:gry cid:225
hcl:#18171d

pid:439665905
cid:311 ecl:amb iyr:2018
eyr:2030
hgt:186cm byr:1950
hcl:#cfa07d

pid:250175056 hcl:#efcc98
byr:1981 cid:262 hgt:154cm ecl:gry iyr:2020 eyr:2027

pid:461335515 iyr:2014 hcl:#f1cf00 hgt:180cm ecl:amb eyr:2027
byr:1956

iyr:2014 eyr:2030 cid:194
pid:234623720 hcl:#733820
hgt:164cm byr:1929
ecl:blu

byr:1992
eyr:2024 hcl:#ef8161 cid:216
ecl:brn hgt:177cm iyr:2018
pid:101726770

hcl:#341e13 hgt:178cm iyr:2016 eyr:2029 byr:1945 pid:045325957 ecl:grn cid:99

ecl:gry
iyr:2012
cid:52 hgt:168cm byr:1943
hcl:#cfa07d
pid:899608935 eyr:2030

cid:241
byr:1934 hgt:161cm eyr:2027 iyr:2011 hcl:#c0946f ecl:amb pid:346857644

iyr:2019 hgt:178cm
hcl:#c0946f byr:1957
eyr:2026
ecl:brn pid:222885240

ecl:blu
eyr:2021 cid:312 hcl:#733820 hgt:186cm iyr:2012 byr:1969
pid:821704316

hcl:#6b5442 cid:159
hgt:180cm
iyr:2018
eyr:2028
ecl:hzl byr:1966
pid:#e0238e

pid:622400994 eyr:2022 hcl:#5b6635 iyr:2012 byr:1980
hgt:190cm ecl:oth

byr:1976 ecl:gry eyr:2020 iyr:2020 hgt:171cm pid:219878671 hcl:#6b5442

hgt:163cm byr:1968
pid:003521394 ecl:oth
iyr:2010
cid:61 hcl:#888785

cid:115 pid:810722029 hgt:166cm byr:1955
ecl:blu eyr:2030 iyr:2018

hgt:176cm
eyr:2025
pid:617393532 hcl:#733820 byr:1975 iyr:2018 ecl:grn

hcl:#733820 byr:1979 pid:838168666
hgt:190cm ecl:oth cid:330
eyr:2029 iyr:2018

eyr:1940 hgt:67cm iyr:2009 ecl:gry pid:#e76a62 byr:2020 hcl:z

hgt:190cm ecl:brn pid:396113351
byr:1956 iyr:2010
hcl:#6b5442 eyr:2024
cid:256

hcl:#efcc98
hgt:178cm byr:1984 iyr:2013 pid:752620212 eyr:2021 ecl:gry

iyr:2014 hcl:#a97842
hgt:166cm ecl:blu eyr:2024
byr:1935
pid:836748873

cid:236 ecl:amb hgt:168cm iyr:2010 hcl:#602927 byr:1950 eyr:2026 pid:404810674

eyr:2030 ecl:grn
byr:1975 pid:064596263 hgt:193cm
iyr:2019 cid:71 hcl:#a97842

iyr:2014
pid:298386733 hcl:#c0946f
hgt:180cm ecl:hzl cid:115 byr:1940 eyr:2023

iyr:1960 hgt:139 ecl:#9db7b8 byr:1980 pid:#ef597b cid:54 eyr:2028 hcl:fdcda3

iyr:2015 byr:1954 ecl:blu hgt:62in hcl:#ceb3a1 pid:253593755 eyr:2028

eyr:2025 ecl:blu pid:216388098 iyr:2017 byr:1968 hgt:151cm hcl:#602927

eyr:2022 hcl:#a97842
pid:606979543 iyr:2013 ecl:grn cid:63
hgt:186cm byr:1992

ecl:gry
hgt:168cm hcl:#18171d iyr:2017 pid:670898814 byr:1983
eyr:2022

hgt:155cm ecl:grn iyr:2012 pid:837979074 eyr:2024 hcl:#888785 byr:1972

iyr:2015 pid:970743533 hcl:#866857 eyr:2027
byr:1921 ecl:brn

eyr:2022
hgt:160cm
byr:1964 hcl:#efcc98 iyr:2019 ecl:oth pid:141923637

byr:2029 pid:3313111652 ecl:brn eyr:2034
iyr:2013 hgt:193cm hcl:z

pid:853890227 eyr:2029
hcl:#efcc98 iyr:2021 byr:2003 ecl:#037c39 hgt:160cm

iyr:1927
byr:1992
eyr:2030
hcl:#efcc98
ecl:amb hgt:152cm pid:436765906

iyr:2014
hcl:#c0946f pid:207052381
eyr:2024 ecl:hzl
hgt:177cm
byr:1923

ecl:blu
iyr:2014
eyr:2025 hgt:165cm
hcl:#733820 pid:343011857 byr:1967

ecl:xry
eyr:2028
iyr:2011 hgt:166in hcl:#c0946f
pid:805297331
cid:167 byr:1926

byr:1947
pid:468012954 eyr:2026 ecl:oth iyr:2018 hgt:170cm hcl:#b6652a

hcl:#6b5442 ecl:brn
hgt:180cm cid:233
pid:029789713
byr:1920 iyr:2010 eyr:2024

iyr:2010 eyr:2027
hgt:156cm
hcl:#c0946f
byr:1960 pid:312723130 ecl:hzl

eyr:2023 byr:1959 iyr:2010 hgt:186cm pid:066768932 ecl:grn hcl:#602927 cid:310

eyr:2030 pid:460535178 hgt:171cm ecl:gry iyr:2020 byr:1934 hcl:#888785

hgt:64cm eyr:2021 byr:1995 cid:336
ecl:gmt pid:926714223 iyr:2017 hcl:#18171d

eyr:2022 iyr:2010
ecl:grn pid:285994301 cid:215
hgt:186cm byr:1978

hgt:63in hcl:#866857
pid:386128445 iyr:2020 byr:1971 eyr:2021 ecl:gry

hgt:183cm hcl:#733820 iyr:2015
ecl:blu pid:216205626 eyr:2022 byr:1941

cid:150 ecl:amb pid:872515243 byr:1926
eyr:1996
hcl:#dedc39 hgt:67in iyr:2020

byr:1927 ecl:brn cid:153 iyr:2011
pid:165190810 hcl:#fffffd
eyr:2028 hgt:64in

pid:502603734
byr:1966 iyr:2015 hgt:176cm cid:205 ecl:brn hcl:#fffffd eyr:2021

hcl:#18171d hgt:158cm byr:1943 iyr:2019
pid:058840094
eyr:2023

byr:1962 hcl:#b6652a ecl:grn
cid:297
iyr:2010 pid:990422650
hgt:154cm eyr:2020

eyr:1934 iyr:2011
ecl:gry
hcl:z byr:2004 hgt:63cm pid:6173356201

pid:329432364 eyr:2029
ecl:grn hcl:#18171d iyr:2013
hgt:158cm byr:1960

hcl:#efcc98 iyr:2016 hgt:186cm cid:215
pid:852781253 eyr:2027 ecl:blu byr:1937

hcl:#623a2f ecl:gry iyr:2020 byr:1972 hgt:182cm pid:073426952 eyr:2027

hcl:#3317b9 byr:1950 pid:304511418 hgt:177cm cid:124 eyr:2020 ecl:hzl iyr:2014

eyr:2029
pid:034754507 byr:1936
cid:265 ecl:#b50997 hgt:183cm
hcl:#623a2f iyr:1924

eyr:2024 byr:1927 cid:243 ecl:gry hcl:#6b5442 pid:714355627 hgt:160cm
iyr:2016

hgt:152cm
ecl:gry hcl:#a97842
eyr:2029 byr:1952
pid:555308923 iyr:2010

byr:2008
pid:19681314 hgt:180in iyr:2030 ecl:gry cid:272
eyr:2023
hcl:#b6652a

cid:234
iyr:2014 byr:1940 ecl:hzl pid:042231105 hcl:#3bf69c hgt:172cm eyr:2029

hcl:#efcc98 pid:831567586 hgt:190cm iyr:2017
byr:1966 eyr:2024 ecl:blu

hcl:#341e13 ecl:blu
eyr:2022 cid:161 pid:197839646 iyr:2014

hcl:#cfa07d
byr:1957
iyr:2019 hgt:181cm
pid:543775141 ecl:oth eyr:2021

hcl:z
pid:#596c41 eyr:2035
byr:2008 iyr:1975
ecl:#c66ee6
hgt:150in

ecl:grn
hcl:#7d3b0c iyr:2016
pid:804255369 eyr:2028 byr:1983 hgt:69in cid:82

eyr:2022
iyr:2013 hgt:191cm ecl:gry
hcl:#a97842 pid:186827268 byr:1969

pid:871672398 eyr:2026 byr:1946 ecl:oth
iyr:2015
hcl:#866857 hgt:185cm

byr:1973
hgt:150cm
pid:905076707
iyr:2017
hcl:#2edf01 ecl:oth cid:221 eyr:2026

eyr:2024 ecl:grn pid:955444191 hcl:z iyr:2015 byr:2008 hgt:151cm

byr:1958 hcl:#fffffd pid:218986541 cid:203 ecl:brn hgt:154cm
iyr:2014
eyr:2026

hcl:#623a2f byr:1964 ecl:oth iyr:2010 pid:525843363 hgt:164cm eyr:2025

ecl:blu iyr:2013 hgt:193cm byr:1990 pid:612387132 hcl:#18171d cid:280 eyr:2028

ecl:oth eyr:2022
pid:110447037 hgt:187cm byr:1967 hcl:#efcc98

byr:1930
eyr:2026 hgt:159cm
iyr:2011
ecl:hzl hcl:#6b5442 pid:923471212

cid:350
eyr:2029 pid:823592758 iyr:2018
ecl:grn byr:1972 hgt:167cm hcl:#18171d

cid:76 eyr:2027 hcl:#6b5442 pid:099579798 byr:1930
iyr:2020
ecl:gry hgt:153cm

byr:1957 ecl:brn
hcl:z iyr:2016 pid:352677969 hgt:189cm
eyr:2029

cid:143 eyr:2035 pid:602952079
ecl:#9b73f0 hcl:#602927
iyr:2022 byr:1975
hgt:174cm

byr:1971 pid:741305897 hgt:192cm
ecl:amb hcl:#888785 eyr:2028 iyr:2011

ecl:oth iyr:2016
byr:1942 hgt:189cm hcl:#888785 eyr:2024 pid:054290182

hcl:#a97842
byr:1945
ecl:amb pid:370849304
eyr:2028
iyr:2016 hgt:168cm

hgt:154cm iyr:2015 eyr:2030 byr:1952 ecl:hzl hcl:#341e13 pid:996518075

byr:1941 ecl:amb iyr:2014
hcl:#fffffd pid:560990286 eyr:2022 hgt:173cm

ecl:blu byr:1974
hgt:150cm hcl:#ceb3a1 eyr:2020 iyr:2013
pid:827415351

hcl:#623a2f eyr:2027 iyr:2011 pid:913199234 ecl:oth
byr:1990 hgt:178cm

ecl:blu byr:1989 hcl:#b6652a
eyr:2026 pid:724881482 hgt:185cm iyr:2014

cid:115 pid:255002731 eyr:2025 ecl:amb
byr:1934 iyr:2020 hcl:#7d3b0c

hgt:150cm byr:1969 ecl:blu iyr:2023
hcl:#866857 pid:754288625 eyr:2029

iyr:2011 hcl:#7d3b0c ecl:hzl
byr:1930
hgt:188cm
eyr:2023
pid:256556076 cid:136

iyr:2025 byr:1978
ecl:#fe30a9 hcl:#efcc98 eyr:2029
pid:392032459 hgt:178cm

eyr:2027 iyr:2017 hgt:160in
byr:1990 pid:131099122 hcl:#623a2f ecl:amb

ecl:grn
byr:1978
eyr:2029 hcl:#18171d
hgt:165cm pid:172369888
cid:93
iyr:2011

ecl:hzl
hcl:#733820 iyr:2010 eyr:2029 pid:127253449
hgt:156cm
byr:1963

hcl:#6c8530
iyr:2020
byr:1929 eyr:2021 hgt:177cm ecl:oth pid:347925482

eyr:2037 iyr:2026
pid:163cm
hgt:174in byr:2007 hcl:c1305f cid:134
ecl:#0cf85c

iyr:2011 pid:033811215
hcl:#a97842 byr:2002 eyr:2021 hgt:186cm
ecl:brn

hcl:#a97842
iyr:2020 eyr:2029 byr:1972 pid:535511110 hgt:160cm ecl:oth

ecl:grn cid:89 hgt:193cm pid:73793987 iyr:2021 eyr:2027 byr:1939 hcl:z

hcl:#623a2f
hgt:182cm cid:154
pid:873863966 iyr:2018 byr:1999 ecl:brn eyr:2031

iyr:2014 eyr:2029
cid:71 hcl:#fffffd byr:1924 hgt:63in
ecl:gry pid:897972798

hgt:76cm
hcl:z eyr:1955
iyr:2012 byr:2001 pid:9425090 ecl:hzl

eyr:2021
pid:501861442
ecl:grn hcl:#d71ae9
byr:1977
hgt:167cm iyr:2015

iyr:2014
hgt:170cm ecl:gry byr:1928 cid:314 hcl:#602927 eyr:2029
pid:836710987

eyr:2027 hcl:#efcc98 ecl:amb iyr:2016 byr:1995 pid:603705616 hgt:179cm

eyr:2030 hcl:#602927 cid:105 byr:1943 ecl:hzl
pid:381601507
hgt:188cm iyr:2020

iyr:2011
byr:1993 hcl:#c0946f pid:292649640 hgt:139 ecl:hzl cid:268
eyr:1999

cid:339 byr:1928
ecl:brn eyr:2022 hcl:#733820 hgt:191cm pid:282733347 iyr:2019

hgt:176cm
byr:1935 ecl:brn cid:252 eyr:2023 pid:105060622 iyr:2020 hcl:#18171d

ecl:hzl eyr:2029
hgt:193cm pid:770254253
hcl:#efcc98 iyr:2020 byr:1926

pid:977785261 eyr:2022 iyr:2015 byr:1978
hcl:#733820 hgt:172cm
ecl:brn

byr:2021
hgt:160in
ecl:gmt
eyr:2032 cid:345 pid:179cm
hcl:8f5c13 iyr:2029

iyr:2018 hgt:182cm ecl:gry
pid:897076789 eyr:2023 hcl:#866857
byr:1980

hgt:88 eyr:2039 cid:99 byr:2007 hcl:a1bb42 ecl:#a2f6bb
pid:2264966188
iyr:2022

iyr:2012 cid:59 ecl:gry eyr:2021
byr:1931
hgt:172cm hcl:#7d3b0c pid:862416147

byr:1962 eyr:2025
ecl:grn
hcl:#866857 hgt:180cm iyr:2014 pid:313647071

eyr:2030 hgt:157cm byr:1985
iyr:2020
hcl:#7d3b0c pid:911544768
ecl:grn

hgt:175cm
byr:1938
iyr:2020 ecl:amb hcl:#602927 eyr:2026 pid:144411560

iyr:2019 ecl:amb hcl:#888785 eyr:2025 hgt:187cm
pid:942054361 byr:1939

cid:168 pid:722146139 byr:1952 ecl:grn
iyr:2014 hgt:97
hcl:z
eyr:2023

eyr:2024 pid:567528498 ecl:gry iyr:2012 byr:1990
hcl:#733820 hgt:193cm
cid:293

hcl:#bc352c pid:321838059 byr:1930 hgt:178cm cid:213 eyr:2023 ecl:amb
iyr:2017

hgt:173cm byr:1925 pid:070222017 iyr:2013 hcl:#ceb3a1 ecl:gry eyr:2024";
        }

        static int Day4Part2_PassportProcessing(string input)
        {
            int valid = 0;
            var rawInputs = input.Replace(Environment.NewLine + Environment.NewLine, "|").Split(new[] { '|' });

            foreach (var rawInput in rawInputs)
            {
                var passport = new Day4.PassportPart2(rawInput);
                if (passport.IsValid)
                {
                    valid++;
                }
            }

            return valid;
        }

        static int Day4Part1_PassportProcessing(string input)
        {
            int valid = 0;
            var rawInputs = input.Replace(Environment.NewLine + Environment.NewLine, "|").Split(new[] { '|' });

            foreach (var rawInput in rawInputs)
            {
                var passport = new Day4.Passport(rawInput);
                if (passport.IsValid)
                {
                    valid++;
                }
            }

            return valid;
        }

        static char[,] Day3SampleInput()
        {
            var rawInput = new char[] {
                '.', '.', '#', '#', '.', '.', '.', '.', '.', '.', '.',
                '#', '.', '.', '.', '#', '.', '.', '.', '#', '.', '.',
                '.', '#', '.', '.', '.', '.', '#', '.', '.', '#', '.',
                '.', '.', '#', '.', '#', '.', '.', '.', '#', '.', '#',
                '.', '#', '.', '.', '.', '#', '#', '.', '.', '#', '.',
                '.', '.', '#', '.', '#', '#', '.', '.', '.', '.', '.',
                '.', '#', '.', '#', '.', '#', '.', '.', '.', '.', '#',
                '.', '#', '.', '.', '.', '.', '.', '.', '.', '.', '#',
                '#', '.', '#', '#', '.', '.', '.', '#', '.', '.', '.',
                '#', '.', '.', '.', '#', '#', '.', '.', '.', '.', '#',
                '.', '#', '.', '.', '#', '.', '.', '.', '#', '.', '#'
            };

            var twoDInput = Convert1DArrayInto2D(rawInput, 11, 11);

            return twoDInput;
        }

        static char[,] Day3Input()
        {
            var rawInput = new char[]
                {
                    '.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','#','#','#','#','#','.','#','#',
                    '.','#','.','#','.','.','.','.','#','.','.','.','.','.','.','#','.','.','.','.','#','#','.','.','.','.','.','.','.','.','.',
                    '.','.','.','.','.','.','#','.','#','.','#','.','.','.','.','.','#','#','#','.','#','.','#','.','.','.','.','.','.','.','.',
                    '.','.','.','.','.','.','#','.','.','.','#','.','.','.','.','.','#','#','#','#','#','.','.','.','.','#','.','.','#','#','.',
                    '.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','#','#','.','.','.','#','#','#','.','#','#','.','.','.','.',
                    '#','.','.','.','.','.','#','.','.','.','#','.','.','.','.','#','.','.','.','.','.','.','#','#','.','.','.','.','#','#','.',
                    '#','.','.','.','#','.','#','.','.','.','.','#','.','.','#','.','.','#','#','.','#','#','.','.','.','#','.','.','.','.','.',
                    '.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','#','.','#','.','.','.','.',
                    '.','#','.','.','.','.','.','#','.','#','.','.','.','.','.','.','.','#','.','.','#','.','.','.','#','.','.','.','.','#','.',
                    '#','.','.','#','.','#','#','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','#','#','.',
                    '.','.','.','#','.','#','.','#','#','.','.','.','#','#','.','#','#','#','.','.','.','.','.','#','.','.','#','.','.','.','#',
                    '.','.','#','.','#','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','#','.',
                    '#','.','.','#','.','#','.','.','#','.','#','.','.','.','.','#','.','.','.','#','.','#','.','.','.','.','.','#','.','.','#',
                    '#','.','.','.','.','.','.','#','#','.','.','.','.','#','.','.','#','.','#','.','#','.','.','.','.','.','.','.','.','#','.',
                    '.','.','.','.','#','.','.','#','.','#','.','#','.','#','#','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#',
                    '.','.','.','.','#','.','.','#','.','.','#','.','.','.','#','.','#','.','#','#','.','.','.','.','.','.','#','.','.','.','#',
                    '#','#','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','#','#','#','.','#','.','.','.',
                    '.','.','#','.','.','.','#','.','#','.','.','.','#','.','#','.','.','.','.','.','#','.','.','.','.','#','#','.','#','#','.',
                    '.','.','.','.','#','#','.','.','.','#','#','.','#','.','.','.','.','#','.','.','.','.','.','#','.','#','#','.','.','.','.',
                    '#','.','.','.','.','.','.','.','.','#','#','.','.','.','.','.','.','#','.','.','.','.','.','.','#','.','#','.','#','.','#',
                    '.','.','.','.','#','.','#','.','#','.','.','.','.','.','.','.','.','.','#','#','.','.','.','.','.','.','#','.','.','.','.',
                    '.','#','.','.','.','.','.','.','#','.','.','.','#','.','.','.','.','.','#','#','.','.','#','.','.','.','.','#','.','.','#',
                    '.','.','.','.','#','.','.','#','.','#','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','#','.',
                    '.','.','#','#','.','.','.','#','.','.','#','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','#',
                    '.','.','.','.','.','#','.','.','.','.','#','.','#','.','.','#','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','.','#','.','.','#','.','#','.','.','.','.','.','.','#','.','#','.','.','.','.','.','.','.','.',
                    '.','.','.','.','.','#','.','#','.','.','.','.','#','#','.','#','#','#','.','.','.','.','#','.','.','.','#','.','.','.','.',
                    '.','.','.','#','#','.','#','.','.','.','.','.','.','.','#','.','.','.','.','#','#','#','.','.','#','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','.','.','.','.','.','#','#','.','#','.','.','#','.','.','.','#','.','.','.','.','.','.','.','.',
                    '#','.','.','#','#','#','.','.','#','.','.','.','.','.','#','.','#','#','#','#','.','.','.','.','.','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','#','#','.','.','.','.','.','#','.','.','.','.','.','.','#','.','.','.','.','.','.','#','.','.',
                    '#','.','.','.','.','.','.','.','.','#','#','.','.','#','.','.','.','.','.','#','#','.','.','.','.','.','.','.','#','.','#',
                    '#','.','#','#','.','.','.','#','.','.','.','#','.','.','.','#','.','.','.','.','.','.','#','#','.','.','#','.','#','.','#',
                    '.','.','.','.','.','.','#','.','.','.','.','#','#','.','#','.','#','.','.','.','#','.','.','.','#','#','.','.','.','.','#',
                    '#','.','.','#','.','.','.','.','#','#','.','#','.','.','.','.','.','.','#','.','.','.','.','.','.','.','#','#','.','.','.',
                    '.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','#','.','#',
                    '#','.','.','.','.','.','#','#','.','.','.','.','.','.','#','#','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.',
                    '.','.','#','.','#','.','.','.','.','.','#','.','#','.','.','.','#','.','.','.','.','.','.','.','.','#','.','.','.','.','.',
                    '.','.','.','#','.','.','.','.','.','.','.','.','#','.','.','#','.','.','#','.','#','#','.','.','#','#','.','.','.','.','.',
                    '.','.','.','.','.','.','#','#','#','.','.','.','.','.','#','.','.','#','.','.','.','#','.','#','#','#','.','.','.','#','#',
                    '.','#','#','.','#','#','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','#','#','#','.','.','.','#','.','.','.',
                    '#','.','#','.','.','#','.','#','.','#','.','.','.','.','#','.','.','.','.','.','#','#','#','.','.','#','.','.','.','#','#',
                    '.','.','.','.','.','.','#','.','#','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','#','#','.',
                    '#','.','.','#','.','#','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','#','#','.','.','.','#','#','.','.','.',
                    '.','.','#','.','.','.','#','.','.','.','.','#','.','.','.','.','#','#','#','.','#','.','.','.','.','.','.','#','.','.','.',
                    '.','.','.','.','.','#','.','.','#','.','#','#','#','#','#','#','.','.','.','.','.','#','.','.','#','.','#','.','.','.','.',
                    '.','.','#','.','#','.','.','.','.','.','#','.','.','.','.','.','#','#','.','#','.','.','.','.','#','#','.','#','.','#','#',
                    '.','.','.','#','.','#','.','#','.','.','.','.','#','.','.','.','.','#','#','.','.','#','.','.','#','.','#','.','#','#','.',
                    '.','.','.','.','.','.','.','.','.','.','.','#','.','#','.','.','.','#','.','.','#','.','.','#','#','#','#','.','.','.','.',
                    '.','.','.','.','.','.','.','.','.','#','#','#','#','#','.','#','.','#','.','#','.','.','.','#','.','#','#','.','#','.','.',
                    '.','.','.','.','.','.','.','#','.','.','.','#','.','.','.','.','.','.','#','.','#','#','.','#','.','#','#','.','.','.','.',
                    '.','.','.','.','#','.','.','.','.','.','#','.','.','.','.','.','#','#','#','.','.','.','.','.','.','.','.','.','.','#','.',
                    '.','#','.','#','#','#','.','.','.','.','#','#','.','#','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.',
                    '#','.','.','.','#','.','.','.','.','.','.','.','.','.','#','#','.','.','.','.','.','#','#','#','#','.','.','.','.','#','.',
                    '#','#','.','.','.','.','#','#','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.',
                    '.','.','.','#','.','#','.','#','.','#','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.',
                    '.','.','.','.','.','.','.','#','.','.','.','.','#','.','.','.','.','.','.','#','#','.','.','.','.','.','.','.','#','.','.',
                    '.','#','.','#','.','.','#','.','.','.','.','.','.','.','.','.','#','.','#','.','#','#','.','.','.','.','#','.','.','.','.',
                    '.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','#','.','#','.','#','#','.','.','#','#','#',
                    '.','#','.','#','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','#','#','.','.','#','.',
                    '.','.','#','#','.','#','.','.','#','.','.','.','.','.','.','#','.','.','.','#','#','.','.','#','.','#','#','.','.','.','#',
                    '.','.','.','.','.','.','#','.','.','#','.','.','.','.','#','.','.','.','.','#','.','.','.','.','#','#','.','.','#','.','.',
                    '.','.','.','#','.','.','.','#','#','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','#','#','.','.','.',
                    '.','.','.','#','#','.','.','.','.','#','.','#','.','#','#','.','.','.','.','.','.','.','.','#','.','.','.','.','.','#','#',
                    '.','.','.','.','#','.','#','.','.','.','.','.','.','.','#','.','.','#','#','#','.','.','#','.','.','.','.','#','#','#','#',
                    '#','.','.','.','#','.','.','.','#','#','.','.','#','.','#','#','#','#','.','.','#','.','.','.','#','#','.','.','.','.','#',
                    '.','.','.','.','.','.','.','#','.','.','#','.','#','#','.','.','#','.','.','.','#','.','#','.','.','.','.','.','.','.','.',
                    '#','#','#','.','#','.','.','.','.','.','.','#','.','.','#','#','.','.','#','.','.','.','.','.','.','#','.','#','#','.','.',
                    '#','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','#','.','.','.','.','.','.',
                    '.','.','#','#','.','.','.','#','.','.','#','#','.','.','.','.','.','.','#','.','.','#','.','.','.','.','#','.','.','.','.',
                    '.','#','.','.','#','#','.','.','.','#','.','.','.','.','#','.','#','.','.','.','#','.','.','.','#','.','.','#','.','.','#',
                    '.','.','.','.','.','.','.','.','#','.','.','.','.','#','#','#','.','.','.','#','.','.','#','#','.','.','#','#','#','.','#',
                    '.','.','.','.','.','.','.','.','.','#','.','.','.','.','#','.','.','.','.','#','.','.','#','.','#','.','#','.','.','.','#',
                    '.','#','.','.','.','.','#','#','#','.','#','#','.','.','.','#','.','#','.','.','.','.','.','.','.','.','.','.','.','#','#',
                    '.','.','#','.','.','#','.','#','.','.','#','.','#','.','#','#','.','.','#','.','.','.','#','#','.','.','.','.','.','.','.',
                    '#','#','.','.','#','.','#','.','#','.','.','.','.','#','.','.','.','#','.','.','#','.','.','.','.','.','.','.','.','.','.',
                    '#','.','.','#','.','.','.','.','.','.','.','#','.','.','.','.','#','.','.','#','#','.','.','.','#','#','#','#','.','.','.',
                    '.','.','.','.','.','.','.','.','.','.','.','.','#','.','#','.','.','.','.','.','.','.','.','.','.','#','#','.','#','#','.',
                    '#','.','.','.','#','.','.','#','.','#','.','.','.','.','#','.','.','#','.','#','.','.','.','.','#','#','.','.','.','.','.',
                    '.','.','.','.','.','.','#','.','.','.','#','.','.','.','#','.','#','#','.','.','.','.','.','.','.','.','.','.','.','.','#',
                    '#','.','.','.','.','.','#','#','.','.','#','#','#','.','.','#','.','#','.','.','#','.','#','.','#','#','.','.','#','.','#',
                    '#','.','.','#','.','#','.','.','#','.','.','.','.','.','.','#','.','.','.','.','.','.','.','#','#','.','#','.','.','.','.',
                    '#','#','.','.','#','.','#','.','.','#','.','.','.','#','.','.','.','.','.','.','#','.','#','#','.','.','.','#','#','#','.',
                    '.','#','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','#','.','#','.','.',
                    '.','.','#','.','#','.','.','#','#','.','.','.','.','#','.','.','.','.','#','.','.','#','#','.','.','.','.','.','.','.','.',
                    '.','#','.','#','.','.','.','#','.','.','#','.','.','.','.','.','#','.','#','.','.','#','#','.','.','.','.','.','.','.','.',
                    '.','.','.','.','.','#','.','.','#','.','#','.','.','.','.','.','.','#','.','.','.','.','#','.','#','.','.','#','.','#','.',
                    '.','.','.','.','#','.','#','#','#','.','.','.','#','#','#','.','#','.','#','.','.','.','.','.','#','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','.','.','.','.','#','.','#','.','.','.','.','#','#','.','.','.','.','#','#','.','.','.','.','.',
                    '.','.','#','.','.','#','.','#','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','#','.','.','.','#','.','.','#',
                    '.','.','.','.','.','#','.','#','#','#','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.',
                    '.','.','.','.','#','.','.','.','.','#','#','.','.','.','.','.','.','.','.','#','#','#','.','.','.','#','.','.','.','.','.',
                    '.','#','.','.','.','.','.','#','#','.','.','.','.','.','.','.','#','.','.','.','.','#','.','.','#','#','.','.','#','#','#',
                    '#','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','#','.','.','.','.','.','.','#',
                    '#','.','.','#','.','#','.','.','#','.','#','.','#','.','.','.','.','.','#','.','#','.','.','.','#','.','.','.','.','.','.',
                    '.','#','#','.','#','#','#','.','.','.','#','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','#','.','.','.',
                    '.','#','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.',
                    '.','#','.','#','.','.','.','.','#','.','.','.','#','#','.','.','#','.','.','.','#','.','.','.','#','#','.','.','.','.','.',
                    '.','#','.','#','.','.','.','#','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','#','.','.','.','#','.','.','.',
                    '.','.','.','.','#','.','#','.','.','#','.','#','.','.','#','.','.','.','#','.','.','.','.','#','#','.','.','.','.','.','.',
                    '.','.','.','.','#','#','.','.','.','.','.','#','.','#','#','.','.','.','.','#','.','#','#','.','.','#','#','.','.','#','#',
                    '.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','#','#','#','.','#','#','.','.','#','.','.','.',
                    '.','#','.','.','#','.','.','.','.','.','.','.','.','.','#','.','#','#','.','.','.','.','#','.','.','.','.','#','.','.','#',
                    '.','#','.','.','#','#','.','.','#','.','.','#','.','.','.','.','.','.','.','.','#','.','#','.','#','#','.','#','.','#','#',
                    '.','#','#','#','.','#','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','#','.',
                    '.','.','.','#','.','#','#','.','#','#','.','#','.','.','.','.','.','.','#','.','.','.','#','.','.','.','.','#','#','.','#',
                    '#','.','.','.','.','.','.','#','#','.','.','.','.','.','.','.','#','#','.','.','.','#','#','#','.','.','.','.','#','.','#',
                    '#','.','.','#','#','.','.','.','.','.','#','#','.','.','.','.','.','.','#','.','#','.','#','#','.','.','.','.','#','.','#',
                    '.','.','.','#','.','#','.','.','.','.','#','.','#','.','#','.','.','.','.','.','.','.','.','.','.','.','#','#','.','.','#',
                    '#','.','.','.','.','.','#','#','.','.','.','.','.','.','#','#','.','#','.','.','.','.','.','.','.','.','.','.','#','#','.',
                    '#','#','#','.','.','.','.','#','.','#','.','.','.','#','.','#','.','.','#','#','#','#','.','.','.','.','.','.','.','.','.',
                    '.','#','#','.','#','.','#','.','.','.','#','#','.','.','#','.','.','.','.','.','#','.','.','#','.','.','.','#','.','.','.',
                    '#','.','.','.','.','.','#','.','#','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','#','.','.',
                    '.','.','#','#','#','.','#','#','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.',
                    '#','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','.','.','.','.','.','.','#','.','#','#','.',
                    '#','.','#','.','#','.','#','.','.','#','.','.','.','.','.','#','#','.','.','#','#','.','#','.','.','.','.','#','.','.','.',
                    '.','.','.','#','.','.','.','#','.','.','#','.','.','.','#','.','.','#','#','.','.','#','#','.','.','.','.','.','.','.','.',
                    '.','.','.','#','#','.','.','.','#','#','.','.','#','.','.','.','#','#','.','.','.','.','.','.','.','.','.','.','.','#','.',
                    '.','#','#','#','#','.','.','#','.','#','.','#','.','#','#','.','#','.','.','.','.','.','.','.','#','.','.','.','.','.','.',
                    '.','.','.','#','.','.','.','.','#','.','.','.','.','.','.','.','#','.','.','.','.','.','.','#','.','.','.','.','.','.','.',
                    '.','.','.','.','.','#','.','#','.','.','.','#','.','.','.','#','.','.','#','#','.','.','#','.','.','#','.','.','.','.','.',
                    '.','.','.','.','.','.','#','.','.','.','.','.','#','#','#','.','#','.','.','#','.','.','#','.','#','.','.','#','#','#','.',
                    '.','#','.','.','.','.','#','.','.','.','.','#','.','.','#','.','.','#','#','.','.','.','.','.','#','#','.','.','.','#','.',
                    '.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','#','#','.','#','#','#','.','#','.','.','.','#','.','#','.','.',
                    '#','.','.','#','.','.','#','.','.','.','.','.','.','#','.','#','#','#','.','.','.','.','.','.','.','.','.','.','.','.','#',
                    '#','#','.','#','.','.','#','#','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','#','.','#','.','.','.',
                    '.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','#','.','.','.','#','.','.','.','.','.','.','.','#','#','.','.',
                    '.','.','.','.','#','.','#','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','#','.','#','.','.',
                    '.','.','.','#','.','.','#','.','.','.','#','.','#','.','.','.','#','.','.','.','.','.','.','.','.','#','.','.','.','.','.',
                    '.','.','.','.','.','#','#','.','.','.','#','.','.','.','.','#','.','.','.','.','.','.','.','.','.','#','#','.','#','#','.',
                    '.','.','.','.','#','.','.','.','#','.','.','.','#','.','#','#','.','#','#','.','.','.','#','.','.','.','.','#','.','.','.',
                    '.','#','.','.','#','.','.','.','.','.','#','#','.','.','.','.','.','.','#','.','.','#','.','#','.','.','#','.','.','.','.',
                    '.','.','.','.','.','.','.','.','#','#','.','.','.','#','#','.','#','#','.','.','.','.','.','.','#','.','#','.','#','.','#',
                    '.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','.','.','.','#','#','.','#','.',
                    '.','.','.','#','.','.','.','.','.','#','.','.','.','#','.','.','.','.','.','.','.','.','.','#','.','.','#','.','#','.','#',
                    '.','.','.','.','#','#','.','#','.','.','.','.','.','#','.','.','.','.','.','.','.','.','#','.','.','.','#','.','.','#','.',
                    '#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','.','.','.','#','.','.','.','#','.',
                    '.','.','.','.','.','#','.','.','#','.','.','.','.','#','.','.','.','#','.','#','#','#','#','.','#','.','#','.','.','.','.',
                    '#','#','#','#','.','#','.','.','#','.','#','#','.','.','.','#','.','.','.','.','#','.','.','.','#','#','.','.','.','.','.',
                    '#','.','.','.','#','#','.','.','#','.','.','.','#','#','#','#','.','.','#','.','.','.','.','#','.','#','.','.','.','#','.',
                    '.','.','#','.','.','.','.','.','.','.','#','.','#','#','.','.','#','#','.','.','.','#','.','#','.','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','.','.','.','.','#','#','.','.','.','.','.','.','.','#','.','.','.','.','#','.','.','#','.','.',
                    '#','.','#','#','.','.','.','.','#','.','.','.','#','.','.','.','.','.','#','.','.','.','.','#','#','.','.','.','.','.','.',
                    '.','.','.','.','#','#','.','#','.','.','.','.','.','.','.','#','.','.','#','.','.','.','#','#','.','.','.','.','.','.','.',
                    '.','.','.','#','.','.','.','.','.','.','.','.','.','#','#','.','#','.','.','#','.','.','.','.','.','.','#','.','#','#','#',
                    '.','#','.','.','#','.','.','#','.','.','.','.','#','.','#','.','#','#','.','.','.','.','#','#','#','.','.','#','#','#','.',
                    '.','.','.','.','#','.','#','.','.','.','.','.','.','.','.','#','#','.','.','.','.','.','.','.','.','#','#','.','.','.','.',
                    '.','.','.','.','#','#','#','#','#','#','#','#','.','.','.','.','#','.','#','.','#','.','#','#','#','.','#','.','.','.','#',
                    '.','.','.','#','.','#','#','#','.','#','#','#','.','#','#','.','.','.','.','.','.','#','#','.','.','.','.','.','.','.','#',
                    '.','#','.','.','.','#','.','#','#','#','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.',
                    '.','.','#','.','.','#','#','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','#','.',
                    '.','.','.','.','.','.','.','#','#','.','#','.','.','.','#','.','.','.','#','#','.','.','.','#','.','.','.','#','.','.','#',
                    '#','.','#','#','.','.','.','.','#','.','#','.','.','.','#','.','.','.','.','.','#','.','.','#','.','#','.','.','.','.','.',
                    '.','.','#','.','.','.','.','.','.','.','.','#','.','.','#','.','#','.','#','.','#','.','.','.','.','#','.','#','#','.','.',
                    '.','.','.','#','.','.','.','#','.','#','.','.','.','.','.','.','.','.','.','#','.','.','.','#','.','#','.','.','#','#','.',
                    '#','.','.','.','.','#','.','.','.','.','.','.','#','.','#','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','#',
                    '.','.','.','#','.','#','.','#','.','.','#','.','.','.','#','#','.','.','.','#','.','.','.','#','.','.','.','#','.','.','.',
                    '#','#','#','.','.','.','.','.','.','.','.','.','.','#','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.',
                    '.','.','#','.','.','.','.','#','.','#','.','#','.','#','.','.','.','.','.','.','.','.','.','.','.','.','#','.','#','.','.',
                    '.','.','.','.','#','.','.','.','#','.','.','#','#','#','.','.','.','#','.','#','.','.','.','.','#','.','.','.','.','.','.',
                    '#','.','.','.','.','.','.','.','.','.','.','.','#','#','#','#','.','.','.','.','.','.','#','#','.','#','.','.','.','.','.',
                    '.','.','#','.','.','#','#','.','#','.','.','.','#','.','.','.','.','.','#','.','.','#','.','.','.','.','.','.','.','#','#',
                    '#','.','.','.','.','.','#','.','.','#','#','#','.','.','.','.','.','#','.','.','.','#','#','.','.','#','#','.','.','.','.',
                    '#','#','.','.','#','#','#','.','.','#','#','.','.','.','.','.','.','.','.','.','.','.','#','.','#','.','.','.','#','.','.',
                    '.','.','.','.','.','#','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.',
                    '#','.','.','#','.','#','#','.','#','#','#','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','#','.','.','.','#',
                    '#','.','.','.','.','.','.','.','.','#','.','.','.','.','#','#','.','.','.','.','.','.','#','.','#','.','.','.','.','.','.',
                    '.','#','.','#','.','#','.','.','.','#','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','#','.','#','#','.',
                    '#','.','.','#','.','.','#','#','.','.','.','.','.','#','.','.','.','#','.','#','.','#','.','#','.','.','#','#','#','.','.',
                    '.','#','.','#','.','.','.','.','#','.','.','#','.','.','#','.','#','.','.','.','.','#','#','.','#','.','#','.','.','.','.',
                    '.','.','#','.','#','.','.','.','.','.','.','.','.','.','#','#','#','#','.','#','.','.','.','#','.','#','.','#','#','#','.',
                    '.','.','.','.','#','#','.','.','.','.','.','.','.','.','#','#','.','.','.','.','#','.','.','.','.','.','.','.','.','#','.',
                    '.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.',
                    '.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','#','#','.','#','#','.','.','#',
                    '.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','#','.','#','.','.','.','#','.','.','.','.','#','.','#','.','#',
                    '.','.','.','.','.','.','#','.','.','.','.','.','#','#','#','.','.','.','.','.','#','.','#','.','.','#','.','.','.','#','.',
                    '.','#','.','#','.','.','.','.','.','#','.','.','#','#','.','.','.','.','.','.','.','.','.','.','.','.','#','#','.','.','.',
                    '.','.','.','#','#','.','.','.','.','.','.','#','#','.','#','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.',
                    '.','.','.','#','#','.','.','#','#','.','.','#','#','#','.','#','.','.','.','#','#','.','.','.','.','.','.','.','.','.','.',
                    '.','.','.','.','#','#','#','.','.','.','#','.','.','#','.','#','.','.','.','.','.','.','#','.','.','.','.','.','.','#','.',
                    '.','.','.','.','#','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','#','.','#','.','.',
                    '#','#','#','#','.','.','.','.','.','.','.','#','.','.','.','#','#','.','#','#','.','.','#','.','#','.','.','.','.','.','.',
                    '.','#','.','.','.','.','.','.','#','.','.','.','.','.','#','.','.','.','.','#','#','#','.','.','#','.','.','.','.','#','.',
                    '.','#','.','.','.','.','.','.','.','#','.','.','.','#','#','.','.','.','#','.','.','#','#','.','#','.','.','.','.','.','.',
                    '#','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','#','.','#','.','.','.','.','#','.','#','.','#','.','.','#',
                    '.','.','.','.','.','.','.','.','#','.','.','#','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','#','#','.','#',
                    '#','.','#','.','.','.','#','.','#','.','.','#','#','.','.','#','.','.','.','.','.','.','.','#','#','.','.','#','.','.','.',
                    '.','.','.','#','.','.','.','.','#','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','#','.','.','#','.','.','.',
                    '#','.','#','.','.','.','#','.','#','#','.','.','.','.','#','#','#','.','.','.','.','.','.','#','#','.','.','.','.','#','.',
                    '#','.','.','#','.','.','.','#','#','#','.','.','.','.','.','.','.','.','#','.','.','#','.','.','.','.','#','.','.','#','.',
                    '#','.','.','.','.','#','.','.','.','.','#','#','#','.','.','.','.','#','.','.','#','.','.','.','.','.','.','.','#','.','.',
                    '.','.','.','.','#','.','#','.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.',
                    '.','#','.','#','#','.','.','.','.','.','.','.','.','#','#','.','.','.','#','.','.','.','#','.','.','.','#','.','.','.','#',
                    '#','.','.','.','.','.','#','#','.','.','.','.','.','#','.','.','.','.','.','.','.','#','.','#','.','#','.','.','.','.','.',
                    '.','#','.','#','#','.','.','.','.','.','.','.','.','.','.','#','#','.','.','#','.','.','.','.','#','.','.','.','.','.','.',
                    '.','#','.','.','#','#','.','#','#','.','#','.','.','.','#','#','.','.','.','.','#','.','#','.','.','.','.','#','#','.','.',
                    '.','.','.','.','.','.','.','.','#','.','#','.','#','#','.','#','.','.','.','.','#','.','#','.','.','#','.','.','.','.','#',
                    '.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#',
                    '.','#','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','#','.','.','.','.','#','.','#','.','.','#','.','.',
                    '.','.','.','.','.','.','.','.','#','#','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','#','.','.','.','#','.',
                    '.','.','#','.','.','.','.','.','#','.','.','#','.','.','.','.','.','.','#','.','.','#','#','.','.','.','.','.','.','.','#',
                    '.','.','#','.','.','.','.','#','#','#','.','.','#','#','#','.','.','.','#','.','#','.','#','.','.','#','.','.','.','.','#',
                    '#','.','.','#','.','#','.','.','.','#','.','.','.','.','.','.','#','#','.','.','.','.','.','.','#','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','#','#','.','.','#','#','.','.','.','.','#','#','.','.','.','.',
                    '#','.','#','.','.','.','.','.','.','#','#','#','.','.','#','.','.','.','.','.','#','.','.','.','.','.','.','.','#','.','#',
                    '#','.','.','.','.','.','#','.','.','.','.','#','.','.','.','.','#','.','#','.','.','.','#','.','.','.','#','.','.','.','.',
                    '.','.','.','.','#','.','.','.','#','.','.','.','.','.','.','.','#','.','.','.','.','#','#','.','#','.','.','#','.','.','.',
                    '.','#','#','#','#','.','.','#','#','.','.','.','.','.','.','#','#','.','#','.','.','.','.','.','.','.','.','#','.','.','#',
                    '.','.','#','#','#','.','.','#','.','#','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','#','#','.','.',
                    '.','.','#','#','.','#','.','#','.','.','#','.','.','.','.','#','.','.','#','.','.','#','.','.','.','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','.','.','.','#','.','#','.','#','#','#','#','#','.','.','.','#','.','.','.','.','.','.','.','.',
                    '.','#','#','#','.','.','.','.','.','.','#','#','.','#','.','.','.','.','#','.','.','.','.','.','.','.','.','#','.','.','.',
                    '.','.','.','.','.','#','.','.','#','.','.','#','.','#','.','.','#','.','.','.','.','.','.','.','.','.','#','.','.','.','.',
                    '.','.','#','.','.','.','.','#','.','.','.','#','.','.','.','#','.','.','.','#','#','.','.','.','.','.','.','.','.','.','.',
                    '.','.','.','.','#','.','.','#','#','.','#','.','.','.','.','.','.','.','.','.','#','#','.','#','.','.','#','#','.','.','.',
                    '#','#','.','#','#','#','#','.','.','#','.','.','.','#','.','#','.','.','.','#','.','.','.','.','.','#','.','.','#','#','#',
                    '.','.','#','.','.','#','.','.','.','#','.','.','.','#','.','.','.','.','.','#','#','.','.','.','.','#','.','.','#','.','#',
                    '#','.','.','#','#','.','.','#','.','.','.','.','.','#','.','.','.','.','#','.','#','.','.','.','.','.','#','#','.','.','#',
                    '.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','#','#','.','.','.','.','.','#','.','.','.','.','.','.','#','.',
                    '.','.','.','.','.','.','#','.','.','.','#','.','.','.','.','.','#','.','#','.','.','#','#','#','.','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','#','#','#','.','#','#','.','.','#','.','.','.','#','.','.','.',
                    '.','#','.','.','.','#','.','#','#','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','#','.','.','#','#','.',
                    '.','.','.','.','.','.','#','.','.','.','.','.','.','.','#','#','.','.','.','.','.','#','.','.','.','.','.','#','#','.','.',
                    '.','.','.','.','.','.','.','.','#','#','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','#','.','.','.','.','.',
                    '#','#','.','.','.','.','.','.','.','#','#','#','.','.','#','#','#','.','.','.','#','#','.','.','.','#','.','.','.','.','.',
                    '#','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','#','.','#','.','.','.','.','.','.',
                    '.','.','#','#','.','.','.','.','.','.','.','.','#','.','#','#','#','.','.','.','.','.','#','.','.','.','.','#','#','.','.',
                    '.','.','.','.','.','.','#','.','.','.','#','.','.','.','.','.','.','#','.','.','.','.','#','#','.','.','.','.','.','.','#',
                    '.','.','#','.','.','.','.','.','#','.','.','.','#','#','.','.','.','#','.','.','.','.','.','.','.','#','.','.','#','.','.',
                    '.','.','#','.','#','#','#','.','.','#','#','.','#','#','.','.','.','#','.','.','.','.','#','.','.','.','#','#','.','#','.',
                    '.','.','.','.','.','.','.','.','#','#','.','.','.','#','.','.','#','.','#','.','.','#','#','.','.','.','.','.','#','.','#',
                    '.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','#',
                    '.','.','#','#','.','#','#','#','.','.','.','.','.','.','#','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','#',
                    '.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','#','#','#','.','.','.','.','.','.','.','.','.','.','.','.',
                    '#','#','.','.','.','#','#','.','.','.','.','.','#','.','.','.','.','.','.','.','#','#','.','.','.','.','.','.','.','#','.',
                    '.','.','.','#','.','.','#','#','.','.','#','#','.','.','#','.','#','.','#','#','#','.','.','#','.','.','.','.','.','.','#',
                    '.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','#','.','#','.','.','#','.','.','#','.','.','.','.','.',
                    '.','#','.','.','.','.','.','.','#','.','.','.','.','#','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','#','.',
                    '.','#','#','.','.','.','.','.','.','.','.','.','.','.','#','#','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.',
                    '.','#','.','.','#','.','.','.','.','#','#','#','.','.','.','.','.','.','.','#','.','.','.','.','#','.','.','#','#','.','.',
                    '.','.','.','.','.','#','#','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','#','.','#','.','#','.','.','.',
                    '.','.','.','#','.','.','.','.','#','#','#','.','#','.','#','.','.','.','.','.','.','#','.','.','.','.','.','.','#','.','.',
                    '#','.','#','.','#','#','.','#','.','.','.','.','.','#','.','.','#','.','.','.','.','.','.','.','.','#','.','.','.','#','.',
                    '.','.','.','#','.','#','#','.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','.','.','.','#','.','.','.','.','.',
                    '.','#','#','.','.','.','#','#','.','.','.','.','.','.','#','#','.','.','.','#','#','#','.','.','.','#','.','.','.','.','.',
                    '.','.','.','#','.','.','.','.','.','#','.','#','#','.','.','#','.','.','.','#','.','.','#','.','.','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','#','.','#','.','#','.','.','#','#','.',
                    '#','#','#','.','.','.','#','.','.','.','.','.','#','.','.','.','#','.','.','#','.','.','.','.','.','.','.','.','#','#','.',
                    '#','#','.','.','.','#','.','.','#','.','.','.','.','.','#','.','#','.','.','.','.','#','.','#','.','#','.','.','.','.','.',
                    '#','.','.','#','#','.','.','.','.','.','.','.','#','.','.','.','#','.','#','.','.','.','#','#','.','.','#','.','.','.','.',
                    '#','.','.','.','#','.','#','#','.','.','.','.','.','#','.','#','.','.','#','.','#','#','.','.','.','.','.','.','#','.','#',
                    '.','.','#','.','.','.','.','.','.','#','.','#','.','#','.','#','#','.','#','#','.','.','.','.','.','.','.','.','.','.','#',
                    '.','.','#','.','#','#','.','.','.','.','.','.','#','.','#','.','#','.','.','#','#','.','.','.','.','.','.','.','.','.','.',
                    '.','.','.','.','#','.','.','#','.','.','.','.','#','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#',
                    '.','.','.','.','.','.','.','.','.','.','#','#','#','.','.','.','.','.','#','#','.','.','#','.','.','.','.','.','.','.','.',
                    '.','.','.','#','.','.','.','.','.','#','#','.','.','.','.','.','#','.','.','#','.','#','.','.','#','.','.','.','#','#','.',
                    '.','#','.','.','#','#','.','#','.','.','#','.','.','.','.','#','.','#','.','.','.','.','.','.','#','.','#','#','.','.','.',
                    '.','.','.','#','.','.','.','.','.','#','.','.','#','.','#','.','.','.','#','.','.','#','.','.','.','.','.','#','.','#','.',
                    '#','.','.','.','#','.','#','.','.','.','.','.','.','#','#','.','.','.','#','.','.','#','.','.','.','#','.','.','.','.','#',
                    '.','.','#','.','.','.','.','.','.','.','#','#','.','.','.','#','.','.','#','.','.','.','.','.','.','.','#','.','.','.','#',
                    '#','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','#','#','.','#','.','.','.','.','.','.','.','.','.',
                    '.','#','.','.','.','.','.','.','#','#','.','.','.','.','.','#','#','#','#','.','.','.','#','.','.','.','.','.','.','.','#',
                    '.','.','.','.','.','.','.','.','#','.','.','#','.','.','.','.','.','#','.','.','.','.','.','.','.','#','.','.','#','.','.',
                    '.','.','.','.','#','.','#','.','.','.','#','#','.','.','#','#','.','.','.','#','.','.','#','.','.','.','.','#','.','.','.',
                    '#','.','#','.','.','.','.','.','.','#','.','.','.','#','.','#','.','#','#','#','.','.','.','.','.','#','.','.','.','.','.',
                    '.','.','#','#','.','.','.','#','.','#','.','.','.','.','.','.','.','.','#','.','#','#','.','.','.','.','#','.','#','.','#',
                    '.','#','.','.','.','.','#','.','.','.','.','.','.','#','.','#','.','.','.','#','#','#','.','#','.','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','#','.','#','.','.','.','#','#','.','.','.','.','#','.','#','.','.','.','.','#','.','.','.','.',
                    '.','.','.','.','.','#','#','.','.','#','#','.','.','.','#','.','.','#','.','#','.','.','.','.','.','#','#','.','.','#','.',
                    '.','#','#','.','.','#','.','#','.','#','.','.','.','.','#','#','.','#','.','.','.','#','.','.','.','.','.','#','.','.','.',
                    '.','#','.','.','#','.','.','#','#','.','.','.','.','#','.','#','#','.','.','.','.','.','.','.','#','.','.','.','#','.','.',
                    '.','.','.','.','#','.','#','#','.','.','.','#','.','.','#','#','.','.','.','.','.','.','#','.','.','.','.','.','#','.','.',
                    '.','#','.','.','#','.','.','.','.','#','#','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.',
                    '.','.','#','#','.','.','.','#','.','.','.','.','.','#','#','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','#','.','#','#','.','.','.','.','.','.','.','.','#','.','#',
                    '.','#','.','#','.','.','.','.','#','.','.','.','.','#','.','.','.','#','.','#','.','.','.','.','.','.','.','.','#','.','.',
                    '.','#','#','.','.','.','#','.','.','.','#','.','#','.','.','.','.','#','.','.','.','.','#','.','#','.','.','.','.','.','#',
                    '#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','#','.','#','#','#','#','.','#','.',
                    '.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','.','.','.','#','#','.','.',
                    '#','.','#','.','.','#','#','.','#','#','.','.','.','.','.','#','.','.','.','.','.','.','#','.','.','#','.','#','.','.','#',
                    '#','#','.','#','#','.','.','#','.','#','#','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','#',
                    '.','.','.','#','.','.','#','.','.','.','.','.','.','#','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','.','#','#','#','.','#','.','#','.','.','#','.','.','.','#','.','.','.','.','.','#','.','#','#',
                    '.','.','#','.','.','.','.','.','.','.','#','.','#','#','.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','.','.',
                    '.','.','.','#','#','.','#','.','.','.','.','.','.','.','.','#','#','.','.','.','#','.','#','.','#','#','.','.','#','.','.',
                    '.','.','.','#','.','.','#','.','.','.','.','.','.','#','.','.','.','#','.','.','.','.','#','.','.','.','.','.','.','.','.',
                    '.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','#','.','.','.','#','#','.','.','.','#','.','.','.','.',
                    '.','.','.','#','.','.','.','.','.','#','.','.','.','.','#','.','.','#','#','#','#','.','.','#','#','.','.','.','.','.','#',
                    '.','.','.','.','.','.','.','#','.','.','#','.','.','#','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','#',
                    '#','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','#','#','#','.','.','.','.','.','#','#','.','.','.','.','#',
                    '.','.','#','.','.','#','.','.','#','.','#','.','#','.','.','.','.','#','#','.','.','.','#','#','.','.','.','.','.','.','#',
                    '#','.','#','.','.','#','.','.','#','#','#','.','#','.','.','#','.','.','.','.','.','#','#','#','#','.','.','.','.','.','.',
                    '.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','#','#','#','#','.','.','.','.','#','.','.','.',
                    '.','#','.','.','.','.','.','.','.','.','.','#','.','.','.','#','.','.','.','.','.','.','.','#','.','.','.','.','.','.','#',
                    '.','.','#','.','.','.','.','.','.','.','#','#','#','#','#','#','#','.','.','.','.','.','.','.','.','#','.','.','.','.','.',
                    '.','.','#','.','.','.','.','.','.','.','.','#','.','.','.','.','.','#','.','.','#','.','.','.','#','.','.','#','.','.','#',
                    '.','#','.','.','#','.','#','.','.','#','.','.','.','.','#','.','#','.','.','#','#','.','.','.','#','.','.','#','.','#','.',
                    '.','.','#','.','.','.','.','.','.','.','.','.','.','.','#','.','#','.','.','.','#','.','#','.','#','#','.','.','.','.','.',
                    '.','.','.','#','.','#','.','#','.','.','.','.','#','#','.','#','#','#','.','.','.','.','#','.','.','.','#','#','#','#','.',
                    '.','.','.','.','.','#','.','.','#','.','.','.','.','.','#','.','.','#','.','#','.','.','.','.','.','.','.','.','.','#','.',
                    '.','.','.','.','.','.','#','#','.','.','.','#','.','.','.','#','#','#','.','.','.','.','.','.','.','.','.','.','.','.','#',
                    '.','.','#','.','#','.','.','.','.','.','.','#','#','#','.','.','#','#','#','#','.','.','#','.','.','.','.','.','.','#','.',
                    '#','#','#','.','#','#','.','#','.','.','#','.','.','.','.','.','.','#','#','.','#','.','.','#','#','.','.','.','.','.','#',
                    '.','.','.','.','#','#','#','.','.','.','#','#','.','.','.','.','.','.','.','.','.','.','.','.','#','.','#','.','.','.','.',
                    '.','.','#','.','.','.','.','.','#','#','.','.','.','#','.','.','.','#','#','.','.','.','.','#','.','.','.','#','.','.','.',
                    '#','.','.','.','.','.','#','.','.','.','.','.','#','.','.','.','#','.','.','.','#','.','#','.','.','#','.','.','.','.','.',
                    '#','#','#','#','.','.','.','.','.','.','.','.','.','.','#','#','.','#','.','#','.','.','#','.','.','.','.','.','#','#','.',
                    '.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','#','.','.','.','#','#','.','.','#','#','.','#','.',
                    '.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','#','.','#','.','.','#','.','.','#','.','.',
                    '#','.','.','.','.','#','#','#','.','.','.','.','.','#','.','#','.','.','.','#','.','.','.','.','.','.','.','#','#','.','#',
                    '#','.','.','#','.','#','#','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','#','.','.','.',
                    '.','.','.','#','.','#','.','#','#','#','.','.','.','.','.','.','.','#','#','.','.','#','.','.','.','.','.','#','.','.','.',
                    '#','.','.','.','#','.','#','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','.','#','.','.',
                    '#','.','.','.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#',
                    '.','.','#','.','#','.','.','.','.','#','.','#','.','.','#','#','.','#','.','.','.','#','.','.','#','.','.','.','.','#','.',
                    '#','.','.','.','#','.','.','.','.','.','.','.','.','.','.','#','.','.','.','#','#','#','.','.','.','.','#','.','.','.','#',
                    '.','.','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','.','.','#','.','.','.','.','#',
                    '#','.','#','.','.','.','.','.','.','.','#','#','.','.','.','.','.','.','.','#','.','#','.','.','.','.','#','#','.','.','#',
                    '#','#','.','.','.','#','.','.','.','.','#','.','.','.','.','.','.','.','.','.','.','.','.','.','#','.','.','#','.','.','.',
                    '.','.','.','.','.','.','.','.','#','.','.','.','#','#','#','.','#','#','.','#','.','.','#','#','#','.','#','.','.','.','#',
                    '.','.','.','#','#','.','.','.','#','.','.','#','.','.','#','.','.','.','#','#','.','.','#','#','.','.','.','.','.','.','#',
                    '.','.','#','.','.','.','.','.','.','.','#','#','.','.','.','.','#','.','#','.','#','#','.','.','.','.','#','.','.','.','.',
                    '.','.','.','.','.','#','.','.','.','.','#','.','.','#','.','#','.','.','.','#','#','.','#','.','#','.','.','.','.','.','#'
                };

            var twoDInput = Convert1DArrayInto2D(rawInput, 323, 31);
            for (int counter = 0; counter < rawInput.Length; counter++)
            {
                twoDInput[counter / 31, counter % 31] = rawInput[counter];
            }

            return twoDInput;
        }

        static char[,] Convert1DArrayInto2D(char[] input, int rows, int columns)
        {
            var twoDInput = new char[rows, columns];
            for (int counter = 0; counter < input.Length; counter++)
            {
                twoDInput[counter / columns, counter % columns] = input[counter];
            }

            return twoDInput;
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

        static IEnumerable<string> Day2Input()
        {
            return new string[] {
                "8 - 11 l: qllllqllklhlvtl",
                 "1 - 3 m: wmmmmmttm",
                 "2 - 4 p: pgppp",
                 "11 - 12 n: nnndnnnnnnnn",
                 "17 - 19 q: qprqdcgrqrqmmhtqqvr",
                 "16 - 17 k: nphkpzqswcltkkbkk",
                 "6 - 9 c: rvcvlcjcbhxs",
                 "18 - 20 v: hbjhmrtwzfqfvhzjjvcv",
                 "5 - 9 z: jzzhzttttnz",
                 "7 - 13 d: bdqdtddddnwdd",
                 "9 - 11 d: ddddddddxdldddd",
                 "6 - 10 f: fblhfdztgf",
                 "2 - 11 b: vszxfnwghcb",
                 "15 - 18 n: nbnmwxnnlkmlknnnhn",
                 "2 - 9 z: lhwqvczrrqqhqlfvkbcm",
                 "15 - 16 d: dndddddddjdddddbdld",
                 "7 - 8 k: kkkmkkkf",
                 "1 - 8 p: rdcmrkbwqjpph",
                 "2 - 6 s: cswdpsjgsfvzkvqqmrqf",
                 "9 - 11 m: mmmmmmmzbmmmv",
                 "8 - 9 j: jjjjjjjjfj",
                 "7 - 8 d: dddsjnds",
                 "1 - 4 f: qffb",
                 "3 - 8 f: cphmtfff",
                 "1 - 13 s: rjsscssstsvssss",
                 "9 - 14 s: gtsnlbqnckhxmssbbs",
                 "12 - 14 j: jfjnjbjrjpdndj",
                 "15 - 16 t: tttttttttttttttwt",
                 "7 - 8 r: rgrdrrrrrrrrjhrrrrrr",
                 "5 - 8 t: lpcqfgzttlt",
                 "1 - 12 r: wrrrrrrjrrrrrrrr",
                 "14 - 19 d: ddvcdddddddhddprldl",
                 "4 - 8 d: pkddlzxsl",
                 "7 - 11 x: xhxqxcfkxwxxnm",
                 "3 - 7 q: qqqqqqjqqqd",
                 "3 - 13 s: rtzsktsdfhtbs",
                 "8 - 15 n: nnnnnnnnknnnnnsnnn",
                 "10 - 13 r: rrrrrrrrrrrrnr",
                 "1 - 9 r: ldfdgzprnptrd",
                 "2 - 3 k: rqkthj",
                 "4 - 7 p: prrpswdpnmpxmjzsp",
                 "12 - 13 p: pmwbptnpppjprfpkppgj",
                 "4 - 6 w: cfwdlw",
                 "2 - 9 r: pnnvrfjhz",
                 "14 - 16 b: bbbbbbbbbbbbbtbbb",
                 "2 - 7 l: xlmzgklxljcl",
                 "1 - 6 c: cccccccc",
                 "11 - 12 w: dmpzfzpwwnwwpggw",
                 "2 - 3 c: xrccccmcc",
                 "12 - 13 k: kkkkkkkvkkkvkknkkk",
                 "10 - 12 h: hhnhcvhhhqhh",
                 "17 - 18 d: dddjddbdzdddvddddw",
                 "1 - 5 p: pppphp",
                 "11 - 13 v: fvvvvjlvbvrvdhbvv",
                 "10 - 14 b: bzxxqcgqnbkmhm",
                 "1 - 14 g: xggghgngqnggggggggg",
                 "9 - 10 s: xslsmpfnxvvssqmgf",
                 "16 - 17 s: nfqggjzbfsssllwns",
                 "9 - 10 w: wwwwwwwwfw",
                 "13 - 15 z: zzzjzzzjzzzzzzgz",
                 "7 - 10 n: jfnwgwnnnn",
                 "4 - 5 b: btbqb",
                 "1 - 5 w: vwflw",
                 "15 - 16 v: vvxvdvvvvzvxmhxvv",
                 "3 - 4 b: cgbbqk",
                 "1 - 3 f: bffffdfclfffgfkf",
                 "6 - 11 m: xckgmdcqmwk",
                 "6 - 9 c: vcptncxbcg",
                 "5 - 6 m: mmmmdm",
                 "2 - 3 d: dmdd",
                 "5 - 7 v: vvhrxkd",
                 "7 - 10 b: bbbbbbqbbbbb",
                 "8 - 9 m: mhvmmwlgm",
                 "3 - 4 x: xvtxkz",
                 "3 - 9 w: wwlwwwwwkqww",
                 "4 - 18 g: mxslljzcgpwsrggqqc",
                 "2 - 3 x: xcff",
                 "16 - 17 j: jjjjjjjjjjfqjfjwhjjj",
                 "9 - 13 p: ppppppppgppppp",
                 "16 - 17 f: fffffffffffffffffff",
                 "3 - 5 c: cncpcck",
                 "9 - 11 c: kzcwczccccmcfsrcc",
                 "3 - 7 s: ssdsssvnsssssjs",
                 "1 - 6 v: vvvvqv",
                 "5 - 7 b: fzbbxbbbgbb",
                 "3 - 9 t: gtttttttftt",
                 "5 - 19 p: ngpnpklwsclptfjvtgm",
                 "3 - 4 d: dddtdddddd",
                 "4 - 5 m: mjmmwl",
                 "11 - 13 l: lllblllllvllrl",
                 "2 - 6 h: cphqvz",
                 "17 - 19 w: gwwrvfglsljwfgxwbbw",
                 "15 - 17 x: gfcxzcwgjmkwfqxrxzrd",
                 "13 - 14 w: lrmhhxwfkwnkwnbsq",
                 "7 - 8 f: ffffffgcff",
                 "11 - 19 v: vvvvvvvvvvzvvvvvvvlv",
                 "7 - 8 k: kxkkkkpk",
                 "7 - 14 v: vfvvvskttcvvvvvfvv",
                 "11 - 12 m: mmmdhmmgmkgmjmr",
                 "1 - 7 p: hpppppppppbnc",
                 "3 - 8 n: rttbbpjnmzn",
                 "8 - 9 n: nrfnnvxrp",
                 "3 - 4 x: tnxnngq",
                 "9 - 12 s: mbhsxshssrtwvm",
                 "11 - 15 n: nwmnlhgjnnptkmn",
                 "1 - 4 x: xmxl",
                 "1 - 6 f: bffffffffff",
                 "2 - 4 r: zrrr",
                 "2 - 3 t: ttmwvt",
                 "3 - 5 n: ngnnr",
                 "13 - 17 p: jtpppfgklkpshpndpp",
                 "1 - 7 r: rrrrrrrrrrrr",
                 "7 - 10 h: hmhhhhhhhzhhhhhhh",
                 "9 - 15 l: glxqscckgxtkzfllk",
                 "2 - 3 s: gfsh",
                 "5 - 6 b: dpphbj",
                 "6 - 13 h: hhhhhhhhhhhbshgh",
                 "5 - 13 d: dddpbddddddddddd",
                 "10 - 11 p: pppppppppdppppp",
                 "5 - 7 j: jjjjjcx",
                 "8 - 9 r: rrrrmrrrm",
                 "1 - 3 f: ffff",
                 "8 - 15 b: bbbbbbbgbbbbbbrb",
                 "3 - 6 h: hhrhhhhhhh",
                 "9 - 10 v: tkwvvvjvvvblvxvxhxvv",
                 "5 - 9 t: ttttttttmtf",
                 "1 - 4 m: fmmmmm",
                 "5 - 9 n: nfnlnkblnnfnxtzn",
                 "3 - 11 v: dnsvvvbvnvvxvj",
                 "8 - 13 h: nfgmbfjhdhlhb",
                 "2 - 14 q: cxtgcrpsxnjshlqbh",
                 "5 - 13 b: bbbbjbbbbbbbbbbbbbb",
                 "4 - 5 l: wldljllcl",
                 "19 - 20 b: jbvbbbbbqqbbbbbbbbbs",
                 "5 - 14 b: bbbbbbbbbbbbbbbbb",
                 "2 - 5 q: qmqjqhfk",
                 "12 - 13 s: sssfsnsssssssxsms",
                 "3 - 17 z: zzzzzzzzzzzzzzzznzz",
                 "13 - 14 t: ttztttstttbttb",
                 "2 - 6 q: vqhhrqlgvckvsrpwmqwz",
                 "15 - 16 d: dddddddddddddddhd",
                 "5 - 6 w: wwwwdwww",
                 "1 - 2 f: jffkf",
                 "6 - 10 j: jjjjjrjwjbjxgpjjjm",
                 "4 - 5 c: cvgccmcqzrcd",
                 "3 - 7 h: mghkhfgzmkz",
                 "10 - 17 f: ffffsfffffffpffwkff",
                 "4 - 9 g: ggbgcgjgggggg",
                 "8 - 11 d: mdnddhpddddm",
                 "6 - 7 c: ctcldgc",
                 "13 - 14 m: mmmmmmmmmmmmlmm",
                 "18 - 19 t: ttttttttptttttnttgt",
                 "7 - 8 g: qngggtghnxggs",
                 "3 - 12 c: scccrbjtdccq",
                 "2 - 3 q: qgqjq",
                 "5 - 6 x: xxxxzxxxxx",
                 "6 - 10 v: nwjsxvzhvgmsglftbpvc",
                 "2 - 5 m: xjtbsffdwmxmhxrmpm",
                 "4 - 7 c: mfgcvqccg",
                 "1 - 7 c: cctcccc",
                 "3 - 4 m: cnnw",
                 "10 - 13 s: sstssssszsssss",
                 "9 - 10 h: hchhhhjhdh",
                 "2 - 4 j: xjjgsz",
                 "4 - 11 b: rbblbbpmbmbdbjgcbhk",
                 "10 - 11 r: rrrrrrrrrjrrr",
                 "3 - 6 g: hvgfzgjrkdf",
                 "1 - 10 b: tbbbbbbpbbbbbb",
                 "12 - 13 n: nhnnnnnnnnjnznnrnrxl",
                 "7 - 13 w: wwmwfncfwdxww",
                 "3 - 4 c: wccq",
                 "7 - 16 x: xxxxxxtxxxxxxxxxx",
                 "3 - 7 k: zmhkssxs",
                 "1 - 8 n: gnnnnnnnnn",
                 "13 - 14 r: rrrrrrrrrrrrmr",
                 "2 - 3 r: rrlr",
                 "3 - 4 c: sccccwvpjpplgctg",
                 "1 - 2 b: svbs",
                 "1 - 2 f: fbfffrff",
                 "6 - 14 l: lllllvlllllxtllqllll",
                 "13 - 14 f: ffffffffkfffjf",
                 "1 - 6 z: zzzrzfzzzzm",
                 "4 - 8 k: kzzktkgrzjdkq",
                 "6 - 8 j: jjjfsgjjbt",
                 "3 - 7 q: qtqqqqq",
                 "17 - 18 x: djxqkrlcwxxxlvhjxh",
                 "6 - 8 c: tqpcgcjc",
                 "2 - 13 f: khqhkkszblvffhfwcg",
                 "7 - 18 p: kjxrtcpptzpxddbkts",
                 "5 - 12 l: llldllllllntm",
                 "2 - 7 q: bvvrnhqhpqw",
                 "2 - 6 s: scssswssss",
                 "1 - 2 n: njdnnnn",
                 "4 - 8 h: hhhzhhhhhhhhhhhhhhh",
                 "9 - 10 j: jjjjjjjjkjjxqjjw",
                 "4 - 9 t: tzdqtlttttktttttcttt",
                 "4 - 5 w: wdwht",
                 "8 - 9 x: xfxxxxfrsxp",
                 "3 - 4 m: mmmmgwwbmztpmbmmmtls",
                 "8 - 17 f: mgzhfgfffswbgnvbc",
                 "5 - 6 t: tttttg",
                 "4 - 18 x: xxxwxxxxxxxbxxxnxxx",
                 "2 - 4 l: cqglmhmtjls",
                 "2 - 4 z: zfgzr",
                 "11 - 18 k: nrdngbjkpckjxwdbrh",
                 "8 - 9 f: fffffffpf",
                 "4 - 7 g: ggtgghgsnggr",
                 "5 - 6 w: wswwlw",
                 "3 - 5 b: dfbbjbccx",
                 "2 - 3 t: tdwfzg",
                 "4 - 5 r: rhrbw",
                 "4 - 5 j: jjjjtjjn",
                 "3 - 4 k: hkzkk",
                 "1 - 2 c: cdzccc",
                 "3 - 5 r: vhlrrvhr",
                 "4 - 9 l: qbjdqldwzdl",
                 "6 - 11 f: flvpvfcfrgg",
                 "17 - 18 g: xgggggghgggglggggz",
                 "5 - 6 v: bhvgvl",
                 "7 - 15 n: nnnnnnnnnnnnnngnnnnn",
                 "6 - 15 d: dtddsddfddmcpdf",
                 "10 - 12 b: bbbbbbbbvlbbbbbbb",
                 "2 - 12 d: szdghlzwxpnd",
                 "3 - 4 z: zzzw",
                 "6 - 15 t: mrnjvfhtlqwlfzt",
                 "8 - 10 x: lcxcbrxxjw",
                 "6 - 13 r: rgszrlzmmlpdngchhxz",
                 "1 - 14 g: fgggggggggggggggggg",
                 "3 - 5 n: znnnjpksqtzt",
                 "17 - 18 l: bcfmqlsltppxwsxslb",
                 "5 - 8 t: tttnctttt",
                 "4 - 5 m: mmmmnmml",
                 "15 - 20 k: kmkpvxkgnckknzkpkqkt",
                 "12 - 15 x: xxxxvxlxxkdxxxx",
                 "1 - 5 v: vjdndsvsjvqzvnv",
                 "1 - 4 k: kkkkkkk",
                 "5 - 8 c: cxccccccc",
                 "2 - 4 v: vdvd",
                 "12 - 14 w: wwwwwwwwwwqwwbww",
                 "2 - 3 b: kbbtbrllwp",
                 "14 - 15 f: ffffffffffffffm",
                 "9 - 10 v: nlngldlnvsbwcvvt",
                 "4 - 5 c: kccxccc",
                 "5 - 9 m: bmmmmmmmzmf",
                 "8 - 9 f: fzfvffjffffv",
                 "3 - 14 r: rrqrrrrrrrrrrjrh",
                 "13 - 14 p: ppptpppppptpqdpm",
                 "6 - 12 t: tttjtvtgcwvttttqkt",
                 "5 - 10 z: glsrzctzzz",
                 "5 - 8 s: gckwcshsl",
                 "17 - 19 n: nnnnhnnnnnnnntwnnnd",
                 "7 - 9 r: rrrrfdrrxrrrrrrrrrrq",
                 "17 - 20 m: rmxbmmvwphmxmzlmbmxm",
                 "14 - 15 l: kkjwtlsrlhltmdl",
                 "14 - 17 f: ffffffffffffffffff",
                 "3 - 13 l: khxtqtwbvpmgll",
                 "2 - 4 w: wwbmww",
                 "9 - 15 n: nwxcnxnckttrkdqnn",
                 "3 - 4 t: fgnwjbtlntsr",
                 "15 - 16 x: mcxxxxxxrxxxpczx",
                 "6 - 16 w: vtcvkmrwvlmwdvrwmqj",
                 "1 - 3 c: mmcjckwn",
                 "1 - 10 c: ccccccccckccccc",
                 "14 - 16 l: kqjhpjgzvxlnxxll",
                 "4 - 7 r: xrtrrrrrcrrmrrrr",
                 "8 - 13 m: mmmmmmmmmmmmcmm",
                 "7 - 8 r: trkrrrrwf",
                 "3 - 4 n: pnjn",
                 "1 - 5 k: skkknkk",
                 "11 - 16 k: kfkkkjkqpqgkzkkkkwsn",
                 "13 - 17 f: gdllffxlxwncljgwf",
                 "3 - 5 s: gwspdtjtnlbsfffvhlg",
                 "15 - 17 m: krmfcsqbmmmjwgkdmm",
                 "13 - 14 l: knhdrdzcmdhlll",
                 "2 - 3 p: frps",
                 "2 - 9 z: lzwnzmvnqgkpbxv",
                 "5 - 9 n: nnngrnnbj",
                 "3 - 5 c: mncnbk",
                 "2 - 5 n: djgnnnnnzbnnnx",
                 "7 - 8 v: vvgvgvvm",
                 "5 - 15 w: wwwwwwwwwwwwwwwwwww",
                 "6 - 7 d: dddddcz",
                 "7 - 9 g: glrgcggvgckrgggz",
                 "2 - 3 n: dnwbnc",
                 "6 - 8 t: lttztzqt",
                 "1 - 4 m: mmmxm",
                 "4 - 14 l: qqhgtftklcnmllcbgbrx",
                 "2 - 3 d: sdnk",
                 "12 - 15 l: lqllljfglvldcql",
                 "2 - 10 k: kgkkkkkkkkxkkkkkkkkk",
                 "10 - 17 h: ljpwchmhhzmhdhmrchp",
                 "6 - 10 w: lpcfgkslrwwrlkhx",
                 "3 - 7 w: wrpwcpw",
                 "8 - 9 z: kczxltgzh",
                 "6 - 11 n: nnnnnhnsnlnnn",
                 "2 - 9 s: smssssssgss",
                 "2 - 4 x: xxwhxbfjj",
                 "1 - 2 z: fzzzzzzzzzzzzzz",
                 "4 - 5 p: pplcdpp",
                 "3 - 4 c: gncxlzc",
                 "16 - 17 x: fxqltszfgnnkxgrxhcbk",
                 "13 - 17 n: nnnnnnnnnnnnnnnnvn",
                 "1 - 6 x: dxxxxxx",
                 "7 - 8 r: scbnvqrpcbgmpmrrs",
                 "2 - 17 d: ddddddddddddddddhd",
                 "13 - 19 v: fvtphwfnmpfpbpjnnbv",
                 "7 - 18 q: cpwqnhqjqfkqqncbsh",
                 "6 - 10 c: cccdcxccncfxcgc",
                 "2 - 4 g: fggsgbgggggcggt",
                 "13 - 17 r: hspwrxrzbrvlmlwgrkxr",
                 "14 - 15 l: pllgllllllllrmv",
                 "12 - 15 g: hqgcgggsxgjxljgdz",
                 "3 - 4 d: dtxd",
                 "7 - 12 d: kddvbkkdldqbkn",
                 "3 - 13 v: vvvvvvvvvvvvtv",
                 "8 - 13 t: tttttttttfttdt",
                 "18 - 19 q: hprbdznbqlfnwzwpqckb",
                 "5 - 12 c: wwlqcgzqzvtczvcldg",
                 "3 - 5 z: xzzzv",
                 "2 - 11 c: xbblzgtwcjcfqqb",
                 "8 - 9 n: nnnvbnmvl",
                 "8 - 9 z: zzzszzzzt",
                 "2 - 3 l: chsrlrl",
                 "2 - 4 f: nffm",
                 "6 - 7 h: hhhhhhhh",
                 "10 - 16 x: xxxxxxxxxxxxxxxwxxxx",
                 "2 - 19 v: ztpvktjgjlmqfrrxfpv",
                 "2 - 5 g: gncgg",
                 "1 - 3 t: hjtttttvgtttttttttt",
                 "3 - 4 s: nbvs",
                 "5 - 10 n: nnnqnnnnbvnnn",
                 "7 - 15 q: qqqqpqqqqqqqqqzqqsqq",
                 "3 - 5 b: sjtwbr",
                 "2 - 4 t: sttxln",
                 "1 - 5 d: ddddd",
                 "12 - 13 v: zvdpfbkkvcpvdvb",
                 "3 - 6 j: cnnjhj",
                 "7 - 8 q: qqrqpbfqjvbtqlqjqkqh",
                 "2 - 4 v: wvvq",
                 "2 - 7 m: mpmrmmmmdnmmmmk",
                 "10 - 14 g: ggmcgggpggcngglm",
                 "3 - 5 g: fsbpglh",
                 "4 - 5 r: rdrtq",
                 "3 - 4 t: qttltttl",
                 "16 - 18 s: sssszpssbnsssssfss",
                 "6 - 9 b: lbxbwbbqn",
                 "2 - 3 m: dmwsg",
                 "4 - 12 p: lmppwmsplppx",
                 "3 - 15 c: lvjmlzwctxnckvclsj",
                 "13 - 14 t: tttttttftstttw",
                 "1 - 5 m: jmmmm",
                 "2 - 3 r: rsfr",
                 "1 - 4 d: xdns",
                 "2 - 3 k: qklrwnskqnx",
                 "1 - 2 r: rrrr",
                 "5 - 8 l: vlsbftlltc",
                 "3 - 12 n: nhjlchbwphmn",
                 "6 - 7 h: thhghhv",
                 "1 - 11 v: vvvvvvsvvvk",
                 "9 - 11 c: ckdqzdkbjczkkcpdj",
                 "7 - 12 b: bbbbbjbbbbbfzbbb",
                 "3 - 6 v: vvwxkv",
                 "6 - 8 t: twttttttt",
                 "12 - 17 g: gfggggggggggggggg",
                 "2 - 3 g: gqgggggggggggggg",
                 "8 - 9 h: fmjhhbjhvv",
                 "4 - 7 q: qqqqqqjsq",
                 "4 - 5 p: hpkjp",
                 "2 - 10 h: bhsgwpwnhh",
                 "15 - 18 p: nwpqxrcxgjxbbxczxb",
                 "2 - 3 k: mtkszk",
                 "9 - 11 c: zccccpccrrc",
                 "5 - 6 c: qnzjgh",
                 "7 - 11 t: ttttttmtttct",
                 "1 - 5 p: pppppprplmpq",
                 "3 - 4 x: sxlc",
                 "12 - 14 q: xsqzxsrrmxvdxq",
                 "1 - 3 k: kklkjkvkkkkkk",
                 "11 - 12 k: ffflkkkkkkqkkks",
                 "2 - 3 z: zlzzz",
                 "10 - 13 k: kkxkkbkkfkckn",
                 "11 - 15 p: wkppvppxqxpnpbpkpppp",
                 "2 - 11 r: krqxlrvhwhlj",
                 "3 - 4 l: llllllrrbll",
                 "12 - 14 n: nthpvpzmwnsnnn",
                 "15 - 18 w: jwsnzwwwwwvwfdwggcw",
                 "15 - 16 k: gtxkxjvtkktkkhkr",
                 "1 - 3 m: kmzmmm",
                 "9 - 10 j: jjjjjjjjvwj",
                 "5 - 8 p: sppkrxzpbppppphpwv",
                 "5 - 7 w: wwwwgwhwwhppmqw",
                 "5 - 6 h: hchhhplrhphqq",
                 "4 - 5 g: bggbg",
                 "3 - 4 h: sbhmtvhhrbd",
                 "1 - 4 l: lqfl",
                 "5 - 7 j: jjjpjljjjj",
                 "3 - 5 q: qqqqdqqqjqqqqqqqqqqq",
                 "1 - 13 k: kkkkkkkkxkkknkk",
                 "12 - 14 z: jzzzzzzzzzzzzvz",
                 "1 - 4 q: bqqq",
                 "8 - 9 w: wkwftfmfx",
                 "7 - 9 s: kssjlslpmqssx",
                 "1 - 2 n: dxzmtsvnfhjnqsfln",
                 "15 - 17 q: bqmqnrcjsmgghgqjr",
                 "8 - 11 z: zzzzzzzdzzfz",
                 "6 - 7 z: znznzzz",
                 "8 - 11 l: jvlntmjwwrrqlkzrhg",
                 "1 - 5 r: rrvrjtrrjzr",
                 "4 - 20 d: fbvprndxpfqplmtkntdd",
                 "7 - 9 l: llllllqlclllll",
                 "3 - 6 n: xrnjzmlbnjwwzdzmdj",
                 "17 - 19 d: ddddddddddddddddxddd",
                 "9 - 10 w: wwwwwckbwhww",
                 "2 - 5 h: gchshhhn",
                 "1 - 4 l: gtlq",
                 "15 - 16 z: zzzzlzzzzzzzzzzhzdzz",
                 "5 - 6 l: lllfllld",
                 "14 - 16 j: jjjjgjjjjjjjjjjjc",
                 "6 - 8 d: dddddrddd",
                 "4 - 5 h: zhshc",
                 "8 - 9 g: gmgxgbfqg",
                 "1 - 8 r: lrrrrrrzrrgrrrrr",
                 "4 - 13 c: mccqccdccccwccccccc",
                 "3 - 4 z: zhzz",
                 "10 - 11 c: crmmvznptct",
                 "2 - 4 l: slblllt",
                 "1 - 6 q: wqqdqqtqqqgdqqq",
                 "2 - 13 l: nlllpwllpjdbxvbp",
                 "6 - 8 l: mxsflqrlhkqhsrmhtwxq",
                 "4 - 9 t: tpwbtdttt",
                 "2 - 7 q: fzqdrbg",
                 "7 - 8 d: ddpldttdddsd",
                 "14 - 17 b: bbbbbbbbbbbbbmbbbb",
                 "4 - 11 x: wfrxkjtpxlcbgc",
                 "6 - 7 n: nnnnnjn",
                 "13 - 16 z: zmqczdggpqzpcrlz",
                 "1 - 8 j: jjjjjjzdmjjtjj",
                 "5 - 6 v: vjsnvmb",
                 "5 - 7 q: nzqqwbqmbjwllj",
                 "2 - 3 j: mtjg",
                 "12 - 15 d: ddxdddddddddddcddd",
                 "4 - 15 g: hssvxrqgngtkcmh",
                 "1 - 4 m: mmmmmmm",
                 "11 - 13 j: jqjjjjjjjjmjj",
                 "3 - 4 z: zznzz",
                 "2 - 6 c: cccmcs",
                 "6 - 10 x: xxxxxgxxlxxpxxxx",
                 "1 - 2 b: bbrbbbbb",
                 "2 - 5 f: xfmkcf",
                 "4 - 5 r: rrrkxr",
                 "3 - 4 z: zslz",
                 "3 - 4 w: kwwh",
                 "15 - 17 x: rfxxcxwxsxsdgnxlxz",
                 "17 - 18 w: rwqlwwgwwwwjwbcjtw",
                 "2 - 4 p: ppjrpp",
                 "16 - 17 b: bbbbbbbbbbbbbbbtb",
                 "5 - 6 b: fbwbqt",
                 "3 - 5 b: bbjvxg",
                 "4 - 5 j: jbhljfjz",
                 "4 - 5 k: fmkkckpj",
                 "18 - 19 w: wpqtwhngztqkvgqrcjf",
                 "5 - 6 t: wttthhtt",
                 "12 - 15 v: kvgvvvcfglsvnsp",
                 "12 - 14 n: nnnnnnnnnnnknnn",
                 "5 - 8 k: xxzhdkmmkkkbwv",
                 "8 - 9 f: fdffdgvwpfffff",
                 "12 - 14 k: kdbsqwkjhvbxrkh",
                 "4 - 7 f: fvhkstfdrwfkvv",
                 "7 - 17 x: cvkbcvbfxxgxhbxxxpbx",
                 "11 - 14 m: jjnmmmsvhzcmcm",
                 "3 - 9 w: qwxsnsxnwzsnmk",
                 "1 - 5 k: tkkkkkkkkkkkk",
                 "5 - 7 h: hhhhhhdh",
                 "3 - 13 c: cclccccccccwccccc",
                 "1 - 4 w: wwwnw",
                 "3 - 7 z: wzzblltdglmfkl",
                 "9 - 12 k: kkkwqjnqskkdhckhvkk",
                 "2 - 5 r: xjtrrsxrrdzlbjvflqxr",
                 "9 - 13 g: gggbzggggjgxkgg",
                 "1 - 8 m: zmmmmmmhmmmmmhmmmmm",
                 "16 - 18 h: hzhhhhhhhhhhhhhhhh",
                 "2 - 7 w: wwwwwwvw",
                 "3 - 4 d: ddhd",
                 "3 - 5 x: jxvzx",
                 "15 - 18 k: kkkkhkckkkkkkkkkkkxk",
                 "11 - 12 m: mmmmmmmmsmwkm",
                 "7 - 8 k: khfkkktj",
                 "2 - 7 f: ffffffff",
                 "2 - 6 q: hqqdhbfvc",
                 "3 - 5 f: rlpffgf",
                 "3 - 4 t: wtltht",
                 "4 - 5 f: fscfx",
                 "2 - 16 t: nmtppmqttqztvdstc",
                 "1 - 15 j: jwgcbkdjlmjjxzwvpvd",
                 "10 - 12 v: vvhvfvvqvvvv",
                 "5 - 6 l: llllbwlll",
                 "1 - 2 z: xmszvzrwpm",
                 "6 - 11 d: dddjndddddq",
                 "4 - 9 r: xwkfwcztcq",
                 "9 - 10 k: ckskkkktkr",
                 "2 - 4 x: txpxfq",
                 "1 - 3 j: sjzj",
                 "7 - 11 x: bbhcswxtnhx",
                 "9 - 10 q: jlqnqmhjqhqq",
                 "4 - 19 d: qddkdmptbvjpbrjdzddl",
                 "7 - 9 d: sqdpdhhdx",
                 "7 - 8 j: gjzmzjgd",
                 "10 - 15 s: gkgsssssssqssssrpc",
                 "5 - 6 v: vvvvhbvh",
                 "1 - 3 c: cccc",
                 "1 - 3 c: ccwcccczgccpccz",
                 "2 - 4 t: tgtmqtl",
                 "11 - 13 w: wwwcwwwwwwlhw",
                 "4 - 5 z: nzgzrz",
                 "4 - 11 s: lhzxmwclxss",
                 "15 - 18 s: hmszwkscbdzsrgssjj",
                 "4 - 5 m: wkvgzjmhxmwlmlmvsjv",
                 "11 - 12 t: lndqtmsfwpjp",
                 "2 - 10 w: wkwwwwwwwww",
                 "10 - 11 t: ttgpwkjltgn",
                 "3 - 9 b: bbvbbbbbtb",
                 "5 - 7 h: rqlbntrhhkjhhhrdhq",
                 "1 - 2 n: rnnrbnn",
                 "8 - 11 n: nnnnnnnpnnnnnn",
                 "4 - 5 s: vhsnsjc",
                 "5 - 7 b: tbbbbbcbb",
                 "1 - 3 q: frbq",
                 "3 - 4 s: xsssmfsgs",
                 "13 - 17 k: kkkkkbfkkkkkvkkkkkkk",
                 "1 - 13 v: zvvvvvvvvvvvvv",
                 "11 - 14 c: cbcmcccccccmccc",
                 "15 - 17 r: skkrrvsrlmrrrrrjdrrr",
                 "1 - 7 m: jmmqmmmmkmmmrkmmr",
                 "9 - 14 f: kstfsxflhffxsffkb",
                 "7 - 9 g: ggggggggvggggg",
                 "13 - 16 t: tttttttgtttttttvtt",
                 "9 - 10 p: ppppppppphp",
                 "3 - 4 w: wwxw",
                 "9 - 13 g: ggggggggrgggvg",
                 "3 - 4 f: ffkffq",
                 "8 - 11 h: hbhhzhhhhhfh",
                 "2 - 4 d: dcnss",
                 "6 - 7 r: rtrrrbr",
                 "5 - 6 r: rrrrxq",
                 "1 - 11 g: fgggggggmkglk",
                 "14 - 15 h: vlqkqhhhfwhxfvs",
                 "3 - 4 w: wlrsgfsw",
                 "1 - 2 v: dxkwzvvxv",
                 "2 - 4 r: rvrcrtrrl",
                 "4 - 6 t: ttktttt",
                 "10 - 15 j: jjjjbtjjtjnjjjk",
                 "5 - 6 s: ssssssss",
                 "5 - 7 s: sfnkzss",
                 "4 - 5 b: shbtb",
                 "2 - 5 j: hjktjm",
                 "1 - 5 h: hhhhdhhhhh",
                 "5 - 17 m: mmmmgmmmmmmmmmmmmrmn",
                 "2 - 6 b: cxgxbbskzgdhr",
                 "10 - 12 k: kkkkkkkkkbkkkkknkmks",
                 "13 - 16 g: ggggggqggggghggggggg",
                 "1 - 2 w: wwwl",
                 "6 - 9 b: bkbbmbbbzb",
                 "6 - 7 m: qrfhmmndrkmc",
                 "5 - 11 p: ggzmjkxpnrpf",
                 "2 - 3 r: rhrr",
                 "6 - 7 f: vppvpwf",
                 "8 - 10 w: wrwwwdvwwjwwww",
                 "6 - 11 c: wxrbztwpcccj",
                 "14 - 17 x: xxxxxxxxxxxxxrxxxxxx",
                 "5 - 8 c: cccccczqccc",
                 "2 - 6 j: jgqjjfjzjjjjjjmjjj",
                 "4 - 7 t: zphkzttgtjdxdtd",
                 "4 - 7 t: wsrtdqgthqjvznbj",
                 "15 - 19 h: hmhhhhzhhhchhmhhhtxh",
                 "1 - 3 z: zzzz",
                 "2 - 3 j: jcvl",
                 "1 - 7 w: wcpwswwgjfb",
                 "3 - 6 c: crsvmcckc",
                 "9 - 10 f: fffffffffjff",
                 "3 - 6 v: hfvpwvgg",
                 "2 - 5 r: dkhrrd",
                 "1 - 5 f: cflmflfdvbz",
                 "3 - 13 k: sfkgcgktfkhrh",
                 "3 - 9 v: mmrprsvzv",
                 "3 - 4 q: qqqbcrkq",
                 "11 - 13 r: rrrwrrrrrrrgrr",
                 "6 - 11 j: tjjjzpsjrjdj",
                 "14 - 18 t: dtbhmtltcwpnzwqtgt",
                 "2 - 5 c: rsccchcc",
                 "11 - 14 m: kmmmmmlvmmtmmm",
                 "7 - 10 x: xhxxxxxbxbhxxxx",
                 "10 - 13 n: nnntnnnnnpnnn",
                 "3 - 10 w: wwwjwgwwwgwmww",
                 "17 - 18 p: phpppnpqppjsrpppzj",
                 "8 - 12 r: rsrbwrrrrrrzr",
                 "9 - 15 q: bqlrdqqxrdqqnxq",
                 "5 - 11 d: sldcndtlpzdb",
                 "1 - 3 w: zwww",
                 "11 - 12 k: tkbkwkkvsblpt",
                 "13 - 14 c: ccccccccccccqc",
                 "1 - 5 c: ccccrc",
                 "4 - 5 f: fffnf",
                 "3 - 4 w: wwwvw",
                 "2 - 4 k: kzkk",
                 "16 - 18 j: jjjjjjjjjjjjjjvqjj",
                 "2 - 8 v: wvqlrnrtgbzrp",
                 "6 - 10 c: cccccdcccccc",
                 "1 - 4 q: bqqqq",
                 "5 - 6 n: nnnnnnn",
                 "2 - 16 f: cjrffhfpfflxljjfp",
                 "3 - 8 g: ggfggggggg",
                 "7 - 8 z: zmzkzzzczwzzzz",
                 "7 - 8 m: mmmmmmmmmm",
                 "7 - 9 f: vzlffftfw",
                 "4 - 10 w: kckwgbmtws",
                 "4 - 5 g: ggghgp",
                 "6 - 17 w: wwwwwwwwwwwwwwwwkw",
                 "3 - 16 f: fffbfffffffffffcff",
                 "9 - 14 l: lllllllwmllmblllhlml",
                 "1 - 4 s: sssdssss",
                 "3 - 4 m: lmnm",
                 "10 - 11 v: vvvvkvsvvvmvhv",
                 "3 - 4 p: pprb",
                 "3 - 4 k: pkqk",
                 "3 - 4 d: ddxd",
                 "7 - 8 b: bbbbbbfb",
                 "5 - 7 w: qbmhsmt",
                 "11 - 12 b: bbbbbbbbbbbgb",
                 "3 - 5 x: xpxbljxt",
                 "2 - 9 z: kzmpqtbvzrqzh",
                 "3 - 16 v: qwvfvltjrpdxmvqv",
                 "2 - 6 n: pdjxzkn",
                 "7 - 8 j: jmzvjkjk",
                 "2 - 5 r: rrfjqqft",
                 "2 - 5 h: pwhfh",
                 "6 - 7 m: mmgvjmm",
                 "11 - 12 r: rrrrrrrrrrxqrr",
                 "1 - 4 n: nnnw",
                 "1 - 5 z: szzzzzdtzz",
                 "7 - 13 j: jjjjjjnjjjjjbj",
                 "10 - 15 w: rwwwwtmwswwwwwwwnmbk",
                 "11 - 13 t: twxhrldqtttmnt",
                 "1 - 2 r: bkbbrwr",
                 "11 - 17 h: hhdhhhhhhshqpbhhn",
                 "4 - 7 c: crgchccbnr",
                 "9 - 11 r: bdhgrzkmrrl",
                 "6 - 8 g: gggggggzz",
                 "3 - 9 g: ggggggggqg",
                 "9 - 11 z: zrfcqtrxxqzcx",
                 "3 - 9 s: zstjqhnvgjjfxknt",
                 "12 - 13 p: pppppwpgcppjppppptp",
                 "6 - 7 k: kkwrkckb",
                 "8 - 9 k: kkkkqzjkn",
                 "8 - 9 l: lrxlkbflrl",
                 "1 - 3 n: nndn",
                 "8 - 9 d: ddhddddddd",
                 "4 - 12 g: zdclfqvdgnzfv",
                 "3 - 5 d: ddddkddddddd",
                 "9 - 11 x: xxxxxxxxqxxx",
                 "4 - 7 t: ttttfftt",
                 "2 - 4 n: wfmnnddqxfm",
                 "16 - 19 r: zhjsgxjkjpqmpvkrjgr",
                 "3 - 7 v: vvfvvvvv",
                 "1 - 2 d: qdwdfj",
                 "6 - 10 h: hhhhhhhhhrhh",
                 "4 - 16 x: xxxpxxxxxxxxxxxxx",
                 "18 - 19 q: qqqqqqqqqqqqqlqqqqf",
                 "6 - 10 g: gkcntgbgbggklsx",
                 "8 - 9 n: nnnnxnnnpnn",
                 "7 - 9 m: msmmmtdvm",
                 "2 - 15 d: twjdrfzntqhnwkd",
                 "1 - 4 z: kzzz",
                 "16 - 18 b: tbbbtbjbtbtflzckhb",
                 "4 - 12 k: kkbhkgkrkgfk",
                 "8 - 10 q: lrqrjqvwmrb",
                 "1 - 3 f: vfhf",
                 "7 - 14 v: vvvvvvrtvvvvvvvv",
                 "4 - 5 n: xnntnwntrfnbqqdk",
                 "3 - 5 r: rhkrzwrhrrr",
                 "2 - 4 b: bspbjb",
                 "5 - 6 s: sfscsc",
                 "6 - 7 x: xxxxxhx",
                 "8 - 10 w: wwwwbzlmqw",
                 "7 - 10 v: fkvdvjbfvd",
                 "2 - 5 q: qtqspqqq",
                 "8 - 9 k: kmhkkhpsk",
                 "5 - 8 h: xhdhjfph",
                 "3 - 6 b: dlbkbb",
                 "1 - 3 w: wwbswwww",
                 "2 - 4 x: mxtx",
                 "2 - 4 l: llrll",
                 "3 - 7 j: kclqzgc",
                 "2 - 3 r: rxrrrgrrrrr",
                 "2 - 4 q: nzwxlmcqqqm",
                 "15 - 16 h: hhhhvmhbhdtbblbh",
                 "13 - 19 l: ltkftclmlllflzltlnb",
                 "4 - 5 p: zmwtpjrltqdmfppz",
                 "6 - 10 t: tjdxqtsbzhvprspljmv",
                 "14 - 17 q: qcqqqqqcqghqqqqqjq",
                 "1 - 5 j: flxrjspwlrdqsnjcs",
                 "14 - 15 m: mmmlmmmmmmmmmwm",
                 "3 - 5 d: dddvkwksdcrktlpd",
                 "8 - 11 l: llcllllxllml",
                 "2 - 4 v: vvvbv",
                 "1 - 3 g: llggz",
                 "3 - 5 q: znqqmt",
                 "15 - 17 f: ffffffffffffffjfff",
                 "17 - 18 q: zwnkmcqdqlqgkwfmqc",
                 "8 - 11 f: fffsrffbfffffvfxf",
                 "1 - 7 b: bbbbbbbb",
                 "3 - 4 l: llzh",
                 "8 - 9 n: nhnnnnqknnbnncncnnl",
                 "9 - 11 v: wvvvvvvbhjc",
                 "15 - 16 q: qcjqvfdcsqwdrqqt",
                 "9 - 10 j: jcckdzkzjjb",
                 "1 - 2 s: hssmsssms",
                 "1 - 3 w: xwww",
                 "2 - 4 l: lllll",
                 "2 - 4 q: qnmq",
                 "16 - 18 t: tttttttgtftttttttt",
                 "5 - 6 t: kttttj",
                 "16 - 17 t: twlqttttttttttmct",
                 "8 - 15 x: xxwpxsqkxgkxgxxbdgx",
                 "17 - 18 h: hhhhhhhhhhblhhhhrq",
                 "12 - 17 m: fmkmmmmqkmmdrbvthm",
                 "2 - 4 b: fbcb",
                 "1 - 14 t: tttttttttttttqtt",
                 "17 - 18 v: vvvvvvvvvvvvvvvvvnv",
                 "7 - 10 x: vxxtxlxxlk",
                 "3 - 5 n: nnmnqnnb",
                 "2 - 8 s: vssjqsssssb",
                 "9 - 11 l: wlllllllllllll",
                 "4 - 14 r: zrlcrxrrrzrrrrr",
                 "3 - 14 n: wrnjpnkndsshqk",
                 "12 - 16 p: ppppzpppppphppppp",
                 "9 - 12 r: rrrrrcbrrfprrrrr",
                 "2 - 3 b: bbrb",
                 "14 - 16 d: tzdjdndddgsddlnddgd",
                 "16 - 18 c: cccccccccccccccwcc",
                 "5 - 6 v: rvvqvt",
                 "11 - 17 s: ssssssssssssssssps",
                 "8 - 9 v: vpvxqvvdvnvhgnvvlvs",
                 "7 - 8 d: ddddqlrt",
                 "7 - 13 d: bfzrkddtdwqld",
                 "4 - 6 c: cccccq",
                 "6 - 8 d: hkdndlqq",
                 "11 - 13 l: ngmllbdklvlmqlz",
                 "8 - 17 m: mmmmfmmmmmmmmmmmlmm",
                 "12 - 15 b: bbsbbcblbsnbzbbfcfzz",
                 "12 - 13 k: gbwkkkkkkkksk",
                 "12 - 14 x: xxxxwxxxxxxdxxxxxxx",
                 "3 - 4 m: mwsmp",
                 "5 - 6 k: kkkkzk",
                 "4 - 5 h: pqslhh",
                 "7 - 13 l: gmpxpvwqrnlfp",
                 "3 - 6 t: sttxtmtn",
                 "11 - 13 r: rrbmbrwrrrrrkhrr",
                 "14 - 16 s: ssssssssssssstsss",
                 "7 - 10 v: vvvvvvhvdvvvkv",
                 "5 - 6 z: sxpzzx",
                 "2 - 4 d: rmxd",
                 "16 - 17 z: zzzzzzzzzzzzzzzzzz",
                 "1 - 3 k: kjkkkkcckkzk",
                 "1 - 11 k: xzkkkkzkppk",
                 "8 - 9 f: bfvfdffzb",
                 "4 - 14 r: rfzcrrlmxqlrrrqr",
                 "7 - 19 t: gtnxjqtnjbkrwpzshqqn",
                 "2 - 5 j: kjjgpddjpjjjffzjjp",
                 "2 - 3 f: cfffh",
                 "1 - 2 x: xxxxx",
                 "3 - 13 j: jjjjjjjjjjjjzfjjj",
                 "7 - 8 m: sgmmpmjmwmmmtfs",
                 "4 - 12 z: zfzqzzszvtml",
                 "6 - 9 b: jsfbpkzwb",
                 "13 - 16 x: zsxxjxxsxxqxpxxx",
                 "8 - 12 b: rlzdlplbgbdgd",
                 "3 - 14 h: hmrhhhhhhhhhrthhhh",
                 "15 - 19 g: mgggggcgggggqgghggg",
                 "2 - 9 p: ppppptppzcf",
                 "6 - 7 b: bbbbbbbbb",
                 "4 - 20 q: skqqvxptdswwnrflkvxq",
                 "4 - 5 t: lqttq",
                 "1 - 10 l: lqkqllvllj",
                 "11 - 15 m: qmmmmmrmqmmmsmf",
                 "6 - 15 s: ssssstssssssssss",
                 "2 - 4 x: xtxxx",
                 "9 - 11 q: qqqqqqqqhqgqq",
                 "1 - 4 n: gpnnfnn",
                 "1 - 3 l: lltl",
                 "11 - 15 k: kkfkkfkmmkrkkkk",
                 "11 - 12 f: fkcvfvtqfcfffffffffj",
                 "1 - 4 c: ccjc",
                 "14 - 15 n: bvbvfvzcbfnzqlsvh",
                 "4 - 5 x: xxlmxx",
                 "3 - 6 n: nnrnnnwlnncnn",
                 "6 - 9 j: jjjjjjjjq",
                 "7 - 10 d: pdplmxdczddbd",
                 "12 - 13 c: ccccbctccccccccc",
                 "12 - 13 j: jfjdjjjjjjjjjj",
                 "6 - 7 h: mrnphwh",
                 "2 - 9 n: njnnnnnnnnnnnn",
                 "3 - 6 g: rgxgggggnjghgggntg",
                 "9 - 12 b: bbbbbbbbbbbcbb",
                 "3 - 5 p: ppppvpp",
                 "16 - 20 t: ctkgpgzrwwngltvxcqct",
                 "4 - 5 s: sssdsh",
                 "12 - 14 v: vvvvvsvvvvvvvsv",
                 "8 - 13 w: zwwwwwwvwwrwgv",
                 "12 - 17 r: wrcrrrrrrrbrwrrrxr",
                 "12 - 13 x: xxxxxxxxxjsvrnxx",
                 "7 - 9 n: nqnnqnvnn",
                 "14 - 19 n: nnnnnnnnnnnnnnnnnnnn",
                 "4 - 5 c: vscjrl",
                 "1 - 3 l: llrl",
                 "11 - 12 w: wwwwwwwwwwzww",
                 "6 - 7 t: wlcktht",
                 "2 - 10 r: rrrrrrrrrwrrrmrr",
                 "2 - 6 x: lhqvpx",
                 "10 - 16 h: kqrhxclktcqhxchg",
                 "6 - 10 m: mmsmkmmjmlmhfmmnmm",
                 "5 - 7 h: hchhhhph",
                 "5 - 7 z: vtzzzwl",
                 "3 - 12 z: zzfzzzzzzzzzz",
                 "7 - 9 z: zzzzzzszzzzzzzzjz",
                 "8 - 9 g: ggggggggg",
                 "13 - 16 f: ptvzfmfkxfdkfhjff",
                 "1 - 10 w: cvhnfgnwpw",
                 "5 - 8 d: fvvmdlfqgjc",
                 "6 - 9 s: rzlrwzngshvt",
                 "2 - 4 v: vgql",
                 "1 - 3 r: rrmrr",
                 "5 - 7 j: jkjgwjj",
                 "4 - 7 b: bbbzdzbbcbbb",
                 "4 - 10 k: kkkkrkckkgkkk",
                 "10 - 12 m: mmmmmmddmjmn",
                 "4 - 10 k: mskmvkcpqkk",
                 "5 - 10 m: wbtdmxnvrmwqbqkwmtq",
                 "7 - 14 z: cfzftzzqnxffzh",
                 "12 - 13 z: zzzzkzzzzdzzz",
                 "4 - 5 l: lllslllvl",
                 "5 - 8 k: kkkkkkkkkk",
                 "10 - 11 l: llllllllllwl",
                 "3 - 5 v: hvzpxfvmvcv",
                 "8 - 10 t: tbtnrtbqzwtkqtf",
                 "6 - 10 j: njjjpjjjjkjsj",
                 "8 - 16 f: cvpxnsxfdnpdfswdhbb",
                 "6 - 12 n: nnndnnnnnnnz",
                 "2 - 3 d: dzdd",
                 "1 - 4 s: jshkscssssssssssssss",
                 "5 - 7 k: kkkqckwkcl",
                 "3 - 4 f: ffdf",
                 "9 - 11 c: cpccccncccqccc",
                 "1 - 8 x: gxxxxgxx",
                 "5 - 15 p: ppvkmmpcvzmmczpz",
                 "12 - 13 p: xppppppppvpnpppp",
                 "7 - 12 n: nwnnnnhcbnjnc",
                 "1 - 4 f: fnzjf",
                 "2 - 5 s: tltqss",
                 "3 - 10 r: rrqkrzvkrtbqcrp",
                 "3 - 14 h: hhhhthhhlrwhhhthp",
                 "2 - 4 b: bkbhbq",
                 "15 - 16 v: vvvvvvvvvvvvvvvsvvv",
                 "1 - 17 h: vtjjhtxrchshpxhsh",
                 "4 - 7 n: jnpnpnn",
                 "3 - 4 h: jvhz",
                 "4 - 5 w: wcpzw",
                 "9 - 10 q: tvxbsfmqqblhq",
                 "3 - 5 s: jssstxfbsssshssgkss",
                 "3 - 9 r: fnrhqkrmtstqjgc",
                 "12 - 15 n: xqwnnnnnnnnmnnn",
                 "13 - 15 q: qqqqqqqqqqqqqqtq",
                 "3 - 4 d: dcdl",
                 "4 - 12 d: vrldnmpndmlgdzrv",
                 "2 - 4 h: mhhh",
                 "3 - 4 f: fcvfc",
                 "1 - 2 w: whwwwz",
                 "7 - 8 m: mpmlmmmmhdbh",
                 "2 - 4 q: qxbqqdsjrdpxf",
                 "6 - 14 r: wbmlhrcgrgrkzqfj",
                 "2 - 7 c: ghcvcdcmcztckct",
                 "2 - 9 n: nnnnnnnnpnnn",
                 "3 - 5 f: zlgffv",
                 "1 - 6 m: ntmmmm",
                 "2 - 4 w: jgqwv",
                 "5 - 12 f: gscfzhmrtxfw",
                 "5 - 7 r: rwzklcrnrrg",
                 "8 - 10 h: hhhzhhhpxhhh",
                 "9 - 11 x: xxxxxxxxfxbx",
                 "7 - 8 q: qdnqnzbq",
                 "2 - 10 s: sssmssslbb",
                 "8 - 9 n: wgfnghnlnkf",
                 "4 - 10 d: dddsdddlds",
                 "1 - 5 k: bfkkkn",
                 "2 - 5 w: wwwwww",
                 "14 - 16 s: bjszbzmcnsvplsrh",
                 "8 - 9 b: bbjbbbbbbvvbbx",
                 "2 - 10 m: dmnrsmtqkf",
                 "7 - 12 f: fbtwftvffsgfwlnw",
                 "9 - 10 h: shhhpshfxhbrdhshh",
                 "4 - 9 t: tgpdtwrmt",
                 "2 - 6 t: vhtwntl",
                 "3 - 5 j: ljjjd",
                 "2 - 3 w: hxwvbxwwbwsvc",
                 "7 - 8 r: rrrzrrnr",
                 "3 - 4 x: jxjh",
                 "7 - 12 w: mjmbtgntdwjwnqztv",
                 "5 - 6 l: vlvllt",
                 "7 - 8 n: nnnnnnpnnnn",
                 "3 - 10 c: wcgcxzcdwmcn",
                 "16 - 18 h: hchhhhhhhhhhhhhcmh",
                 "5 - 11 f: fflffffffflfff",
                 "3 - 13 z: zzzzzzzzzzzzpzz",
                 "6 - 9 k: kkkkkskkkk",
                 "6 - 15 c: ccccccccbccccctccc",
                 "9 - 18 p: klcpzpdwzvpqppspfpp",
                 "10 - 13 b: pbbbbmbbdbwtmd",
                 "10 - 11 v: xvvvvvvvvnnvv",
                 "2 - 4 m: msmmm",
                 "1 - 4 w: rwwlwrwrwwrfngc",
                 "8 - 9 r: rjjlddjrnbr",
                 "13 - 16 d: pzdfzqbwclbjddxtvddf",
                 "14 - 15 q: qqqqqqqqqqqqqbq",
                 "12 - 14 k: kkkjgrkkqkkkkl",
                 "3 - 4 d: gsdnkdfnf",
                 "8 - 17 h: glhfvrshlrqwdrfrh",
                 "2 - 12 l: mflqfvxfgzkmd",
                 "5 - 8 f: ckllfnfbflqgrsd",
                 "1 - 17 m: kckvffhnlmjvdtgpm",
                 "16 - 17 p: pplppppcppppppppppp",
                 "5 - 8 h: hhjbmplh",
                 "7 - 10 s: jsjlwgsssbsvfsvk",
                 "2 - 8 x: xpfxbqxxqxhdrxhqm",
                 "12 - 16 n: nnnnnznnnnnnnnnmnvn",
                 "6 - 12 v: vvvvvvvvvvvgv",
                 "8 - 9 j: pjjjjmjnj",
                 "16 - 17 h: hhhbhjhrhhhhxhhgt",
                 "3 - 11 d: ldpmvddhdrdjdj",
                 "6 - 7 n: nnnnnnnn",
                 "5 - 8 f: tglffvhgnfxzfhf",
                 "13 - 18 r: rrrrrrrrrrbrhrrrrrrr",
                 "19 - 20 n: nnnnnnnnnnnnnnnnnnnj",
                 "7 - 8 w: tpmmxqsw",
                 "5 - 7 c: ccccccr",
                 "9 - 10 l: qltnnlnfllqlw",
                 "6 - 7 g: xggbggz",
                 "7 - 10 s: sssssfcssss",
                 "5 - 7 j: jsjkxwqhjcvjtwjzl",
                 "10 - 14 t: qdtttzttcvtttnn",
                 "12 - 13 b: bbbbbbrbbbbqb",
                 "1 - 15 d: dshhrjkwcjjhlthdts",
                 "7 - 12 p: hrxkphmqpvpptpqbw",
                 "13 - 14 d: ddndddxdtdrkvldd",
                 "3 - 4 h: htht",
                 "7 - 8 c: xtsvzccfckccx",
                 "4 - 5 r: gstrwshptzrdtjj",
                 "7 - 8 b: wbbnbbbm",
                 "15 - 17 c: cgpqxbccqcjpzlcctmx",
                 "2 - 7 k: kvtqqmsx",
                 "8 - 11 s: ssxssssqsssssssss",
                 "3 - 9 d: ddddddddld",
                 "13 - 16 p: pppppppppppppppwpj",
                 "6 - 8 v: sxkghpckvb",
                 "17 - 18 s: ssssssssbsssssssksss",
                 "1 - 2 w: wlwxdsw",
                 "8 - 9 q: qqqqqqqqnq",
                 "9 - 16 f: fjdsfvkfqffffjcfpff",
                 "12 - 13 h: bhhhhhhfwhphhhhhh",
                 "7 - 8 k: kkkkkknkkkkkkk",
                 "4 - 7 w: wwwfpsw",
                 "8 - 11 d: rsndldddddxddmf",
                 "2 - 10 c: cjcdcccccc",
                 "6 - 7 v: zvnrhth",
                 "3 - 8 z: zzxzzzzzdzjzzzzz",
                 "11 - 12 t: tctdttttwtrtttttjth",
                 "8 - 9 c: ccccccccrccc",
                 "17 - 18 p: pppppppppppppppppvp",
                 "3 - 8 l: svlmlkspljr",
                 "1 - 2 n: nwnkq",
                 "1 - 11 j: jjjjjjjjjjjj",
                 "18 - 19 g: ggggggggggggggggggr",
                 "10 - 11 j: jjjjjcdjgjv",
                 "3 - 7 p: ptttppppppj",
                 "2 - 5 d: cdndsd",
                 "6 - 10 s: sssssmssssss",
                 "15 - 16 k: vxwxxhhkkhklqksd",
                 "3 - 4 x: rpxn",
                 "1 - 6 g: vmgckg",
                 "3 - 4 j: jjbs",
                 "5 - 10 d: qrnmbddndvcmdsjjbdhd",
                 "7 - 9 v: vvmgvvvpvm",
                 "1 - 7 z: zzzzzzwzzzz",
                 "4 - 7 n: nnnnnnqn",
                 "8 - 9 k: kwkknknkrkgkbklmpb",
                 "1 - 5 z: zzmzfzz",
                 "6 - 10 m: mmmmmfmmmm",
                 "9 - 11 s: sssssstsssgss",
                 "2 - 6 n: nnfnpgnnnmnnn",
                 "15 - 17 w: wwwwrswthgwhkwwrw",
                 "5 - 9 h: lbhdhplmbnwh",
                 "5 - 6 d: jdddqqt"
            };
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

        static IEnumerable<int> Day1Input()
        {
            return new int[] { 
                1650, 1174, 1156, 1874, 1958, 1918, 1980, 1588, 1863, 1656, 
                1843, 1738, 2001, 1883, 1941, 1602, 1881, 1927, 1284, 1474, 
                1942, 1992, 1925, 1990, 1831, 1907, 1914, 1815, 1921, 1589, 
                1224, 1148, 1223, 935, 1726, 1828, 1838, 1611, 1960, 1668, 
                1744, 1566, 1902, 1203, 1975, 1225, 2000, 1678, 1950, 572, 
                1812, 1568, 1484, 1767, 1509, 1658, 1127, 1870, 1098, 1294,
                1310, 1483, 1865, 1967, 1856, 1963, 1929, 1119, 132, 1969, 
                1094, 1523, 1701, 1896, 1631, 1956, 1910, 1672, 1232, 1285, 
                1761, 1649, 1931, 1959, 1191, 1846, 1908, 1976, 1500, 1940, 
                1924, 1521, 1989, 1635, 1102, 1114, 1948, 2007, 1964, 1926, 
                1590, 1900, 1690, 1880, 1596, 1395, 1373, 1937, 1833, 1845, 
                1949, 1128, 1218, 1928, 1912, 1893, 1869, 960, 1813, 1645, 
                1490, 1318, 1934, 1259, 2005, 1522, 1270, 1089, 1674, 1997, 
                1112, 1954, 1769, 1829, 1814, 1922, 1904, 1894, 1595, 1103, 
                237, 1943, 1364, 1906, 1971, 1998, 1461, 1606, 1911, 1545, 
                1952, 1917, 1582, 1994, 1946, 1935, 1844, 1938, 1633, 2004, 
                1132, 1530, 1915, 1982, 1871, 1852, 1613, 1476, 1216, 1834, 
                1939, 409, 1895, 1120, 1194, 1135, 1899, 1901, 1439, 485, 1855, 
                1136, 200, 1887, 250, 1930, 1506, 1945, 1988, 1170, 1575, 1872, 
                1261, 1137, 1978, 1537, 1897, 1837, 1753, 1913
            };
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

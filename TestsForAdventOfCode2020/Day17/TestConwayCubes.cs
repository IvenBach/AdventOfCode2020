using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestsForAdventOfCode2020.Day17
{
    [TestFixture]
    public class TestConwayCubes
    {
        [Test]
        public void Part1_sample_after_1_cycle_at_Z_equals_negative_1()
        {
            var expected = new char[5, 5];

            expected[0, 0] = '.';
            expected[0, 1] = '.';
            expected[0, 2] = '.';
            expected[0, 3] = '.';
            expected[0, 4] = '.';

            expected[1, 0] = '.';
            expected[1, 1] = '.';
            expected[1, 2] = '.';
            expected[1, 3] = '.';
            expected[1, 4] = '.';

            expected[2, 0] = '.';
            expected[2, 1] = '#';
            expected[2, 2] = '.';
            expected[2, 3] = '.';
            expected[2, 4] = '.';

            expected[3, 0] = '.';
            expected[3, 1] = '.';
            expected[3, 2] = '.';
            expected[3, 3] = '#';
            expected[3, 4] = '.';

            expected[4, 0] = '.';
            expected[4, 1] = '.';
            expected[4, 2] = '#';
            expected[4, 3] = '.';
            expected[4, 4] = '.';
            var cc = new AdventOfCode2020.Day17.ConwayCube(AdventOfCode2020.Inputs.Day17Sample());

            var cycle = cc.ProcessCycles(1);
            var actual = cycle[-1];

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Part1_sample_after_1_cycle_at_Z_equals_1()
        {
            var expected = new char[5, 5];

            expected[0, 0] = '.';
            expected[0, 1] = '.';
            expected[0, 2] = '.';
            expected[0, 3] = '.';
            expected[0, 4] = '.';

            expected[1, 0] = '.';
            expected[1, 1] = '.';
            expected[1, 2] = '.';
            expected[1, 3] = '.';
            expected[1, 4] = '.';

            expected[2, 0] = '.';
            expected[2, 1] = '#';
            expected[2, 2] = '.';
            expected[2, 3] = '.';
            expected[2, 4] = '.';

            expected[3, 0] = '.';
            expected[3, 1] = '.';
            expected[3, 2] = '.';
            expected[3, 3] = '#';
            expected[3, 4] = '.';

            expected[4, 0] = '.';
            expected[4, 1] = '.';
            expected[4, 2] = '#';
            expected[4, 3] = '.';
            expected[4, 4] = '.';
            var cc = new AdventOfCode2020.Day17.ConwayCube(AdventOfCode2020.Inputs.Day17Sample());

            var cycle = cc.ProcessCycles(1);
            var actual = cycle[1];

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Part1_sample_after_1_cycle_at_Z_equals_0()
        {
            var expected = new char[5, 5];

            expected[0, 0] = '.';
            expected[0, 1] = '.';
            expected[0, 2] = '.';
            expected[0, 3] = '.';
            expected[0, 4] = '.';

            expected[1, 0] = '.';
            expected[1, 1] = '.';
            expected[1, 2] = '.';
            expected[1, 3] = '.';
            expected[1, 4] = '.';

            expected[2, 0] = '.';
            expected[2, 1] = '#';
            expected[2, 2] = '.';
            expected[2, 3] = '#';
            expected[2, 4] = '.';

            expected[3, 0] = '.';
            expected[3, 1] = '.';
            expected[3, 2] = '#';
            expected[3, 3] = '#';
            expected[3, 4] = '.';

            expected[4, 0] = '.';
            expected[4, 1] = '.';
            expected[4, 2] = '#';
            expected[4, 3] = '.';
            expected[4, 4] = '.';
            var cc = new AdventOfCode2020.Day17.ConwayCube(AdventOfCode2020.Inputs.Day17Sample());

            var cycle = cc.ProcessCycles(1);
            var actual = cycle[0];

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(0, 5)]
        [TestCase(1, 11)]
        [TestCase(6, 112)]
        public void Part1_after_X_cycles_Y_cubes_left_in_active_state(int cycles, int expected)
        {
            var cc = new AdventOfCode2020.Day17.ConwayCube(AdventOfCode2020.Inputs.Day17Sample());
            var state = cc.ProcessCycles(cycles);
            var actual = AdventOfCode2020.Day17.ConwayCube.ActiveCubes(state);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Part1_input_produces_expected_output()
        {
            var cc = new AdventOfCode2020.Day17.ConwayCube(AdventOfCode2020.Inputs.Day17());
            var state = cc.ProcessCycles(6);
            var actual = AdventOfCode2020.Day17.ConwayCube.ActiveCubes(state);

            Assert.AreEqual(395, actual);
        }
    }
}

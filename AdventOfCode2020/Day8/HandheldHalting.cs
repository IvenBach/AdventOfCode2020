using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day8
{
    public class HandheldHalting
    {
        private string[] Commands;
        private int GlobalAccumulator = 0;
        public HandheldHalting(string[] commands)
        {
            this.Commands = commands;
        }

        /// <summary>
        /// Evaluates statements in order of operation until a statement would be run a second time.
        /// </summary>
        /// <returns>Global accumulator value when a statement would be twice.</returns>
        public int AccumulatorValueBeforeRepeatingStatement()
        {
            var hash = new HashSet<int>();
            var executingLine = 0;
            var hasPreviouslyExecuted = hash.Contains(executingLine);
            while (!hasPreviouslyExecuted)
            {
                hash.Add(executingLine);
                executingLine = ExecuteStatement(executingLine);
                hasPreviouslyExecuted = hash.Contains(executingLine);
            }

            return GlobalAccumulator;
        }

        /// <summary>
        /// Executes the statement and returns the next line to be executed. Updates the global accumulator value, when applicable,
        /// as part of execution.
        /// </summary>
        /// <param name="lineNumber">Current line to execute</param>
        /// <returns>Next line to be executed.</returns>
        private int ExecuteStatement(int lineNumber)
        {
            var executingLine = lineNumber;
            switch (Commands[lineNumber].Substring(0,3))
            {
                case "nop":
                    executingLine++;
                    break;
                case "acc":
                    executingLine++;
                    GlobalAccumulator += AccumulatorIncrement(Commands[lineNumber]);
                    break;
                case "jmp":
                    executingLine += JumpStatement(Commands[lineNumber]);
                    break;
            }

            return executingLine;

            int AccumulatorIncrement(string value)
            {
                string quantity = value.Split(new[] { ' ' })[1];
                return int.Parse(quantity);
            }

            int JumpStatement(string value)
            {
                string quantity = value.Split(new[] { ' ' })[1];
                return int.Parse(quantity);
            }
        }
    }
}

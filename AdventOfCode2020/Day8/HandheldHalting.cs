using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day8
{
    public class HandheldHalting
    {
        private readonly string[] Commands;
        private int GlobalAccumulator = 0;
        public HandheldHalting(string[] commands)
        {
            Commands = commands;
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


        private bool ExecutionConcludesNormally(out int accumulator)
        {
            var hash = new HashSet<int>();
            var executingLine = 0;
            var hasPreviouslyExecuted = hash.Contains(executingLine);
            while (!hasPreviouslyExecuted)
            {
                hash.Add(executingLine);
                executingLine = ExecuteStatement(executingLine);

                if (executingLine >= Commands.Length)
                {
                    accumulator = GlobalAccumulator;
                    return true;
                }

                if (hash.Contains(executingLine))
                {
                    accumulator = -1;
                    return false;
                }
            }

            accumulator = -1;
            return false;
        }

        /// <summary>
        /// By changing a single statement from 'jmp' to 'nop' or 'nop' to 'jmp' execution
        /// will conclude normaly by running through to the end of the commands.
        /// </summary>
        /// <param name="statements">Statements to be executed.</param>
        /// <returns>Accumulator value after execution concludes.</returns>
        public int ExecutionConcludesNormally()
        {
            for (int i = 0; i < Commands.Length; i++)
            {
                if (IsValidReplacement(Commands[i], out var oldOperand, out var newOperand))
                {
                    string[] updatedCommands = new string[Commands.Length];
                    Array.Copy(Commands, updatedCommands, Commands.Length);
                    updatedCommands[i] = updatedCommands[i].Replace(oldOperand, newOperand);
                    var hh = new HandheldHalting(updatedCommands);
                    if (hh.ExecutionConcludesNormally(out var value))
                    {
                        return value;
                    }
                }
            }

            return -1;

            bool IsValidReplacement(string statement, out string oldOperand, out string newOperand)
            {
                if (statement.StartsWith("jmp"))
                {
                    oldOperand = "jmp";
                    newOperand = "nop";
                    return true;
                }

                if (statement.StartsWith("nop"))
                {
                    oldOperand = "nop";
                    newOperand = "jmp";
                    return true;
                }

                oldOperand = string.Empty;
                newOperand = string.Empty;
                return false;
            }
        }
    }
}

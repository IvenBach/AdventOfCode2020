using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day18
{
    public class OperationOrder
    {
        private IEnumerable<string> Input { get; }
        private Dictionary<char, int> OperatorPredecence { get; }
        public OperationOrder(IEnumerable<string> input, Dictionary<char, int> operatorPrecedence)
        {
            Input = input;
            OperatorPredecence = operatorPrecedence;
        }

        /// <summary>
        /// Evaluates each expression and returns the sum of all evaluations.
        /// </summary>
        /// <returns>Sum of all evaluations</returns>
        public ulong EvaluationSum()
        {
            var sum = 0UL;
            ulong evaluated;
            foreach (var expression in Input)
            {
                var reversePolishNotation = ShuntingYardAlgorithm.Execute(expression, OperatorPredecence);
                evaluated = ReversePolishNotationEvaluator.Evaluate(reversePolishNotation);

                sum += evaluated;
            }

            return sum;
        }        
    }
}

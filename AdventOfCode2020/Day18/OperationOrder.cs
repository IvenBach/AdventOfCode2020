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
        public OperationOrder(IEnumerable<string> input)
        {
            Input = input;
        }

        /// <summary>
        /// Evaluates each expression and returns the sum of all evaluations.
        /// </summary>
        /// <returns>Sum of all evaluations</returns>
        public int EvaluationSum()
        {
            var sum = 0;

            foreach (var expression in Input)
            {
                sum += Evaluate(expression.Replace(" ", string.Empty));
            }


            return sum;
        }

        private int Evaluate(string expression)
        {
            
            var leftSpan = 0;
            while ('0' <= expression[leftSpan] && expression[leftSpan] <= '9')
            {
                leftSpan++;
            }
            var leftOperand = int.Parse(expression.Substring(0, leftSpan));

            var operation = expression[leftSpan];

            var rightIndex = leftSpan + 1;
            var rightSpan = 0;
            while ((rightIndex + rightSpan) < expression.Length && '0' <= expression[rightIndex + rightSpan] && expression[rightIndex + rightSpan] <= '9')
            {
                rightSpan++;
            }
            var rightOperand = int.Parse(expression.Substring(rightIndex, rightSpan));

            var pending = expression.Substring(rightIndex + rightSpan);

            var evaluted = EvaluateOperator(leftOperand, rightOperand, operation);

            return pending == string.Empty
                ? evaluted
                : Evaluate(evaluted + pending);
        }

        private int EvaluateOperator(int leftOperand, int rightOperand, char operation)
        {
            switch (operation)
            {
                case '+':
                    return leftOperand + rightOperand;
                case '*':
                    return leftOperand * rightOperand;
                default:
                    throw new ArgumentException();
            }
        }
    }
}

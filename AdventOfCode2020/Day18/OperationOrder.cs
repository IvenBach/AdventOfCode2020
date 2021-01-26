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
        public ulong EvaluationSum()
        {
            var sum = 0UL;
            ulong evaluated = 0;
            ulong max = ulong.MinValue;
            foreach (var expression in Input)
            {
                evaluated = Evaluate(expression.Replace(" ", string.Empty));
                max = Math.Max(evaluated, max);
                sum += evaluated;
            }

            return sum;
        }

        private uint Evaluate(string expression)
        {
            int leftSpan = 0;
            var leftOperand = GetOperand(expression, 0, ref leftSpan);
            if (expression.Length == leftSpan)
            {
                return leftOperand;
            }

            var operation = expression[leftSpan];

            var rightIndex = leftSpan + 1;
            var rightSpan = 0;
            var rightOperand = GetOperand(expression, rightIndex, ref rightSpan);

            var pending = expression.Substring(rightIndex + rightSpan);

            var evaluted = EvaluateOperator(leftOperand, rightOperand, operation);

            return pending == string.Empty
                ? evaluted
                : Evaluate(evaluted + pending);
        }

        private uint GetOperand(string expression, int startIndex, ref int span)
        {
            if (expression[startIndex] == '(')
            {
                span = ParenthesizedSpan(expression, startIndex);
                //var front = expression.Substring(0, startIndex);

                //var middle = Evaluate(expression.Substring(startIndex + 1, span - 2));

                //var end = expression.Substring(startIndex + span);
                //return Evaluate(front + middle + end);
                return Evaluate(expression.Substring(startIndex + 1, span - 2));
            }

            var lSpan = 0;
            while ((startIndex + lSpan) < expression.Length && '0' <= expression[startIndex + lSpan] && expression[startIndex + lSpan] <= '9')
            {
                lSpan++;
            }
            span = lSpan;

            return uint.Parse(expression.Substring(startIndex, lSpan));
        }

        private int ParenthesizedSpan(string expression, int startIndex)
        {
            int depth = 1;
            int span = 1;

            while (depth > 0 & (startIndex + span) < expression.Length)
            {
                var c = expression[startIndex + span];
                if (c == '(')
                {
                    depth++;
                }
                else if (c == ')')
                {
                    depth--;
                }

                span++;
            }

            return span;
        }

        private uint EvaluateOperator(uint leftOperand, uint rightOperand, char operation)
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

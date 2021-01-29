using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day18
{
    public static class ReversePolishNotationEvaluator
    {
        /// <summary>
        /// Evaluates the given expression and returns the result.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns>Result of evaluating the expression</returns>
        public static ulong Evaluate(Queue<char> expression)
        {
            var operands = new Stack<ulong>();

            foreach (var c in expression)
            {
                if ('0' <= c && c <= '9')
                {
                    operands.Push((ulong)(c - '0'));
                }
                else
                {
                    var b = operands.Pop();
                    var a = operands.Pop();
                    var value = Evaluate(a, b, c);
                    operands.Push(value);
                }
            }

            return operands.Pop();
        }

        private static ulong Evaluate(ulong a, ulong b, char op)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '/':
                    return a / b;
                case '*':
                case 'x':
                    return a * b;
                default:
                    throw new ArgumentException();
            }
        }
    }
}

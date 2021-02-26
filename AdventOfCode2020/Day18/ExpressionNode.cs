using AdventOfCode2020.Day18.Expressions.Abstract;
using AdventOfCode2020.Day18.Expressions.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day18
{
    public class ExpressionNode
    {
        /// <summary>
        /// Builds an expression tree from the string formula argument.
        /// </summary>
        /// <param name="s">Formula from which to build the tree.</param>
        /// <param name="operatorPriority">Contains operators and their priority for evaluation. Suppling a <see cref="null"/> value uses default operator order.</param>
        /// <returns>Root <see cref="Expression"/> of the expression tree.</returns>
        public static Expression BuildTree(string s, Dictionary<char, int> operatorPriority)
        {
            if (operatorPriority == null)
            {
                operatorPriority = DefaultOperatorPrecedence();
            }

            var nodeStack = new Stack<Expression>();
            var charStack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == ' ')
                {
                    continue;
                }

                if (char.IsDigit(c))
                {
                    var span = 0;
                    while ((i + span + 1) < s.Length
                        && char.IsDigit(s[i + span + 1]))
                    {
                        span++;
                    }

                    var number = int.Parse(s.Substring(i, span +1));
                    
                    i += span;
                    nodeStack.Push(new IntegerExpression(number));
                    continue;
                }

                if (c == '(')
                {
                    charStack.Push(c);
                    continue;
                }

                if (c == ')')
                {
                    while (charStack.Any()
                        && charStack.Peek() != '(')
                    {

                        var right = nodeStack.Pop();
                        var left = nodeStack.Pop();
                        var node = BinaryExpression(charStack.Pop(), left, right);

                        nodeStack.Push(node);
                    }

                    nodeStack.Push(new ParenthesizedExpression(nodeStack.Pop()));

                    charStack.Pop();
                    continue;
                }

                if (operatorPriority.ContainsKey(c) && !charStack.Any()
                    || charStack.Any() && charStack.Peek() == '(')
                {
                    charStack.Push(c);
                    continue;
                }

                if (operatorPriority.ContainsKey(c))
                {
                    if (charStack.Any()
                        && operatorPriority[c] > operatorPriority[charStack.Peek()])
                    {
                        charStack.Push(c);
                        continue;
                    }

                    while (charStack.Any()
                        && operatorPriority[c] <= operatorPriority[charStack.Peek()])
                    {
                        var right = nodeStack.Pop();
                        var left = nodeStack.Pop();
                        var node = BinaryExpression(charStack.Pop(), left, right);

                        nodeStack.Push(node);
                    }

                    charStack.Push(c);
                }
            }

            while (charStack.Any())
            {
                var right = nodeStack.Pop();
                var left = nodeStack.Pop();
                var node = BinaryExpression(charStack.Pop(), left, right);

                nodeStack.Push(node);
            }

            return nodeStack.Pop();
        }

        private static BinaryExpression BinaryExpression(char oper, Expression left, Expression right)
        {
            if (oper == '+')
            {
                return new AddExpression(left, right);
            }

            if (oper == '*')
            {
                return new MultiplyExpression(left, right);
            }

            throw new ArgumentException();
        }

        private static Dictionary<char, int> DefaultOperatorPrecedence()
        {
            return new Dictionary<char, int>()
            {
                { '+', 1 },
                { '-', 1 },
                { '/', 2 },
                { '*', 2 },
                { '^', 3 }
            };
        }
    }
}

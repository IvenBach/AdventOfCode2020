using AdventOfCode2020.Day18.MDoerner_Example.Tokens.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day18.MDoerner_Example.Context
{
    public class ExpressionContext : ParserContext
    {
        public ExpressionContext(int startIndex, int stopIndex, IToken[] tokenStream, ParserContextType type)
            : base(type, startIndex, stopIndex, tokenStream)
        {
        }

        /// <summary>
        /// Evaluates the expression according to the operator precedence.
        /// </summary>
        /// <param name="tokenOperatorPrecedence">Defines the order in which operator evaluation occurs.</param>
        /// <returns>Value of the evaluated expression</returns>
        public ulong Evaluate(Dictionary<char, int> tokenOperatorPrecedence)
        {

            if (!tokenOperatorPrecedence.ContainsKey('('))
            {
                tokenOperatorPrecedence.Add('(', int.MinValue);
            }

            var operandStack = new Stack<ulong>();
            var operatorStack = new Stack<char>();
            foreach (var token in TokenStream)
            {
                if (token.Type == TokenType.Integer)
                {
                    operandStack.Push(ulong.Parse(token.Text));
                    continue;
                }

                if (token.Text[0] == '(')
                {
                    operatorStack.Push(token.Text[0]);
                    continue;
                }

                if (token.Text[0] == ')')
                {
                    while (operatorStack.Peek() != '(')
                    {
                        var right = operandStack.Pop();
                        var left = operandStack.Pop();
                        var op = operatorStack.Pop();

                        var value = EvaluateOperation(op, left, right);
                        operandStack.Push(value);
                    }

                    operatorStack.Pop();
                    continue;
                }

                if (!operatorStack.Any())
                {
                    operatorStack.Push(token.Text[0]);
                }
                else
                {
                    if (tokenOperatorPrecedence[token.Text[0]] > tokenOperatorPrecedence[operatorStack.Peek()])
                    {
                        operatorStack.Push(token.Text[0]);
                        continue;
                    }
                    else
                    {
                        while (operatorStack.Any()
                            && tokenOperatorPrecedence[operatorStack.Peek()] >= tokenOperatorPrecedence[token.Text[0]])
                        {
                            var op = operatorStack.Pop();
                            var right = operandStack.Pop();
                            var left = operandStack.Pop();

                            var value = EvaluateOperation(op, left, right);
                            operandStack.Push(value);
                        }

                        operatorStack.Push(token.Text[0]);
                        continue;
                    }
                }
            }

            while (operatorStack.Any())
            {
                var op = operatorStack.Pop();
                var right = operandStack.Pop();
                var left = operandStack.Pop();
                var value = EvaluateOperation(op, left, right);

                operandStack.Push(value);
            }

            return operandStack.Pop();
        }

        private ulong EvaluateOperation(char op, ulong left, ulong right)
        {
            switch (op)
            {
                case '+':
                    return left + right;
                case '*':
                    return left * right;
                default:
                    throw new ArgumentException();
            }
        }
    }
}

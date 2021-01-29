using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day18
{
    public static class ShuntingYardAlgorithm
    {
        /// <summary>
        /// Will evaluate the expression to return the formula in Reverse Polish Notation.
        /// </summary>
        /// <param name="expression">Expression to evaluate</param>
        /// <param name="operatorPrecedence">Precedence of operators for evaluation. If argument is null standard PEMDAS order is used</param>
        /// <returns>Equation in Reverse Polish Notation</returns>
        public static Queue<char> Execute(string expression, Dictionary<char, int> operatorPrecedence)
        {
            if (operatorPrecedence == null)
            {
                operatorPrecedence = StandardPEMDASPrecedence();
            }

            if (!operatorPrecedence.ContainsKey('('))
            {
                operatorPrecedence.Add('(', int.MinValue);
            }

            var rpn = ReversePolishNotation(expression.Replace(" ",""), operatorPrecedence);
            return rpn;
        }

        private static Queue<char> ReversePolishNotation(string expression, Dictionary<char,int> opPrecedence)
        {
            var operators = new Stack<char>();
            var output = new Queue<char>();

            foreach (var c in expression)
            {
                //If the incoming symbols is an operand, print it
                if (IsDigit(c))
                {
                    output.Enqueue(c);
                    continue;
                }

                //If the incoming symbol is a left parenthesis, push it on the stack.                
                if (c == '(')
                {
                    operators.Push(c);
                    continue;
                }

                //If the incoming symbol is a right parenthesis: discard the right parenthesis,
                //pop and print the stack symbols until you see a left parenthesis. Pop the left parenthesis and discard it.}
                if (c == ')')
                {
                    while (operators.Peek() != '(')
                    {
                        output.Enqueue(operators.Pop());
                    }

                    var _ = operators.Pop();
                    continue;
                }

                //If the incoming symbol is an operator:
                if (IsOperator(c))
                {
                    //the stack is empty or contains a left parenthesis on top, push the incoming operator onto the stack.
                    if (!operators.Any() || operators.Peek() == '(')
                    {
                        operators.Push(c);
                        continue;
                    }

                    const bool isLeftAssociative = true; // [ +, -, *, /] are all left associative.
                    const bool isRightAssociative = false; // No exponent (^) operator;
                    //has either higher precedence than the operator on the top of the stack,
                    // or has the same precedence as the operator on the top of the stack and is right associative --push it on the stack.
                    if (opPrecedence[c] > opPrecedence[operators.Peek()]
                        || opPrecedence[c] == opPrecedence[operators.Peek()] && isRightAssociative)
                    {
                        operators.Push(c);
                        continue;
                    }

                    //has either lower precedence than the operator on the top of the stack,
                    //or has the same precedence as the operator on the top of the stack and is left associative
                    //-- continue to pop the stack until this is not true.Then, push the incoming operator.
                    while (operators.Any() &&
                        (opPrecedence[c] < opPrecedence[operators.Peek()]
                        || opPrecedence[c] == opPrecedence[operators.Peek()] && isLeftAssociative))
                    {
                        output.Enqueue(operators.Pop());
                    }
                    operators.Push(c);
                }
            }

            //At the end of the expression, pop and print all operators on the stack. (No parentheses should remain.)
            while (operators.Any())
            {
                output.Enqueue(operators.Pop());
            }

            return output;
        }

        private static bool IsDigit(char c)
        {
            return '0' <= c && c <= '9';
        }

        private static bool IsOperator(char c)
        {
            return c == '+'
                || c == '*' || c == 'x'
                || c == '/'
                || c == '-';
        }

        private static Dictionary<char, int> StandardPEMDASPrecedence()
        {
            var dict = new Dictionary<char, int>
            {
                { '+', 1 },
                { '-', 1 },
                { '*', 2 },
                { 'x', 2 },
                { '/', 2 },
            };

            return dict;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day18
{
    public class Node
    {
        public char Data { get; }
        public Node Left { get; }
        public Node Right { get; }

        public Node(char data, Node left = null, Node right = null)
        {
            Data = data;
            Left = left;
            Right = right;
        }

        /// <summary>
        /// Builds an expression tree from the string formula argument.
        /// </summary>
        /// <param name="s">Formula from which to build the tree.</param>
        /// <param name="operatorPriority">Contains operators and their priority for evaluation. Suppling a <see cref="null"/> value uses default operator order.</param>
        /// <returns>Root <see cref="Node"/> of the expression tree.</returns>
        public static Node BuildTree(string s, Dictionary<char, int> operatorPriority)
        {
            if (operatorPriority == null)
            {
                operatorPriority = DefaultOperatorPrecedence();
            }

            var nodeStack = new Stack<Node>();
            var charStack = new Stack<char>();

            foreach (var c in s)
            {
                if (c == ' ')
                {
                    continue;
                }

                if ('0' <= c && c <= '9')
                {
                    nodeStack.Push(new Node(c));
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
                        var node = new Node(charStack.Pop(), left, right);

                        nodeStack.Push(node);
                    }

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
                        var node = new Node(charStack.Pop(), left, right);

                        nodeStack.Push(node);
                    }

                    charStack.Push(c);
                }
            }

            while (charStack.Any())
            {
                var right = nodeStack.Pop();
                var left = nodeStack.Pop();
                var node = new Node(charStack.Pop(), left, right);

                nodeStack.Push(node);
            }

            return nodeStack.Pop();
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

        public static ulong Evaluate(Node root)
        {
            if (root.Left != null && root.Right != null)
            {
                var left = Evaluate(root.Left);
                var right = Evaluate(root.Right);

                switch (root.Data)
                {
                    case '+':
                        return left + right;
                    case '*':
                        return left * right;
                    default:
                        throw new ArgumentException();
                }
            }

            return ulong.Parse(root.Data.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode2020.Day18.Expressions.Abstract;

namespace AdventOfCode2020.Day18.Expressions.Concrete
{
    public class AddExpression : BinaryExpression
    {
        public override Expression Left { get; }
        public override Expression Right { get; }
        public AddExpression(Expression left, Expression right)
        {
            if (left == null || right == null)
            {
                throw new ArgumentNullException();
            }

            Left = left;
            Right = right;
        }

        public override string GetText()
        {
            var left = Left.Value().ToString();
            var right = Right.Value().ToString();
            var op = Right.Value() < 0 ? string.Empty : "+";

            return left + op + right;
        }

        public override int Value()
        {
            return Left.Value() + Right.Value();
        }
    }
}

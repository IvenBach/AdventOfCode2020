using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode2020.Day18.Expressions.Abstract;

namespace AdventOfCode2020.Day18.Expressions.Concrete
{
    public class MultiplyExpression : BinaryExpression
    {
        public MultiplyExpression(Expression left, Expression right)
        {
            if (left == null || right == null)
            {
                throw new ArgumentNullException();
            }

            Left = left;
            Right = right;

        }
        public override Expression Left { get; }

        public override Expression Right { get; }

        public override string GetText()
        {
            return Left.GetText() + "*" + Right.GetText();
        }

        public override int Value()
        {
            return Left.Value() * Right.Value();
        }
    }
}

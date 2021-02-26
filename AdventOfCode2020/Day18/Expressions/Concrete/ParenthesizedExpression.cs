using AdventOfCode2020.Day18.Expressions.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day18.Expressions.Concrete
{
    public class ParenthesizedExpression : Expression
    {
        public Expression Expression { get; }
        public ParenthesizedExpression(Expression expression)
        {
            if (expression == null)
            {
                throw new ArgumentNullException();
            }

            Expression = expression;
        }

        public override string GetText()
        {
            return "(" + Expression.GetText() + ")";
        }

        public override int Value() => Expression.Value();
    }
}

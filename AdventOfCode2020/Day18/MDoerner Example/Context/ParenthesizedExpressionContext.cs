using AdventOfCode2020.Day18.MDoerner_Example.Tokens.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day18.MDoerner_Example.Context
{
    [DebuggerDisplay("{GetText()}")]
    public class ParenthesizedExpressionContext : ExpressionContext
    {
        internal ExpressionContext InnerExpression { get; }

        public ParenthesizedExpressionContext(ExpressionContext innerExpression, IToken[] tokenStream) 
            : base(innerExpression.StartIndex - 1, innerExpression.StopIndex + 1, tokenStream, ParserContextType.ParenthesizedExpression)
        {
            InnerExpression = innerExpression;
        }
    }
}

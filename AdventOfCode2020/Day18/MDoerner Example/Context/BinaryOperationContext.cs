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
    public class BinaryOperationContext : ExpressionContext
    {
        string Operator { get; }
        ExpressionContext Left { get; }
        ExpressionContext Right { get; }

        public BinaryOperationContext(int operatorIndex, ExpressionContext left, ExpressionContext right, IToken[] tokenStream) 
            : base(left.StartIndex, right.StopIndex, tokenStream, ParserContextType.BinaryOperation)
        {
            Operator = tokenStream[operatorIndex].Text;
            Left = left;
            Right = right;
        }
    }
}

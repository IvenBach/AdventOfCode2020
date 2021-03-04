using AdventOfCode2020.Day18.MDoerner_Example.Tokens.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day18.MDoerner_Example.Context
{
    [DebuggerDisplay("{Value}")]
    class IntegerContext : ExpressionContext
    {
        public int Value { get; }

        public IntegerContext(int index, IToken[] tokenStream) 
            : base(index, index + 1, tokenStream, ParserContextType.Integer)
        {
            Value = int.Parse(tokenStream[index].Text);
        }
    }
}

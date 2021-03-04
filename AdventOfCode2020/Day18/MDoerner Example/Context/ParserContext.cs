using AdventOfCode2020.Day18.MDoerner_Example.Tokens.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day18.MDoerner_Example.Context
{
    public enum ParserContextType
    {
        Expression = 1 << 0,
        BinaryOperation = Expression | 1 << 1,
        Integer = Expression | 1 << 2,
        ParenthesizedExpression = Expression | 1 << 3
    }

    public class ParserContext
    {
        internal ParserContextType Type { get; }
        internal int StartIndex { get; }
        internal int StopIndex { get; }
        internal IToken[] TokenStream { get; }

        public ParserContext(ParserContextType type, int startIndex, int stopIndex, IToken[] tokenStream)
        {
            Type = type;
            StartIndex = startIndex;
            StopIndex = stopIndex;
            TokenStream = tokenStream;
        }

        internal string GetText()
        {
            return string.Join(string.Empty, TokenStream
                .Skip(StartIndex)
                .Take(StopIndex)
                .Select(t => t.Text));
        }
    }
}

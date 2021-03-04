using AdventOfCode2020.Day18.MDoerner_Example.Tokens.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day18.MDoerner_Example.Tokens.Concrete
{
    [DebuggerDisplay("Value = {Text}")]
    class IntegerToken : IToken
    {
        public TokenType Type { get; } = TokenType.Integer;

        public string Text { get; }

        public IntegerToken(string text)
        {
            Text = text;
        }
    }
}

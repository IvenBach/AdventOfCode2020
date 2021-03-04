using AdventOfCode2020.Day18.MDoerner_Example.Tokens.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day18.MDoerner_Example.Tokens.Concrete
{
    internal static class Token
    {
        internal static AdditionToken AdditionToken { get; } = new AdditionToken();
        internal static MultiplicationToken MultiplicationToken { get; } = new MultiplicationToken();
        internal static LeftParenthesis LeftParenthesis { get; } = new LeftParenthesis();
        internal static RightParenthesis RightParenthesis { get; } = new RightParenthesis();
    }

    [DebuggerDisplay("{Text}")]
    class AdditionToken : IToken
    {
        public TokenType Type => TokenType.Plus;

        public string Text => "+";
    }

    [DebuggerDisplay("{Text}")]
    class MultiplicationToken : IToken
    {
        public TokenType Type => TokenType.Multiplication;

        public string Text => "*";
    }

    [DebuggerDisplay("{Text}")]
    class LeftParenthesis : IToken
    {
        public TokenType Type => TokenType.LeftParenthesis;

        public string Text => "(";
    }

    [DebuggerDisplay("{Text}")]
    class RightParenthesis : IToken
    {
        public TokenType Type => TokenType.RightParenthesis;

        public string Text => ")";
    }
}

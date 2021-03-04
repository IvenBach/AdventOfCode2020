using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day18.MDoerner_Example.Tokens.Abstract
{
    public interface IToken
    {
        TokenType Type { get; }
        string Text { get; }
    }
}

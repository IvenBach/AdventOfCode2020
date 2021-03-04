using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode2020.Day18.MDoerner_Example.Tokens.Abstract;
using AdventOfCode2020.Day18.MDoerner_Example.Tokens.Concrete;

namespace AdventOfCode2020.Day18.MDoerner_Example
{
    class FormulaLexer
    {
        internal static IToken[] TokenStream(string text)
        {
            List<IToken> tokens = new List<IToken>();
            List<char> currentDigits = new List<char>();

            foreach (var c in text)
            {
                if (char.IsDigit(c))
                {
                    currentDigits.Add(c);
                }
                else
                {
                    if (currentDigits.Count > 0)
                    {
                        var s = string.Join(string.Empty, currentDigits);
                        var token = new IntegerToken(s);
                        tokens.Add(token);
                        currentDigits = new List<char>();
                    }

                    switch (c)
                    {
                        case '*':
                            tokens.Add(Token.MultiplicationToken);
                            break;
                        case '+':
                            tokens.Add(Token.AdditionToken);
                            break;
                        case '(':
                            tokens.Add(Token.LeftParenthesis);
                            break;
                        case ')':
                            tokens.Add(Token.RightParenthesis);
                            break;
                    }
                }
            }

            if (currentDigits.Count > 0)
            {
                var s = string.Join(string.Empty, currentDigits);
                var token = new IntegerToken(s);
                tokens.Add(token);
            }
            
            return tokens.ToArray();
        }
        
    }
}

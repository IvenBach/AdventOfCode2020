using AdventOfCode2020.Day18.MDoerner_Example.Context;
using AdventOfCode2020.Day18.MDoerner_Example.Tokens.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day18.MDoerner_Example.Parser.Abstract
{
    interface IFormulaParser
    {
        ExpressionContext Parse(string text);
    }

    public abstract class FormulaParserBase : IFormulaParser
    {
        public ExpressionContext Parse(string text)
        {
            var tokenStream = FormulaLexer.TokenStream(text);

            return ParseTokenStream(tokenStream);
        }

        private ExpressionContext ParseTokenStream(IToken[] tokenStream)
        {
            return ParseExpression(tokenStream.Length - 1, tokenStream);
        }

        protected ExpressionContext ParseExpression(int endIndex, IToken[] tokenStream)
        {
            var operandExpression = ParseOperandExpression(endIndex, tokenStream);

            if (operandExpression == null)
            {
                return null;
            }

            var previousTokenIndex = operandExpression.StartIndex - 1;

            if (previousTokenIndex < 0)
            {
                return operandExpression;
            }

            var previousToken = tokenStream[previousTokenIndex];

            switch (previousToken.Type)
            {
                case TokenType.Plus:
                case TokenType.Multiplication:
                    return ParseBinaryOperation(previousTokenIndex, operandExpression, tokenStream);
                    break;
                default:
                    return operandExpression;
            }
        }

        protected ExpressionContext ParseOperandExpression(int endIndex, IToken[] tokenStream)
        {
            var endToken = tokenStream[endIndex];

            switch (endToken.Type)
            {
                case TokenType.Integer:
                    return new IntegerContext(endIndex, tokenStream);
                case TokenType.RightParenthesis:
                    return ParseParenthesizedExpression(endIndex, tokenStream);
                default:
                    return null;
            }
            return null;
        }

        protected ParenthesizedExpressionContext ParseParenthesizedExpression(int endIndex, IToken[] tokenStream)
        {
            var innerExpression = ParseExpression(endIndex - 1, tokenStream);
            return innerExpression != null
                ? new ParenthesizedExpressionContext(innerExpression, tokenStream)
                : null;
        }

        protected BinaryOperationContext ParseBinaryOperation(int operatorIndex, ExpressionContext right, IToken[] tokenStream)
        {
            var left = ParseExpression(operatorIndex - 1, tokenStream);
            return left != null
                ? new BinaryOperationContext(operatorIndex, left, right, tokenStream)
                : null;
        }
    }
}

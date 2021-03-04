using AdventOfCode2020.Day18.MDoerner_Example.Context;
using AdventOfCode2020.Day18.MDoerner_Example.Parser.Abstract;
using AdventOfCode2020.Day18.MDoerner_Example.Tokens.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day18.MDoerner_Example.Parser.Concrete
{
    public class Parser : FormulaParserBase
    {
        internal BinaryOperationContext ParseBinaryOperation(int operatorIndex, ExpressionContext rightOperand, IToken[] tokenStream)
        {
            var currentOperatorIndex = operatorIndex;
            var oper = tokenStream[operatorIndex];
            var right = rightOperand;

            while (currentOperatorIndex >= 0 && oper.Type == TokenType.Plus)
            {
                var nextOperand = ParseOperandExpression(currentOperatorIndex - 1, tokenStream);
                if (nextOperand == null)
                {
                    return null;
                }

                right = new BinaryOperationContext(currentOperatorIndex, nextOperand, right, tokenStream);
                if (right == null)
                {
                    return null;
                }

                currentOperatorIndex = right.StartIndex - 1;
                oper = tokenStream[currentOperatorIndex];
            }

            if (currentOperatorIndex < 0 || oper.Type != TokenType.Multiplication)
            {
                return right as BinaryOperationContext;
            }

            var left = ParseExpression(currentOperatorIndex - 1, tokenStream);
            return left != null
                ? new BinaryOperationContext(currentOperatorIndex, left, right, tokenStream)
                : null;
        }
    }
}

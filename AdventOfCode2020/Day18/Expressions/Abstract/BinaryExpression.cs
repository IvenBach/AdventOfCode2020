using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day18.Expressions.Abstract
{
    public abstract class BinaryExpression : Expression
    {
        public abstract Expression Left { get; }

        public abstract Expression Right { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode2020.Day18.Expressions.Abstract;

namespace AdventOfCode2020.Day18.Expressions.Concrete
{
    public class IntegerExpression : Expression
    {
        private readonly int value;
        public IntegerExpression(int value)
        {
            this.value = value;
        }

        public override string GetText()
        {
            return value.ToString();
        }

        public override int Value() => value;
    }
}

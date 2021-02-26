using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day18.Expressions.Abstract
{
    public abstract class Expression
    {
        public abstract string GetText();

        public abstract int Value();
    }
}

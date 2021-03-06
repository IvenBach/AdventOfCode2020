﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AdventOfCode2020.Day16
{
    [DebuggerDisplay("Category={Category}, Lower={LowerSpan}, Upper={UpperSpan}")]
    public class TicketConstraint
    {
        public string Category { get; }
        public TicketSpan LowerSpan { get; }
        public TicketSpan UpperSpan { get; }
        public TicketConstraint(string category, (int, int) lowerSpan, (int,int) upperSpan)
        {
            Category = category;
            LowerSpan = new TicketSpan(lowerSpan.Item1, lowerSpan.Item2);
            UpperSpan = new TicketSpan(upperSpan.Item1, upperSpan.Item2);
        }
    }

    [DebuggerDisplay("{LowerValue}-{UpperValue}")]
    public class TicketSpan
    {
        public int LowerValue { get; }
        public int UpperValue { get; }
        public TicketSpan(int lower, int upper)
        {
            LowerValue = lower;
            UpperValue = upper;
        }
    }
}

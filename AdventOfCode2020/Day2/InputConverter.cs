using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day2
{
    public class InputConverter
    {
        public InputConverter(string input)
        {
            var parts = input.Split(' ');
            MinimumQuantity = int.Parse(parts[0]);
            MaximumQuantity = int.Parse(parts[2]);
            Character = parts[3].Substring(0, 1).ToCharArray()[0];
            Password = parts[4];
        }

        public int MinimumQuantity { get; }
        public int MaximumQuantity { get; }
        public char Character { get; }
        public string Password { get; }
    }
}

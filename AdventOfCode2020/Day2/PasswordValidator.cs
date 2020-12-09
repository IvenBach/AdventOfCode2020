using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AdventOfCode2020.Day2
{
    public class PasswordValidator
    {
        private readonly InputConverter converter;
        public PasswordValidator(InputConverter converter)
        {
            this.converter = converter;
        }

        public bool Part1IsValid()
        {
            int count = 0;
            foreach (var c in converter.Password)
            {
                if (c == converter.Character)
                {
                    count++;

                    if (count > converter.MaximumQuantity) { return false; }
                }
            }

            return converter.MinimumQuantity <= count && count <= converter.MaximumQuantity;
        }

        public bool Part2IsValid()
        {
            var password = converter.Password;
            var firstPosition = converter.MinimumQuantity - 1;
            var secondPosition = converter.MaximumQuantity - 1;
            if (password[firstPosition] == converter.Character
                || password[secondPosition] == converter.Character)
            {
                return password[firstPosition] != password[secondPosition];
            }

            return false;
        }
    }
}

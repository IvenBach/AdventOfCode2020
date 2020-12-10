using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day6
{
    public class CustomsDeclaration
    {
        public int TrueAnswerCount { get; }
        public CustomsDeclaration(string input)
        {
             TrueAnswerCount = input.Replace(Environment.NewLine, string.Empty)
                .Distinct()
                .Count();
        }

        public static string[] ConvertRawInput(string input)
        {
            return input.Split(new[] { Environment.NewLine + Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static int GroupCount(IEnumerable<string> groups)
        {
            int count = 0;
            foreach (var group in groups)
            {
                var cd = new CustomsDeclaration(group);
                count += cd.TrueAnswerCount;
            }

            return count;
        }
    }
}

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

        public static string[] ConvertToGroups(string input)
        {
            return input.Split(new[] { Environment.NewLine + Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static int CountWhereAnyoneAnsweredTrue(IEnumerable<string> groups)
        {
            int count = 0;
            foreach (var group in groups)
            {
                var cd = new CustomsDeclaration(group);
                count += cd.TrueAnswerCount;
            }

            return count;
        }

        public static int CountWhereEveryoneInGroupAnsweredYes(IEnumerable<string> groups)
        {
            int count = 0;
            foreach (var group in groups)
            {
                if (SinglePersonGroup(group))
                {
                    count += group.Distinct().Count();
                }
                else
                {
                    count += CountOfQuestionsEveryoneAnsweredYes(group.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));
                }
            }

            return count;

            bool SinglePersonGroup(string value) => !value.Contains(Environment.NewLine);

            int CountOfQuestionsEveryoneAnsweredYes(string[] answers)
            {
                var hash = new HashSet<char>(answers[0]);
                foreach (var answer in answers)
                {
                    var checkHash = new HashSet<char>(hash);
                    foreach (var c in hash)
                    {
                        if (!answer.Contains(c))
                        {
                            checkHash.Remove(c);
                        }
                    }

                    if (checkHash.Count == 0)
                    {
                        return 0;
                    }

                    hash = checkHash;
                }

                return hash.Count;
            }
        }
    }
}

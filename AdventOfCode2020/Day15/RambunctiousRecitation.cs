using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day15
{
    public class RambunctiousRecitation
    {
        private readonly IEnumerable<int> StartingValues;
        public RambunctiousRecitation(IEnumerable<int> startingValues)
        {
            StartingValues = startingValues;
        }

        public int NthSpokenNumber(int nthNumber)
        {
            var oneBack = new Dictionary<int, int>();
            var twoBack = new Dictionary<int, int>();

            foreach (var v in StartingValues)
            {
                oneBack.Add(v, oneBack.Count + 1);
            }

            var lastSpoken = StartingValues.Last();
            int turn = oneBack.Count + 1;
            int delta;
            while (turn <= nthNumber)
            {
                if (oneBack.ContainsKey(lastSpoken))
                {
                    if (twoBack.ContainsKey(lastSpoken))
                    {
                        delta = oneBack[lastSpoken] - twoBack[lastSpoken];
                        if (oneBack.ContainsKey(delta))
                        {
                            if (twoBack.ContainsKey(delta))
                            {
                                twoBack[delta] = oneBack[delta];
                            }
                            else
                            {
                                twoBack.Add(delta, oneBack[delta]);
                            }

                            oneBack[delta] = turn;
                        }
                        else
                        {
                            oneBack.Add(delta, turn);
                        }

                        lastSpoken = delta;
                    }
                    else
                    {
                        if (!twoBack.ContainsKey(lastSpoken))
                        {
                            twoBack[0] = oneBack[0];
                            oneBack[0] = turn;
                        }
                        else
                        {
                            twoBack[lastSpoken] = oneBack[lastSpoken];
                            oneBack[lastSpoken] = turn;
                        }
                        
                        lastSpoken = 0;
                    }
                }
                else
                {
                    oneBack.Add(lastSpoken, turn);
                    lastSpoken = 0;
                }

                turn++;
            }
            return lastSpoken;
        }
    }
}

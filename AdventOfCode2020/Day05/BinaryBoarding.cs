using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Day05
{
    public class BinaryBoarding
    {
        private string _input;
        private bool _previouslyCalculated;

        private int _row;
        public int Row
        {
            get
            {
                if (!_previouslyCalculated)
                {
                    CalculateBackingFields();
                }

                return _row;
            }
            private set
            {
                _row = value;
            }
        }

        private int _column;
        public int Column
        {
            get
            {
                if (!_previouslyCalculated)
                {
                    CalculateBackingFields();
                }

                return _column;
            }
            private set
            {
                _column = value;
            }
        }

        private int _seat;
        public int Seat
        {
            get
            {
                if (!_previouslyCalculated)
                {
                    CalculateBackingFields();
                }

                return _seat;
            }

            set
            {
                _seat = value;
            }
        }

        /// <summary>
        /// Value to determine seat location. Must consist of only the charactrs (F | B | L | R).
        /// </summary>
        /// <exception cref="System.ArgumentNullException">Thrown when input is unassigned.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when length does not match 10.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown then contains character other than (F | B | L | R).</exception>
        /// <param name="input"></param>
        public BinaryBoarding(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }

            const int expectedCharacterCount = 10;
            if (input.Length != expectedCharacterCount)
            {
                throw new ArgumentOutOfRangeException("Input must be " + expectedCharacterCount + " characters long.");
            }

            if (ContainsInvalidChar(input))
            {
                throw new ArgumentOutOfRangeException("Input must contain only values of (F, B, L, R)");
            }

            _input = input;
        }

        private bool ContainsInvalidChar(string value)
        {
            var hash = new HashSet<char>(4)
            {
                'F',
                'B',
                'L',
                'R'
            };

            foreach (var c in value.Distinct())
            {
                if (!hash.Contains(c))
                {
                    return true;
                }
            }

            return false;
        }

        private void CalculateBackingFields()
        {
            _row = CalculateField(_input.Substring(0,7).ToUpper());
            _column = CalculateField(_input.Substring(7, 3).ToUpper());
            _seat = _row * 8 + _column;

            _previouslyCalculated = true;

            int CalculateField(string subString)
            {
                int lowerBound = 0;
                int upperBound = (int)Math.Pow(2, subString.Length) - 1;

                for (int i = 0; i < subString.Length; i++)
                {
                    if (subString[i] == 'F' || subString[i] == 'L')
                    {
                        upperBound = ((lowerBound + upperBound + 1) / 2) - 1;
                    }
                    else
                    {
                        lowerBound = ((lowerBound + upperBound + 1) / 2);
                    }
                }

                return upperBound;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AdventOfCode2020.Day04
{
    public class Passport
    {
        public int? BirthYear { get; private set; }
        public int? IssueYear { get; private set; }
        public int? ExpirationYear { get; private set; }
        public string Height { get; private set; }
        public string HairColor { get; private set; }
        public string EyeColor { get; private set; }
        public int? PassportId { get; private set; }
        public int? CountryId { get; private set; }

        public Passport(string input)
        {
            var kvps = input.Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            AssignValues(kvps);
        }

        public bool IsValid => BirthYear.HasValue
                && IssueYear.HasValue
                && ExpirationYear.HasValue
                && Height != null
                && HairColor != null
                && EyeColor != null
                && PassportId.HasValue;

        private void AssignValues(string[] kvps)
        {
            foreach (var kvp in kvps)
            {
                var value = kvp.Split(new[] { ':' })[1];
                switch (kvp.Substring(0, 3))
                {
                    case "byr":
                        BirthYear = ValidBirthYear(value);
                        break;
                    case "iyr":
                        IssueYear = ValidIssueYear(value);
                        break;
                    case "eyr":
                        ExpirationYear = ValidExpirationYear(value);
                        break;
                    case "hgt":
                        Height = ValidHeight(value);
                        break;
                    case "hcl":
                        HairColor = ValidHairColor(value);
                        break;
                    case "ecl":
                        EyeColor = ValidEyeColor(value);
                        break;
                    case "pid":
                        PassportId = ValidPassportId(value);
                        break;
                    case "cid":
                        CountryId = ValidCountryId(value);
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }

        public virtual int? ValidBirthYear(string value) =>  int.Parse(value);
        public virtual int? ValidIssueYear(string value) => int.Parse(value);
        public virtual int? ValidExpirationYear(string value) => int.Parse(value);
        public virtual string ValidHeight(string value) => value;
        public virtual string ValidHairColor(string value) => value;
        public virtual string ValidEyeColor(string value) => value;
        public virtual int? ValidCountryId(string value) => int.Parse(value);

        public virtual int? ValidPassportId(string value)
        {
            if (int.TryParse(value, out var retval))
            {
                return retval;
            }

            if (value.Contains("#"))
            {
                return ConvertFromPoundPrefixedHex(value);
            }

            return null;
        }

        private int ConvertFromPoundPrefixedHex(string value)
        {
            return Convert.ToInt32(value.Replace("#", "0x"), 16);
        }
    }

    public class PassportPart2 : Passport
    {
        public PassportPart2(string input) : base(input)
        { }

        public override int? ValidBirthYear(string value)
        {
            return Get4DigitYearWithinBoundaries(value, 1920, 2002);
        }

        public override int? ValidIssueYear(string value)
        {
            return Get4DigitYearWithinBoundaries(value, 2010, 2020);
        }

        public override int? ValidExpirationYear(string value)
        {
            return Get4DigitYearWithinBoundaries(value, 2020, 2030);
        }

        private int? Get4DigitYearWithinBoundaries(string value, int lowerBound, int upperBound)
        {
            if (value.Length < 4) { return null; }

            if (int.TryParse(value, out var val))
            {
                return lowerBound <= val && val <= upperBound
                    ? val
                    : (int?)null;
            }

            return null;
        }

        public override string ValidHeight(string value)
        {
            if (value.EndsWith("cm"))
            {
                if (int.TryParse(value.Remove(value.Length - 2, 2), out var val))
                {
                    return 150 <= val && val <= 193
                        ? value
                        : null;
                }

                return null;
            }

            if (value.EndsWith("in"))
            {
                if (int.TryParse(value.Remove(value.Length - 2, 2), out var val))
                {
                    return 59 <= val && val <= 76
                        ? value
                        : null;
                }

                return null;
            }

            return null;
        }

        public override string ValidHairColor(string value)
        {
            var regex = new Regex("^#[0-9a-f]{6}");

            return regex.IsMatch(value) 
                ? value 
                : null;
        }

        public override string ValidEyeColor(string value)
        {
            var regex = new Regex(@"^(amb|blu|brn|gry|grn|hzl|oth)\Z");
            return regex.IsMatch(value)
                ? value
                : null;
        }

        public override int? ValidPassportId(string value)
        {
            var regex = new Regex(@"^\d{9}\Z");
            if (regex.IsMatch(value))
            {
                return int.Parse(value);
            }

            return null;
        }
    }
}

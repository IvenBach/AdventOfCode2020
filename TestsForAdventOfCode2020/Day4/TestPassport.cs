using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2020.Day4;

namespace TestsForAdventOfCode2020.Day4
{
    [TestClass]
    public class TestPassport
    {
        [TestMethod]
        public void Passport_with_complete_and_valid_inputs_returns_passport()
        {
            var input = @"ecl:gry pid:860033327 eyr:2020 hcl:#fffffd byr:1937 iyr:2017 cid:147 hgt:183cm";

            var passport = new Passport(input);

            Assert.AreEqual("gry", passport.EyeColor);
            Assert.AreEqual(860033327, passport.PassportId);
            Assert.AreEqual(2020, passport.ExpirationYear);
            Assert.AreEqual("#fffffd", passport.HairColor);
            Assert.AreEqual(1937, passport.BirthYear);
            Assert.AreEqual(2017, passport.IssueYear);
            Assert.AreEqual(147, passport.CountryId);
            Assert.AreEqual("183cm", passport.Height);
        }

        [TestMethod]
        public void Passport_with_all_inputs_filled_is_valid()
        {
            const string input = @"ecl:gry pid:860033327 eyr:2020 hcl:#fffffd byr:1937 iyr:2017 cid:147 hgt:183cm";

            var passport = new Passport(input);

            Assert.IsTrue(passport.IsValid);
        }

        [TestMethod]
        public void Passport_missing_only_countryId_considered_valid()
        {
            const string input = @"ecl:gry pid:860033327 eyr:2020 hcl:#fffffd byr:1937 iyr:2017 hgt:183cm";

            var passport = new Passport(input);

            Assert.IsTrue(passport.IsValid);
        }

        [TestMethod]
        public void Passport_missing_height_is_invalid()
        {
            const string input = @"iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884 hcl:#cfa07d byr:1929";

            var passport = new Passport(input);

            Assert.IsFalse(passport.IsValid);
        }

        [TestMethod]
        public void Passport_missing_countryId_and_any_other_property_is_invalid()
        {
            const string input = @"hcl:#cfa07d eyr:2025 pid:166559648 iyr:2011 ecl:brn hgt:59in";

            var passport = new Passport(input);

            Assert.IsFalse(passport.IsValid);
        }

        [TestMethod]
        public void Passport_kvp_values_separated_by_newline_creates_passport()
        {
            const string input = @"pid:827837505
byr:1976
hgt:187cm
iyr:2016
hcl:#fffffd
eyr:2024";

            var passport = new Passport(input);

            Assert.IsNotNull(passport);
        }

        [TestMethod]
        public void Passport_kvp_values_separated_by_space_creates_passport()
        {
            const string input = @"pid:827837505 byr:1976 hgt:187cm iyr:2016 hcl:#fffffd eyr:2024";

            var passport = new Passport(input);

            Assert.IsNotNull(passport);
        }

        [TestMethod]
        public void Passport_kvp_values_separated_by_space_and_newline_creates_passport()
        {
            const string input = @"pid:827837505 byr:1976
hgt:187cm iyr:2016 hcl:#fffffd eyr:2024";

            var passport = new Passport(input);

            Assert.IsNotNull(passport);
        }

        [TestMethod]
        public void Passport_with_id_stored_as_pound_prefixed_hex_number_is_created()
        {
            const string input = @"byr:2030 iyr:2024 ecl:#f66808 hcl:fd548d cid:183 pid:#fced33 hgt:160in";

            var passport = new Passport(input);

            Assert.IsNotNull(passport);
        }

        [TestMethod]
        [DataRow(@"eyr:1972 cid:100
hcl:#18171d ecl:amb hgt:170 pid:186cm iyr:2018 byr:1926")]
        [DataRow(@"iyr:2019
hcl:#602927 eyr:1967 hgt:170cm
ecl:grn pid:012533040 byr:1946")]
        [DataRow(@"hcl:dab227 iyr:2012
ecl:brn hgt:182cm pid:021572410 eyr:2020 byr:1992 cid:277")]
        [DataRow(@"hgt:59cm ecl:zzz
eyr:2038 hcl:74454a iyr:2023
pid:3556412378 byr:2007")]
        public void PassportV2_invalid_inputs_reports_as_invalid(string input)
        {
            var passport = new PassportPart2(input);

            Assert.IsFalse(passport.IsValid);
        }

        [TestMethod]
        [DataRow(@"pid:087499704 hgt:74in ecl:grn iyr:2012 eyr:2030 byr:1980
hcl:#623a2f")]
        [DataRow(@"eyr:2029 ecl:blu cid:129 byr:1989
iyr:2014 pid:896056539 hcl:#a97842 hgt:165cm")]
        [DataRow(@"hcl:#888785
hgt:164cm byr:2001 iyr:2015 cid:88
pid:545766238 ecl:hzl
eyr:2022")]
        [DataRow(@"iyr:2010 hgt:158cm hcl:#b6652a ecl:blu byr:1944 eyr:2021 pid:093154719")]
        public void PassportV2_validInputs_reports_as_valid(string input)
        {
            var passport = new PassportPart2(input);

            Assert.IsTrue(passport.IsValid);
        }
    }
}

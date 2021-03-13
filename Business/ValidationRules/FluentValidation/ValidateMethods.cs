using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Business.ValidationRules.FluentValidation
{
    public static class ValidateMethods
    {
        public static bool DasCapital(string args)
        {
            return Regex.IsMatch(args, "^[A-Z_ĞÜŞİÖÇ].*");
        }

        public static bool PasswordChek(string args)
        {
            return Regex.IsMatch(args, @"^(?=.*[a-z_ğüşıöç])(?=.*[A-Z_ĞÜŞİÖÇ])(?=.*\d)[A-Za-z_ğüşıöçĞÜŞİÖÇ\d]{8,}$");
        }
        public static bool DateTimeChek(DateTime args)
        {
            string result = args.Year.ToString() + "-" + args.Month.ToString() + "-" + args.Day.ToString();
            return Regex.IsMatch(/*args.ToString()*/result, @"^(([2][0-9])\d{2}?)-(\d|[0]\d|[1][0-2])-(\d|[0-2]\d|[3][0-1])");// @"^([0-2]\d|[3][0-1])-([0]\d|[1][0-2])-([2][0-9])\d{2}?$");
        }
    }
}

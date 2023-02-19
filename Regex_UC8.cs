using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssig
{
    public class Regex_UC8
    {
        public static string REGEX_PATTERN = "^([a-zA-Z0-9])*[!@#$%^&*]{1}{1}([a-zA-Z0-9])*$";

        public bool validateName(string name)
        {
            return Regex.IsMatch(name, REGEX_PATTERN);
        }
    }
}

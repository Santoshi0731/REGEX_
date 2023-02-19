using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssig
{
    public class Regex_UC7
    {
        public static string REGEX_PATTERN = "^[0-9 a-z A-Z]*$";

        public bool validateName(string name)
        {
            return Regex.IsMatch(name, REGEX_PATTERN);
        }
    }
}

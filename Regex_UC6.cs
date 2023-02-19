using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssig
{
    public class Regex_UC6
    {
        public static string REGEX_PATTERN = "^[A-Z]{1}[a-z]{7}$";

        public bool validateName(string name)
        {
            return Regex.IsMatch(name, REGEX_PATTERN);
        }
    }

}



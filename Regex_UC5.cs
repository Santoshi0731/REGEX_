using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssig
{
    public class Regex_UC5
    {
        public static string REGEX_PATTERN = "^[a-zA-Z]{8}$";

        public bool validateName(string name)
        {
            return Regex.IsMatch(name, REGEX_PATTERN);
        }
    }
}

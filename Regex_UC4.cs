using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssig
{
    public class Regex_UC4
    {
        public static string REGEX_PATTERN = "^[1-9]{2}[' ']?[0-9]{10}$";

        public bool validateName(string name)
        {
            return Regex.IsMatch(name, REGEX_PATTERN);
        }
    }
}

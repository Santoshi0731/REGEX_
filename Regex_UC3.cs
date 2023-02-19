using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssig
{
    public class Regex_UC3
    {
        public static string gmailpattern = "^[a-z]{3}[.][xyz]{0,3}@(bl.co)[.][a-z]{2}$";

        public bool validateName(string name)
        {
            return Regex.IsMatch(name, gmailpattern);
        }
    }
}

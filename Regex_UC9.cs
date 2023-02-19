using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexAssig
{
    public class Regex_UC9
    {
        public static string gmailpattern =@"^([a-z]+)(\.[a-z0-9_\+\-]+)?@([a-z]+)\.([a-z]{2,4})(\.[a-z]{2})?$";

        public bool validateName(string name)
        {
            return Regex.IsMatch(name, gmailpattern);
        }
    }
}

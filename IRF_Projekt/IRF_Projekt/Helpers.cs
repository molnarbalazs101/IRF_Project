using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IRF_Projekt
{
    public class Helpers
    {
        public static bool IsPhoneNumber(string phone)
        {
            Regex regex = new Regex(@"^(\+36|06)(-|/)[0-9]{1,2}-[0-9]{3}-?[0-9]{3,4}$");

            return regex.IsMatch(phone);
        }
    }
}

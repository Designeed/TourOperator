using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourOperator.Classes
{
    class Validation
    {
        public static bool txtBoxIsEmpty(params TextBox[] InputTextBox)
        {
            bool result = false;

            foreach (var item in InputTextBox)
            {
                if (String.IsNullOrEmpty(item.Text) == true)
                    result = true;

                else
                    result = false;
            }

            return result;
        }

        public static bool ValidationEmail(string Email)
        {

            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" +
                @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" +
                @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

            return regex.IsMatch(Email);
        }
    }
}

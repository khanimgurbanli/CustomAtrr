using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomValidateAttribute.MyAttributes
{
    public  class ValidEmail : ValidationAttribute
    {
        private readonly string _allowedEmailDomain;
        public ValidEmail() { }

        public ValidEmail(string email)
        {
             var check= IsValid(email);
            if (!check)
            {
                Console.WriteLine("Incorrect email format");
            }
            this._allowedEmailDomain = email;
        }

        public override bool IsValid(object email)
        {
            if (string.IsNullOrEmpty(email as string))
            {
                return false;
            }
            else
            {
                Regex regex = new(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                    + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                    + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$");
                Match match = regex.Match(email.ToString());

                return match.Success;
            }
        }
    
    }
}

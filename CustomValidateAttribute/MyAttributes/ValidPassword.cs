using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomValidateAttribute.MyAttributes
{
    public class ValidPassword : ValidationAttribute
    {
        private readonly string _allowedPassword;
        public ValidPassword() { }
    
        public ValidPassword(string password)
        {
            var check = IsValid(password);
            if (!check)
            {
                Console.WriteLine("Incorrect password format");
            }
            this._allowedPassword = password;
        }

        public override bool IsValid(object password)
        {
            if (string.IsNullOrEmpty(password as string))
            {
                return false;
            }
            else
            {

                Regex regex = new(@"^^(?=.*?\d).{8}");
                Match match = regex.Match(password.ToString());

                return match.Success;
            }
        }
    }
}

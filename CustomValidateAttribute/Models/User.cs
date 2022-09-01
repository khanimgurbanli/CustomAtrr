using CustomValidateAttribute.MyAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidateAttribute.Models
{
    public class User
    {
        [ValidEmail]
        public string Email { get; set; }

        [ValidPassword]
        public string Password { get; set; }
    }
}

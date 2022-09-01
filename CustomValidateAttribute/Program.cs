using CustomValidateAttribute.Models;
using CustomValidateAttribute.MyAttributes;

namespace CustomValidateAttribute
{
    class Program
    {
        public static void Main(string[] args)
        {

            User user = new();
            user.Email = "zeri@hejbjd";
            user.Password = "a233";
            ValidEmail validEmail = new ValidEmail(user.Email);
            ValidPassword validPassword = new ValidPassword(user.Password); ;


        }
    }
}
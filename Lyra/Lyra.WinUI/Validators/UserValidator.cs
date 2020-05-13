using Lyra.Model.Requests;
using Lyra.WinUI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyra.WinUI.Validators
{
    public class UserValidator : BaseValidator, IUserValidator
    {
        private readonly APIService _apiService = new APIService("User");
        public ValidationResult EmailCheck(string value)
        {
            if (!Required(value))
            {
                return new ValidationResult("This is a required field", false);
            }
            else if (!Email(value))
            {
                return new ValidationResult("Value is not a valid email address", false);
            }
            else
            {
                return new ValidationResult("", true);
            }
        }

        public ValidationResult FirstNameCheck(string value)
        {
            if (!Required(value))
            {
                return new ValidationResult("This is a required field", false);
            }
            else
            {
                return new ValidationResult("", true);
            }
        }

        public ValidationResult LastNameCheck(string value)
        {
            if (!Required(value))
            {
                return new ValidationResult("This is a required field", false);
            }
            else
            {
                return new ValidationResult("", true);
            }
        }

        public ValidationResult PasswordCheck(string value)
        {
            if (!Required(value))
            {
                return new ValidationResult("This is a required field", false);
            }
            else
            {
                return new ValidationResult("", true);
            }
        }

        public ValidationResult PasswordConfirmCheck(string password, string confirmpassword)
        {
            if (!Required(password))
            {
                return new ValidationResult("This is a required field", false);
            }
            else if(password != confirmpassword)
            {
                return new ValidationResult("Passwords do not match", false);
            }
            else
            {
                return new ValidationResult("", true);
            }
        }

        public ValidationResult UsernameCheck(string value)
        {
            if (!Required(value))
            {
                return new ValidationResult("This is a required field", false);
            }
            else
            {
                return new ValidationResult("", true);
            }
        }
    }
}

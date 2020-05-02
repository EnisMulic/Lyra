using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyra.WinUI.Validators
{
    public interface IUserValidator
    {
        ValidationResult FirstNameCheck(string value);
        ValidationResult LastNameCheck(string value);
        Task<ValidationResult> EmailCheck(string value);
        Task<ValidationResult> UsernameCheck(string value);
        ValidationResult PasswordCheck(string value);
        ValidationResult PasswordConfirmCheck(string password, string confirmpassword);
    }
}

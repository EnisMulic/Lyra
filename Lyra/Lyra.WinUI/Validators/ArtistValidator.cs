using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyra.WinUI.Validators
{
    public class ArtistValidator : BaseValidator, IArtistValidator
    {
        public ValidationResult NameCheck(string value)
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

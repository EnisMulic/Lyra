using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyra.WinUI.Validators
{
    public class AlbumValidator : BaseValidator, IAlbumValidator
    {
        public ValidationResult NameCheck(string value)
        {
            if(!Required(value))
            {
                return new ValidationResult("This is a required field", false);
            }
            else
            {
                return new ValidationResult("", true);
            }
        }

        public ValidationResult ReleaseYearCheck(string value)
        {
            if (!Required(value))
            {
                return new ValidationResult("This is a required field", false);
            }
            else if(!Number(value) || Convert.ToInt32(value) < 0)
            {
                return new ValidationResult("Wrong format", false);
            }
            else
            {
                return new ValidationResult("", true);
            }
        }
    }
}

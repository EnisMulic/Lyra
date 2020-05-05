using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyra.WinUI.Validators
{
    public class TrackValidator : BaseValidator, ITrackValidator
    {
        public ValidationResult LengthCheck(string value)
        {
            if (!Required(value))
            {
                return new ValidationResult("This is a required field", false);
            }
            else if(!Time(value))
            {
                return new ValidationResult("Wrong time format, correct format is (hh:mm:ss)", false);
            }
            else
            {
                return new ValidationResult("", true);
            }
        }

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

        public ValidationResult MainArtistCheck(int mainArtist, List<int> featureArtists)
        {
            if(featureArtists.Contains(mainArtist))
            {
                return new ValidationResult("Artist is already featured", false);
            }
            else
            {
                return new ValidationResult("", true);
            }
        }
    }
}

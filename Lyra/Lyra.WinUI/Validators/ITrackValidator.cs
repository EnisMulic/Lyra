using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyra.WinUI.Validators
{
    public interface ITrackValidator
    {
        ValidationResult NameCheck(string value);
        ValidationResult LengthCheck(string value);
    }
}

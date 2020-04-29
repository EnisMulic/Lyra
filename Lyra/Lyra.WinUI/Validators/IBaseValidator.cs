using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyra.WinUI.Validators
{
    public interface IBaseValidator
    {
        bool Required(string value);
        bool Email(string value);
        bool Time(string value);
        bool PhoneNumber(string value);
        bool MaxLength(string value, int max);
        bool MinLength(string value, int min);
        bool Range(string value, int min, int max);
        bool Number(string value);
    }
}

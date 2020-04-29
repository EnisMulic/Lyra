using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lyra.WinUI.Validators
{
    public class BaseValidator : IBaseValidator
    {
        public bool Email(string value)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            Match match = regex.Match(value);

            return match.Success;
        }

        public bool MaxLength(string value, int max)
        {
            return value.Length <= max;
        }

        public bool MinLength(string value, int min)
        {
            return value.Length >= min;
        }

        public bool Number(string value)
        {
            return int.TryParse(value, out _);
        }

        public bool PhoneNumber(string value)
        {
            throw new NotImplementedException();
        }

        public bool Range(string value, int min, int max)
        {
            return min <= value.Length && value.Length <= max;
        }

        public bool Required(string value)
        {
            return !string.IsNullOrEmpty(value);
        }

        public bool Time(string value)
        {
            Regex regex = new Regex(@"^([01]?[0-9]|2[0-3]):[0-5][0-9]$");
            Match match = regex.Match(value);

            return match.Success;
        }
    }
}

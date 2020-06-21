using Lyra.Mobile.Validators.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lyra.Mobile.Validators.Implementations
{
    public class EmptyOrFormatValidator : IValidator
    {
        public string Message { get; set; } = "Invalid format";
        public string Format { get; set; }

        public bool Check(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                Regex format = new Regex(Format);

                return format.IsMatch(value);
            }
            else
            {
                return true;
            }
        }
    }
}

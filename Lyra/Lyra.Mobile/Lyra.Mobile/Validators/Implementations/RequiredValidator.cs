using Lyra.Mobile.Validators.Contracts;

namespace Lyra.Mobile.Validators.Implementations
{
    public class RequiredValidator : IValidator
    {
        public string Message { get; set; } = "This field is required";

        public bool Check(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }
    }
}
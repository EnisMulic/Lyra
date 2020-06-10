using Lyra.Mobile.Services;
using Lyra.Mobile.Validators.Contracts;


namespace Lyra.Mobile.Validators.Implementations
{
    public class CurrentPasswordValidator : IValidator
    {
        public string Message { get; set; } = "Current password does not match";

        public bool Check(string value)
        {
            return value == APIService.Password;
        }
    }
}

using Xamarin.Forms;

namespace Lyra.Mobile.Validators.Contracts
{
    public interface IErrorStyle
    {
        void ShowError(View view, string message);
        void RemoveError(View view);
    }
}
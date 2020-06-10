using Lyra.Mobile.Helpers;
using Lyra.Model.Requests;
using Lyra.Mobile.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lyra.Mobile.ViewModels
{
    public class ChangePasswordViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("User");
        string currentPassword;
        public string CurrentPassword
        {
            get { return currentPassword; }
            set { SetProperty(ref currentPassword, value); }
        }

        string newPassword;
        public string NewPassword
        {
            get { return newPassword; }
            set { SetProperty(ref newPassword, value); }
        }

        string newPasswordConfirmation;
        public string NewPasswordConfirmation
        {
            get { return newPasswordConfirmation; }
            set { SetProperty(ref newPasswordConfirmation, value); }
        }

        public ICommand SavePasswordCommand { get; set; }

        public ChangePasswordViewModel()
        {
            SavePasswordCommand = new Command(async () => await SavePassword());
        }

        private async Task SavePassword()
        {
            if (NewPassword == NewPasswordConfirmation)
            {
                try
                {
                    var user = SignedInUserHelper.User;
                    var request = new UserUpdateRequest()
                    {
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Email = user.Email,
                        Username = user.Username,
                        PhoneNumber = user.Username,
                        Image = user.Image,
                        Password = NewPassword,
                        PasswordConfirmation = NewPasswordConfirmation
                    };

                    await _service.Update<Model.User>(SignedInUserHelper.User.ID, request);
                    APIService.Password = NewPassword;

                    await Application.Current.MainPage.DisplayAlert("Success", "You have successfully changed your password", "OK");
                }
                catch
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "An error occured", "OK");
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Confirmation password does not match", "OK");
            }
        }
    }
}

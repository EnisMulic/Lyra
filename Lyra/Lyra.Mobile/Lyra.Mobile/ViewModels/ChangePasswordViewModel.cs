using Lyra.Mobile.Helpers;
using Lyra.Model.Requests;
using Lyra.WinUI;
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
        string oldPassword = string.Empty;
        public string OldPassword
        {
            get { return oldPassword; }
            set { SetProperty(ref oldPassword, value); }
        }

        string newPassword = string.Empty;
        public string NewPassword
        {
            get { return newPassword; }
            set { SetProperty(ref newPassword, value); }
        }

        string newPasswordConfirmation = string.Empty;
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
            try
            {
                if (APIService.Password == OldPassword) //Temp Validation
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
            }
            catch
            {
                await Application.Current.MainPage.DisplayAlert("Error", "An error occured", "OK");
            }
        }
    }
}

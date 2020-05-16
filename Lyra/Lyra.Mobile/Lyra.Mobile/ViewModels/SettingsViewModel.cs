using Lyra.Mobile.Helpers;
using Lyra.Model.Requests;
using Lyra.WinUI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lyra.Mobile.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("User");
        byte[] userImage;
        public byte[] UserImage
        {
            get { return userImage; }
            set { SetProperty(ref userImage, value); }
        }
        string firstName = string.Empty;
        public string FirstName
        {
            get { return firstName; }
            set { SetProperty(ref firstName, value); }
        }

        string lastName = string.Empty;
        public string LastName
        {
            get { return lastName; }
            set { SetProperty(ref lastName, value); }
        }

        string username = string.Empty;
        public string Username
        {
            get { return username; }
            set { SetProperty(ref username, value); }
        }

        string email = string.Empty;
        public string Email
        {
            get { return email; }
            set { SetProperty(ref email, value); }
        }

        string phoneNumber = string.Empty;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { SetProperty(ref phoneNumber, value); }
        }

        public ICommand SaveCommand { get; set; }
        public ICommand ChangePasswordPageCommand { get; set; }
        public ICommand ChangeImage { get; set; }

        public SettingsViewModel()
        {
            userImage = SignedInUserHelper.User.Image;
            firstName = SignedInUserHelper.User.FirstName;
            lastName = SignedInUserHelper.User.LastName;
            username = SignedInUserHelper.User.Username;
            email = SignedInUserHelper.User.Email;
            phoneNumber = SignedInUserHelper.User.PhoneNumber;

            SaveCommand = new Command(async () => await SaveSettings());
            ChangePasswordPageCommand = new Command(() => ChangePasswordPageLoad());
            ChangeImage = new Command(async () => await OnTapped());
        }

        private async Task OnTapped()
        {
            UserImage = await UploadImageHelper.UploadImage(UserImage);
        }

        private void ChangePasswordPageLoad()
        {
            throw new NotImplementedException();
        }

        private async Task SaveSettings()
        {
            try
            {
                var request = new UserUpdateRequest()
                {
                    Image = UserImage,
                    FirstName = FirstName,
                    LastName = LastName,
                    Username = Username,
                    Email = Email,
                    PhoneNumber = PhoneNumber
                };

                SignedInUserHelper.User = await _service.Update<Model.User>(SignedInUserHelper.User.ID, request);

                await Application.Current.MainPage.DisplayAlert("Success", "You have successfully changed your information", "OK");
            }
            catch
            {
                await Application.Current.MainPage.DisplayAlert("Error", "An error occured", "OK");
            }
        }
    }
}

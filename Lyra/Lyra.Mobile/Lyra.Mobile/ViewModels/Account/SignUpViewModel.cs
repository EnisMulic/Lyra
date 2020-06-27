using Lyra.Mobile.Views;
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
    public class SignUpViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("User");
        string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { SetProperty(ref firstName, value); }
        }

        string lastName;
        public string LastName
        {
            get { return lastName; }
            set { SetProperty(ref lastName, value); }
        }

        string username;
        public string Username
        {
            get { return username; }
            set { SetProperty(ref username, value); }
        }

        string email;
        public string Email
        {
            get { return email; }
            set { SetProperty(ref email, value); }
        }

        string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { SetProperty(ref phoneNumber, value); }
        }

        string password;
        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }

        string passwordConfirmation;
        public string PasswordConfirmation
        {
            get { return passwordConfirmation; }
            set { SetProperty(ref passwordConfirmation, value); }
        }
        
        public ICommand SignUpCommand { get; set; }
        public ICommand SignInLoadCommand { get; set; }
        public SignUpViewModel()
        {
            SignUpCommand = new Command(async () => await SignUp());
            SignInLoadCommand = new Command(() => SignInLoad());
        }

        private async Task SignUp()
        {
            try
            {
                var request = new UserInsertRequest()
                {
                    FirstName = FirstName,
                    LastName = LastName,
                    Username = Username,
                    Email = Email,
                    PhoneNumber = PhoneNumber,
                    Password = Password,
                    PasswordConfirmation = PasswordConfirmation,
                    Roles = new List<int> {2}
                };

                await _service.SignUp(request);
                await Application.Current.MainPage.DisplayAlert("Success", "You have successfully signed up", "OK");
                Application.Current.MainPage = new SignInPage();
            }
            catch
            {
                await Application.Current.MainPage.DisplayAlert("Error", "An error has accured", "OK");
            }
        }

        void SignInLoad()
        {
            Application.Current.MainPage = new SignInPage();
        }
    }
}

using Lyra.Mobile.Helpers;
using Lyra.Mobile.Views;
using Lyra.Model.Requests;
using Lyra.Mobile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Lyra.Model;

namespace Lyra.Mobile.ViewModels
{
    public class SignInViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("User");
        private readonly APIService _covidService = new APIService("RSIICovidExam");
        string username;
        public string Username
        {
            get { return username; }
            set { SetProperty(ref username, value); }
        }

        string password;
        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }

        public ICommand SignInCommand { get; set; }
        public ICommand SignUpLoadCommand { get; set; }
        public SignInViewModel()
        {
            SignInCommand = new Command(async () => await SignIn());
            SignUpLoadCommand = new Command(() => SignUpLoad());
        }

        void SignUpLoad()
        {
            Application.Current.MainPage = new SignUpPage();
        }

        async Task SignIn()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;
            var request = new UserAuthenticationRequest()
            {
                Username = APIService.Username,
                Password = APIService.Password
            };

            var user = await _service.Authenticate(request);

            if (user != null)
            {
                var userRole = user.UserRoles.FirstOrDefault(i => i.Role.Name == "User");
                if (userRole != null)
                {
                    var randGen = new Random();
                    var covidRequest = new RSIICovidExamUpsertRequest()
                    {
                        UserID = user.ID,
                        DateTested = DateTime.Now,
                        TestPositive = randGen.Next() % 2 == 0
                    };

                    await _covidService.Insert<RSIICovidExam>(covidRequest);

                    Application.Current.MainPage = new MainPage();
                    SignedInUserHelper.User = user;
                    new FavouritesHelper();
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Wrong Username or Password", "OK");
            }
        }
    }

}
 

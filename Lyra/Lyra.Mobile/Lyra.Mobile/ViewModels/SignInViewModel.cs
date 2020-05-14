using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Mobile.ViewModels
{
    public class SignInViewModel : BaseViewModel
    {
        string username = string.Empty;
        public string Username
        {
            get { return username; }
            set { SetProperty(ref username, value); }
        }

        string password = string.Empty;
        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }
    }
}

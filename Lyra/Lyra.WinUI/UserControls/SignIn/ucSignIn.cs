using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lyra.Model.Requests;
using Lyra.WinUI.Administrator;
using Lyra.WinUI.Validators;

namespace Lyra.WinUI.SignIn
{
    public partial class ucSignIn : UserControl
    {
        private readonly APIService _service = new APIService("User");
        private static ucSignIn _instance;
        public static ucSignIn Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSignIn();
                return _instance;
            }
        }

        public ucSignIn()
        {
            InitializeComponent();
        }

        

        private async void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            var request = new UserSearchRequest()
            {
                Username = txtUsername.Text
            };

            var response = await _service.Get<List<Model.User>>(request);

            if(response.Count == 0)
            {
                errorProviderUsername.SetError(txtUsername, "Username does not exist");
                e.Cancel = true;
            }
            else
            {
                errorProviderUsername.SetError(txtUsername, "");
                e.Cancel = false;
            }
        }

        private async void btnSignIn_ClickAsync(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;
                var request = new UserAuthenticationRequest()
                {
                    Username = APIService.Username,
                    Password = APIService.Password
                };
                
                var user = await _service.Authenticate(request);

                if(user != null)
                {
                    LoadPanel(user);
                }
                else
                {
                    errorProviderPassword.SetError(txtPassword, "Wrong Password");
                }
            }
        }

        private void LoadPanel(Model.User user)
        {
            var adminRole = user.UserRoles.FirstOrDefault(i => i.Role.Name == "Administrator");
            if(adminRole != null)
            {
                var form = new frmAdminPanel(user);
                form.Show();

                ParentForm.Hide();

                return;
            }
        }
    }
}

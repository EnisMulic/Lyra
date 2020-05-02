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

namespace Lyra.WinUI.SingIn
{
    public partial class ucSignIn : UserControl
    {
        private readonly APIService _service = new APIService("User");
        private static ucSignIn _instance;
        private Point lastPoint;
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

        private void ucSignIn_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ucSignIn_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private async void btnSignIn_ClickAsync(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;

                //var users = await _service.Get<List<Model.User>>(null);
                //var user = users.Find(i => i.Username == APIService.Username);
                var user = await _service.Authenticate();

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

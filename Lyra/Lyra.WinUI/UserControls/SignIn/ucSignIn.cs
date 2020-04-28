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
using Lyra.WinUI.User;

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

        bool UsernameInDatabase(string username)
        {
            var search = new UserSearchRequest()
            {
                Username = username
            };

            var user = _service.Get<Model.User>(search);

            return user != null;
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorUsername.SetError(txtUsername, "Required field");
                e.Cancel = true;
            }
            else if (UsernameInDatabase(txtUsername.Text))
            {
                errorUsername.SetError(txtUsername, "Username does not exist");
                e.Cancel = true;
            }
            else
            {
                errorUsername.SetError(txtUsername, "");
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
            try
            {
                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;

                var users = await _service.Get<List<Model.User>>(null);
                var user = users.Find(i => i.Username == APIService.Username);


                LoadPanel(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Authenticatio", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

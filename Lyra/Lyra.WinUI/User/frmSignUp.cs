using Lyra.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyra.WinUI.User
{
    public partial class frmSignUp : Form
    {
        private readonly APIService _service = new APIService("User");
        private Point lastPoint;
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }

        private void frmSignUp_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frmSignUp_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.ParentForm.Left += e.X - lastPoint.X;
                this.ParentForm.Top += e.Y - lastPoint.Y;
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {
            Form SignIn = new frmSignIn();
            SignIn.MdiParent = this.ParentForm;
            this.Height = SignIn.Height;
            this.Width = SignIn.Width;
            SignIn.Dock = DockStyle.Fill;
            SignIn.Show();
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = "Admin";
                APIService.Password = "Password1";

                var request = new Model.Requests.UserUpsertRequest()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Username = txtUsername.Text,
                    PhoneNumber = txtPhone.Text,
                    Password = txtPassword.Text,
                    PasswordConfirmation = txtConfirmPassword.Text

                };
                await _service.Insert<Model.User>(request);

                ClearTextBoxes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }


        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        bool UsernameInDatabase(string username)
        {
            var search = new UserSearchRequest()
            {
                Username = username
            };

            var user = _service.Get<Model.User>(search);

            return user != null ? true : false;
        }

        bool EmailInDatabase(string email)
        {
            var search = new UserSearchRequest()
            {
                Email = email
            };

            var user = _service.Get<Model.User>(search);

            return user != null ? true : false;
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorFirstName.SetError(txtFirstName, "Required field");
                e.Cancel = true;
            }
            else
            {
                errorFirstName.SetError(txtUsername, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorLastName.SetError(txtLastName, "Required field");
                e.Cancel = true;
            }
            else
            {
                errorLastName.SetError(txtLastName, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorEmail.SetError(txtEmail, "Required field");
                e.Cancel = true;
            }
            else if (EmailInDatabase(txtEmail.Text))
            {
                errorEmail.SetError(txtEmail, "Email is taken");
                e.Cancel = true;
            }
            else
            {
                errorEmail.SetError(txtEmail, "");
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorPhone.SetError(txtPhone, "Required field");
                e.Cancel = true;
            }
            else
            {
                errorPhone.SetError(txtPhone, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorPassword.SetError(txtPassword, "Required field");
                e.Cancel = true;
            }
            else
            {
                errorPassword.SetError(txtPassword, "");
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                errorConfirmPassword.SetError(txtConfirmPassword, "Required field");
                e.Cancel = true;
            }
            else if(txtConfirmPassword != txtPassword)
            {
                errorConfirmPassword.SetError(txtConfirmPassword, "Passwords do not match");
                e.Cancel = true;
            }
            else
            {
                errorConfirmPassword.SetError(txtConfirmPassword, "");
            }
        }
    }
}

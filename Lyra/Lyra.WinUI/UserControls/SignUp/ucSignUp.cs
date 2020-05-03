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
using Lyra.WinUI.Validators;

namespace Lyra.WinUI.SignUp
{
    public partial class ucSignUp : UserControl
    {
        private readonly APIService _service = new APIService("User");
        private static ucSignUp _instance;
        private Point lastPoint;

        public static ucSignUp Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSignUp();
                return _instance;
            }
        }
        public ucSignUp()
        {
            InitializeComponent();
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                APIService.Username = "Admin";
                APIService.Password = "Password1";

                var request = new Model.Requests.UserInsertRequest()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Username = txtUsername.Text,
                    PhoneNumber = txtPhone.Text,
                    Password = txtPassword.Text,
                    PasswordConfirmation = txtPasswordConfirm.Text

                };
                await _service.Insert<Model.User>(request);

                ClearTextBoxes();
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

        private void FirstName_Validating(object sender, CancelEventArgs e)
        {
            var validator = new UserValidator();
            var result = validator.FirstNameCheck(txtFirstName.Text);
            errorProviderFirstName.SetError(txtFirstName, result.Message);
            e.Cancel = !result.IsValid;
        }

        private void LastName_Validating(object sender, CancelEventArgs e)
        {
            var validator = new UserValidator();
            var result = validator.FirstNameCheck(txtLastName.Text);
            errorProviderLastName.SetError(txtLastName, result.Message);
            e.Cancel = !result.IsValid;
        }

        private async void Username_Validating(object sender, CancelEventArgs e)
        {
            var validator = new UserValidator();
            var result = await validator.UsernameCheck(txtUsername.Text);
            errorProviderUsername.SetError(txtUsername, result.Message);
            e.Cancel = !result.IsValid;
        }

        private async void Email_Validating(object sender, CancelEventArgs e)
        {
            var validator = new UserValidator();
            var result = await validator.EmailCheck(txtEmail.Text);
            errorProviderEmail.SetError(txtEmail, result.Message);
            e.Cancel = !result.IsValid;
        }

        private void Password_Validating(object sender, CancelEventArgs e)
        {
            var validator = new UserValidator();
            var result = validator.PasswordCheck(txtPassword.Text);
            errorProviderPassword.SetError(txtPassword, result.Message);
            e.Cancel = !result.IsValid;
        }

        private void PasswordConfirm_Validating(object sender, CancelEventArgs e)
        {
            var validator = new UserValidator();
            var result = validator.PasswordConfirmCheck(txtPassword.Text, txtPasswordConfirm.Text);
            errorProviderPasswordConfirm.SetError(txtPasswordConfirm, result.Message);
            e.Cancel = !result.IsValid;
        }

        private void ucSignUp_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ucSignUp_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Parent.Left += e.X - lastPoint.X;
                Parent.Top += e.Y - lastPoint.Y;
            }
        }
    }
}

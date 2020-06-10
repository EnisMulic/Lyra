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
using Lyra.WinUI.Helpers;
using Lyra.WinUI.Properties;

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
                try
                {
                    APIService.Username = "Enis";
                    APIService.Password = "12341234";


                    var request = new UserInsertRequest
                    {
                        FirstName = Convert.ToString(txtFirstName.Text),
                        LastName = Convert.ToString(txtLastName.Text),
                        Email = Convert.ToString(txtEmail.Text),
                        Username = Convert.ToString(txtUsername.Text),
                        PhoneNumber = Convert.ToString(txtPhone.Text),
                        Password = Convert.ToString(txtPassword.Text),
                        PasswordConfirmation = Convert.ToString(txtPasswordConfirm.Text),
                        Image = ImageHelper.SystemDrawingToByteArray(Resources.profile_picture),
                        Roles = new List<int>{1}
                    };
                    await _service.SignUp(request);

                    PanelHelper.SwapPanels(this.Parent, this, new ucSignUp());
                }
                catch
                {
                    MessageBox.Show("Error");
                }
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

        private void Username_Validating(object sender, CancelEventArgs e)
        {
            var validator = new UserValidator();
            var result = validator.UsernameCheck(txtUsername.Text);
            errorProviderUsername.SetError(txtUsername, result.Message);
            e.Cancel = !result.IsValid;
        }

        private void Email_Validating(object sender, CancelEventArgs e)
        {
            var validator = new UserValidator();
            var result = validator.EmailCheck(txtEmail.Text);
            errorProviderEmail.SetError(txtEmail, result.Message);
            e.Cancel = !result.IsValid;
        }

        private void PhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            var validator = new UserValidator();
            var result = validator.PhoneCheck(txtPhone.Text);
            errorProviderPhoneNumber.SetError(txtPhone, result.Message);
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

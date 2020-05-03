using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lyra.WinUI.Helpers;
using Lyra.WinUI.Validators;
using Lyra.WinUI.Administrator;

namespace Lyra.WinUI.UserControls.Administrator.User
{
    public partial class ucUserAdd : UserControl
    {
        private readonly APIService _apiService = new APIService("User");
        private readonly APIService _roleApiService = new APIService("Role");
        public ucUserAdd()
        {
            InitializeComponent();
        }

        private async void ucUserAdd_Load(object sender, EventArgs e)
        {
            var roles = await _roleApiService.Get<List<Model.Role>>(null);
            clbRoles.DataSource = roles;
            clbRoles.ValueMember = "ID";
            clbRoles.DisplayMember = "Name";
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog
            {
                Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif"
            };
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbUserImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pbUserImage.Image = new Bitmap(opnfd.FileName);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                var roleList = clbRoles.CheckedItems.Cast<Model.Role>().Select(i => i.ID).ToList();

                var request = new Model.Requests.UserInsertRequest
                {
                    FirstName = Convert.ToString(txtFirstName.Text),
                    LastName = Convert.ToString(txtLastName.Text),
                    Username = Convert.ToString(txtUsername.Text),
                    Email = Convert.ToString(txtEmail.Text),
                    PhoneNumber = Convert.ToString(txtPhoneNumber.Text),
                    Password = Convert.ToString(txtPassword.Text),
                    PasswordConfirmation = Convert.ToString(txtPasswordConfirm.Text),
                    Image = ImageHelper.SystemDrawingToByteArray(pbUserImage.Image),
                    Roles = roleList
                };

                await _apiService.Insert<Model.User>(request);

                MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PanelHelper.SwapPanels(this.Parent, this, new ucUserAdd());
            }
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
    }
}

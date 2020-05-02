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

namespace Lyra.WinUI.UserControls.Administrator
{
    public partial class ucAdminInfoUpdate : UserControl
    {
        private readonly APIService _userApiService = new APIService("User");
        private readonly APIService _roleApiService = new APIService("Role");
        private readonly int _ID;
        public ucAdminInfoUpdate(int ID)
        {
            _ID = ID;
            InitializeComponent();
        }

        private async void ucAdminInfoUpdate_Load(object sender, EventArgs e)
        {
            var user = await _userApiService.GetById<Model.User>(_ID);

            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtUsername.Text = user.Username;
            txtEmail.Text = user.Email;
            txtPhoneNumber.Text = user.PhoneNumber;

            if (user.Image.Length != 0)
            {
                pbUserImage.Image = ImageHelper.ByteArrayToSystemDrawing(user.Image);
                pbUserImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            //List all roles
            var roles = await _roleApiService.Get<List<Model.Role>>(null);
            clbRoles.DataSource = roles;
            clbRoles.ValueMember = "ID";
            clbRoles.DisplayMember = "Name";

            //Check users roles
            var rolesList = clbRoles.Items.Cast<Model.Role>().Select(i => i.ID).ToList();
            foreach (var userRole in user.UserRoles)
            {
                for (int i = 0; i < clbRoles.Items.Count; i++)
                {
                    if (rolesList[i] == userRole.RoleID)
                    {
                        clbRoles.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            var uc = new ucAdminPasswordUpdate(_ID);
            if (!this.Controls.Contains(uc))
            {
                this.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }

            uc.BringToFront();
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
                var checkedRoles = clbRoles.CheckedItems.Cast<Model.Role>().Select(i => i.ID).ToList();

                List<int> uncheckedRoles = new List<int>();
                for (int i = 0; i < clbRoles.Items.Count; i++)
                {
                    if (!clbRoles.GetItemChecked(i))
                    {
                        int RoleID = clbRoles.Items.Cast<Model.Role>().ToList()[i].ID;
                        uncheckedRoles.Add(RoleID);
                    }
                }

                var request = new Model.Requests.UserUpdateRequest
                {
                    FirstName = Convert.ToString(txtFirstName.Text),
                    LastName = Convert.ToString(txtLastName.Text),
                    Username = Convert.ToString(txtUsername.Text),
                    Email = Convert.ToString(txtEmail.Text),
                    PhoneNumber = Convert.ToString(txtPhoneNumber.Text),
                    Image = ImageHelper.SystemDrawingToByteArray(pbUserImage.Image),
                    Roles = checkedRoles,
                    RolesToDelete = uncheckedRoles
                };

                await _userApiService.Update<Model.User>(_ID, request);

                MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}

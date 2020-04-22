using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyra.WinUI.UserControlls.Administrator.User
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
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxUserImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxUserImage.Image = new Bitmap(opnfd.FileName);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
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
                    PasswordConfirmation = Convert.ToString(txtConfirmPassword.Text),
                    Roles = roleList
                };

                await _apiService.Insert<Model.User>(request);

                MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

            }
        }
    }
}

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
        public ucUserAdd()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new Model.Requests.UserUpsertRequest
                {
                    FirstName = Convert.ToString(txtFirstName.Text),
                    LastName = Convert.ToString(txtLastName.Text),
                    Username = Convert.ToString(txtUsername.Text),
                    Email = Convert.ToString(txtEmail.Text),
                    PhoneNumber = Convert.ToString(txtPhoneNumber.Text),
                    Password = Convert.ToString(txtPassword.Text),
                    PasswordConfirmation = Convert.ToString(txtConfirmPassword.Text)
                };

                await _apiService.Insert<Model.User>(request);

                MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

            }
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
    }
}

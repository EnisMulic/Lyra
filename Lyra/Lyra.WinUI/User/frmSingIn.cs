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
    public partial class frmSingIn : Form
    {

        private readonly APIService _service = new APIService("User");
        public frmSingIn()
        {
            InitializeComponent();
        }

        bool UsernameInDatabase(string username)
        {
            var search = new UserSearchRequest()
            {
                FirstName = username
            };

            var user = _service.Get<Model.User>(search);

            return user != null ? true : false;
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorUsername.SetError(txtUsername, "Required field");
                e.Cancel = true;
            }
            else if(UsernameInDatabase(txtUsername.Text))
            {
                errorUsername.SetError(txtUsername, "Username does not exist");
                e.Cancel = true;
            }
            else
            {
                errorUsername.SetError(txtUsername, "");
            }
        }

        private void frmSingIn_Load(object sender, EventArgs e)
        {

        }

        private async void btnSingIn_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;

                await _service.Get<dynamic>(null);

                MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Authenticatio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}

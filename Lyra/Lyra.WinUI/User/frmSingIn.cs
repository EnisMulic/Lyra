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
        private Point lastPoint;
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

        private void lblSingUp_Click(object sender, EventArgs e)
        {
            Form SingUp = new frmSingUp();
            SingUp.MdiParent = this.ParentForm;
            this.Height = SingUp.Height;
            this.Width = SingUp.Width;
            SingUp.Dock = DockStyle.Fill;
            SingUp.Show();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void frmSingIn_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frmSingIn_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.ParentForm.Left += e.X - lastPoint.X;
                this.ParentForm.Top += e.Y - lastPoint.Y;
            }
        }
    }
}

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
                    PasswordConfirmation = txtPasswordConfirm.Text

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
    }
}

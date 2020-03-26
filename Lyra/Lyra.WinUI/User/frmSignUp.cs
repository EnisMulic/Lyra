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
    }
}

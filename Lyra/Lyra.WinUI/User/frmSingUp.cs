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
    public partial class frmSingUp : Form
    {
        private Point lastPoint;
        public frmSingUp()
        {
            InitializeComponent();
        }

        private void frmSingUp_Load(object sender, EventArgs e)
        {

        }

        private void frmSingUp_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frmSingUp_MouseMove(object sender, MouseEventArgs e)
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

        private void lblSingIn_Click(object sender, EventArgs e)
        {
            Form SingIn = new frmSingIn();
            SingIn.MdiParent = this.ParentForm;
            this.Height = SingIn.Height;
            this.Width = SingIn.Width;
            SingIn.Dock = DockStyle.Fill;
            SingIn.Show();
        }
    }
}

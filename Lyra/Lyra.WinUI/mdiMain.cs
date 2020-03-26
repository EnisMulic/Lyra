using Lyra.WinUI.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyra.WinUI
{
    public partial class mdiMain : Form
    {
        private int childFormNumber = 0;
        private Point lastPoint;
        public mdiMain()
        {
            InitializeComponent();
            Form SingIn = new frmSingIn();
            SingIn.MdiParent = this;
            this.Height = SingIn.Height;
            this.Width = SingIn.Width;
            SingIn.Dock = DockStyle.Fill;
            SingIn.Show();
            
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void mdiMain_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void mdiMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        
    }
}

using Lyra.WinUI.SingIn;
using Lyra.WinUI.SignUp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lyra.WinUI.UserControlls.Shared;

namespace Lyra.WinUI
{
    public partial class frmMain : Form
    {
        private Point lastPoint;
        public frmMain()
        {
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;
        }

        private void btnSignInUC_Click(object sender, EventArgs e)
        {
            
            if (!pnlMain.Controls.Contains(ucSignIn.Instance))
            {
                pnlMain.Controls.Add(ucSignIn.Instance);
                ucSignIn.Instance.Dock = DockStyle.Fill;
            }

            ucSignIn.Instance.BringToFront();
        }

        private void btnSingUpUC_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(ucSignUp.Instance))
            {
                pnlMain.Controls.Add(ucSignUp.Instance);
                ucSignUp.Instance.Dock = DockStyle.Fill;
            }

            ucSignUp.Instance.BringToFront();
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}

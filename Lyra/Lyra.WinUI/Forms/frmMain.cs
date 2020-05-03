using Lyra.WinUI.SignIn;
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
using Lyra.WinUI.UserControls.Shared;
using Lyra.WinUI.Helpers;

namespace Lyra.WinUI
{
    public partial class frmMain : Form
    {
        private Point lastPoint;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSignInUC_Click(object sender, EventArgs e)
        {

            PanelHelper.AddPanel(pnlMain, new ucSignIn());
        }

        private void btnSingUpUC_Click(object sender, EventArgs e)
        {

            PanelHelper.AddPanel(pnlMain, new ucSignUp());
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

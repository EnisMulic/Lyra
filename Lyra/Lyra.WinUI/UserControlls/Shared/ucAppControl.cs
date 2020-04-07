using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyra.WinUI.UserControlls.Shared
{
    public partial class ucAppControl : UserControl
    {
        private static ucAppControl _instance;
        public static ucAppControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucAppControl();
                return _instance;
            }
        }
        public ucAppControl()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if (ParentForm.WindowState == FormWindowState.Maximized)
            {
                ParentForm.WindowState = FormWindowState.Normal;
            }
            else if (ParentForm.WindowState == FormWindowState.Normal)
            {
                ParentForm.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            ParentForm.WindowState = FormWindowState.Minimized;
        }
    }
}

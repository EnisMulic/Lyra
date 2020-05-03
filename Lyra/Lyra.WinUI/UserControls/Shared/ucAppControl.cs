using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyra.WinUI.UserControls.Shared
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            ParentForm.WindowState = FormWindowState.Minimized;
        }
    }
}

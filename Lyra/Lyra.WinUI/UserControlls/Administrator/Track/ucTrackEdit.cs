using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyra.WinUI.UserControlls.Administrator.Track
{
    public partial class ucTrackEdit : UserControl
    {
        private readonly int _ID;
        public ucTrackEdit(int ID)
        {
            _ID = ID;
            InitializeComponent();
        }
    }
}

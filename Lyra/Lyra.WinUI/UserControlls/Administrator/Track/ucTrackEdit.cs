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
        public ucTrackEdit()
        {
            InitializeComponent();
        }

        public ucTrackEdit(Model.Track track)
        {
            InitializeComponent();

            txtID.Text = Convert.ToString(track.ID);
            txtName.Text = track.Name;
            txtLength.Text = track.Length;
        }
    }
}

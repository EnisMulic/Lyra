using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyra.WinUI.UserControlls.Administrator.Playlist
{
    public partial class ucPlaylistEdit : UserControl
    {
        public ucPlaylistEdit()
        {
            InitializeComponent();
        }

        public ucPlaylistEdit(String ID, string Name)
        {
            InitializeComponent();

            txtID.Text = ID;
            txtName.Text = Name;
        }
    }
}

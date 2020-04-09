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

        public ucPlaylistEdit(Model.Playlist playlist)
        {
            InitializeComponent();

            txtID.Text = Convert.ToString(playlist.ID);
            txtName.Text = playlist.Name;
        }
    }
}

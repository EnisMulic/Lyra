using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyra.WinUI.UserControlls.Administrator.Album
{
    public partial class ucAlbumEdit : UserControl
    {
        private readonly APIService _apiService = new APIService("Album");
        
        public ucAlbumEdit()
        {
            InitializeComponent();
        }

        public ucAlbumEdit(String ID, String Name, String ReleaseYear)
        {
            InitializeComponent();

            txtID.Text = ID;
            txtName.Text = Name;
            txtReleaseYear.Text = ReleaseYear;
        }
        
    }
}

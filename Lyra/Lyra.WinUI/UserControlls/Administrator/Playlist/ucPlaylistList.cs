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
    public partial class ucPlaylistList : UserControl
    {
        private readonly APIService _apiService = new APIService("Playlist");
        private static ucPlaylistList _instance;
        public static ucPlaylistList Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucPlaylistList();
                return _instance;
            }
        }
        public ucPlaylistList()
        {
            InitializeComponent();
            LoadList();
        }

        private async void LoadList()
        {
            var list = await _apiService.Get<List<Model.Playlist>>(null);
            dgvPlaylists.DataSource = list;
        }
    }
}

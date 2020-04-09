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

        private void btnEditPlaylist_Click(object sender, EventArgs e)
        {
            var playlist = new Model.Playlist()
            {
                ID = Convert.ToInt32(dgvPlaylists.CurrentRow.Cells["ID"].Value),
                Name = Convert.ToString(dgvPlaylists.CurrentRow.Cells["Name"].Value)
            };

            var uc = new ucPlaylistEdit(playlist);

            if (!Parent.Controls.Contains(uc))
            {
                Parent.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }

            uc.BringToFront();
        }
    }
}

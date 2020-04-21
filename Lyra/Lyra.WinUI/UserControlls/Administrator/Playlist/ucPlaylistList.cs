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
        
        public ucPlaylistList()
        {
            InitializeComponent();
        }

        private async void ucPlaylistList_Load(object sender, EventArgs e)
        {
            var list = await _apiService.Get<List<Model.Playlist>>(null);
            dgvPlaylists.DataSource = list;
        }

        private void btnEditPlaylist_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dgvPlaylists.CurrentRow.Cells["ID"].Value);

            var uc = new ucPlaylistUpsert(ID);

            if (!Parent.Controls.Contains(uc))
            {
                Parent.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }

            uc.BringToFront();
        }

        private async void btnDeletePlaylist_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvPlaylists.CurrentRow.Cells["ID"].Value);
            await _apiService.Delete<dynamic>(id);
        }

        private void btnAddPlaylist_Click(object sender, EventArgs e)
        {
            var uc = new ucPlaylistUpsert();

            if (!Parent.Controls.Contains(uc))
            {
                Parent.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }

            uc.BringToFront();
        }

        
    }
}

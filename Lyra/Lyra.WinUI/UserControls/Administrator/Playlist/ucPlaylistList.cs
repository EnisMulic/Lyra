using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lyra.WinUI.Helpers;

namespace Lyra.WinUI.UserControls.Administrator.Playlist
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
            var props = new List<string> { "ID", "Name", "CreatedAt" };
            DataGridViewHelper.PopulateWithList(dgvPlaylists, list, props);
        }

        private void btnEditPlaylist_Click(object sender, EventArgs e)
        {
            if(dgvPlaylists.CurrentRow != null)
            {
                int ID = Convert.ToInt32(dgvPlaylists.CurrentRow.Cells["ID"].Value);
                PanelHelper.SwapPanels(this.Parent, this, new ucPlaylistUpsert(ID));
            }
        }

        private async void btnDeletePlaylist_Click(object sender, EventArgs e)
        {
            if(dgvPlaylists.CurrentRow != null)
            {
                int ID = Convert.ToInt32(dgvPlaylists.CurrentRow.Cells["ID"].Value);
                await _apiService.Delete<dynamic>(ID);
                PanelHelper.SwapPanels(this.Parent, this, new ucPlaylistList());
            }
        }

        private void btnAddPlaylist_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new ucPlaylistUpsert());
        }

        
    }
}

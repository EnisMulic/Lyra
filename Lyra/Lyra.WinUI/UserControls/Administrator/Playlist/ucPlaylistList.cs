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
using Lyra.Model.Requests;

namespace Lyra.WinUI.UserControls.Administrator.Playlist
{
    public partial class ucPlaylistList : UserControl
    {
        private readonly APIService _apiService = new APIService("Playlist");
        private readonly List<string> _props = new List<string> { "ID", "Name", "CreatedAt" };
        private int _page { get; set; }
        private int _itemsPerPage { get; set; }

        public ucPlaylistList()
        {
            _page = 1;
            _itemsPerPage = 10;
            InitializeComponent();
        }

        private async void ucPlaylistList_Load(object sender, EventArgs e)
        {
            var request = new PlaylistSearchRequest()
            {
                Page = 1,
                ItemsPerPage = _itemsPerPage
            };
            await LoadList(request);
        }

        private async Task LoadList(PlaylistSearchRequest request)
        {
            var list = await _apiService.Get<List<Model.Playlist>>(request);

            if (list.Count > 0)
            {
                dgvPlaylists.ColumnCount = 0;
                DataGridViewHelper.PopulateWithList(dgvPlaylists, list, _props);

                _page = request.Page;
            }
            else if (!string.IsNullOrEmpty(Convert.ToString(txtSearch.Text)) && request.Page == 1)
            {
                dgvPlaylists.ColumnCount = 0;
                DataGridViewHelper.PopulateWithList(dgvPlaylists, list, _props);

                _page = 1;
            }

            btnPageNumber.Text = Convert.ToString(_page);
        }

        #region Buttons
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

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = Convert.ToString(txtSearch.Text);

            var request = new PlaylistSearchRequest()
            {
                Page = 1,
                ItemsPerPage = _itemsPerPage,
                Name = search
            };

            await LoadList(request);
        }


        #endregion

        #region Pagination

        private async void btnNext_Click(object sender, EventArgs e)
        {
            var search = Convert.ToString(txtSearch.Text);

            var request = new PlaylistSearchRequest()
            {
                Page = _page + 1,
                ItemsPerPage = _itemsPerPage,
                Name = search
            };

            await LoadList(request);
        }

        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_page > 1)
            {
                var search = Convert.ToString(txtSearch.Text);

                var request = new PlaylistSearchRequest()
                {
                    Page = _page - 1,
                    ItemsPerPage = _itemsPerPage,
                    Name = search
                };

                await LoadList(request);
            }
        }

        #endregion
    }
}

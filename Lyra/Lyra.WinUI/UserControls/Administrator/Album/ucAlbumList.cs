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

namespace Lyra.WinUI.UserControls.Administrator.Album
{
    public partial class ucAlbumList : UserControl
    {
        private readonly APIService _apiService = new APIService("Album");
        private readonly List<string> _props = new List<string> { "ID", "Name", "ReleaseYear" };
        private int _page { get; set; }
        private int _itemsPerPage { get; set; }

        public ucAlbumList()
        {
            _page = 1;
            _itemsPerPage = 10;
            InitializeComponent();
        }

        private async void ucAlbumList_Load(object sender, EventArgs e)
        {
            var request = new AlbumSearchRequest()
            {
                Page = 1,
                ItemsPerPage = _itemsPerPage
            };
            await LoadList(request);
        }

        private async Task LoadList(AlbumSearchRequest request)
        {
            var list = await _apiService.Get<List<Model.Track>>(request);

            if (list.Count > 0)
            {
                dgvAlbums.ColumnCount = 0;
                DataGridViewHelper.PopulateWithList(dgvAlbums, list, _props);

                _page = request.Page;
            }
            else if (!string.IsNullOrEmpty(Convert.ToString(txtSearch.Text)) && request.Page == 1)
            {
                dgvAlbums.ColumnCount = 0;
                DataGridViewHelper.PopulateWithList(dgvAlbums, list, _props);

                _page = 1;
            }
            
            btnPageNumber.Text = Convert.ToString(_page);
        }

        #region Buttons
        private async void btnDeleteAlbum_Click(object sender, EventArgs e)
        {
            if (dgvAlbums.CurrentRow != null)
            {
                int ID = Convert.ToInt32(dgvAlbums.CurrentRow.Cells["ID"].Value);
                await _apiService.Delete<dynamic>(ID);
                PanelHelper.SwapPanels(this.Parent, this, new ucAlbumList());
            }
        }

        private void btnEditAlbum_Click(object sender, EventArgs e)
        {
            if(dgvAlbums.CurrentRow != null)
            {
                int ID = Convert.ToInt32(dgvAlbums.CurrentRow.Cells["ID"].Value);
                PanelHelper.SwapPanels(this.Parent, this, new ucAlbumUpsert(ID));
            }
        }

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new ucAlbumUpsert());
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = Convert.ToString(txtSearch.Text);

            var request = new AlbumSearchRequest()
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
            var request = new AlbumSearchRequest()
            {
                Page = _page + 1,
                ItemsPerPage = _itemsPerPage,
                Name = Convert.ToString(txtSearch.Text)
            };

            await LoadList(request);
        }

        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_page > 1)
            {
                var request = new AlbumSearchRequest()
                {
                    Page = _page - 1,
                    ItemsPerPage = _itemsPerPage,
                    Name = Convert.ToString(txtSearch.Text)
                };

                await LoadList(request);
            }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lyra.Model.Requests;
using Lyra.WinUI.Helpers;

namespace Lyra.WinUI.UserControls.Administrator.Genre
{
    public partial class ucGenreList : UserControl
    {
        private readonly APIService _apiService = new APIService("Genre");
        private readonly List<string> _props = new List<string> { "ID", "Name" };
        private int _page { get; set; }
        private int _itemsPerPage { get; set; }
        public ucGenreList()
        {
            _page = 1;
            _itemsPerPage = 10;
            InitializeComponent();
        }

        private async void ucGenreList_Load(object sender, EventArgs e)
        {
            var request = new GenreSearchRequest()
            {
                Page = 1,
                ItemsPerPage = _itemsPerPage
            };
            await LoadList(request);
        }

        private async Task LoadList(GenreSearchRequest request)
        {
            var list = await _apiService.Get<List<Model.Genre>>(request);

            if (list.Count > 0)
            {
                dgvGenres.ColumnCount = 0;
                DataGridViewHelper.PopulateWithList(dgvGenres, list, _props);

                _page = request.Page;
            }
            else if (!string.IsNullOrEmpty(Convert.ToString(txtSearch.Text)) && request.Page == 1)
            {
                dgvGenres.ColumnCount = 0;
                DataGridViewHelper.PopulateWithList(dgvGenres, list, _props);

                _page = 1;
            }

            btnPageNumber.Text = Convert.ToString(_page);
        }

        

        #region Buttons
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = Convert.ToString(txtSearch.Text);

            var request = new GenreSearchRequest()
            {
                Page = 1,
                ItemsPerPage = _itemsPerPage,
                Name = search
            };

            await LoadList(request);
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new ucGenreUpsert());
        }

        private void btnEditGenre_Click(object sender, EventArgs e)
        {
            if (dgvGenres.CurrentRow != null)
            {
                int ID = Convert.ToInt32(dgvGenres.CurrentRow.Cells["ID"].Value);
                PanelHelper.SwapPanels(this.Parent, this, new ucGenreUpsert(ID));
            }
        }

        private async void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            if (dgvGenres.CurrentRow != null)
            {
                int ID = Convert.ToInt32(dgvGenres.CurrentRow.Cells["ID"].Value);
                await _apiService.Delete<dynamic>(ID);
                PanelHelper.SwapPanels(this.Parent, this, new ucGenreList());
            }
        }
        #endregion

        #region Pagination
        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_page > 1)
            {
                var search = Convert.ToString(txtSearch.Text);

                var request = new GenreSearchRequest()
                {
                    Page = _page - 1,
                    ItemsPerPage = _itemsPerPage,
                    Name = search
                };

                await LoadList(request);
            }
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            var search = Convert.ToString(txtSearch.Text);

            var request = new GenreSearchRequest()
            {
                Page = _page + 1,
                ItemsPerPage = _itemsPerPage,
                Name = search
            };

            await LoadList(request);
        }

        #endregion

        
    }
}

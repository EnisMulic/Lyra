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

namespace Lyra.WinUI.UserControls.Administrator.Track
{
    public partial class ucTrackList : UserControl
    {
        private readonly APIService _apiService = new APIService("Track");
        private readonly List<string> _props = new List<string> { "ID", "Name", "Length" };
        private int _page { get; set; }
        private int _itemsPerPage { get; set; }

        public ucTrackList()
        {
            _page = 1;
            _itemsPerPage = 10;
            InitializeComponent();
        }

        private async void ucTrackList_Load(object sender, EventArgs e)
        {
            var request = new TrackSearchRequest()
            {
                Page = 1,
                ItemsPerPage = _itemsPerPage
            };
            await LoadList(request);
        }

        private async Task LoadList(TrackSearchRequest request)
        {
            var list = await _apiService.Get<List<Model.Track>>(request);

            if(list.Count > 1)
            {
                dgvTracks.ColumnCount = 0;
                DataGridViewHelper.PopulateWithList(dgvTracks, list, _props);

                _page = request.Page;
            }
            else if (!string.IsNullOrEmpty(Convert.ToString(txtSearch.Text)) && request.Page == 1)
            {
                dgvTracks.ColumnCount = 0;
                DataGridViewHelper.PopulateWithList(dgvTracks, list, _props);

                _page = 1;
            }

            btnPageNumber.Text = Convert.ToString(_page);
        }

        #region Buttons

        private void btnEditTrack_Click(object sender, EventArgs e)
        {
            if(dgvTracks.CurrentRow != null)
            {
                int ID = Convert.ToInt32(dgvTracks.CurrentRow.Cells["ID"].Value);
                PanelHelper.SwapPanels(this.Parent, this, new ucTrackUpsert(ID));
            }
        }

        private async void btnDeleteTrack_Click(object sender, EventArgs e)
        {
            if (dgvTracks.CurrentRow != null)
            {
                int ID = Convert.ToInt32(dgvTracks.CurrentRow.Cells["ID"].Value);
                await _apiService.Delete<dynamic>(ID);
                PanelHelper.SwapPanels(this.Parent, this, new ucTrackList());
            }
        }

        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new ucTrackUpsert());
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = Convert.ToString(txtSearch.Text);

            var request = new TrackSearchRequest()
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

            var request = new TrackSearchRequest()
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

                var request = new TrackSearchRequest()
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

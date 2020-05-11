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
using Lyra.Model;

namespace Lyra.WinUI.UserControls.Administrator.User
{
    public partial class ucUserList : UserControl
    {
        private readonly APIService _apiService = new APIService("User");
        private readonly List<string> _props = new List<string> { "ID", "FirstName", "LastName", "Username", "Email", "PhoneNumber" };
        private int _page { get; set; }
        private int _itemsPerPage { get; set; }
        public ucUserList()
        {
            _page = 1;
            _itemsPerPage = 10;
            InitializeComponent();
        }

        private async void ucUserList_Load(object sender, EventArgs e)
        {
            var request = new UserSearchRequest()
            {
                Page = 1,
                ItemsPerPage = _itemsPerPage
            };
            await LoadList(request);
        }

        private async Task LoadList(UserSearchRequest request)
        {
            var list = await _apiService.Get<List<Model.User>>(request);
            
            if(list.Count > 1)
            {
                dgvUsers.ColumnCount = 0;
                DataGridViewHelper.PopulateWithList(dgvUsers, list, _props);

                _page = request.Page;
            }
            else if (!string.IsNullOrEmpty(Convert.ToString(txtSearch.Text)) && request.Page == 1)
            {
                dgvUsers.ColumnCount = 0;
                DataGridViewHelper.PopulateWithList(dgvUsers, list, _props);

                _page = 1;
            }

            btnPageNumber.Text = Convert.ToString(_page);
        }

        #region Buttons
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if(dgvUsers.CurrentRow != null)
            {
                int ID = Convert.ToInt32(dgvUsers.CurrentRow.Cells["ID"].Value);
                PanelHelper.SwapPanels(this.Parent, this, new ucUserEdit(ID));
            }
        }

        private async void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                int ID = Convert.ToInt32(dgvUsers.CurrentRow.Cells["ID"].Value);
                await _apiService.Delete<dynamic>(ID);
                PanelHelper.SwapPanels(this.Parent, this, new ucUserList());
            }
            
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new ucUserAdd());
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = Convert.ToString(txtSearch.Text);

            var request = new UserSearchRequest()
            {
                Page = 1,
                ItemsPerPage = _itemsPerPage,
                FirstName = search,
                LastName = search,
                Email = search,
                Username = search
            };

            await LoadList(request);
        }

        #endregion

        #region Pagination

        private async void btnNext_Click(object sender, EventArgs e)
        {
            var search = Convert.ToString(txtSearch.Text);

            var request = new UserSearchRequest()
            {
                Page = _page + 1,
                ItemsPerPage = _itemsPerPage,
                FirstName = search,
                LastName = search,
                Email = search,
                Username = search
            };

            await LoadList(request);
        }

        private async void btnPrevious_Click(object sender, EventArgs e)
        {
            if(_page > 1)
            {
                var search = Convert.ToString(txtSearch.Text);

                var request = new UserSearchRequest()
                {
                    Page = _page - 1,
                    ItemsPerPage = _itemsPerPage,
                    FirstName = search,
                    LastName = search,
                    Email = search,
                    Username = search
                };

                await LoadList(request);
            }
        }

        #endregion
    }
}

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

namespace Lyra.WinUI.UserControls.Administrator.User
{
    public partial class ucUserList : UserControl
    {
        private readonly APIService _apiService = new APIService("User");
        
        public ucUserList()
        {
            InitializeComponent();
        }

        private async void ucUserList_Load(object sender, EventArgs e)
        {
            var list = await _apiService.Get<List<Model.User>>(null);
            var proprs = new List<string> { "ID", "FirstName", "LastName", "Username", "Email", "PhoneNumber" };
            DataGridViewHelper.PopulateWithList(dgvUsers, list, proprs);
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dgvUsers.CurrentRow.Cells["ID"].Value);
            PanelHelper.SwapPanels(this.Parent, this, new ucUserEdit(ID));
        }

        private async void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUsers.CurrentRow.Cells["ID"].Value);
            await _apiService.Delete<dynamic>(id);
            PanelHelper.SwapPanels(this.Parent, this, new ucUserList());
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new ucUserAdd());
        }

        
    }
}

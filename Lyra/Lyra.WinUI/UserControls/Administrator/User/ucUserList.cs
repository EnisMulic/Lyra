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

namespace Lyra.WinUI.UserControlls.Administrator.User
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

            var uc = new ucUserEdit(ID);

            if (!Parent.Controls.Contains(uc))
            {
                Parent.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }

            uc.BringToFront();
        }

        private async void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUsers.CurrentRow.Cells["ID"].Value);
            await _apiService.Delete<dynamic>(id);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var uc = new ucUserAdd();

            if (!Parent.Controls.Contains(uc))
            {
                Parent.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }

            uc.BringToFront();
        }

        
    }
}

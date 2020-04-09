using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyra.WinUI.UserControlls.Administrator.User
{
    public partial class ucUserList : UserControl
    {
        private readonly APIService _apiService = new APIService("User");
        private static ucUserList _instance;
        public static ucUserList Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucUserList();
                return _instance;
            }
        }
        public ucUserList()
        {
            InitializeComponent();
            LoadList();
        }

        private async void LoadList()
        {
            var list = await _apiService.Get<List<Model.User>>(null);
            dgvUsers.DataSource = list;
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            var user = new Model.User()
            {
                ID = Convert.ToInt32(dgvUsers.CurrentRow.Cells["ID"].Value),
                FirstName = Convert.ToString(dgvUsers.CurrentRow.Cells["FirstName"].Value),
                LastName = Convert.ToString(dgvUsers.CurrentRow.Cells["LastName"].Value),
                Username = Convert.ToString(dgvUsers.CurrentRow.Cells["Username"].Value),
                Email = Convert.ToString(dgvUsers.CurrentRow.Cells["Email"].Value),
                PhoneNumber = Convert.ToString(dgvUsers.CurrentRow.Cells["PhoneNumber"].Value),
            };

            var uc = new ucUserEdit(user);

            if (!Parent.Controls.Contains(uc))
            {
                Parent.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }

            uc.BringToFront();
        }
    }
}

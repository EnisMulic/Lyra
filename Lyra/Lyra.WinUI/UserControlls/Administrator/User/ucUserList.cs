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
    }
}

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
    public partial class ucUserEdit : UserControl
    {
        private readonly APIService _apiService = new APIService("User");
        private readonly APIService _roleApiService = new APIService("Role");
        private readonly int _ID;
        public ucUserEdit()
        {
            InitializeComponent();
        }

        public ucUserEdit(int ID)
        {
            _ID = ID;
            InitializeComponent();
        }

        private async void ucUserEdit_Load(object sender, EventArgs e)
        {
            //Load user info
            var user = await _apiService.GetById<Model.User>(_ID);

            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtUsername.Text = user.Username;
            txtEmail.Text = user.Email;
            txtPhoneNumber.Text = user.PhoneNumber;

            //List all roles
            var roles = await _roleApiService.Get<List<Model.Role>>(null);
            clbRoles.DataSource = roles;
            clbRoles.ValueMember = "ID";
            clbRoles.DisplayMember = "Name";

            //Check users roles
            var rolesList = clbRoles.Items.Cast<Model.Role>().Select(i => i.ID).ToList();
            foreach(var userRole in user.UserRoles)
            {
                for (int i = 0; i < clbRoles.Items.Count; i++)
                {
                    if (rolesList[i] == userRole.RoleID)
                    {
                        clbRoles.SetItemChecked(i, true);
                    }
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}

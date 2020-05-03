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

namespace Lyra.WinUI.UserControls.Administrator
{
    public partial class ucAdminPasswordUpdate : UserControl
    {
        private readonly APIService _userApiService = new APIService("User");
        private readonly int _ID;
        public ucAdminPasswordUpdate(int ID)
        {
            _ID = ID;
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            var uc = new ucAdminInfoUpdate(_ID);
            if (!this.Controls.Contains(uc))
            {
                this.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }

            uc.BringToFront();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var user = await _userApiService.GetById<Model.User>(_ID);
                var request = new UserUpdateRequest
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Username = user.Username,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    Image = user.Image,
                    Password = txtNewPassword.Text,
                    PasswordConfirmation = txtNewPasswordConfirm.Text
                };

                await _userApiService.Update<Model.User>(_ID, request);
                
                MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PanelHelper.SwapPanels(this.Parent, this, new ucAdminPasswordUpdate(_ID));
            }
            catch
            {

            }
        }
    }
}

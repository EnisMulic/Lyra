using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyra.WinUI.UserControlls.Administrator.Artist
{
    public partial class ucArtistList : UserControl
    {
        private readonly APIService _apiService = new APIService("Artist");
        
        public ucArtistList()
        {
            InitializeComponent();
        }

        private async void ucArtistList_Load(object sender, EventArgs e)
        {
            var list = await _apiService.Get<List<Model.Artist>>(null);
            dgvArtists.DataSource = list;
        }

        private void btnEditArtist_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dgvArtists.CurrentRow.Cells["ID"].Value);

            var uc = new ucArtistUpsert(ID);

            if (!Parent.Controls.Contains(uc))
            {
                Parent.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }

            uc.BringToFront();
        }

        private async void btnDeleteArtist_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvArtists.CurrentRow.Cells["ID"].Value);
            await _apiService.Delete<dynamic>(id);
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            var uc = new ucArtistUpsert();

            if (!Parent.Controls.Contains(uc))
            {
                Parent.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }

            uc.BringToFront();
        }
    }
}

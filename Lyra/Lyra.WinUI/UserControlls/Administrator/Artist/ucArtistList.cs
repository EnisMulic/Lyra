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
        private static ucArtistList _instance;
        public static ucArtistList Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucArtistList();
                return _instance;
            }
        }
        public ucArtistList()
        {
            InitializeComponent();
            LoadList();
        }

        private async void LoadList()
        {
            var list = await _apiService.Get<List<Model.Artist>>(null);
            dgvArtists.DataSource = list;
        }

        private void btnEditArtist_Click(object sender, EventArgs e)
        {
            var ID = Convert.ToString(dgvArtists.CurrentRow.Cells["ID"].Value);
            var Name = Convert.ToString(dgvArtists.CurrentRow.Cells["Name"].Value);

            var uc = new ucArtistEdit(ID, Name);

            if (!Parent.Controls.Contains(uc))
            {
                Parent.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }

            uc.BringToFront();
        }
    }
}

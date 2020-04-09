using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyra.WinUI.UserControlls.Administrator.Album
{
    public partial class ucAlbumList : UserControl
    {
        private readonly APIService _apiService = new APIService("Album");
        private static ucAlbumList _instance;
        public static ucAlbumList Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucAlbumList();
                return _instance;
            }
        }
        public ucAlbumList()
        {
            InitializeComponent();
            LoadList();
        }

        private async void LoadList()
        {
            var list = await _apiService.Get<List<Model.Album>>(null);
            dgvAlbums.DataSource = list;
        }

        private void btnDeleteAlbum_Click(object sender, EventArgs e)
        {

        }

        private void btnEditAlbum_Click(object sender, EventArgs e)
        {
            var album = new Model.Album()
            {
                ID = Convert.ToInt32(dgvAlbums.CurrentRow.Cells["ID"].Value),
                Name = Convert.ToString(dgvAlbums.CurrentRow.Cells["Name"].Value),
                ReleaseYear = Convert.ToInt32(dgvAlbums.CurrentRow.Cells["ReleaseYear"].Value)
            };

            var uc = new ucAlbumEdit(album);

            if (!Parent.Controls.Contains(uc))
            {
                Parent.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }

            uc.BringToFront();
        }
    }
}

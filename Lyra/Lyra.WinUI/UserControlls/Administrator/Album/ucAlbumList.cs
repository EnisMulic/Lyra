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
    }
}

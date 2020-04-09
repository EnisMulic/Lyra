using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyra.WinUI.UserControlls.Administrator.Track
{
    public partial class ucTrackList : UserControl
    {
        private readonly APIService _apiService = new APIService("Track");
        private static ucTrackList _instance;
        public static ucTrackList Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucTrackList();
                return _instance;
            }
        }
        public ucTrackList()
        {
            InitializeComponent();
            LoadList();
        }

        private async void LoadList()
        {
            var list = await _apiService.Get<List<Model.Track>>(null);
            dgvTracks.DataSource = list;
        }

        private void btnEditTrack_Click(object sender, EventArgs e)
        {
            var track = new Model.Track()
            {
                ID = Convert.ToInt32(dgvTracks.CurrentRow.Cells["ID"].Value),
                Name = Convert.ToString(dgvTracks.CurrentRow.Cells["Name"].Value),
                Length = Convert.ToString(dgvTracks.CurrentRow.Cells["Length"].Value)
            };

            var uc = new ucTrackEdit(track);

            if (!Parent.Controls.Contains(uc))
            {
                Parent.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }

            uc.BringToFront();
        }
    }
}

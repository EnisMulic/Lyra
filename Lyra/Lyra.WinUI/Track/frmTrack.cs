using Lyra.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyra.WinUI.Track
{
    public partial class frmTrack : Form
    {
        APIService _apiService = new APIService("Track");
        public frmTrack()
        {
            InitializeComponent();
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            var search = new TrackSearchRequest()
            {
                Name = txtSearch.Text
            };

            var list = await _apiService.Get<List<Model.Track>>(search);

            
            dgvTracks.DataSource = list;
        }
    }
}

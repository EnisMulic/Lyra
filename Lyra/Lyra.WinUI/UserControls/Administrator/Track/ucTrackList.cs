using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lyra.WinUI.Helpers;

namespace Lyra.WinUI.UserControls.Administrator.Track
{
    public partial class ucTrackList : UserControl
    {
        private readonly APIService _apiService = new APIService("Track");
        
        public ucTrackList()
        {
            InitializeComponent();
        }

        private async void ucTrackList_Load(object sender, EventArgs e)
        {
            var list = await _apiService.Get<List<Model.Track>>(null);
            List<string> props = new List<string> { "ID", "Name", "Length" };
            DataGridViewHelper.PopulateWithList(dgvTracks, list, props);
        }

        private void btnEditTrack_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dgvTracks.CurrentRow.Cells["ID"].Value);
            PanelHelper.SwapPanels(this.Parent, this, new ucTrackUpsert(ID));
        }

        private async void btnDeleteTrack_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvTracks.CurrentRow.Cells["ID"].Value);
            await _apiService.Delete<dynamic>(id);
            PanelHelper.SwapPanels(this.Parent, this, new ucTrackList());
        }

        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new ucTrackUpsert());
        }

        
    }
}

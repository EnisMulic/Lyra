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

namespace Lyra.WinUI.UserControls.Administrator.Artist
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
            var props = new List<string> { "ID", "Name" };
            DataGridViewHelper.PopulateWithList(dgvArtists, list, props);
        }

        private void btnEditArtist_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dgvArtists.CurrentRow.Cells["ID"].Value);
            PanelHelper.SwapPanels(this.Parent, this, new ucArtistUpsert(ID));
        }

        private async void btnDeleteArtist_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvArtists.CurrentRow.Cells["ID"].Value);
            await _apiService.Delete<dynamic>(id);
            PanelHelper.SwapPanels(this.Parent, this, new ucArtistList());
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            PanelHelper.SwapPanels(this.Parent, this, new ucArtistUpsert());
        }
    }
}

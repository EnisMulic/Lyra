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
    public partial class ucTrackAdd : UserControl
    {
        private readonly APIService _trackApiService = new APIService("Track");
        private readonly APIService _artistApiService = new APIService("Artist");
        public ucTrackAdd()
        {
            InitializeComponent();
        }

        private void BindComboList<T>(ComboBox comboBox, IList<T> list)
        {
            comboBox.DataSource = list;
            comboBox.ValueMember = "ID";
            comboBox.DisplayMember = "Name";
        }

        private async void ucTrackAdd_Load(object sender, EventArgs e)
        {
            var artists = await _artistApiService.Get<List<Model.Artist>>(null);
            var featuredArtists = new List<Model.Artist>(artists);

            BindComboList(cbMainArtist, artists);
            BindComboList(cbFeaturedArtist, featuredArtists);

            lbFeaturedArtists.DataSource = null;
            lbFeaturedArtists.ValueMember = "ID";
            lbFeaturedArtists.DisplayMember = "Name";
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            var artist = cbFeaturedArtist.SelectedItem;

            if(!lbFeaturedArtists.Items.Contains(artist))
            {
                lbFeaturedArtists.Items.Add(artist);
            }
        }

        private void btnRemoveArtist_Click(object sender, EventArgs e)
        {
            var artist = lbFeaturedArtists.SelectedItem;
            lbFeaturedArtists.Items.Remove(artist);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            //Todo String -> TimeSpan convertion
            try
            {
                var request = new Model.Requests.TrackUpsertRequest
                {
                    Name = Convert.ToString(txtName.Text)
                };

                await _trackApiService.Insert<Model.Track>(request);

                MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

            }
        }
    }
}

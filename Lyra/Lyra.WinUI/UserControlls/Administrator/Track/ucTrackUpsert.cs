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

namespace Lyra.WinUI.UserControlls.Administrator.Track
{
    public partial class ucTrackUpsert : UserControl
    {
        private readonly APIService _trackApiService = new APIService("Track");
        private readonly APIService _artistApiService = new APIService("Artist");
        private readonly APIService _genreApiService = new APIService("Genre");
        private readonly int? _ID;
        public ucTrackUpsert(int? ID = null)
        {
            _ID = ID;
            InitializeComponent();
        }

        private void BindComboList<T>(ComboBox comboBox, List<T> list)
        {
            comboBox.DataSource = list;
            comboBox.ValueMember = "ID";
            comboBox.DisplayMember = "Name";
        }

        private void BindListBox<T>(ListBox listBox, IList<T> list)
        {
            listBox.DataSource = null;
            listBox.ValueMember = "ID";
            listBox.DisplayMember = "Name";

            if (list != null)
            {
                foreach (var item in list)
                {
                    listBox.Items.Add(item);
                }
            }
            
        }

        private async void ucTrackEdit_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            var artists = await _artistApiService.Get<List<Model.Artist>>(null);
            var featuredArtists = new List<Model.Artist>(artists);
            var genres = await _genreApiService.Get<List<Model.Genre>>(null);

            BindComboList(cbMainArtist, artists);
            BindComboList(cbFeaturedArtist, featuredArtists);
            BindComboList(cbGenre, genres);

            BindListBox<Model.Artist>(lbFeaturedArtists, null);
            BindListBox<Model.Genre>(lbGenres, null);

            if (_ID.HasValue)
            {
                var track = await _trackApiService.GetById<Model.Track>(_ID);

                txtName.Text = track.Name;
                txtLength.Text = track.Length;

                //Set Main Artist
                cbMainArtist.SelectedItem = track.Artists
                    .Where(i => i.TrackArtistRole == "Main")
                    .SingleOrDefault().ArtistID;

                //Get Track Featured Artists IDs
                var trackFeaturedArtistsIDs = track.Artists
                    .Where(i => i.TrackArtistRole == "Feature")
                    .Select(i => i.ArtistID)
                    .ToList();

                //Filter Artists by Track Featured Artists IDs
                var trackFeaturedArtists = artists
                    .Where(i => trackFeaturedArtistsIDs.Any(id => id.Equals(i.ID)))
                    .ToList();

                BindListBox(lbFeaturedArtists, trackFeaturedArtists);

                //Get Track Genres IDs
                var trackGenresIDs = track.Genres
                    .Select(i => i.GenreID)
                    .ToList();

                //Filter Genres by Track Genres IDs
                var trackGenres = genres
                    .Where(i => trackGenresIDs.Any(id => id.Equals(i.ID)))
                    .ToList();

                BindListBox(lbGenres, trackGenres);
            }
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            var artist = cbFeaturedArtist.SelectedItem;

            if (!lbFeaturedArtists.Items.Contains(artist))
            {
                lbFeaturedArtists.Items.Add(artist);
            }
        }

        private void btnRemoveArtist_Click(object sender, EventArgs e)
        {
            var artist = lbFeaturedArtists.SelectedItem;
            lbFeaturedArtists.Items.Remove(artist);
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            var genre = cbGenre.SelectedItem;

            if (!lbGenres.Items.Contains(genre))
            {
                lbGenres.Items.Add(genre);
            }
        }

        private void btnRemoveGenre_Click(object sender, EventArgs e)
        {
            var genre = lbGenres.SelectedItem;
            lbGenres.Items.Remove(genre);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new TrackUpsertRequest()
                {
                    Name = Convert.ToString(txtName.Text)
                    
                };
            }
            catch
            {

            }
        }
    }
}

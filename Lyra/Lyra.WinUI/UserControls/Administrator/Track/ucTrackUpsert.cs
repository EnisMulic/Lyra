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
using Lyra.Model;
using Lyra.WinUI.Validators;
using Lyra.WinUI.Helpers;
using System.IO;
using NAudio.Wave;

namespace Lyra.WinUI.UserControls.Administrator.Track
{
    public partial class ucTrackUpsert : UserControl
    {
        private readonly APIService _trackApiService = new APIService("Track");
        private readonly APIService _artistApiService = new APIService("Artist");
        private readonly APIService _genreApiService = new APIService("Genre");
        private static Model.Track _track = null;
        private readonly int? _ID;
        public ucTrackUpsert(int? ID = null)
        {
            _ID = ID;
            InitializeComponent();
            AutoScroll = true;
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
                _track = await _trackApiService.GetById<Model.Track>(_ID);

                txtName.Text = _track.Name;
                txtLength.Text = _track.Length;

                //Set Main Artist
                cbMainArtist.SelectedValue = _track.TrackArtists
                    .Where(i => i.TrackArtistRole == "Main")
                    .SingleOrDefault().ArtistID;

                //Get Track Featured Artists IDs
                var trackFeaturedArtistsIDs = _track.TrackArtists
                    .Where(i => i.TrackArtistRole == "Feature")
                    .Select(i => i.ArtistID)
                    .ToList();

                //Filter Artists by Track Featured Artists IDs
                var trackFeaturedArtists = artists
                    .Where(i => trackFeaturedArtistsIDs.Any(id => id.Equals(i.ID)))
                    .ToList();

                BindListBox(lbFeaturedArtists, trackFeaturedArtists);

                //Get Track Genres IDs
                var trackGenresIDs = _track.TrackGenres
                    .Select(i => i.GenreID)
                    .ToList();

                //Filter Genres by Track Genres IDs
                var trackGenres = genres
                    .Where(i => trackGenresIDs.Any(id => id.Equals(i.ID)))
                    .ToList();

                BindListBox(lbGenres, trackGenres);

                //Load Track
                if(_track.MP3File.Length != 0)
                {
                    Guid g = Guid.NewGuid();
                    string file = _track.Name + "-" + g.ToString() + ".mp3";
                    File.WriteAllBytes(file, _track.MP3File);
                    MediaPlayer.URL = file;
                    MediaPlayer.Ctlcontrols.stop();
                }
            }
        }

        private void btnUploadMp3File_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog
            {
                Filter = "All Supported Audio | *.mp3;"
            };
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                MediaPlayer.URL = opnfd.FileName;
                MediaPlayer.Ctlcontrols.stop();

                Mp3FileReader reader = new Mp3FileReader(opnfd.FileName);
                TimeSpan duration = reader.TotalTime;
                txtLength.Text = duration.ToString(@"hh\:mm\:ss");

                if (string.IsNullOrEmpty(txtName.Text))
                {
                    txtName.Text = opnfd.SafeFileName.Replace(".mp3", "");
                }
            }
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            var artist = cbFeaturedArtist.SelectedItem;

            if (!lbFeaturedArtists.Items.Contains(artist) && Convert.ToInt32(cbFeaturedArtist.SelectedValue) != Convert.ToInt32(cbMainArtist.SelectedValue))
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

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                MediaPlayer.Ctlcontrols.stop();

                var trackGenres = lbGenres.Items.Cast<Model.Genre>().Select(i => i.ID).ToList();

                var trackArtists = lbFeaturedArtists.Items.Cast<Model.Artist>().Select(i => i.ID).ToList();
                int mainArtist = Convert.ToInt32(cbMainArtist.SelectedValue);

                byte[] MP3File = File.ReadAllBytes(MediaPlayer.URL);

                var request = new TrackUpsertRequest()
                {
                    Name = Convert.ToString(txtName.Text),
                    Length = Convert.ToString(txtLength.Text),
                    Genres = trackGenres,
                    MainArtist = mainArtist,
                    FeaturedArtists = trackArtists,
                    MP3File = MP3File
                };


                if (_ID.HasValue)
                {
                    var genresToDelete = _track.TrackGenres
                        .Where(i => !trackGenres.Any(j => j.Equals(i.GenreID)))
                        .Select(i => i.GenreID)
                        .ToList();

                    var artistToDelete = _track.TrackArtists
                        .Where(i => !trackArtists.Any(j => j.Equals(i.ArtistID)))
                        .Select(i => i.ArtistID)
                        .ToList();

                    var oldMainArtist = _track.TrackArtists
                        .Where(i => i.TrackArtistRole == "Main")
                        .Select(i => i.ArtistID)
                        .SingleOrDefault();

                    if (oldMainArtist != mainArtist)
                        artistToDelete.Add(oldMainArtist);

                    request.GenresToDelete = genresToDelete;
                    request.ArtistsToDelete = artistToDelete;

                    await _trackApiService.Update<Model.Track>(_ID.Value, request);
                }
                else
                {
                    await _trackApiService.Insert<Model.Track>(request);
                    PanelHelper.SwapPanels(this.Parent, this, new ucTrackUpsert());
                }

                MessageBox.Show("Success", "Success", MessageBoxButtons.OK);
            }
        }

        private void Name_Validating(object sender, CancelEventArgs e)
        {
            var validator = new TrackValidator();
            var result = validator.NameCheck(txtName.Text);
            errorProviderName.SetError(txtName, result.Message);
            e.Cancel = !result.IsValid;
        }

        private void Length_Validating(object sender, CancelEventArgs e)
        {
            var validator = new TrackValidator();
            var result = validator.LengthCheck(txtLength.Text);
            errorProviderLength.SetError(txtLength, result.Message);
            e.Cancel = !result.IsValid;
        }

        private void cbMainArtist_Validating(object sender, CancelEventArgs e)
        {
            var trackArtists = lbFeaturedArtists.Items.Cast<Model.Artist>().Select(i => i.ID).ToList();
            var mainArtist = Convert.ToInt32(cbMainArtist.SelectedValue);

            var validator = new TrackValidator();
            var result = validator.MainArtistCheck(mainArtist, trackArtists);
            errorProviderMainArtist.SetError(cbMainArtist, result.Message);
            e.Cancel = !result.IsValid;
        }

        
    }
}

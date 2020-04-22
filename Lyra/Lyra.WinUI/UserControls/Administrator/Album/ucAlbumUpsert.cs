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
    public partial class ucAlbumUpsert : UserControl
    {
        private readonly APIService _albumApiService = new APIService("Album");
        private readonly APIService _trackApiService = new APIService("Track");
        private readonly APIService _artistApiService = new APIService("Artist");
        private readonly int? _ID;
        public ucAlbumUpsert(int? ID = null)
        {
            _ID = ID;
            InitializeComponent();
        }

        private async void ucAlbumUpsert_Load(object sender, EventArgs e)
        {
            AutoScroll = true;

            var artists = await _artistApiService.Get<List<Model.Artist>>(null);

            cbArtist.DataSource = artists;
            cbArtist.ValueMember = "ID";
            cbArtist.DisplayMember = "Name";

            var tracks = await _trackApiService.Get<List<Model.Track>>(null);
            dgvAllTracks.DataSource = tracks;

            if (_ID.HasValue)
            {
                var album = await _albumApiService.GetById<Model.Album>(_ID.Value);

                txtName.Text = album.Name;
                txtReleaseYear.Text = album.ReleaseYear.ToString();
                cbArtist.SelectedItem = artists.Where(i => i.ID == album.ArtistID).SingleOrDefault();

                var albumTracks = await _albumApiService.GetTracks<List<Model.Track>>(_ID.Value);
                dgvAlbumTracks.DataSource = albumTracks;
            }

            btnSave.Location = new Point(gbTracks.Location.X, gbTracks.Location.Y + gbTracks.Height + 20);

        }

        private void SetDataGridViewSize(DataGridView dgv)
        {
            var height = 40;
            foreach (DataGridViewRow dr in dgv.Rows)
            {
                height += dr.Height;
            }

            dgv.Height = height;
        }

        private void SetGroupBoxTracksHeight()
        {
            gbTracks.Height = (dgvAllTracks.Height > dgvAlbumTracks.Height ? dgvAllTracks.Height : dgvAlbumTracks.Height) + 100;
        }

        private void dgvAlbumTracks_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetDataGridViewSize(dgvAlbumTracks);
            SetGroupBoxTracksHeight();
        }

        private void dgvAllTracks_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetDataGridViewSize(dgvAllTracks);
            SetGroupBoxTracksHeight();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog
            {
                Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif"
            };
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbAlbumImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pbAlbumImage.Image = new Bitmap(opnfd.FileName);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new Model.Requests.AlbumUpsertRequest
                {
                    Name = Convert.ToString(txtName.Text),
                    ReleaseYear = Convert.ToInt32(txtReleaseYear.Text),
                    ArtistID = Convert.ToInt32(cbArtist.SelectedItem)
                };

                if(_ID.HasValue)
                {
                    await _albumApiService.Update<Model.Album>(_ID.Value, request);
                }
                else
                {
                    await _albumApiService.Insert<Model.Album>(request);
                }

                MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyra.WinUI.UserControlls.Administrator.Playlist
{
    public partial class ucPlaylistUpsert : UserControl
    {
        private readonly APIService _playlistApiService = new APIService("Playlist");
        private readonly APIService _trackApiService = new APIService("Track");
        private readonly int? _ID;
        public ucPlaylistUpsert(int? ID = null)
        {
            _ID = ID;
            InitializeComponent();
        }

        private async void ucPlaylistUpsert_Load(object sender, EventArgs e)
        {
            AutoScroll = true;


            var tracks = await _trackApiService.Get<List<Model.Track>>(null);
            dgvAllTracks.DataSource = tracks;

            if (_ID.HasValue)
            {
                var playlist = await _playlistApiService.GetById<Model.Playlist>(_ID.Value);

                txtName.Text = playlist.Name;
                txtCreatedAt.Text = playlist.CreatedAt;
                txtOwner.Text = playlist.User.Username;

                var playlistTracks = await _playlistApiService.GetTracks<List<Model.Track>>(_ID.Value);
                dgvPlaylistTracks.DataSource = playlistTracks;
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
            gbTracks.Height = (dgvAllTracks.Height > dgvPlaylistTracks.Height ? dgvAllTracks.Height : dgvPlaylistTracks.Height) + 100;
        }

        private void dgvPlaylistTracks_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetDataGridViewSize(dgvPlaylistTracks);
            SetGroupBoxTracksHeight();
        }

        private void dgvAllTracks_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetDataGridViewSize(dgvAllTracks);
            SetGroupBoxTracksHeight();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new Model.Requests.PlaylistUpsertRequest
                {
                    Name = Convert.ToString(txtName.Text)
                };

                if (_ID.HasValue)
                {
                    await _playlistApiService.Update<Model.Playlist>(_ID.Value, request);
                }
                else
                {
                    await _playlistApiService.Insert<Model.Playlist>(request);
                }

                MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog
            {
                Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif"
            };
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbPlaylistImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pbPlaylistImage.Image = new Bitmap(opnfd.FileName);
            }
        }

        
    }
}

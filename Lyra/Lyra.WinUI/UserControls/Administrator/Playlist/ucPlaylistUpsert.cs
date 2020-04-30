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
using Lyra.WinUI.Validators;

namespace Lyra.WinUI.UserControlls.Administrator.Playlist
{
    public partial class ucPlaylistUpsert : UserControl
    {
        private readonly APIService _playlistApiService = new APIService("Playlist");
        private readonly APIService _trackApiService = new APIService("Track");
        private static Model.Playlist _playlist = null;
        private readonly int? _ID;
        public ucPlaylistUpsert(int? ID = null)
        {
            _ID = ID;
            InitializeComponent();
        }

        private async void ucPlaylistUpsert_Load(object sender, EventArgs e)
        {
            AutoScroll = true;
            var props = new List<string> { "ID", "Name", "Length" };

            var tracks = await _trackApiService.Get<List<Model.Track>>(null);

            List<Model.Track> playlistTracks = null;
            if (_ID.HasValue)
            {
                _playlist = await _playlistApiService.GetById<Model.Playlist>(_ID.Value);

                txtName.Text = _playlist.Name;
                txtCreatedAt.Text = _playlist.CreatedAt;
                txtOwner.Text = _playlist.User.Username;

                if (_playlist.Image.Length != 0)
                {
                    pbPlaylistImage.Image = ImageHelper.ByteArrayToSystemDrawing(_playlist.Image);
                    pbPlaylistImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                playlistTracks = await _playlistApiService.GetTracks<List<Model.Track>>(_ID.Value);
                DataGridViewHelper.PopulateWithList(dgvPlaylistTracks, playlistTracks, props);

                tracks.RemoveAll(i => playlistTracks.Select(j => j.ID).Contains(i.ID));
            }
            else
            {
                DataGridViewHelper.PopulateWithList(dgvPlaylistTracks, new List<Model.Track>(), props);
            }
            DataGridViewHelper.PopulateWithList(dgvAllTracks, tracks, props);

            SetButtonSavePosition();
        }

        private void SetButtonSavePosition()
        {
            btnSave.Location = new Point(gbTracks.Location.X, gbTracks.Location.Y + gbTracks.Height + 20);
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

        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = dgvAllTracks.CurrentRow;
                dgvAllTracks.Rows.Remove(selectedRow);
                dgvPlaylistTracks.Rows.Add(selectedRow);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnRemoveTrack_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = dgvPlaylistTracks.CurrentRow;
                dgvPlaylistTracks.Rows.Remove(selectedRow);
                dgvAllTracks.Rows.Add(selectedRow);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
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

        private void dgvPlaylistTracks_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            SetDataGridViewSize(dgvPlaylistTracks);
            SetGroupBoxTracksHeight();
            SetButtonSavePosition();
        }

        private void dgvAllTracks_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            SetDataGridViewSize(dgvAllTracks);
            SetGroupBoxTracksHeight();
            SetButtonSavePosition();
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                var playlistTracks = new List<int>();
                foreach (DataGridViewRow Row in dgvPlaylistTracks.Rows)
                {
                    playlistTracks.Add(Convert.ToInt32(Row.Cells["ID"].Value));
                }


                var request = new Model.Requests.PlaylistUpsertRequest
                {
                    Name = Convert.ToString(txtName.Text),
                    Image = ImageHelper.SystemDrawingToByteArray(pbPlaylistImage.Image),
                    Tracks = playlistTracks
                };

                if (_ID.HasValue)
                {
                    var tracksToDelete = _playlist.PlaylistTracks
                        .Where(i => !playlistTracks.Any(j => j.Equals(i.TrackID)))
                        .Select(i => i.TrackID)
                        .ToList();

                    request.TracksToDelete = tracksToDelete;
                    request.UserID = _playlist.UserID;
                    request.CreatedAt = _playlist.CreatedAt;

                    await _playlistApiService.Update<Model.Playlist>(_ID.Value, request);
                }
                else
                {
                    request.CreatedAt = DateTime.Now.ToString();
                    request.UserID = 9; //TODO : Get LoggedIn User
                    await _playlistApiService.Insert<Model.Playlist>(request);
                }

                MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Name_Validating(object sender, CancelEventArgs e)
        {
            var validator = new PlaylistValidator();
            var result = validator.NameCheck(txtName.Text);
            errorProviderName.SetError(txtName, result.Message);
            e.Cancel = !result.IsValid;
        }
    }
}

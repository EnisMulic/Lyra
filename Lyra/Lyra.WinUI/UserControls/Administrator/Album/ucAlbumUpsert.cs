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

namespace Lyra.WinUI.UserControls.Administrator.Album
{
    public partial class ucAlbumUpsert : UserControl
    {
        private readonly APIService _albumApiService = new APIService("Album");
        private readonly APIService _trackApiService = new APIService("Track");
        private readonly APIService _artistApiService = new APIService("Artist");
        private readonly int? _ID;
        private static Model.Album _album = null;
        
        public ucAlbumUpsert(int? ID = null)
        {
            _ID = ID;
            InitializeComponent();
            AutoScroll = true;
        }

        private async void ucAlbumUpsert_Load(object sender, EventArgs e)
        {
            var props = new List<string> { "ID", "Name", "Length" };

            var artists = await _artistApiService.Get<List<Model.Artist>>(null);

            cbArtist.DataSource = artists;
            cbArtist.ValueMember = "ID";
            cbArtist.DisplayMember = "Name";

            var tracks = await _trackApiService.Get<List<Model.Track>>(null);

            List<Model.Track> albumTracks = null;
            if (_ID.HasValue)
            {
                _album = await _albumApiService.GetById<Model.Album>(_ID.Value);

                txtName.Text = _album.Name;
                txtReleaseYear.Text = _album.ReleaseYear.ToString();

                if (_album.Image.Length != 0)
                {
                    pbAlbumImage.Image = ImageHelper.ByteArrayToSystemDrawing(_album.Image);
                    pbAlbumImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                cbArtist.SelectedItem = artists.Where(i => i.ID == _album.ArtistID).SingleOrDefault();

                albumTracks = await _albumApiService.GetTracks<List<Model.Track>>(_ID.Value);
                DataGridViewHelper.PopulateWithList(dgvAlbumTracks, albumTracks, props);

                tracks.RemoveAll(i => albumTracks.Select(j => j.ID).Contains(i.ID));
            }
            else
            {
                DataGridViewHelper.PopulateWithList(dgvAlbumTracks, new List<Model.Track>(), props);
            }
            DataGridViewHelper.PopulateWithList(dgvAllTracks, tracks, props);

            SetButtonSavePosition();
        }

        private void SetButtonSavePosition()
        {
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

        private void dgvAlbumTracks_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            SetDataGridViewSize(dgvAlbumTracks);
            SetGroupBoxTracksHeight();
            SetButtonSavePosition();
        }

        private void dgvAllTracks_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            SetDataGridViewSize(dgvAllTracks);
            SetGroupBoxTracksHeight();
            SetButtonSavePosition();
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

        private void btnRemoveTrack_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = dgvAlbumTracks.CurrentRow;
                dgvAlbumTracks.Rows.Remove(selectedRow);
                dgvAllTracks.Rows.Add(selectedRow);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = dgvAllTracks.CurrentRow;
                dgvAllTracks.Rows.Remove(selectedRow);
                dgvAlbumTracks.Rows.Add(selectedRow);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var albumTracks = new List<int>();
                foreach (DataGridViewRow Row in dgvAlbumTracks.Rows)
                {
                    albumTracks.Add(Convert.ToInt32(Row.Cells["ID"].Value));
                }



                var request = new Model.Requests.AlbumUpsertRequest()
                {
                    Name = Convert.ToString(txtName.Text),
                    ReleaseYear = Convert.ToInt32(txtReleaseYear.Text),
                    ArtistID = Convert.ToInt32(cbArtist.SelectedValue),
                    Image = pbAlbumImage.Image != null ? ImageHelper.SystemDrawingToByteArray(pbAlbumImage.Image) : null,
                    Tracks = albumTracks
                };

                if (_ID.HasValue)
                {
                    var tracksToDelete = _album.AlbumTracks
                        .Where(i => !albumTracks.Any(id => id.Equals(i.TrackID)))
                        .Select(i => i.TrackID)
                        .ToList();

                    request.TracksToDelete = tracksToDelete;

                    await _albumApiService.Update<Model.Album>(_ID.Value, request);
                }
                else
                {
                    await _albumApiService.Insert<Model.Album>(request);

                    var parent = this.Parent;
                    
                    PanelHelper.SwapPanels(this.Parent, this, new ucAlbumUpsert());
                }

                MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void Name_Validating(object sender, CancelEventArgs e)
        {
            var validator = new AlbumValidator();
            var result = validator.NameCheck(txtName.Text);
            errorProviderName.SetError(txtName, result.Message);
            e.Cancel = !result.IsValid;
        }

        private void ReleaseYear_Validating(object sender, CancelEventArgs e)
        {
            var validator = new AlbumValidator();
            var result = validator.ReleaseYearCheck(txtReleaseYear.Text);
            errorProviderReleaseYear.SetError(txtReleaseYear, result.Message);
            e.Cancel = !result.IsValid;
        }
    }
}

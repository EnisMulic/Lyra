using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lyra.WinUI.UserControlls.Administrator.Album;
using Lyra.WinUI.UserControlls.Administrator.Track;
using Lyra.WinUI.Helpers;
using Lyra.WinUI.Validators;

namespace Lyra.WinUI.UserControlls.Administrator.Artist
{
    public partial class ucArtistUpsert : UserControl
    {
        private readonly APIService _apiService = new APIService("Artist");
        private readonly int? _ID;
        public ucArtistUpsert(int? ID = null)
        {
            _ID = ID;
            InitializeComponent();
        }

        private async void ucArtistUpsert_Load(object sender, EventArgs e)
        {
            AutoScroll = true;

            if (_ID.HasValue)
            {
                var artist = await _apiService.GetById<Model.Artist>(_ID.Value);
                txtName.Text = artist.Name;

                if (artist.Image.Length != 0)
                {
                    pbArtistImage.Image = ImageHelper.ByteArrayToSystemDrawing(artist.Image);
                    pbArtistImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                gbAlbums.Visible = true;
                gbTracks.Visible = true;

                var albums = await _apiService.GetAlbums<List<Model.Album>>(_ID.Value);
                var albumProps = new List<string> { "ID", "Name", "ReleaseYear" };
                DataGridViewHelper.PopulateWithList(dgvAlbums, albums, albumProps);


                var tracks = await _apiService.GetTracks<List<Model.Track>>(_ID.Value);
                var trackProps = new List<string> { "ID", "Name", "Length" };
                DataGridViewHelper.PopulateWithList(dgvTracks, tracks, trackProps);

                gbTracks.Location = new Point(gbAlbums.Location.X, gbAlbums.Location.Y + gbAlbums.Height);


                SetButtonSavePosition();
            }
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


        private void dgvAlbums_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            SetDataGridViewSize(dgvAlbums);
            gbAlbums.Height = dgvAlbums.Height + 50;
            SetButtonSavePosition();
        }

        private void dgvTracks_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            SetDataGridViewSize(dgvTracks);
            gbTracks.Height = dgvTracks.Height + 50;
            SetButtonSavePosition();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbArtistImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pbArtistImage.Image = new Bitmap(opnfd.FileName);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                var request = new Model.Requests.ArtistUpsertRequest
                {
                    Name = Convert.ToString(txtName.Text),
                    Image = ImageHelper.SystemDrawingToByteArray(pbArtistImage.Image)
                };

                if (_ID.HasValue)
                {
                    await _apiService.Update<Model.Artist>(_ID.Value, request);
                }
                else
                {
                    await _apiService.Insert<Model.Artist>(request);
                }

                MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Name_Validating(object sender, CancelEventArgs e)
        {
            var validator = new ArtistValidator();
            var result = validator.NameCheck(txtName.Text);
            errorProviderName.SetError(txtName, result.Message);
            e.Cancel = !result.IsValid;
        }
    }
}

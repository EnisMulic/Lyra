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

                gbAlbums.Visible = true;
                gbTracks.Visible = true;

                var albums = await _apiService.GetAlbums<List<Model.Album>>(_ID.Value);
                dgvAlbums.DataSource = albums;


                var tracks = await _apiService.GetTracks<List<Model.Track>>(_ID.Value);
                dgvTracks.DataSource = tracks;
                gbTracks.Location = new Point(gbAlbums.Location.X, gbAlbums.Location.Y + gbAlbums.Height);


                btnSave.Location = new Point(gbTracks.Location.X, gbTracks.Location.Y + gbTracks.Height);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new Model.Requests.ArtistUpsertRequest
                {
                    Name = Convert.ToString(txtName.Text)
                };

                if(_ID.HasValue)
                {
                    await _apiService.Update<Model.Artist>(_ID.Value, request);
                }
                else
                {
                    await _apiService.Insert<Model.Artist>(request);
                }

                MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

            }
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

        

        private void SetDataGridViewSize(DataGridView dgv)
        {
            var height = 40;
            foreach (DataGridViewRow dr in dgv.Rows)
            {
                height += dr.Height;
            }

            dgv.Height = height;
        }


        private void dgvAlbums_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetDataGridViewSize(dgvAlbums);
            gbAlbums.Height += dgvAlbums.Height - 25;
        }

        private void dgvTracks_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetDataGridViewSize(dgvTracks);
            gbTracks.Height += dgvTracks.Height - 25;
        }
    }
}

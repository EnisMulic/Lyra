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
    public partial class ucPlaylistAdd : UserControl
    {
        private readonly APIService _apiService = new APIService("Playlist");
        public ucPlaylistAdd()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new Model.Requests.PlaylistUpsertRequest
                {
                    Name = Convert.ToString(txtName.Text)
                };

                await _apiService.Insert<Model.Playlist>(request);

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
                pbPlaylistImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pbPlaylistImage.Image = new Bitmap(opnfd.FileName);
            }
        }
    }
}

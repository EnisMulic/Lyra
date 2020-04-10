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
    public partial class ucAlbumAdd : UserControl
    {
        private readonly APIService _apiService = new APIService("Album");
        public ucAlbumAdd()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new Model.Requests.AlbumUpsertRequest
                {
                    Name = Convert.ToString(txtName.Text),
                    ReleaseYear = Convert.ToInt32(txtReleaseYear.Text)
                };

                await _apiService.Insert<Model.Album>(request);

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
                pbAlbumImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pbAlbumImage.Image = new Bitmap(opnfd.FileName);
            }
        }
    }
}

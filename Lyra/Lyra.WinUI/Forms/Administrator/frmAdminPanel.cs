using Lyra.WinUI.Helpers;
using Lyra.WinUI.UserControlls.Administrator.Album;
using Lyra.WinUI.UserControlls.Administrator.Artist;
using Lyra.WinUI.UserControlls.Administrator.Playlist;
using Lyra.WinUI.UserControlls.Administrator.Track;
using Lyra.WinUI.UserControlls.Administrator.User;
using Lyra.WinUI.UserControlls.Shared;
using Lyra.WinUI.UserControls.Administrator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyra.WinUI.Administrator
{
    public partial class frmAdminPanel : Form
    {
        private static Model.User _user;
        public frmAdminPanel(Model.User user)
        {
            _user = user;
            InitializeComponent();   
        }

        private void frmAdminPanel_Load(object sender, EventArgs e)
        {
            if(_user.Image.Length != 0)
            {
                pbUserImage.Image = ImageHelper.ByteArrayToSystemDrawing(_user.Image);
                pbUserImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            lblUsername.Text = _user.Username;

            btnUser_Click(sender, e);
        }

        private void LoadUserControl(UserControl uc)
        {
            Refresh();
            if (!pnlMain.Controls.Contains(uc))
            {
                pnlMain.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }

            uc.BringToFront();
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            var uc = new ucUserList();
            LoadUserControl(uc);
        }

        private void btnArtist_Click(object sender, EventArgs e)
        {
            var uc = new ucArtistList();
            LoadUserControl(uc);
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            var uc = new ucAlbumList();
            LoadUserControl(uc);
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            var uc = new ucTrackList();
            LoadUserControl(uc);
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            var uc = new ucPlaylistList();
            LoadUserControl(uc);
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            var uc = new ucAdminInfoUpdate(_user.ID);
            LoadUserControl(uc);
        }
    }
}

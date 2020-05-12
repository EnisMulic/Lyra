using Lyra.WinUI.Helpers;
using Lyra.WinUI.UserControls.Administrator.Album;
using Lyra.WinUI.UserControls.Administrator.Artist;
using Lyra.WinUI.UserControls.Administrator.Playlist;
using Lyra.WinUI.UserControls.Administrator.Track;
using Lyra.WinUI.UserControls.Administrator.User;
using Lyra.WinUI.UserControls.Shared;
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
using Lyra.WinUI.UserControls.Administrator.Genre;

namespace Lyra.WinUI.Administrator
{
    public partial class frmAdminPanel : Form
    {
        private static Model.User _user;
        private Point lastPoint;
        public frmAdminPanel(Model.User user)
        {
            _user = user;
            SignedInUserHelper.User = _user;
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;
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

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            var form = new frmMain();
            form.Show();

            Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            PanelHelper.RemovePanels(pnlMain);
            PanelHelper.AddPanel(pnlMain, new ucUserList());
        }

        private void btnArtist_Click(object sender, EventArgs e)
        {
            PanelHelper.RemovePanels(pnlMain);
            PanelHelper.AddPanel(pnlMain, new ucArtistList());
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            PanelHelper.RemovePanels(pnlMain);
            PanelHelper.AddPanel(pnlMain, new ucAlbumList());
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            PanelHelper.RemovePanels(pnlMain);
            PanelHelper.AddPanel(pnlMain, new ucTrackList());
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            PanelHelper.RemovePanels(pnlMain);
            PanelHelper.AddPanel(pnlMain, new ucPlaylistList());
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            PanelHelper.RemovePanels(pnlMain);
            PanelHelper.AddPanel(pnlMain, new ucGenreList());
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            PanelHelper.RemovePanels(pnlMain);
            PanelHelper.AddPanel(pnlMain, new ucAdminInfoUpdate(_user.ID));
        }

        //Movable Form
        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}

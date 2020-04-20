using Lyra.WinUI.UserControlls.Administrator.Album;
using Lyra.WinUI.UserControlls.Administrator.Artist;
using Lyra.WinUI.UserControlls.Administrator.Playlist;
using Lyra.WinUI.UserControlls.Administrator.Track;
using Lyra.WinUI.UserControlls.Administrator.User;
using Lyra.WinUI.UserControlls.Shared;
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
        public frmAdminPanel()
        {
            InitializeComponent();   
        }

        private void btnUser_Click(object sender, EventArgs e)
        {

            Refresh();
            var uc = new ucUserList();
            if (!pnlMain.Controls.Contains(uc))
            {
                pnlMain.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }

            uc.BringToFront();
        }

        private void btnArtist_Click(object sender, EventArgs e)
        {
            Refresh();
            var uc = new ucArtistList();
            if (!pnlMain.Controls.Contains(uc))
            {
                pnlMain.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }

            uc.BringToFront();
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            Refresh();
            var uc = new ucAlbumList();
            if (!pnlMain.Controls.Contains(uc))
            {
                pnlMain.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }

            uc.BringToFront();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            Refresh();
            var uc = new ucTrackList();
            if (!pnlMain.Controls.Contains(uc))
            {
                pnlMain.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }

            uc.BringToFront();
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            Refresh();
            var uc = new ucPlaylistList();
            if (!pnlMain.Controls.Contains(uc))
            {
                pnlMain.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
            }

            uc.BringToFront();
        }
    }
}

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

        private void btnUserCRUD_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(ucUserList.Instance))
            {
                pnlMain.Controls.Add(ucUserList.Instance);
                ucUserList.Instance.Dock = DockStyle.Fill;
            }

            ucUserList.Instance.BringToFront();
        }

        private void btnArtist_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(ucArtistList.Instance))
            {
                pnlMain.Controls.Add(ucArtistList.Instance);
                ucArtistList.Instance.Dock = DockStyle.Fill;
            }

            ucArtistList.Instance.BringToFront();
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(ucAlbumList.Instance))
            {
                pnlMain.Controls.Add(ucAlbumList.Instance);
                ucAlbumList.Instance.Dock = DockStyle.Fill;
            }

            ucAlbumList.Instance.BringToFront();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(ucTrackList.Instance))
            {
                pnlMain.Controls.Add(ucTrackList.Instance);
                ucTrackList.Instance.Dock = DockStyle.Fill;
            }

            ucTrackList.Instance.BringToFront();
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(ucPlaylistList.Instance))
            {
                pnlMain.Controls.Add(ucPlaylistList.Instance);
                ucPlaylistList.Instance.Dock = DockStyle.Fill;
            }

            ucPlaylistList.Instance.BringToFront();
        }
    }
}

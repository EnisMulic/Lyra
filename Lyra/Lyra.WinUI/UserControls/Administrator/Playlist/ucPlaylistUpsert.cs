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
using Lyra.Model.Requests;
using Lyra.WinUI.Administrator;

namespace Lyra.WinUI.UserControls.Administrator.Playlist
{
    public partial class ucPlaylistUpsert : UserControl
    {
        private static Model.Playlist _playlist = null;
        private readonly int? _ID;
        private readonly APIService _playlistApiService = new APIService("Playlist");
        private readonly APIService _trackApiService = new APIService("Track");
        private readonly List<string> props = new List<string> { "ID", "Name", "Length" };
        private List<Model.Track> _playlistTracks = new List<Model.Track>();
        private int _playlistTracksPage;
        private int _allTracksPage;
        private int _itemsPerPage;
        public ucPlaylistUpsert(int? ID = null)
        {
            _ID = ID;
            _playlistTracksPage = 1;
            _allTracksPage = 1;
            _itemsPerPage = 10;
            InitializeComponent();
            AutoScroll = true;
        }

        #region Setup
        private async void ucPlaylistUpsert_Load(object sender, EventArgs e)
        {
            BuildAllTracksList();
            BuildPlaylistTracksList();

            var tracksRequest = new TrackSearchRequest()
            {
                Page = _allTracksPage,
                ItemsPerPage = _itemsPerPage
            };
            await LoadListAllTracks(tracksRequest);

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

                _playlistTracks = await _playlistApiService.GetTracks<List<Model.Track>>(_ID.Value, null);

                var request = new TrackSearchRequest()
                {
                    Page = _playlistTracksPage,
                    ItemsPerPage = _itemsPerPage
                };

                LoadListPlaylistTracks(request);
            }
            else
            {
                DataGridViewHelper.PopulateWithList(dgvPlaylistTracks, _playlistTracks, props);
            }
            

            SetButtonSavePosition();
        }

        private void SetButtonSavePosition()
        {
            btnSave.Location = new Point(gbTracks.Location.X, gbTracks.Location.Y + gbTracks.Height + 20);
        }


        private void SetDataGridViewSize(DataGridView dgv)
        {
            var rowHeight = 27;
            dgv.Height = rowHeight * _itemsPerPage;
        }

        private void SetGroupBoxTracksHeight()
        {
            gbTracks.Height = (dgvAllTracks.Height > dgvPlaylistTracks.Height ? dgvAllTracks.Height : dgvPlaylistTracks.Height) + 150;
        }

        private void BuildPlaylistTracksList()
        {
            SetDataGridViewSize(dgvPlaylistTracks);
            SetGroupBoxTracksHeight();
            SetButtonSavePosition();
            pnlPlaylistTracksPageButtons.Location = new Point(pnlPlaylistTracksPageButtons.Location.X, dgvPlaylistTracks.Height + 90);
        }

        private void BuildAllTracksList()
        {
            SetDataGridViewSize(dgvAllTracks);
            SetGroupBoxTracksHeight();
            SetButtonSavePosition();
            pnlAllTracksPageButtons.Location = new Point(pnlAllTracksPageButtons.Location.X, dgvAllTracks.Height + 90);
        }

        #endregion


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
                if (!_playlistTracks.Select(i => i.ID).ToList().Contains(Convert.ToInt32(selectedRow.Cells["ID"].Value)))
                {
                    var track = new Model.Track()
                    {
                        ID = Convert.ToInt32(selectedRow.Cells["ID"].Value),
                        Name = Convert.ToString(selectedRow.Cells["Name"].Value),
                        Length = Convert.ToString(selectedRow.Cells["Length"].Value)
                    };
                    _playlistTracks.Add(track);

                    var request = new TrackSearchRequest()
                    {
                        Page = _playlistTracksPage,
                        ItemsPerPage = _itemsPerPage
                    };
                    LoadListPlaylistTracks(request);
                }

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

                var track = _playlistTracks.Single(i => i.ID == Convert.ToInt32(selectedRow.Cells["ID"].Value));
                _playlistTracks.Remove(track);

                var request = new TrackSearchRequest()
                {
                    Page = _playlistTracksPage,
                    ItemsPerPage = _itemsPerPage
                };
                LoadListPlaylistTracks(request);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        

        private void LoadListPlaylistTracks(TrackSearchRequest request)
        {
            var list = _playlistTracks;
            if (!string.IsNullOrEmpty(request.Name))
            {
                list = list.Where(i => i.Name.StartsWith(request.Name)).ToList();
            }

            list = list.Skip((request.Page - 1) * request.ItemsPerPage).ToList();
            if (request.ItemsPerPage > 0)
            {
                list = list.Take(request.ItemsPerPage).ToList();
            }


            if (list.Count > 0)
            {
                dgvPlaylistTracks.ColumnCount = 0;
                DataGridViewHelper.PopulateWithList(dgvPlaylistTracks, list, props);

                _playlistTracksPage = request.Page;
                
            }
            else if (!string.IsNullOrEmpty(Convert.ToString(txtSearchPlaylistTracks.Text)) && request.Page == 1)
            {
                dgvPlaylistTracks.ColumnCount = 0;
                DataGridViewHelper.PopulateWithList(dgvPlaylistTracks, list, props);

                _playlistTracksPage = 1;
            }

            btnPageNumberPlaylistTracks.Text = Convert.ToString(_playlistTracksPage);
        }


        private async Task LoadListAllTracks(TrackSearchRequest request)
        {
            var list = await _trackApiService.Get<List<Model.Track>>(request);

            if (list.Count > 0)
            {
                dgvAllTracks.ColumnCount = 0;
                DataGridViewHelper.PopulateWithList(dgvAllTracks, list, props);

                _allTracksPage = request.Page;
                btnPageNumberAllTracks.Text = Convert.ToString(_allTracksPage);
            }
            else if (!string.IsNullOrEmpty(Convert.ToString(txtSearchAllTracks.Text)) && request.Page == 1)
            {
                dgvAllTracks.ColumnCount = 0;
                DataGridViewHelper.PopulateWithList(dgvAllTracks, list, props);

                _allTracksPage = 1;
            }

            btnPageNumberAllTracks.Text = Convert.ToString(_allTracksPage);

        }

        #region Validation
        private void Name_Validating(object sender, CancelEventArgs e)
        {
            var validator = new PlaylistValidator();
            var result = validator.NameCheck(txtName.Text);
            errorProviderName.SetError(txtName, result.Message);
            e.Cancel = !result.IsValid;
        }
        #endregion

        #region Pagination
        private void btnPreviousPlaylistTracks_Click(object sender, EventArgs e)
        {
            if (_playlistTracksPage > 1)
            {
                var request = new TrackSearchRequest()
                {
                    Page = _playlistTracksPage - 1,
                    ItemsPerPage = _itemsPerPage
                };

                LoadListPlaylistTracks(request);
            }
        }

        private void btnNextPlaylistTracks_Click(object sender, EventArgs e)
        {
            var request = new TrackSearchRequest()
            {
                Page = _playlistTracksPage + 1,
                ItemsPerPage = _itemsPerPage
            };

            LoadListPlaylistTracks(request);
        }

        private async void btnPreviousAllTracks_Click(object sender, EventArgs e)
        {
            if (_allTracksPage > 1)
            {
                var request = new TrackSearchRequest()
                {
                    Page = _allTracksPage - 1,
                    ItemsPerPage = _itemsPerPage
                };

                await LoadListAllTracks(request);
            }
        }

        private async void btnNextAllTracks_Click(object sender, EventArgs e)
        {
            var request = new TrackSearchRequest()
            {
                Page = _allTracksPage + 1,
                ItemsPerPage = _itemsPerPage
            };

            await LoadListAllTracks(request);
        }
        #endregion

        #region Search
        private async void btnSearchAllTracks_Click(object sender, EventArgs e)
        {
            var search = Convert.ToString(txtSearchAllTracks.Text);

            var request = new TrackSearchRequest()
            {
                Page = 1,
                ItemsPerPage = _itemsPerPage,
                Name = search
            };

            await LoadListAllTracks(request);
        }

        private void btnSearchPlaylistTracks_Click(object sender, EventArgs e)
        {
            var search = Convert.ToString(txtSearchPlaylistTracks.Text);

            var request = new TrackSearchRequest()
            {
                Page = 1,
                ItemsPerPage = _itemsPerPage,
                Name = search
            };

            LoadListPlaylistTracks(request);
        }

        #endregion

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var playlistTracks = _playlistTracks.Select(i => i.ID).ToList();


                var request = new PlaylistUpsertRequest
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
                    request.UserID = SignedInUserHelper.User.ID;
                    await _playlistApiService.Insert<Model.Playlist>(request);
                    PanelHelper.SwapPanels(this.Parent, this, new ucPlaylistUpsert());
                }

                MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

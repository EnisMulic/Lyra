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

namespace Lyra.WinUI.UserControls.Administrator.Album
{
    public partial class ucAlbumUpsert : UserControl
    {
        private static Model.Album _album = null;
        private readonly int? _ID;
        private readonly APIService _albumApiService = new APIService("Album");
        private readonly APIService _trackApiService = new APIService("Track");
        private readonly APIService _artistApiService = new APIService("Artist");
        private List<string> props = new List<string> { "ID", "Name", "Length" };
        private List<Model.Track> _albumTracks = new List<Model.Track>();
        private int _albumTracksPage;
        private int _allTracksPage;
        private int _itemsPerPage;
        
        public ucAlbumUpsert(int? ID = null)
        {
            _ID = ID;
            _allTracksPage = 1;
            _albumTracksPage = 1;
            _itemsPerPage = 10;
            InitializeComponent();
            AutoScroll = true;
        }

        #region Setup
        private async void ucAlbumUpsert_Load(object sender, EventArgs e)
        {
            var artists = await _artistApiService.Get<List<Model.Artist>>(null);

            cbArtist.DataSource = artists;
            cbArtist.ValueMember = "ID";
            cbArtist.DisplayMember = "Name";

            BuildAllTracksList();
            BuildAlbumTracksList();

            var tracksRequest = new TrackSearchRequest()
            {
                Page = _allTracksPage,
                ItemsPerPage = _itemsPerPage
            };
            await LoadListAllTracks(tracksRequest);
            
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

                _albumTracks = await _albumApiService.GetTracks<List<Model.Track>>(_ID.Value, null);
                var request = new TrackSearchRequest()
                {
                    Page = _albumTracksPage,
                    ItemsPerPage = _itemsPerPage
                };

                LoadListAlbumTracks(request);
            }
            else
            {
                DataGridViewHelper.PopulateWithList(dgvAlbumTracks, _albumTracks, props);
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
            gbTracks.Height = (dgvAllTracks.Height > dgvAlbumTracks.Height ? dgvAllTracks.Height : dgvAlbumTracks.Height) + 150;
        }

        private void BuildAlbumTracksList()
        {
            SetDataGridViewSize(dgvAlbumTracks);
            SetGroupBoxTracksHeight();
            SetButtonSavePosition();
            pnlAlbumTracksPageButtons.Location = new Point(pnlAlbumTracksPageButtons.Location.X, dgvAlbumTracks.Height + 100);
        }

        private void BuildAllTracksList()
        {
            SetDataGridViewSize(dgvAllTracks);
            SetGroupBoxTracksHeight();
            SetButtonSavePosition();
            pnlAllTracksPageButtons.Location = new Point(pnlAllTracksPageButtons.Location.X, dgvAllTracks.Height + 100);
        }

        #endregion

        private void LoadListAlbumTracks(TrackSearchRequest request)
        {
            var list = _albumTracks;

            if(!string.IsNullOrEmpty(request.Name))
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
                dgvAlbumTracks.ColumnCount = 0;
                DataGridViewHelper.PopulateWithList(dgvAlbumTracks, list, props);

                _albumTracksPage = request.Page;
            }
            else if(!string.IsNullOrEmpty(Convert.ToString(txtSearchAlbumTracks.Text)) && request.Page == 1)
            {
                dgvAlbumTracks.ColumnCount = 0;
                DataGridViewHelper.PopulateWithList(dgvAlbumTracks, new List<Model.Track>(), props);

                _albumTracksPage = 1;
            }

            btnPageNumberAlbumTracks.Text = Convert.ToString(_albumTracksPage);
        }

        private async Task LoadListAllTracks(TrackSearchRequest request)
        {
            var list = await _trackApiService.Get<List<Model.Track>>(request);

            if (list.Count > 0)
            {
                dgvAllTracks.ColumnCount = 0;
                DataGridViewHelper.PopulateWithList(dgvAllTracks, list, props);

                _allTracksPage = request.Page;
            }
            else if(!string.IsNullOrEmpty(Convert.ToString(txtSearchAllTracks.Text)) && request.Page == 1)
            {
                dgvAllTracks.ColumnCount = 0;
                DataGridViewHelper.PopulateWithList(dgvAllTracks, list, props);

                _allTracksPage = 1;
            }

            btnPageNumberAllTracks.Text = Convert.ToString(_allTracksPage);
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

                var track = _albumTracks.Single(i => i.ID == Convert.ToInt32(selectedRow.Cells["ID"].Value));
                _albumTracks.Remove(track);

                var request = new TrackSearchRequest()
                {
                    Page = _albumTracksPage,
                    ItemsPerPage = _itemsPerPage
                };
                LoadListAlbumTracks(request);
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
                if (!_albumTracks.Select(i => i.ID).ToList().Contains(Convert.ToInt32(selectedRow.Cells["ID"].Value)))
                {
                    var track = new Model.Track()
                    {
                        ID = Convert.ToInt32(selectedRow.Cells["ID"].Value),
                        Name = Convert.ToString(selectedRow.Cells["Name"].Value),
                        Length = Convert.ToString(selectedRow.Cells["Length"].Value)
                    };
                    _albumTracks.Add(track);

                    var request = new TrackSearchRequest()
                    {
                        Page = _albumTracksPage,
                        ItemsPerPage = _itemsPerPage
                    };
                    LoadListAlbumTracks(request);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        #region Validation
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
        #endregion

        #region Pagination Button Events
        private void btnPreviousAlbumTracks_Click(object sender, EventArgs e)
        {
            if (_albumTracksPage > 1)
            {
                var search = Convert.ToString(txtSearchAlbumTracks.Text);

                var request = new TrackSearchRequest()
                {
                    Page = _albumTracksPage - 1,
                    ItemsPerPage = _itemsPerPage,
                    Name = search
                };

                LoadListAlbumTracks(request);
            }
        }

        private void btnNextAlbumTracks_Click(object sender, EventArgs e)
        {
            var search = Convert.ToString(txtSearchAlbumTracks.Text);

            var request = new TrackSearchRequest()
            {
                Page = _albumTracksPage + 1,
                ItemsPerPage = _itemsPerPage,
                Name = search
            };

            LoadListAlbumTracks(request);
        }

        private async void btnPreviousAllTracks_Click(object sender, EventArgs e)
        {
            if (_allTracksPage > 1)
            {
                var search = Convert.ToString(txtSearchAllTracks.Text);

                var request = new TrackSearchRequest()
                {
                    Page = _allTracksPage - 1,
                    ItemsPerPage = _itemsPerPage,
                    Name = search
                };

                await LoadListAllTracks(request);
            }
        }

        private async void btnNextAllTracks_Click(object sender, EventArgs e)
        {
            var search = Convert.ToString(txtSearchAllTracks.Text);

            var request = new TrackSearchRequest()
            {
                Page = _allTracksPage + 1,
                ItemsPerPage = _itemsPerPage,
                Name = search
            };

            await LoadListAllTracks(request);
        }
        #endregion

        #region Search
        private void btnSearchAlbumTracks_Click(object sender, EventArgs e)
        {
            var search = Convert.ToString(txtSearchAlbumTracks.Text);

            var request = new TrackSearchRequest()
            {
                Page = 1,
                ItemsPerPage = _itemsPerPage,
                Name = search
            };

            LoadListAlbumTracks(request);
        }

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

        #endregion


        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var albumTracks = _albumTracks.Select(i => i.ID).ToList();

                var request = new AlbumUpsertRequest()
                {
                    Name = Convert.ToString(txtName.Text),
                    ReleaseYear = Convert.ToInt32(txtReleaseYear.Text),
                    ArtistID = Convert.ToInt32(cbArtist.SelectedValue),
                    Image = ImageHelper.SystemDrawingToByteArray(pbAlbumImage.Image),
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
    }
}

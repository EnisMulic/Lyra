using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using Lyra.Model;
using System.Runtime.CompilerServices;
using LiveCharts.Helpers;
using Flurl.Util;

namespace Lyra.WinUI.UserControls.Administrator.Analytics
{
    public delegate Task Delagate();
    public partial class ucAnalytics : UserControl
    {
        private APIService _apiService;
        private Delagate LoadGraphData { get; set; }
        public ucAnalytics()
        {
            InitializeComponent();
            LoadGraphData = new Delagate(GetTrackAnalytics);
            cbResource.DataSource = new List<string> { "Track", "Album", "Artist", "Playlist" };
        }

        private async Task GetTrackAnalytics()
        {
            _apiService = new APIService("Analytics/Track");

            var list = await _apiService.Get<List<UserActivityTrack>>(null);
            var dictonary = list
                .GroupBy(i => i.TrackID)
                .ToDictionary(i => i.Key, i => i.Count())
                .OrderByDescending(i => i.Value)
                .Take(Convert.ToInt32(nudTopN.Value));

            var values = dictonary.Select(i => i.Value).Reverse().ToList();

            var labels = new List<string>();
            foreach(var item in dictonary.Reverse())
            {
                var track = list.Where(i => i.ID == item.Key).Select(i => i.Track).FirstOrDefault();
                labels.Add(track.Name);
            }

            SetGraphData(values, labels);
        }

        private async Task GetAlbumAnalytics()
        {
            _apiService = new APIService("Analytics/Album");

            var list = await _apiService.Get<List<UserActivityAlbum>>(null);
            var dictonary = list
                .GroupBy(i => i.AlbumID)
                .ToDictionary(i => i.Key, i => i.Count())
                .OrderByDescending(i => i.Value)
                .Take(Convert.ToInt32(nudTopN.Value));

            var values = dictonary.Select(i => i.Value).Reverse().ToList();

            var labels = new List<string>();
            foreach (var item in dictonary.Reverse())
            {
                var album = list.Where(i => i.ID == item.Key).Select(i => i.Album).FirstOrDefault();
                labels.Add(album.Name);
            }

            SetGraphData(values, labels);
        }

        private async Task GetArtistAnalytics()
        {
            _apiService = new APIService("Analytics/Artist");

            var list = await _apiService.Get<List<UserActivityArtist>>(null);
            var dictonary = list
                .GroupBy(i => i.ArtistID)
                .ToDictionary(i => i.Key, i => i.Count())
                .OrderByDescending(i => i.Value)
                .Take(Convert.ToInt32(nudTopN.Value));

            var values = dictonary.Select(i => i.Value).Reverse().ToList();

            var labels = new List<string>();
            foreach (var item in dictonary.Reverse())
            {
                var artist = list.Where(i => i.ID == item.Key).Select(i => i.Artist).FirstOrDefault();
                labels.Add(artist.Name);
            }

            SetGraphData(values, labels);
        }

        private async Task GetPlaylistAnalytics()
        {
            _apiService = new APIService("Analytics/Playlist");

            var list = await _apiService.Get<List<UserActivityPlaylist>>(null);
            var dictonary = list
                .GroupBy(i => i.PlaylistID)
                .ToDictionary(i => i.Key, i => i.Count())
                .OrderByDescending(i => i.Value)
                .Take(Convert.ToInt32(nudTopN.Value));

            var values = dictonary.Select(i => i.Value).Reverse().ToList();

            var labels = new List<string>();
            foreach (var item in dictonary.Reverse())
            {
                var playlist = list.Where(i => i.ID == item.Key).Select(i => i.Playlist).FirstOrDefault();
                labels.Add(playlist.Name);
            }

            SetGraphData(values, labels);
        }

        private void SetGraphData(List<int> Values, List<string> Labels)
        {
            cartesianChart1.Series.Clear();
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisY.Clear();

            cartesianChart1.Series = new SeriesCollection
            {
                new RowSeries
                {
                    Title = "Tracks",
                    Values = new ChartValues<int> ( Values )
                }
            };

            cartesianChart1.AxisY.Add(new Axis
            {
                Labels = Labels
            });

            cartesianChart1.AxisX.Add(new Axis
            {
                LabelFormatter = value => value.ToString("N")
            });

            var tooltip = new DefaultTooltip
            {
                SelectionMode = TooltipSelectionMode.SharedYValues
            };
        }

        private async void nudTopN_ValueChanged(object sender, EventArgs e)
        {
            if(LoadGraphData != null)
            {
                await LoadGraphData.Invoke();
            }
        }

        private async void cbResource_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (cbResource.Text)
            {
                case "Track":
                    LoadGraphData = new Delagate(GetTrackAnalytics);
                    break;
                case "Album":
                    LoadGraphData = new Delagate(GetAlbumAnalytics);
                    break;
                case "Artist":
                    LoadGraphData = new Delagate(GetArtistAnalytics);
                    break;
                case "Playlist":
                    LoadGraphData = new Delagate(GetPlaylistAnalytics);
                    break;
            }


            if(LoadGraphData != null)
            {
                await LoadGraphData.Invoke();
            }
        }
    }
}

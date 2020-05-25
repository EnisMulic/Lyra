using Lyra.Mobile.Helpers;
using Lyra.Mobile.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lyra.Mobile.ViewModels
{
    public class YourMusicTracksViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("");
        public ObservableCollection<Model.Track> TracksList { get; set; } = new ObservableCollection<Model.Track>();

        private Model.Track _selectedTrack { get; set; }
        public Model.Track SelectedTrack
        {
            get { return _selectedTrack; }
            set 
            { 
                if(_selectedTrack != value)
                {
                    _selectedTrack = value;
                    HandleSelectedItem();
                }
            }
        }

        private void HandleSelectedItem()
        {
            Application.Current.MainPage.DisplayAlert("Selected", _selectedTrack.Name, "OK");
            MusicPlayerViewModel MusicPlayer = new MusicPlayerViewModel(_selectedTrack, null);

        }

        public YourMusicTracksViewModel()
        {
        }

        public async Task Init()
        {
            TracksList.Clear();
            try
            {
                int ID = SignedInUserHelper.User.ID;

                var tracks = await _service.GetFavouriteTracks(ID);
                foreach (var track in tracks)
                {
                    TracksList.Add(track);
                }
            }
            catch
            {

            }
        }
    }
}

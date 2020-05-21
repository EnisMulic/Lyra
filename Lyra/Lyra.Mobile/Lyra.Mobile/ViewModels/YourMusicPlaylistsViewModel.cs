using Lyra.Mobile.Helpers;
using Lyra.Mobile.Services;
using Lyra.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lyra.Mobile.ViewModels
{
    class YourMusicPlaylistsViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Playlist");
        public ObservableCollection<Model.Playlist> PlaylistsList { get; set; } = new ObservableCollection<Model.Playlist> ();
        public ICommand NewPlaylistCommand { get; set; }
        public YourMusicPlaylistsViewModel()
        {
            NewPlaylistCommand = new Command(() => CreateNewPlaylist());
        }

        private void CreateNewPlaylist()
        {
            throw new NotImplementedException();
        }

        public async Task Init()
        {
            PlaylistsList.Clear();
            try
            {
                var request = new PlaylistSearchRequest()
                {
                    UserID = SignedInUserHelper.User.ID
                };

                var playlists = await _service.Get<List<Model.Playlist>>(request);
                foreach (var playlist in playlists)
                {
                    PlaylistsList.Add(playlist);
                }
            }
            catch
            {

            }
        }
    }
}

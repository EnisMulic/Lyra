using Lyra.Mobile.Helpers;
using Lyra.Mobile.Services;
using Lyra.Model.Requests;
using Lyra.WinUI;
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
        private bool IsLoaded = false;
        public YourMusicPlaylistsViewModel()
        {
        }

        public async Task Init()
        {
            try
            {
                if(!IsLoaded)
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

                    IsLoaded = true;
                }
            }
            catch
            {

            }
        }
    }
}

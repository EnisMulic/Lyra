using Lyra.Mobile.Helpers;
using Lyra.Mobile.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lyra.Mobile.ViewModels
{
    class ActivityPlaylistsViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("");
        public ObservableCollection<Model.UserActivityPlaylist> PlaylistsList { get; set; } = new ObservableCollection<Model.UserActivityPlaylist>();
        public ICommand NewPlaylistCommand { get; set; }

        public async Task Init()
        {
            PlaylistsList.Clear();
            try
            {
                var UserID = SignedInUserHelper.User.ID;

                var playlists = await _service.GetActivityPlaylists(UserID);
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

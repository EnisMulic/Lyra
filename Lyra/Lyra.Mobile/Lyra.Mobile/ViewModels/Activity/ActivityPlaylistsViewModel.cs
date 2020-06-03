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
    class ActivityPlaylistsViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("");
        public ObservableCollection<Model.UserActivityPlaylist> PlaylistsList { get; set; } = new ObservableCollection<Model.UserActivityPlaylist>();
        public ICommand PerformSearch { get; set; }

        public ActivityPlaylistsViewModel()
        {
            PerformSearch = new Command(async (object query) => await Search(query));
        }


        private async Task Search(object query)
        {
            var request = new PlaylistSearchRequest()
            {
                Name = query as string
            };

            await Init(request);
        }

        public async Task Init(PlaylistSearchRequest request = null)
        {
            PlaylistsList.Clear();
            try
            {
                var UserID = SignedInUserHelper.User.ID;

                var playlists = await _service.GetActivityPlaylists(UserID, request);
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

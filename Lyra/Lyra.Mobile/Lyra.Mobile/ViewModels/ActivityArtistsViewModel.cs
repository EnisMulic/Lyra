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
    public class ActivityArtistsViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("");
        public ObservableCollection<Model.UserActivityArtist> ArtistsList { get; set; } = new ObservableCollection<Model.UserActivityArtist>();
        public ICommand NewPlaylistCommand { get; set; }

        public async Task Init()
        {
            ArtistsList.Clear();
            try
            {
                var UserID = SignedInUserHelper.User.ID;

                var artists = await _service.GetActivityArtists(UserID);
                foreach (var artist in artists)
                {
                    ArtistsList.Add(artist);
                }
            }
            catch
            {

            }
        }
    }
}

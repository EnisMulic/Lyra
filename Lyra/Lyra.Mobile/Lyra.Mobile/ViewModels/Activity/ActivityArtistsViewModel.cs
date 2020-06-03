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
    public class ActivityArtistsViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("");
        public ObservableCollection<Model.UserActivityArtist> ArtistsList { get; set; } = new ObservableCollection<Model.UserActivityArtist>();
        public ICommand PerformSearch { get; set; }

        public ActivityArtistsViewModel()
        {
            PerformSearch = new Command(async (object query) => await Search(query));
        }


        private async Task Search(object query)
        {
            var request = new ArtistSearchRequest()
            {
                Name = query as string
            };

            await Init(request);
        }

        public async Task Init(ArtistSearchRequest request = null)
        {
            ArtistsList.Clear();
            try
            {
                var UserID = SignedInUserHelper.User.ID;

                var artists = await _service.GetActivityArtists(UserID, request);
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

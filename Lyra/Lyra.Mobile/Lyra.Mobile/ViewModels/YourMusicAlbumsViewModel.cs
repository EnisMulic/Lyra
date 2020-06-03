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
    public class YourMusicAlbumsViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("");
        public ObservableCollection<AlbumViewModel> AlbumsList { get; set; } = new ObservableCollection<AlbumViewModel>();


        public ICommand PerformSearch { get; set; }

        public YourMusicAlbumsViewModel()
        {
            PerformSearch = new Command(async (object query) => await Search(query));
        }


        private async Task Search(object query)
        {
            var request = new AlbumSearchRequest()
            {
                Name = query as string
            };

            await Init(request);
        }

        public async Task Init(AlbumSearchRequest request = null)
        {
            AlbumsList.Clear();
            try
            {
                int ID = SignedInUserHelper.User.ID;

                var albums = await _service.GetFavouriteAlbums(ID, request);
                foreach (var album in albums)
                {
                    AlbumsList.Add(new AlbumViewModel(album));
                }
            }
            catch
            {

            }
        }
    }
}

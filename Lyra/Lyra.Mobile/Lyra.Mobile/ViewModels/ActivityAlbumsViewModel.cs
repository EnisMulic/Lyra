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
    public class ActivityAlbumsViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("");
        public ObservableCollection<Model.UserActivityAlbum> AlbumsList { get; set; } = new ObservableCollection<Model.UserActivityAlbum>();

        public ICommand PerformSearch { get; set; }

        public ActivityAlbumsViewModel()
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
                var UserID = SignedInUserHelper.User.ID;

                var albums = await _service.GetActivityAlbums(UserID, request);
                foreach (var album in albums)
                {
                    AlbumsList.Add(album);
                }
            }
            catch
            {

            }
        }
    }
}

using Lyra.Mobile.Helpers;
using Lyra.Mobile.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Lyra.Mobile.ViewModels
{
    public class YourMusicAlbumsViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("");
        public ObservableCollection<Model.Album> AlbumsList { get; set; } = new ObservableCollection<Model.Album>();
        public YourMusicAlbumsViewModel()
        {
        }

        public async Task Init()
        {
            AlbumsList.Clear();
            try
            {
                int ID = SignedInUserHelper.User.ID;

                var albums = await _service.GetFavouriteAlbums(ID);
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

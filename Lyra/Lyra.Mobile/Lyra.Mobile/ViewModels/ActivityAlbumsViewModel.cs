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
    public class ActivityAlbumsViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("");
        public ObservableCollection<Model.UserActivityAlbum> AlbumsList { get; set; } = new ObservableCollection<Model.UserActivityAlbum>();
        public ICommand NewPlaylistCommand { get; set; }

        public async Task Init()
        {
            AlbumsList.Clear();
            try
            {
                var UserID = SignedInUserHelper.User.ID;

                var albums = await _service.GetActivityAlbums(UserID);
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

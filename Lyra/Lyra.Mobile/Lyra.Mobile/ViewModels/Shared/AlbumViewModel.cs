using Lyra.Mobile.Extensions;
using Lyra.Mobile.Helpers;
using Lyra.Mobile.Services;
using Lyra.Model;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lyra.Mobile.ViewModels
{
    public class AlbumViewModel : BaseViewModel
    {
        private readonly APIService _userService = new APIService("User");
        public ICommand ToggleFavouriteCommand { get; set; }

        private bool _isFavourite;

        public bool IsFavourite
        {
            get { return _isFavourite; }
            set
            {
                _isFavourite = value;
                OnPropertyChanged(nameof(IsFavouriteImage));
            }
        }

        private Album _album;
        public Album Album
        {
            get { return _album; }
            set { SetProperty(ref _album, value); }
        }

        public ImageSource IsFavouriteImage
        {
            get => IsFavourite ? ImageSource.FromResource("Lyra.Mobile.Assets.heart-filled.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                               : ImageSource.FromResource("Lyra.Mobile.Assets.heart-empty.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);

        }
        public AlbumViewModel()
        {

        }


        public AlbumViewModel(Album album)
        {
            Album = album;
            IsFavourite = FavouritesHelper.FavouriteAlbums.Find(i => i.ID == Album.ID) != null;

            ToggleFavouriteCommand = new Command(async () => await ToggleFavourite());
        }

        private async Task ToggleFavourite()
        {
            //Test post database seed
            //Remove/add track to Favourites helper?
            try
            {
                if (IsFavourite)
                {
                    await _userService.DeleteFavouriteAlbum(SignedInUserHelper.User.ID, Album.ID);
                    IsFavourite = false;
                }
                else
                {
                    await _userService.InsertFavouriteAlbum(SignedInUserHelper.User.ID, Album.ID);
                    IsFavourite = true;
                }

            }
            catch
            {

            }
        }
    }
}

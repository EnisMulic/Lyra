using Acr.UserDialogs;
using Lyra.Mobile.Extensions;
using Lyra.Mobile.Helpers;
using Lyra.Mobile.Services;
using Lyra.Model;
using Lyra.Model.Requests;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lyra.Mobile.ViewModels
{
    public class TrackViewModel : BaseViewModel
    {
        private readonly APIService _userService = new APIService("User");
        private readonly APIService _playlistService = new APIService("Playlist");
        public ICommand ToggleFavouriteCommand { get; set; }
        public ICommand ShowPlaylistsCommand { get; set; }

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

        private Track _track;
        public Track Track
        {
            get { return _track; }
            set { SetProperty(ref _track, value); }
        }

        public string IsFavouriteImage
        {
            get => IsFavourite ? "heart-filled.png" : "heart-empty.png";

        }

        public ImageSource AddImage
        {
            get => ImageSource.FromResource("Lyra.Mobile.Assets.add.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
        }

        public TrackViewModel()
        {

        }


        public TrackViewModel(Track track)
        {
            Track = track;
            IsFavourite = FavouritesHelper.FavouriteTracks.Find(i => i.ID == Track.ID) != null;

            ToggleFavouriteCommand = new Command(async () => await ToggleFavourite());
            ShowPlaylistsCommand = new Command(async () => await ShowPlaylists());
        }

        private async Task ShowPlaylists()
        {
            var request = new PlaylistSearchRequest()
            {
                UserID = SignedInUserHelper.User.ID
            };
            var playlists = await _playlistService.Get<List<Playlist>>(request);

            var cfg = new ActionSheetConfig()
               .SetTitle("Add to Playlist")
               .SetCancel();

            foreach (var playlist in playlists)
            {
                cfg.Add(
                    playlist.Name,
                    async () => await AddToPlaylist(playlist.ID, Track.ID));
            }

            UserDialogs.Instance.ActionSheet(cfg);
        }

        private async Task AddToPlaylist(int PlaylistID, int TrackID)
        {
            try
            {
                var playlist = await _playlistService.GetById<Playlist>(PlaylistID);
                var request = new PlaylistUpsertRequest()
                {
                    Name = playlist.Name,
                    Image = playlist.Image,
                    CreatedAt = playlist.CreatedAt,
                    UserID = playlist.UserID,
                    Tracks = new List<int>() { TrackID }
                };

                await _playlistService.Update<Playlist>(PlaylistID, request);
            }
            catch
            {

            }
        }

        private async Task ToggleFavourite()
        {
            //Test post database seed
            //Remove/add track to Favourites helper?
            try
            {
                if (IsFavourite)
                {
                    await _userService.DeleteFavouriteTrack(SignedInUserHelper.User.ID, Track.ID);
                    IsFavourite = false;
                }
                else
                {
                    await _userService.InsertFavouriteTrack(SignedInUserHelper.User.ID, Track.ID);
                    IsFavourite = true;
                }

            }
            catch
            {

            }
        }
    }
}

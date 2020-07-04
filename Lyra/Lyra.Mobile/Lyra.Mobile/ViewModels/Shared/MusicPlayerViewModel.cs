using Lyra.Mobile.Extensions;
using Lyra.Mobile.Helpers;
using Lyra.Mobile.Services;
using Lyra.Model;
using Lyra.Model.Requests;
using MediaManager;
using MediaManager.Player;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Lyra.Mobile.ViewModels
{
    public class MusicPlayerViewModel : BaseViewModel
    {
        #region Properties
        private readonly APIService _logginService = new APIService("User");
        private readonly APIService _trackService = new APIService("Track");
        private readonly APIService _trackReviewService = new APIService("Review");
        ObservableCollection<Track> trackList;
        public ObservableCollection<Track> TrackList
        {
            get { return trackList; }
            set
            {
                trackList = value;
                OnPropertyChanged();
            }
        }

        private Track selectedTrack;
        public Track SelectedTrack
        {
            get { return selectedTrack; }
            set
            {
                selectedTrack = value;
                OnPropertyChanged();
            }
        }

        private UserTrackReview trackReview;
        public UserTrackReview TrackReview
        {
            get { return trackReview; }
            set { SetProperty(ref trackReview, value); }
        }

        private int score;
        public int Score
        {
            get { return score; }
            set { SetProperty(ref score, value); }
        }

        private TimeSpan duration;
        public TimeSpan Duration
        {
            get { return duration; }
            set
            {
                duration = value;
                OnPropertyChanged();
            }
        }

        private TimeSpan position;
        public TimeSpan Position
        {
            get { return position; }
            set
            {
                position = value;
                OnPropertyChanged();
            }
        }

        double maximum = 100f;
        public double Maximum
        {
            get { return maximum; }
            set
            {
                if (value > 0)
                {
                    maximum = value;
                    OnPropertyChanged();
                }
            }
        }


        private bool isPlaying;
        public bool IsPlaying
        {
            get { return isPlaying; }
            set
            {
                isPlaying = value;
                OnPropertyChanged(nameof(PlayIcon));
            }
        }

        public string PlayIcon
        {
            get => isPlaying ? "pause.png" : "play.png";
        }

        public ImageSource CoverImage { get; set; }
        #endregion

        public MusicPlayerViewModel(Track track, ObservableCollection<Track> trackList, Image coverImage)
        {
            this.trackList = trackList;
            CoverImage = coverImage?.Source;
            PlayTrack(track.ID);
        }

        public string filename { get; set; }

        public ICommand PlayCommand => new Command(Play);
        public ICommand ChangeCommand => new Command(ChangeMusic);


        private async void Play()
        {
            if (isPlaying)
            {
                await CrossMediaManager.Current.Pause();
                IsPlaying = false;
            }
            else
            {
                await CrossMediaManager.Current.Play();
                IsPlaying = true;
            }
        }

        private void ChangeMusic(object obj)
        {
            if ((string)obj == "P")
                PreviousTrack();
            else if ((string)obj == "N")
                NextTrack();
        }

        private async void PlayTrack(int ID)
        {
            if(!string.IsNullOrEmpty(filename))
            {
                FileHelper.DeleteFile(filename);
            }

            SelectedTrack = await _trackService.GetById<Model.Track>(ID);

            await LogTrackActivity(ID);
            await SetTrackReview(ID);
            Score = TrackReview != null ? TrackReview.Score : 0;

            var mediaInfo = CrossMediaManager.Current;

            filename = FileHelper.SaveFile(selectedTrack.MP3File, Guid.NewGuid() + ".mp3");   

            if (!string.IsNullOrEmpty(filename))
            {
                await mediaInfo.Play(filename);

                IsPlaying = true;

                mediaInfo.MediaItemFinished += (sender, args) =>
                {
                    IsPlaying = false;
                    FileHelper.DeleteFile(filename);
                    NextTrack();
                };

                Device.StartTimer(TimeSpan.FromMilliseconds(500), () =>
                {
                    Duration = mediaInfo.Duration;
                    Maximum = duration.TotalSeconds;
                    Position = mediaInfo.Position;
                    return true;
                });

                isPlaying = true;
            }
        }

        private void NextTrack()
        {
            var currentIndex = trackList?.Select(i => i.ID).ToList().IndexOf(selectedTrack.ID);

            if (currentIndex != null && currentIndex < trackList.Count - 1)
            {
                SelectedTrack = trackList[(int)currentIndex + 1];
                PlayTrack(selectedTrack.ID);
            }
        }

        private void PreviousTrack()
        {
            var currentIndex = trackList?.Select(i => i.ID).ToList().IndexOf(selectedTrack.ID);

            if (currentIndex != null && currentIndex > 0)
            {
                SelectedTrack = trackList[(int)currentIndex - 1];
                PlayTrack(selectedTrack.ID);
            }
        }

        private async Task SetTrackReview(int TrackID)
        {
            var request = new UserTrackReviewSearchRequest()
            {
                TrackID = TrackID,
                UserID = SignedInUserHelper.User.ID
            };

            var list = await _trackReviewService.Get<List<Model.UserTrackReview>>(request);
            TrackReview = list.FirstOrDefault();
        }

        private async Task LogTrackActivity(int TrackID)
        {
            var request = new UserActivityTrackInsertRequest()
            {
                TrackID = TrackID,
                InteractedAt = DateTime.Now
            };
            await _logginService.InsertActivityTrack(SignedInUserHelper.User.ID, request);
        }
    }
}

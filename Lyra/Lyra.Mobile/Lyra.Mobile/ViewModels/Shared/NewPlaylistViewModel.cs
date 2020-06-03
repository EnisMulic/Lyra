using Lyra.Mobile.Helpers;
using Lyra.Mobile.Services;
using Lyra.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lyra.Mobile.ViewModels
{
    public class NewPlaylistViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Playlist");
        private string name;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        byte[] image;
        public byte[] Image
        {
            get { return image; }
            set { SetProperty(ref image, value); }
        }

        public ICommand SaveCommand { get; set; }
        public ICommand ChangeImage { get; set; }

        public NewPlaylistViewModel()
        {
            SaveCommand = new Command(async () => await SavePlaylist());
            ChangeImage = new Command(async () => await OnTapped());
        }

        private async Task OnTapped()
        {
            Image = await UploadImageHelper.UploadImage(Image);
        }

        private async Task SavePlaylist()
        {
            try
            {
                var playlist = new PlaylistUpsertRequest()
                {
                    UserID = SignedInUserHelper.User.ID,
                    Name = name,
                    Image = image,
                    CreatedAt = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")
                };

                await _service.Insert<Model.Playlist>(playlist);

                await Application.Current.MainPage.DisplayAlert("Success", "You have successfully created a playlist", "OK");
                
            }
            catch
            {

            }
        }
    }
}

using Lyra.Mobile.Services;
using Lyra.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lyra.Mobile.ViewModels.Search
{
    public class SearchPlaylistsViewModel : BaseViewModel
    {
        private readonly APIService _playlistService = new APIService("Playlist");
        public string SearchQuery { get; set; }
        public ObservableCollection<Model.Playlist> PlaylistsList { get; set; } = new ObservableCollection<Model.Playlist>();
        public ICommand PerformSearch { get; set; }

        public SearchPlaylistsViewModel()
        {
            PerformSearch = new Command(async (object query) => await Search(query));
        }

        public SearchPlaylistsViewModel(string search)
        {
            PerformSearch = new Command(async (object query) => await Search(query));
            SearchQuery = search;
            PerformSearch.Execute(search);
        }


        private async Task Search(object query)
        {
            string queryString = query as string;

            SearchQuery = queryString;
            if (!string.IsNullOrEmpty(queryString))
            {
                var request = new PlaylistSearchRequest()
                {
                    Name = queryString
                };

                var artistsList = await _playlistService.Get<List<Model.Playlist>>(request);

                PlaylistsList.Clear();
                foreach (var Item in artistsList)
                {
                    PlaylistsList.Add(Item);
                }
            }
        }
    }
}

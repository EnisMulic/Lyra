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

namespace Lyra.Mobile.ViewModels.Search
{
    public class SearchAlbumsViewModel : BaseViewModel
    {
        private readonly APIService _albumService = new APIService("Album");
        public string SearchQuery { get; set; }
        public ICommand PerformSearch { get; set; }
        public ObservableCollection<AlbumViewModel> AlbumsList { get; set; } = new ObservableCollection<AlbumViewModel>();

        public SearchAlbumsViewModel()
        {
            PerformSearch = new Command(async (object query) => await Search(query));
        }
        public SearchAlbumsViewModel(string search)
        {
            PerformSearch = new Command(async (object query) => await Search(query));
            SearchQuery = search;
            PerformSearch.Execute(search);
        }

        private async Task Search(object query)
        {
            string queryString = query as string;

            SearchQuery = queryString;
            if(!string.IsNullOrEmpty(queryString))
            {
                var request = new ArtistSearchRequest()
                {
                    Name = queryString
                };

                var artistsList = await _albumService.Get<List<Model.Album>>(request);

                AlbumsList.Clear();
                foreach (var Item in artistsList)
                {
                    AlbumsList.Add(new AlbumViewModel(Item));
                }
            }
        }
    }
}

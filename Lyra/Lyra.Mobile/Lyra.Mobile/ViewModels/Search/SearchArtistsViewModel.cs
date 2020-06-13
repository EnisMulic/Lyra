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
    public class SearchArtistsViewModel : BaseViewModel
    {
        private readonly APIService _artistService = new APIService("Artist");
        public string SearchQuery { get; set; }
        public ICommand PerformSearch { get; set; }
        public ObservableCollection<ArtistViewModel> ArtistsList { get; set; } = new ObservableCollection<ArtistViewModel>();

        public SearchArtistsViewModel()
        {
            PerformSearch = new Command(async (object query) => await Search(query));
        }
        public SearchArtistsViewModel(string search)
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

                var artistsList = await _artistService.Get<List<Model.Artist>>(request);

                ArtistsList.Clear();
                foreach (var Item in artistsList)
                {
                    ArtistsList.Add(new ArtistViewModel(Item));
                }
            }
        }
    }
}

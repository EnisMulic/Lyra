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
    public class SearchTracksViewModel : BaseViewModel
    {
        private readonly APIService _trackService = new APIService("Track");
        public string SearchQuery { get; set; }
        public ICommand PerformSearch { get; set; }
        public ObservableCollection<TrackViewModel> TracksList { get; set; } = new ObservableCollection<TrackViewModel>();

        public SearchTracksViewModel()
        {
            PerformSearch = new Command(async (object query) => await Search(query));
        }
        public SearchTracksViewModel(string search)
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
                var request = new TrackSearchRequest()
                {
                    Name = queryString
                };

                var artistsList = await _trackService.Get<List<Model.Track>>(request);

                TracksList.Clear();
                foreach (var Item in artistsList)
                {
                    TracksList.Add(new TrackViewModel(Item));
                }
            }
        }
    }
}

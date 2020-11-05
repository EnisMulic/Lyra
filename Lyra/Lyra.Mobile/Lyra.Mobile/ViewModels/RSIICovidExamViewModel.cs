using Lyra.Mobile.Services;
using Lyra.Model;
using Lyra.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lyra.Mobile.ViewModels
{
    public class RSIICovidExamViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("RSIICovidExam");
        public ObservableCollection<CovidExamViewModel> CovidExams { get; set; } = new ObservableCollection<CovidExamViewModel>();
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public bool? TestPositive { get; set; }
        public ICommand PerformSearch { get; set; }

        public RSIICovidExamViewModel()
        {
            PerformSearch = new Command(async (object query) => await Search(query));
        }

        private async Task Search(object query)
        {
            var request = new RSIICovidExamSearchRequest()
            {
                Username = query as string,
                From = From,
                To = To,
                TestPositive = TestPositive
            };

            await Init(request);
        }

        public async Task Init(RSIICovidExamSearchRequest request = null)
        {
            CovidExams.Clear();
            try
            {
                var exams = await _service.Get<List<RSIICovidExam>>(request);
                foreach (var exam in exams)
                {
                    CovidExams.Add(new CovidExamViewModel(exam));
                }
            }
            catch
            {

            }
        }
    }
}

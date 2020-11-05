using Lyra.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Mobile.ViewModels
{
    public class CovidExamViewModel : BaseViewModel
    {
        private RSIICovidExam _exam;
        public RSIICovidExam Exam
        {
            get { return _exam; }
            set { SetProperty(ref _exam, value); }
        }

        public string User 
        { 
            get { return _exam.User.FirstName + " " + _exam.User.LastName; } 
            
        }
        public DateTime DateTested { get { return _exam.DateTested; } }
        public bool TestPositive { get { return _exam.TestPositive; } }

        public CovidExamViewModel()
        {
            
        }

        public CovidExamViewModel(RSIICovidExam exam)
        {
            _exam = exam;
        }
    }
}

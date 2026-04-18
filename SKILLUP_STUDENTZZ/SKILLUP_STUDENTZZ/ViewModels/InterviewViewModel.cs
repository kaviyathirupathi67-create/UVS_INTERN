using System.Collections.ObjectModel;
using SKILLUP_STUDENTZZ.Models;

namespace SKILLUP_STUDENTZZ.ViewModels
{
    public class InterviewViewModel
    {
        public ObservableCollection<Question> Questions { get; set; }

        public InterviewViewModel()
        {
            Questions = new ObservableCollection<Question>()
            {
                new Question { Title="Tell me about yourself", Answer="Explain education + skills" },
                new Question { Title="Why should we hire you?", Answer="Talk about strengths" }
            };
        }
    }
}
using SKILLUP_STUDENTZZ.ViewModels;

namespace SKILLUP_STUDENTZZ.Views;

public partial class InterviewPage : ContentPage
{
    public InterviewPage()
    {
        InitializeComponent();
        BindingContext = new InterviewViewModel();
    }
}
using StudentTaskManager.ViewModels;

namespace StudentTaskManager.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new TaskViewModel();
    }
}
using SkillUp.Platform.ViewModels; 

namespace SkillUp.Platform.Views;
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();
    }
}
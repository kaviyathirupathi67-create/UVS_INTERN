using Microsoft.Maui.Controls;
using SampleProject.MVVM.ViewModels;

namespace SampleProject.MVVM.Views;

public partial class StudentRegistrationView : ContentPage
{
    public StudentRegistrationView()
    {
        InitializeComponent();
        BindingContext = new StudentRegistrationviewmodel();
    }
}
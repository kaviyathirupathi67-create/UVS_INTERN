using ExpenseTrackerApp.ViewModels;
using ExpenseTrackerApp.Views;

namespace ExpenseTrackerApp.Views;

public partial class HomePage : ContentPage
{
    public HomePage(HomeViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    private async void GoCategories(object sender, EventArgs e)
    {
        var page = Handler.MauiContext.Services.GetService<CategoryPage>();
        await Navigation.PushAsync(page);
    }

    private async void GoExpenses(object sender, EventArgs e)
    {
        var page = Handler.MauiContext.Services.GetService<ExpensePage>();
        await Navigation.PushAsync(page);
    }
}
using ExpenseTracker.Views;
namespace ExpenseTracker.Views;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private async void GoToCategories(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategoriesPage());
    }
}
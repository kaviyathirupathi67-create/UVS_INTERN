using ExpenseTrackerApp.ViewModels;
using ExpenseTrackerApp.Views;

namespace ExpenseTrackerApp.Views;

public partial class ExpensePage : ContentPage
{
    public ExpensePage(ExpenseViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    private async void OnAddExpenseClicked(object sender, EventArgs e)
    {
        var page = Handler.MauiContext.Services.GetService<AddExpensePage>();
        await Navigation.PushAsync(page);
    }
}
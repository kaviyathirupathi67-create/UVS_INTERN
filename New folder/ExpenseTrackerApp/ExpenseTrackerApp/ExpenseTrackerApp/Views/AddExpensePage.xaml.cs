using ExpenseTrackerApp.ViewModels;

namespace ExpenseTrackerApp.Views;

public partial class AddExpensePage : ContentPage
{
    public AddExpensePage(AddExpenseViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
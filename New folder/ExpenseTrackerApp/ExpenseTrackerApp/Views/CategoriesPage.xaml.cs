using ExpenseTrackerApp.ViewModels;

namespace ExpenseTrackerApp.Views;

public partial class CategoryPage : ContentPage
{
    public CategoryPage(CategoryViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
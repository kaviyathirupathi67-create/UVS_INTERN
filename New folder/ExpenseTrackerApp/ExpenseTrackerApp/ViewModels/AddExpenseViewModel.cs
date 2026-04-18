using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ExpenseTrackerApp.Models;
using ExpenseTrackerApp.Interfaces;

namespace ExpenseTrackerApp.ViewModels;

public class AddExpenseViewModel : INotifyPropertyChanged
{
    private readonly IExpenseService _expenseService;
    private readonly ICategoryService _categoryService;

    public event PropertyChangedEventHandler PropertyChanged;

    // 🔷 Property Changed Helper
    void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    // 🔷 Categories
    private ObservableCollection<Category> _categories = new();
    public ObservableCollection<Category> Categories
    {
        get => _categories;
        set
        {
            _categories = value;
            OnPropertyChanged();
        }
    }

    // 🔷 Selected Category
    private Category _selectedCategory;
    public Category SelectedCategory
    {
        get => _selectedCategory;
        set
        {
            _selectedCategory = value;
            OnPropertyChanged();
        }
    }

    // 🔷 Title
    private string _title;
    public string Title
    {
        get => _title;
        set
        {
            _title = value;
            OnPropertyChanged();
        }
    }

    // 🔷 Amount
    private string _amount;
    public string Amount
    {
        get => _amount;
        set
        {
            _amount = value;
            OnPropertyChanged();
        }
    }

    // 🔷 Date
    private DateTime _date = DateTime.Today;
    public DateTime Date
    {
        get => _date;
        set
        {
            _date = value;
            OnPropertyChanged();
        }
    }

    // 🔷 Note
    private string _note;
    public string Note
    {
        get => _note;
        set
        {
            _note = value;
            OnPropertyChanged();
        }
    }

    // 🔷 Command
    public ICommand SaveCommand { get; }

    public AddExpenseViewModel(IExpenseService expenseService, ICategoryService categoryService)
    {
        _expenseService = expenseService;
        _categoryService = categoryService;

        SaveCommand = new Command(async () => await SaveExpense());

        LoadCategories();
    }

    // 🔷 Load Categories
    private async void LoadCategories()
    {
        var list = await _categoryService.GetCategories();
        Categories = new ObservableCollection<Category>(list);
    }

    // 🔷 Save Expense
    private async Task SaveExpense()
    {
        if (SelectedCategory == null ||
            string.IsNullOrWhiteSpace(Title) ||
            string.IsNullOrWhiteSpace(Amount))
        {
            await Application.Current.MainPage.DisplayAlert("Error", "Fill all fields", "OK");
            return;
        }

        var expense = new Expense
        {
            Title = Title,
            Amount = double.Parse(Amount),
            Date = Date,
            Note = Note,
            CategoryId = SelectedCategory.Id,
            CategoryName = SelectedCategory.Name
        };

        await _expenseService.AddExpense(expense);

        await Application.Current.MainPage.DisplayAlert("Success", "Expense Added", "OK");

        // Clear fields
        Title = "";
        Amount = "";
        Note = "";
        SelectedCategory = null;
        Date = DateTime.Today;
    }
}
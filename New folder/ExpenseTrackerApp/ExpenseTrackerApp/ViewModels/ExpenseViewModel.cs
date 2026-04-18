using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ExpenseTrackerApp.Models;
using ExpenseTrackerApp.Interfaces;

namespace ExpenseTrackerApp.ViewModels;

public class ExpenseViewModel : INotifyPropertyChanged
{
    private readonly IExpenseService _expenseService;

    public event PropertyChangedEventHandler PropertyChanged;

    void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    // 🔷 Expenses List
    private ObservableCollection<Expense> _expenses = new();
    public ObservableCollection<Expense> Expenses
    {
        get => _expenses;
        set
        {
            _expenses = value;
            OnPropertyChanged();
        }
    }

    // 🔷 Command
    public ICommand DeleteCommand { get; }

    public ExpenseViewModel(IExpenseService expenseService)
    {
        _expenseService = expenseService;

        DeleteCommand = new Command<int>(async (id) => await DeleteExpense(id));

        LoadExpenses();
    }

    // 🔷 Load Expenses
    private async void LoadExpenses()
    {
        var list = await _expenseService.GetExpenses();
        Expenses = new ObservableCollection<Expense>(list);
    }

    // 🔷 Delete Expense
    private async Task DeleteExpense(int id)
    {
        await _expenseService.DeleteExpense(id);
        LoadExpenses();
    }
}
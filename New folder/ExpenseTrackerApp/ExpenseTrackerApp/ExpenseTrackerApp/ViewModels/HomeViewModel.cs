using System.ComponentModel;
using System.Runtime.CompilerServices;
using ExpenseTrackerApp.Interfaces;

namespace ExpenseTrackerApp.ViewModels;

public class HomeViewModel : INotifyPropertyChanged
{
    private readonly IExpenseService _expenseService;

    public event PropertyChangedEventHandler PropertyChanged;

    void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    // 🔷 Total Expenses
    private int _totalExpenses;
    public int TotalExpenses
    {
        get => _totalExpenses;
        set
        {
            _totalExpenses = value;
            OnPropertyChanged();
        }
    }

    // 🔷 Total Amount
    private double _totalAmount;
    public double TotalAmount
    {
        get => _totalAmount;
        set
        {
            _totalAmount = value;
            OnPropertyChanged();
        }
    }

    public HomeViewModel(IExpenseService expenseService)
    {
        _expenseService = expenseService;
        LoadData();
    }

    // 🔷 Load Summary Data Only
    private async void LoadData()
    {
        var expenses = await _expenseService.GetExpenses();

        TotalExpenses = expenses.Count;
        TotalAmount = expenses.Sum(x => x.Amount);
    }
}
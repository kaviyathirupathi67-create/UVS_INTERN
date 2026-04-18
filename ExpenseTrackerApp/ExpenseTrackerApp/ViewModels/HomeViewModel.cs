using ExpenseTracker.Interfaces;

namespace ExpenseTracker.ViewModels;

public class HomeViewModel : BaseViewModel
{
    private readonly IExpenseService _expenseService;

    public int TotalCount { get; set; }
    public double TotalAmount { get; set; }

    public HomeViewModel(IExpenseService expenseService)
    {
        _expenseService = expenseService;
        LoadData();
    }

    private async Task LoadData()   // 🔥 changed (async void → Task)
    {
        var expenses = await _expenseService.GetExpenses();

        TotalCount = expenses.Count;
        TotalAmount = expenses.Sum(x => x.Amount);

        OnPropertyChanged(nameof(TotalCount));
        OnPropertyChanged(nameof(TotalAmount));
    }
}
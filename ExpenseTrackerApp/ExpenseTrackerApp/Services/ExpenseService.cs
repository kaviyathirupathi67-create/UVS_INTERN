using ExpenseTracker.Models;

public class ExpenseService : IExpenseService
{
    private List<Expense> _expenses = new();

    public Task<List<Expense>> GetExpenses()
    {
        return Task.FromResult(_expenses);
    }

    public Task AddExpense(Expense expense)
    {
        expense.Id = _expenses.Count + 1;
        _expenses.Add(expense);
        return Task.CompletedTask;
    }

    public Task DeleteExpense(int id)
    {
        var exp = _expenses.FirstOrDefault(x => x.Id == id);
        if (exp != null)
            _expenses.Remove(exp);

        return Task.CompletedTask;
    }
}
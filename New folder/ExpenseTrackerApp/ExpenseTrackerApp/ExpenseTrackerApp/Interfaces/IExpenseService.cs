using ExpenseTrackerApp.Models;

public interface IExpenseService
{
    Task<List<Expense>> GetExpenses();
    Task AddExpense(Expense expense);
    Task DeleteExpense(int id);
    Task UpdateExpense(Expense expense);
}

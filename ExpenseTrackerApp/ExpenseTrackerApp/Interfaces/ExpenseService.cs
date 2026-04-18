using ExpenseTracker.Models;

public interface IExpenseService
{
    Task<List<Expense>> GetExpenses();
    Task AddExpense(Expense expense);
    Task DeleteExpense(int id);
}
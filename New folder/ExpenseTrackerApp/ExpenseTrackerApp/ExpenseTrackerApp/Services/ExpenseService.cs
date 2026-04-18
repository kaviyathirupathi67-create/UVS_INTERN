using ExpenseTrackerApp.Models;

namespace ExpenseTrackerApp.Services;

public class ExpenseService : IExpenseService
{
    private readonly DatabaseService _dbService;

    public ExpenseService(DatabaseService dbService)
    {
        _dbService = dbService;
    }

    public async Task<List<Expense>> GetExpenses()
    {
        await _dbService.Init();
        return await _dbService.GetDb().Table<Expense>().ToListAsync();
    }

    public async Task AddExpense(Expense expense)
    {
        await _dbService.Init();
        await _dbService.GetDb().InsertAsync(expense);
    }

    public async Task DeleteExpense(int id)
    {
        await _dbService.Init();
        await _dbService.GetDb().DeleteAsync<Expense>(id);
    }

    public async Task UpdateExpense(Expense expense)
    {
        await _dbService.Init();
        await _dbService.GetDb().UpdateAsync(expense);
    }
}
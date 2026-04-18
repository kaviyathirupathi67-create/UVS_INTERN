using SQLite;
using ExpenseTrackerApp.Models;

namespace ExpenseTrackerApp.Services;
public class DatabaseService
{
    private SQLiteAsyncConnection _db;

    public async Task Init()
    {
        if (_db != null) return;

        var path = Path.Combine(FileSystem.AppDataDirectory, "expenses.db");
        _db = new SQLiteAsyncConnection(path);

        await _db.CreateTableAsync<Category>();
        await _db.CreateTableAsync<Expense>();
    }

    public SQLiteAsyncConnection GetDb() => _db;
}
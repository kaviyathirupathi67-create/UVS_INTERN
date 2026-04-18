using ExpenseTrackerApp.Interfaces;
using ExpenseTrackerApp.Models;

public class CategoryService : ICategoryService
{
    private readonly DatabaseService _dbService;

    public CategoryService(DatabaseService dbService)
    {
        _dbService = dbService;
    }

    public async Task<List<Category>> GetCategories()
    {
        await _dbService.Init();
        return await _dbService.GetDb().Table<Category>().ToListAsync();
    }

    public async Task AddCategory(Category category)
    {
        await _dbService.Init();
        await _dbService.GetDb().InsertAsync(category);
    }

    public async Task DeleteCategory(int id)
    {
        await _dbService.Init();
        await _dbService.GetDb().DeleteAsync<Category>(id);
    }

    public async Task UpdateCategory(Category category)
    {
        await _dbService.Init();
        await _dbService.GetDb().UpdateAsync(category);
    }
}
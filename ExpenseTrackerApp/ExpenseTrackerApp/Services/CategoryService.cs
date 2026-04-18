using ExpenseTracker.Models;
namespace ExpenseTracker.Services;
public class CategoryService : ICategoryService
{
    private List<Category> _categories = new()
    {
        new Category { Id = 1, Name = "Food", Icon = "🍔" },
        new Category { Id = 2, Name = "Transport", Icon = "🚌" }
    };

    public Task<List<Category>> GetCategories()
    {
        return Task.FromResult(_categories);
    }

    public Task AddCategory(Category category)
    {
        category.Id = _categories.Count + 1;
        _categories.Add(category);
        return Task.CompletedTask;
    }

    public Task DeleteCategory(int id)
    {
        var cat = _categories.FirstOrDefault(x => x.Id == id);
        if (cat != null)
            _categories.Remove(cat);

        return Task.CompletedTask;
    }
}
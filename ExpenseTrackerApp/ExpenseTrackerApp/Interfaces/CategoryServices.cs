using ExpenseTracker.Models;

public interface ICategoryService
{
    Task<List<Category>> GetCategories();
    Task AddCategory(Category category);
    Task DeleteCategory(int id);
}
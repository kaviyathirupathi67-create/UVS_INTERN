using System;
using System.Collections.Generic;
using System.Text;
using ExpenseTrackerApp.Models;

namespace ExpenseTrackerApp.Interfaces
{
    public interface ICategoryService

    {
        Task<List<Category>> GetCategories();
        Task AddCategory(Category category);
        Task DeleteCategory(int id);
        Task UpdateCategory(Category category);
    }
}
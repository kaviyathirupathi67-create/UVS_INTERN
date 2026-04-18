using System.Collections.ObjectModel;
using System.Windows.Input;
using ExpenseTrackerApp.Models;
using ExpenseTrackerApp.Interfaces;

namespace ExpenseTrackerApp.ViewModels;

public class CategoryViewModel
{
    private readonly ICategoryService _categoryService;

    public ObservableCollection<Category> Categories { get; set; } = new();

    public string NewCategoryName { get; set; }
    public string NewCategoryIcon { get; set; }

    public ICommand AddCommand { get; }
    public ICommand DeleteCommand { get; }

    public CategoryViewModel(ICategoryService categoryService)
    {
        _categoryService = categoryService;

        AddCommand = new Command(async () => await AddCategory());
        DeleteCommand = new Command<int>(async (id) => await DeleteCategory(id));

        LoadCategories();
    }

    private async void LoadCategories()
    {
        var list = await _categoryService.GetCategories();

        Categories.Clear();
        foreach (var item in list)
            Categories.Add(item);
    }

    private async Task AddCategory()
    {
        if (string.IsNullOrWhiteSpace(NewCategoryName))
            return;

        await _categoryService.AddCategory(new Category
        {
            Name = NewCategoryName,
            Icon = NewCategoryIcon
        });

        NewCategoryName = string.Empty;
        NewCategoryIcon = string.Empty;

        LoadCategories();
    }

    private async Task DeleteCategory(int id)
    {
        await _categoryService.DeleteCategory(id);
        LoadCategories();
    }
}
using ExpenseTracker.Interfaces;
using ExpenseTracker.Services;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder.Services.AddSingleton<ICategoryService, CategoryService>();
        builder.Services.AddSingleton<IExpenseService, ExpenseService>();

        return builder.Build();
    }
}
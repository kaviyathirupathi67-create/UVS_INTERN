using Microsoft.Extensions.Logging;
using ExpenseTrackerApp.Interfaces;
using ExpenseTrackerApp.Services;
using ExpenseTrackerApp.ViewModels;
using ExpenseTrackerApp.Views;

namespace ExpenseTrackerApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        builder.Services.AddSingleton<ICategoryService, CategoryService>();
        builder.Services.AddSingleton<IExpenseService, ExpenseService>();
        builder.Services.AddSingleton<DatabaseService>();

        builder.Services.AddTransient<HomeViewModel>();
        builder.Services.AddTransient<CategoryViewModel>();
        builder.Services.AddTransient<ExpenseViewModel>();
        builder.Services.AddTransient<AddExpenseViewModel>();

        builder.Services.AddTransient<HomePage>();
        builder.Services.AddTransient<CategoryPage>();
        builder.Services.AddTransient<ExpensePage>();
        builder.Services.AddTransient<AddExpensePage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
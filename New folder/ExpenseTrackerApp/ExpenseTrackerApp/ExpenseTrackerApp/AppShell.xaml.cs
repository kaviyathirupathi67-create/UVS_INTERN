namespace ExpenseTrackerApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // 🔥 Register routes (for navigation)
        Routing.RegisterRoute(nameof(Views.AddExpensePage), typeof(Views.AddExpensePage));
    }
}
using ExpenseTrackerApp.Services;
namespace ExpenseTrackerApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // 🔥 Start App with Shell Navigation
        MainPage = new AppShell();
    }
}
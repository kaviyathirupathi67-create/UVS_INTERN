namespace ExpenseTrackerApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        //App start navigation
        MainPage = new AppShell();
    }
}
namespace StudentTaskManager;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

          // First page load
        MainPage = new AppShell();
    }
}
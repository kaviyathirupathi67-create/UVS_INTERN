using SkillUp.Platform; 

namespace SkillUp.Platform;
public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
    }
}
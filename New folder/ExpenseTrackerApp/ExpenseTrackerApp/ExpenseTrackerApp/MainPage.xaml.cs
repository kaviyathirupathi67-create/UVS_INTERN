namespace ExpenseTrackerApp;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        ClickButton.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(ClickButton.Text);
    }
}
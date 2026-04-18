namespace StudentTaskManager.Views;

public partial class AddTaskPage : ContentPage
{
    public AddTaskPage()
    {
        InitializeComponent();
    }
    private void OnSaveClicked(object sender, EventArgs e)
    {
        DisplayAlert("Saved", "Task Added!", "OK");
    }
}
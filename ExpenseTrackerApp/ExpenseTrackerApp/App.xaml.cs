public class HomeViewModel
{
    public async Task LoadData()
    {
        var expenses = await _expenseService.GetExpenses();
    }
}
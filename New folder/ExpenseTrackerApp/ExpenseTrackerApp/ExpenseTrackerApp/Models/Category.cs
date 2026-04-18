using SQLite;

namespace ExpenseTrackerApp.Models;

public class Category
{
    [PrimaryKey,AutoIncrement]
    public int Id { get; set; }

    public string?Name { get; set; }

    public string Icon { get; set; }
}
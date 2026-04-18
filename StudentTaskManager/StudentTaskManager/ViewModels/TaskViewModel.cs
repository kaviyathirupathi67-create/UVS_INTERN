using System.Collections.ObjectModel;
using System.Windows.Input;
using StudentTaskManager.Models;

namespace StudentTaskManager.ViewModels
{
    public class TaskViewModel
    {
        public ObservableCollection<TaskItem> Tasks { get; set; }

        public ICommand AddTaskCommand { get; }

        public TaskViewModel()
        {
            Tasks = new ObservableCollection<TaskItem>();

            AddTaskCommand = new Command(AddTask);
        }

        private void AddTask()
        {
            Tasks.Add(new TaskItem
            {
                Title = "New Task",
                Description = "Description here",
                DueDate = DateTime.Now,
                IsCompleted = false
            });
        }
    }
}
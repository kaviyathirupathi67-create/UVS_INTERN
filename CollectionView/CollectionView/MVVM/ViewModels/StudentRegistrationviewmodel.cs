using Collectionview.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Collectionview.MVVM.ViewModels
{
    public class StudentRegistrationviewmodel
    {
        public ObservableCollection<Student> RegisteredStudents { get; set; }
        public StudentRegistrationviewmodel()
        {
            RegisteredStudents = new ObservableCollection<Student>
            {
                new Student {Name = "Alice", Age = 20 },
                new Student { Name = "Bob", Age = 22 },
                new Student { Name = "Charlie", Age = 19 }
            };
        }
    }
}

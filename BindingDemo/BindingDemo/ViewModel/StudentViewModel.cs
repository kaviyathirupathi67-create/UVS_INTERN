using BindingDemo.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace BindingDemo.ViewModel
{
    public partial class StudentViewModel : ObservableObject
    {
        private Student _student;

        public string _firstName;

        public string FirstName
        {
            get => _firstName;
            set {
                if (_firstName != value)
                {
                    _firstName = value;
                }
            }
        }
        public string _lastName;
        public string LastName
        {
            get => _lastName;
            set
            {
                if (_lastName != value)
                {
                   _lastName = value;
                }
            }
        }

        public string _fullName = "Please Enter the Name";
        

        public string FullName
        {
            get => _fullName;
            set
            {
                if (_fullName != value)
                {
                    _fullName = value;
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }

        public StudentViewModel()
        {
            _student = new Student(); 
        }
        [RelayCommand]
         private void GenerateName()
        {
            FullName = $"Hello,{FirstName}{LastName} Relay Command Working!";
        }
    }
}


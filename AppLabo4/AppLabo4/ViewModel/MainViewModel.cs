using AppLabo4.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLabo4.ViewModel
{
    public class MainViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private ObservableCollection<Student> _students;

        public ObservableCollection<Student> Students
        {
            get { return _students; }
            set
            {
                _students = value;
                RaisePropertyChanged("Students");
            }
        }
        public MainViewModel()
        {
            Students = new ObservableCollection<Student>(AllStudents.GetAllStudents());
        }
        private Student _selectedStudent;

        public Student SelectedStudent
        {
            get { return _selectedStudent; }
            set {
                    _selectedStudent = value;
                    if (_selectedStudent != null)
                    {
                        RaisePropertyChanged("SelectedStudent");
                    }
                }
        }
        private INavigationService _navigationService;
        [PreferredConstructor]
        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            Students = new ObservableCollection<Student>(AllStudents.GetAllStudents());
        }

    }
}

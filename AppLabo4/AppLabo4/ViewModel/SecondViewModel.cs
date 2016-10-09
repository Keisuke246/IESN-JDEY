using AppLabo4.Model;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;

namespace AppLabo4.ViewModel
{
    public class SecondViewModel
    {
        public Student SelectedStudent { get; set; }

        private INavigationService _navigationService;

        public SecondViewModel(INavigationService navigationService = null)
        {
            _navigationService = navigationService;
        }
        public void OnNavigatedTo(NavigationEventArgs e)
        {
            SelectedStudent = (Student)e.Parameter;
        }
    }
}

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace SmartCity.ViewModel
{
    public class HamburgerMenuViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private INavigationService _navigationService;
        public HamburgerMenuViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        private ListBoxItem _selectedSource;
        public ListBoxItem SelectedSource
        {
            get { return _selectedSource; }
            set
            {
                _selectedSource = value;
                RaisePropertyChanged("SelectedSource");

                if (_selectedSource.Name.Equals("AddRiddleItem"))
                    _navigationService.NavigateTo("MainPage");
                else if (_selectedSource.Name.Equals("AddPathItem"))
                    _navigationService.NavigateTo("AddPathPage");
                else if (_selectedSource.Name.Equals("AddStepItem"))
                    _navigationService.NavigateTo("AddStepPage");
            }
        }
    }
}

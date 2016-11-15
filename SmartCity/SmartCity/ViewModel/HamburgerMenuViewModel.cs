using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using SmartCity.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
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
                    _mainFrame.Navigate(typeof(AddRiddlePage));
                else if (_selectedSource.Name.Equals("AddPathItem"))
                    _mainFrame.Navigate(typeof(AddPathPage));
                else if (_selectedSource.Name.Equals("AddStepItem"))
                    _mainFrame.Navigate(typeof(AddStepPage));
            }
        }
        private Frame _mainFrame;

        public Frame MainFrame
        {
            get { return _mainFrame; }
            set {
                _mainFrame = value;
                RaisePropertyChanged("MainFrame");
            }
        }

    }
}

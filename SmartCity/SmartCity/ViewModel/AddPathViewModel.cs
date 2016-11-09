using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;

namespace SmartCity.ViewModel
{
    public class AddPathViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private INavigationService _navigationService;
        [PreferredConstructor]
        public AddPathViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}

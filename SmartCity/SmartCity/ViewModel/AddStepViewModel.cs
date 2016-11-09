using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity.ViewModel
{
    public class AddStepViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private INavigationService _navigationService;
        [PreferredConstructor]
        public AddStepViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}

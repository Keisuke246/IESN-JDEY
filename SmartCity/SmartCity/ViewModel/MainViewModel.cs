﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using SmartCity.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity.ViewModel
{
    public class MainViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private ObservableCollection<Enigme> _enigmes;

        public ObservableCollection<Enigme> Enigmes
        {
            get { return _enigmes; }
            set
            {
                _enigmes = value;
                RaisePropertyChanged("Enigmes");
            }
        }
        private INavigationService _navigationService;
        [PreferredConstructor]
        public MainViewModel(INavigationService navigationService)
        {
            Enigmes = new ObservableCollection<Enigme>(AllEnigme.GetAllEnigmes());
            _navigationService = navigationService;
        }
    }
}

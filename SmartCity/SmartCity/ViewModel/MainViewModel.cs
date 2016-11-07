using GalaSoft.MvvmLight;
using SmartCity.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private Enigme _enigme;
        private String _questions;

        public String Questions
        {
            get { return _questions; }
            set { _questions = value;
                RaisePropertyChanged("Questions");
            }
        }


        public Enigme Enigme
        {
            get { return _enigme; }
            set
            {
                _enigme = value;
                RaisePropertyChanged("Enigme");
            }
        }
    }
}

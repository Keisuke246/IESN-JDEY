using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using SmartCity.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();

            NavigationService navigationPages = new NavigationService();
            SimpleIoc.Default.Register<INavigationService>(() => navigationPages);
            navigationPages.Configure("MainPage", typeof(MainPage));
            navigationPages.Configure("AddStepPage", typeof(AddStepPage));
            navigationPages.Configure("AddPathPage", typeof(AddPathPage));
        }
        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
        public AddPathViewModel AddPath
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AddPathViewModel>();
            }
        }
        public AddStepViewModel AddStep
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AddStepViewModel>();
            }
        }
    }
}

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
            SimpleIoc.Default.Register<AddRiddleViewModel>();
            SimpleIoc.Default.Register<AddStepViewModel>();
            SimpleIoc.Default.Register<AddPathViewModel>();
            SimpleIoc.Default.Register<HamburgerMenuViewModel>();

            NavigationService navigationPages = new NavigationService();
            SimpleIoc.Default.Register<INavigationService>(() => navigationPages);
            navigationPages.Configure("AddRiddlePage", typeof(AddRiddlePage));
            navigationPages.Configure("AddStepPage", typeof(AddStepPage));
            navigationPages.Configure("AddPathPage", typeof(AddPathPage));
            navigationPages.Configure("HamburgerMenu", typeof(HamburgerMenu));
        }
        public AddRiddleViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AddRiddleViewModel>();
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
        public HamburgerMenuViewModel HamMenu
        {
            get
            {
                return ServiceLocator.Current.GetInstance<HamburgerMenuViewModel>();
            }
        }
    }
}

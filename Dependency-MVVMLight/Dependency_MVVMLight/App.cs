using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dependency_MVVMLight.ViewModels;
using Dependency_MVVMLight.Views;
using Xamarin.Forms;

namespace Dependency_MVVMLight
{
    public class App: Application
    {
        public App()
        {
            this.MainPage = new MainPage();
        }

        private static ViewModelLocator _locator;

        public static ViewModelLocator Locator
        {
            get
            {
                return _locator ?? (_locator = new ViewModelLocator());
            }
        }
    }
}

using MvvmLight_Sample.ViewModels;
using MvvmLight_Sample.Views;
using Xamarin.Forms;

namespace MvvmLight_Sample
{
    public class App: Application
    {
        public App()
        {
            this.MainPage = new MainView();
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

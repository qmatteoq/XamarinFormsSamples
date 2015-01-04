using System.Diagnostics;
using System.Linq.Expressions;
using Navigation.Views;
using Xamarin.Forms;

namespace Navigation
{
    public class App : Application
    {
        public App()
        {
            NavigationPage navigationPage = new NavigationPage(new MainView());

            this.MainPage = navigationPage;
        }

        protected override void OnStart()
        {
            Debug.WriteLine("Application started");
        }

        protected override void OnSleep()
        {
            Debug.WriteLine("Application suspended");
        }

        protected override void OnResume()
        {
            Debug.WriteLine("Application resumed");
        }
    }
}

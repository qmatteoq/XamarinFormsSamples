using Views.Views;
using Xamarin.Forms;

namespace Views
{
    public class App : Application
    {
        public App()
        {
            TabbedPage tabbedPage = new TabbedPage {Title = "Tabbed page"};
            tabbedPage.Children.Add(new MainView());
            tabbedPage.Children.Add(new SecondView());

            this.MainPage = tabbedPage;

        }
    }
}

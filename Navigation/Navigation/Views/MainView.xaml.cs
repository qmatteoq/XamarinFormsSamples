using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Navigation.Views
{
    public partial class MainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            Debug.WriteLine("Page is appearing");
        }

        protected override void OnDisappearing()
        {
            Debug.WriteLine("Page is disappearing");
        }

        private async void OnGoToTabbedPageClicked(object sender, EventArgs e)
        {
            TabbedPage tabbedPage = new TabbedPage();

            tabbedPage.Children.Add(new FirstView());
            tabbedPage.Children.Add(new SecondView());

            await Navigation.PushAsync(tabbedPage);
        }

        private async void OnGoToNavigationPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DetailView());
        }

        private async void OnGoToModalPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new DetailModalView());
        }
    }
}

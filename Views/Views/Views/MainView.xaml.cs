using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Views.Views
{
    public partial class MainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        private async void OnNavigateToTabbedPageSample(object sender, EventArgs e)
        {
            TabbedPage tabbedPage = new TabbedPage {Title = "Tabbed page"};
            tabbedPage.Children.Add(new FirstView());
            tabbedPage.Children.Add(new SecondView());

            await Navigation.PushAsync(tabbedPage);
        }

        private async void OnNavigateToCarouselPageSample(object sender, EventArgs e)
        {
            CarouselPage carouselPage = new CarouselPage {Title = "Carousel page"};
            carouselPage.Children.Add(new FirstView());
            carouselPage.Children.Add(new SecondView());

            await Navigation.PushAsync(carouselPage);
        }
    }
}

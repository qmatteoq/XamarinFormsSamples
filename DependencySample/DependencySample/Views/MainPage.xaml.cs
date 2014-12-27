using System;
using DependencySample.Services;
using Xamarin.Forms;

namespace DependencySample.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            IPopupService popupService = DependencyService.Get<IPopupService>();
            popupService.ShowPopup("Sample title", "Sample message");
        }
    }
}

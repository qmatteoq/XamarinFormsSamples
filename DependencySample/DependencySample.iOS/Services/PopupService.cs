using DependencySample.iOS.Services;
using DependencySample.Services;
using MonoTouch.UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(PopupService))]
namespace DependencySample.iOS.Services
{
    public class PopupService: IPopupService
    {
        public void ShowPopup(string title, string message)
        {
            UIAlertView alert = new UIAlertView();
            alert.Title = title;
            alert.Message = message;
            alert.Show();
        }
    }
}

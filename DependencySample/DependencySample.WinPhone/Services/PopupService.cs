using System.Windows;
using DependencySample.Services;
using DependencySample.WinPhone.Services;


[assembly: Xamarin.Forms.Dependency(typeof(PopupService))]
namespace DependencySample.WinPhone.Services
{
    public class PopupService: IPopupService
    {
        public void ShowPopup(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButton.OK);
        }
    }
}

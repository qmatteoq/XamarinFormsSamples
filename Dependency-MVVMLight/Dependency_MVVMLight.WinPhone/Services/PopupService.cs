using System.Windows;
using Dependency_MVVMLight.Services;
using Dependency_MVVMLight.WinPhone.Services;

[assembly: Xamarin.Forms.Dependency(typeof(PopupService))]
namespace Dependency_MVVMLight.WinPhone.Services
{
    public class PopupService: IPopupService
    {
        public void ShowPopup(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButton.OK);
        }
    }
}

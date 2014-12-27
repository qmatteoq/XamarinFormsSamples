using Android.App;
using Dependency_MVVMLight.Droid.Services;
using Dependency_MVVMLight.Services;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(PopupService))]
namespace Dependency_MVVMLight.Droid.Services
{
    public class PopupService: IPopupService
    {
        public void ShowPopup(string title, string message)
        {
            AlertDialog.Builder alert = new AlertDialog.Builder(Forms.Context);
            alert.SetTitle(title)
                .SetMessage(message)
                .SetPositiveButton("Ok", (sender, args) =>
                {
                    
                })
                .Show();
        }
    }
}
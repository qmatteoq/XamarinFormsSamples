using Android.App;
using DependencySample.Droid.Services;
using DependencySample.Services;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(PopupService))]
namespace DependencySample.Droid.Services
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
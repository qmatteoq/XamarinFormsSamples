using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

namespace Dependency_MVVMLight.WinPhone
{
    public partial class MainPage : FormsApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

            Forms.Init();
            LoadApplication(new Dependency_MVVMLight.App());
        }
    }
}

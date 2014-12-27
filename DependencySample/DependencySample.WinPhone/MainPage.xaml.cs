using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

namespace DependencySample.WinPhone
{
    public partial class MainPage : FormsApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

            Forms.Init();
            LoadApplication(new DependencySample.App());
        }
    }
}

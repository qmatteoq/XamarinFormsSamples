using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

namespace Views.WinPhone
{
    public partial class MainPage : FormsApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

            Forms.Init();
            LoadApplication(new global::Views.App());
        }
    }
}

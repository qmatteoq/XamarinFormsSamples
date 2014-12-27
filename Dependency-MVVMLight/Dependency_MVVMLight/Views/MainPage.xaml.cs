namespace Dependency_MVVMLight.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = App.Locator.Main;
        }
    }
}

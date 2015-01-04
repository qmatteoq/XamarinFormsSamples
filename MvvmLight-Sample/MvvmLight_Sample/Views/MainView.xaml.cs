using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLight_Sample.Views
{
    public partial class MainView
    {
        public MainView()
        {
            InitializeComponent();
            this.BindingContext = App.Locator.MainViewModel;
        }
    }
}

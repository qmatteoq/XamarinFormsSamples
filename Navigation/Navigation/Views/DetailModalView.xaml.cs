using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation.Views
{
    public partial class DetailModalView
    {
        public DetailModalView()
        {
            InitializeComponent();
        }

        private async void OnGoBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}

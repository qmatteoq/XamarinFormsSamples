using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DependencySample.Views;
using Xamarin.Forms;

namespace DependencySample
{
    public class App : Application
    {
        public App()
        {
            this.MainPage = new MainPage();
        }
    }
}

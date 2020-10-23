using System;
using Xamarin.Forms;
using System.Windows.Input;
using Xamarin.Forms.Xaml;


namespace XamarinElements
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Home());
        }
    }
}

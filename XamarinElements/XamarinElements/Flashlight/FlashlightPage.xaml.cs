using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinElements.Flashlight
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlashlightPage : ContentPage
    {
        public FlashlightPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Xamarin.Essentials.Flashlight.TurnOnAsync();
            }
            catch (Exception)
            {
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                await Xamarin.Essentials.Flashlight.TurnOffAsync();
            }
            catch (Exception)
            {
            }
        }
    }
}
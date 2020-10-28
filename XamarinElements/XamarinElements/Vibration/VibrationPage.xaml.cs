using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinElements.Vibration
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VibrationPage : ContentPage
    {
        public VibrationPage()
        {
            InitializeComponent();
        }

        private void Button_Pressed(object sender, EventArgs e)
        {
            Xamarin.Essentials.Vibration.Vibrate();
        }

        private void Button_Released(object sender, EventArgs e)
        {
            Xamarin.Essentials.Vibration.Cancel();
        }
    }
}
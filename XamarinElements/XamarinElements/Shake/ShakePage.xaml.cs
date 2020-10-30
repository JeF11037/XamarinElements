using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinElements.Shake
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShakePage : ContentPage
    {
        SensorSpeed speed = SensorSpeed.Game;
        public ShakePage()
        {
            InitializeComponent();
            Accelerometer.ShakeDetected += Accelerometer_ShakeDetected;
            Accelerometer.Start(SensorSpeed.Default);
        }

        private async void Accelerometer_ShakeDetected(object sender, EventArgs e)
        {
            lbl.Text = "You´re SHAKING !!!";
            lbl.TextColor = Color.WhiteSmoke;
            lbl.BackgroundColor = Color.LawnGreen;
            lbl.FontSize = 30;
            await Task.Delay(1000);
            lbl.Text = "You´re not shaking";
            lbl.TextColor = Color.Black;
            lbl.BackgroundColor = Color.PaleVioletRed;
            lbl.FontSize = 22;
        }
    }
}
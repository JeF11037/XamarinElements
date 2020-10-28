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
            Xamarin.Essentials.Accelerometer.ShakeDetected += Accelerometer_ShakeDetected;
        }

        private void Accelerometer_ShakeDetected(object sender, EventArgs e)
        {
            lbl.Text = "You`re SHAKING !!!";
            lbl.TextColor = Color.WhiteSmoke;
            lbl.BackgroundColor = Color.LawnGreen;
            lbl.FontSize = 30;
        }

        public void ToggleAccelerometer()
        {
            try
            {
                if (Accelerometer.IsMonitoring)
                    Accelerometer.Stop();
                else
                    Accelerometer.Start(speed);
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature not supported on device
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }
    }
}
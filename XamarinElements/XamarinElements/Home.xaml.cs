using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinElements.TextToSpeech;
using XamarinElements.PanGesture;
using XamarinElements.Vibration;
using XamarinElements.Shake;
using XamarinElements.Information;

namespace XamarinElements
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        string[] BTN_names = new string[8]
        { 
            "PanGesture", "TextToSpeech", "Vibration", "Shake", "Information", "6", "7", "8"
        };
        public Home()
        {
            InitializeComponent();

            for (int tick = 0; tick < 8; tick++)
            {
                Button btn = new Button
                {
                    Text = BTN_names[tick],
                    WidthRequest = 150,
                    HeightRequest = 50,
                    Margin = 10,
                };
                btn.Clicked += Btn_Clicked;
                stack.Children.Add(btn);
            }
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            Button BTN_temp = (Button)sender;
            switch (BTN_temp.Text)
            {
                case "PanGesture":
                    await Navigation.PushAsync(new PanGesturePage());
                    break;
                case "TextToSpeech":
                    await Navigation.PushAsync(new TextToSpeechPage());
                    break;
                case "Vibration":
                    await Navigation.PushAsync(new VibrationPage());
                    break;
                case "Shake":
                    await Navigation.PushAsync(new ShakePage());
                    break;
                case "Information":
                    await Navigation.PushAsync(new InformationPage());
                    break;
            }
        }
    }
}
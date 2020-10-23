using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinElements.TextToSpeech
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextToSpeechPage : ContentPage
    {
        public TextToSpeechPage()
        {
            InitializeComponent();
            SpeakNowDefaultSettings();
        }

        public async Task SpeakNowDefaultSettings()
        {
            await TextToSpeech.SpeakAsync("Hello World");
        }
    }
}
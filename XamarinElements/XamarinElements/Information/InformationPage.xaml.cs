using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinElements.Information
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InformationPage : ContentPage
    {
        public InformationPage()
        {
            InitializeComponent();
            ChangeLabelText();
            DeviceDisplay.MainDisplayInfoChanged += OnMainDisplayInfoChanged;
        }

        private void OnMainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
        {
            if (DeviceDisplay.MainDisplayInfo.Orientation.ToString() == "Portait")
            {
                ChangeLabelText();
            }
            else
            {
                ChangedLabelText();
            }
        }

        private void ChangedLabelText()
        {
            lbl.Text = "Display Info" +
                       "\nOrientation: " + DeviceDisplay.MainDisplayInfo.Orientation.ToString() +
                       "\nRotation: " + DeviceDisplay.MainDisplayInfo.Rotation.ToString() +
                       "\nWidth: " + DeviceDisplay.MainDisplayInfo.Width.ToString() +
                       "\nHeight: " + DeviceDisplay.MainDisplayInfo.Height.ToString() +
                       "\nDensity: " + DeviceDisplay.MainDisplayInfo.Density.ToString();
        }

        private void ChangeLabelText() 
        {
            lbl.Text = "Display Info" +
                       "\nOrientation: " + DeviceDisplay.MainDisplayInfo.Orientation.ToString() +
                       "\nRotation: " + DeviceDisplay.MainDisplayInfo.Rotation.ToString() +
                       "\nWidth: " + DeviceDisplay.MainDisplayInfo.Width.ToString() +
                       "\nHeight: " + DeviceDisplay.MainDisplayInfo.Height.ToString() +
                       "\nDensity: " + DeviceDisplay.MainDisplayInfo.Density.ToString() +
                       "\n\nDevice Info" +
                       "\nModel: " + DeviceInfo.Model.ToString() +
                       "\nManufacturer: " + DeviceInfo.Manufacturer.ToString() +
                       "\nName: " + DeviceInfo.Name.ToString() +
                       "\nVersion: " + DeviceInfo.VersionString.ToString() +
                       "\nPlatform: " + DeviceInfo.Platform.ToString() +
                       "\nIdiom: " + DeviceInfo.Idiom.ToString() +
                       "\nType: " + DeviceInfo.DeviceType.ToString() +
                       "\n\nApplication Info" +
                       "\nName: " + AppInfo.Name.ToString() +
                       "\nPackage: " + AppInfo.PackageName.ToString() +
                       "\nVersion: " + AppInfo.VersionString.ToString() +
                       "\nBuild: " + AppInfo.BuildString.ToString();
        }
    }
}
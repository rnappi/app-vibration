using System;
using System.ComponentModel;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppVibrate.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void OnStopVibrationClicked(object sender, EventArgs e)
        {
            Vibration.Cancel();
        }


        private void OnStartVibrationClicked(object sender, EventArgs args)
        {
            var duration = TimeSpan.FromSeconds(10);
            Vibration.Vibrate(duration);
        }
    }
}
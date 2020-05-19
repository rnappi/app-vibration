using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppVibrate.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://xamarin.com"));
        }

        public ICommand OpenWebCommand { get; }

        public ICommand StartVibration()
        {
            var duration = TimeSpan.FromSeconds(10);
            return new Command(() => Vibration.Vibrate(duration));
        }

        public ICommand StopVibration => new Command(() => Vibration.Cancel());
    }
}
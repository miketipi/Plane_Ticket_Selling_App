using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DoAnCNLTDNT.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Về chúng tôi";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://github.com/miketipi"));
        }

        public ICommand OpenWebCommand { get; }
    }
}
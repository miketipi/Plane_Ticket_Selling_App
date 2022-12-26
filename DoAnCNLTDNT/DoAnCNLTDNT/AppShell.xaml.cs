using DoAnCNLTDNT.ViewModels;
using DoAnCNLTDNT.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Windows.Input;
namespace DoAnCNLTDNT
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public ICommand HelpCommand { get; }
        
        public AppShell()
        {
            InitializeComponent();
            HelpCommand = new Command<string>(async (url) => await Browser.OpenAsync(url));

            BindingContext = this;
        }
       
        
        private  void OnMenuItemClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}

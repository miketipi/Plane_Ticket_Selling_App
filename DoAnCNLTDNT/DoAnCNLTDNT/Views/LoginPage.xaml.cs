using DoAnCNLTDNT.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DoAnCNLTDNT.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        private void SwtNhoMatKhau_Toggled(object sender, ToggledEventArgs e)
        {

        }

        private void BtnLogin_Clicked(object sender, EventArgs e)
        {

        }
    }
}
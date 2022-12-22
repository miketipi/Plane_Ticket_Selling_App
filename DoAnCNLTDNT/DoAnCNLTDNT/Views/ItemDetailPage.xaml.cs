using DoAnCNLTDNT.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DoAnCNLTDNT.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
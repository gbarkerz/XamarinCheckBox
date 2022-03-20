using System.ComponentModel;
using Xamarin.Forms;
using XamarinCheckBox.ViewModels;

namespace XamarinCheckBox.Views
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
using CalorieDetectionApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CalorieDetectionApp.Views
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
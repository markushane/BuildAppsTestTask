using System;
using today2.ViewModels.Main;
using TodayTest.ViewModels.Main;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using today2.Services;
using System.Reflection;

namespace today2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageDetailsPage : ContentPage
    {
        public ImageDetailsPage()
        {
            InitializeComponent();
            BindingContext = new ImageDetailsViewModel();
        }

            protected override void OnAppearing()
        {
            base.OnAppearing();
            ImagesCarouselView.ScrollTo(DataService.Index, animate: false);
        }
    }
}
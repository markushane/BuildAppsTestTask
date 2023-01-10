using System;
using System.Reflection;
using today2;
using today2.Services;
using TodayTest.ViewModels.Main;
using Xamarin.Forms;

namespace TodayTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
        
        private async void PopUpButton_Clicked(object sender, EventArgs e)
        {
            var isAccepted = await DisplayAlert("Question", "do u like messages", "Yes", "no");
        }

        private async void ImagesCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ImageViewModel SelectedImage = e.CurrentSelection[0] as ImageViewModel;
            if (SelectedImage != null)
            {
                DataService.Index = DataService.CachedImages.IndexOf(SelectedImage);
            }
            await Navigation.PushAsync(new ImageDetailsPage());
        }
    }
}
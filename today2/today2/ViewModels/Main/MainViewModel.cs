using TodayTest.ViewModels.Base;
using TodayTest.Services;
using System.Collections.ObjectModel;
using today2.Services;
using System.Windows.Input;
using Xamarin.Forms;
using TodayTest.Models.Image;
using today2;

namespace TodayTest.ViewModels.Main
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            Initialize();
        }
        
        public ObservableCollection<ImageViewModel> Images { get; set; } = new ObservableCollection<ImageViewModel>();

        private async void Initialize()
        {
            var imageModels = await HttpService.GetImagesASync();

            foreach (var imageModel in imageModels)
            {
                if (imageModel != null)
                {
                    ImageViewModel imageViewModel = new ImageViewModel(imageModel);
                    DataService.CachedImages.Add(imageViewModel);
                }
            }

            CacheImages();
        }

        private void CacheImages()
        {
            foreach (var ImageViewModel in DataService.CachedImages)
            {
                Images.Add(ImageViewModel);
            }
        }
    }
}


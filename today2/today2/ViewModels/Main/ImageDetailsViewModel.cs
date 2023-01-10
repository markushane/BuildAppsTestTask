using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using today2.Services;
using TodayTest.ViewModels.Main;

namespace today2.ViewModels.Main
{
    public class ImageDetailsViewModel
    {
        public ImageDetailsViewModel()
        {
            Initialize();
        }

        public ObservableCollection<ImageViewModel> Images { get; set; } = new ObservableCollection<ImageViewModel>();

        public void Initialize()
        {
            foreach (var image in DataService.CachedImages)
            {
                Images.Add(image);
            }
        }
    }
}

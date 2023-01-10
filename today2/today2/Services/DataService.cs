using System.Collections.Generic;
using System.Collections.ObjectModel;
using TodayTest.ViewModels.Main;

namespace today2.Services
{
    public static class DataService
    {
        public static List<ImageViewModel> CachedImages { get; set; } = new List<ImageViewModel>();
        public static int Index = 0;
    }
}

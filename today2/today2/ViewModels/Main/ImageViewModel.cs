using System;
using System.Data.Common;
using System.Reflection;
using System.Windows.Input;
using today2;
using TodayTest.Models.Image;
using TodayTest.ViewModels.Base;
using Xamarin.Forms;

namespace TodayTest.ViewModels.Main
{
    public class ImageViewModel:  BaseViewModel
    {
        public ImageViewModel(ImageModel imageModel)
        {
            Author = imageModel.author;
            Width = imageModel.width;
            Height = imageModel.height;  
            Url = imageModel.download_url;
            Size = (Width.ToString() + "x" + Height.ToString());
        }

        private string _id;
        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        private string _author;
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author =("Author: " + value);
                OnPropertyChanged("Author");
            }
        }

        private int _width;
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                OnPropertyChanged("Width");
            }
        }

        private int _height;
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                OnPropertyChanged("Height");
            }
        }


        private string _url;
        public string Url
        {
            get
            {
                return _url;
            }
            set
            {
                _url = value;
                OnPropertyChanged("Url");
            }
        }

        private string _size;
        public string Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = (value);
                OnPropertyChanged("Size");
            }
        }

        private string _index;
        public string Index
        {
            get
            {
                return _index;
            }
            set
            {
                _index = (value);
                OnPropertyChanged("Size");
            }
        }
    }
}

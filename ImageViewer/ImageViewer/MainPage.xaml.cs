using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageViewer
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void UpdateImage(object sender, EventArgs e)
        {
            Image.Source = new UriImageSource
            {
                Uri = new Uri(ImageUrl.Text),
                CachingEnabled = true,
                CacheValidity = new TimeSpan(5, 0, 0, 0)
            };

        }
    }
}

using System;
using System.ComponentModel;
using FFImageLoading.Forms;
using FFImageLoading.Transformations;
using FFImageLoading.Work;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ISDK.Omni.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            InitIcons();

        }

        private void InitIcons()
        {
            //var homeCachedImage = new CachedImage()
            //{
            //    HorizontalOptions = LayoutOptions.FillAndExpand,
            //    VerticalOptions = LayoutOptions.FillAndExpand,
            //    DownsampleToViewSize = true,
            //    LoadingPlaceholder = "loading.png",
            //    ErrorPlaceholder = "error.png",
            //    Transformations = new System.Collections.Generic.List<ITransformation>()
            //    {
            //    },
            //    Source = "home.svg"
            //};
            // HomeNavPage.IconImageSource = homeCachedImage.GetImageAsPngAsync();
        }
    }
}
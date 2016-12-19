using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ImageSupport
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Media.Imaging.BitmapImage", "IsPlaying"))
            {
                // You can call the Play and Stop methods safely because is the IsPlaying property is
                // present, these methods are also present.
                //if (imageSource.IsPlaying == true)
                //{
                //    Debug.WriteLine("");
                //    imageSource.Stop();
                //}
                //else
                //{
                //    Debug.WriteLine("");
                //    imageSource.Play();
                //}
                Debug.WriteLine("");
            }
        }

        private void Image_Loaded(object sender, RoutedEventArgs e)
        {
            if (ApiInformation.IsApiContractPresent("Windows.UI.Xaml.Media.Imaging.BitmapImage",14393 ) == true)
            {
                Debug.WriteLine("");
                
            }
        }
    }
}

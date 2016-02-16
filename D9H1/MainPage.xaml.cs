using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace D9H1
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

        private void truck_Button_Click(object sender, RoutedEventArgs e)
        {
            int numTrucks = int.Parse(truckTextBlock.Text) + 1;
            truckTextBlock.Text = numTrucks.ToString();
        }

        private void car_Button_Click(object sender, RoutedEventArgs e)
        {
            int numCars = int.Parse(carTextBlock.Text) + 1;
            carTextBlock.Text = numCars.ToString();
        }
    }
}

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

namespace D9H2
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


        private void euroBox_LostFocus(object sender, RoutedEventArgs e)
        {
            double number;
            bool result = double.TryParse(euroBox.Text, out number);
            if (result)
            {
                number *= 5.95;
                markkaBox.Text = number.ToString("0.00");
            }
            else
            {
                markkaBox.Text = "Conversion failed";
            }
        }

        private void markkaBox_LostFocus(object sender, RoutedEventArgs e)
        {
            double number;
            bool result = double.TryParse(markkaBox.Text, out number);
            if (result)
            {
                number /= 5.95;
                euroBox.Text = number.ToString("0.00");
            }
            else
            {
                euroBox.Text = "Conversion failed";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xaml;

namespace Weather_.ViewUserControls
{
    /// <summary>
    /// Interaction logic for MapUserControl.xaml
    /// </summary>
    public partial class MapUserControl : UserControl
    {
        public Weather_.ViewModels.ControlVM VM;
        public MapUserControl()
        {
            InitializeComponent();
        }
        private void TLV_click(object sender, RoutedEventArgs e)
        {
            this.VM.MapWeather("Tel Aviv,IL");
            this.VM.chartCity("Tel Aviv,IL");


        }
        private void Nablus_click(object sender, RoutedEventArgs e)
        {
            this.VM.MapWeather("Nablus");
            this.VM.chartCity("Nablus");


        }
        private void Zefat_click(object sender, RoutedEventArgs e)
        {
            this.VM.MapWeather("Zefat,IL");
            this.VM.chartCity("Zefat,IL");


        }

        private void Haifa_click(object sender, RoutedEventArgs e)
        {
            this.VM.MapWeather("Haifa,IL");
            this.VM.chartCity("Haifa,IL");



        }

        private void Nazareth_click(object sender, RoutedEventArgs e)
        {
            this.VM.MapWeather("Nazareth,IL");
            this.VM.chartCity("Nazareth,IL");


        }

        private void Jerusalem_click(object sender, RoutedEventArgs e)
        {
            this.VM.MapWeather("Jerusalem,IL");
            this.VM.chartCity("Jerusalem,IL");


        }
        private void Gaza_click(object sender, RoutedEventArgs e)
        {
            this.VM.MapWeather("Gaza");
            this.VM.chartCity("Gaza");


        }

        private void Beer_Sheva_click(object sender, RoutedEventArgs e)
        {

            this.VM.MapWeather("Beer Sheva,IL");
            this.VM.chartCity("Beer Sheva,IL");

        }

        private void Eilat_click(object sender, RoutedEventArgs e)
        {
            this.VM.MapWeather("Eilat,IL");
            this.VM.chartCity("Eilat,IL");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

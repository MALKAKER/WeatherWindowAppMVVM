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
using System.Windows.Shapes;

namespace Weather_
{
    /// <summary>
    /// Interaction logic for WeatherAppControl.xaml
    /// </summary>
    public partial class WeatherAppControl : Window
    {
        public Weather_.ViewModels.ControlVM VM;
        
        public WeatherAppControl()
        {
            InitializeComponent();
            VM = new Weather_.ViewModels.ControlVM(SearchBannerUserControl, DayWeatherUserControl, TableUserControl, MapUserControl,ChartUserControl);
            SearchBannerUserControl.VM = VM;
            DayWeatherUserControl.VM = VM;
            TableUserControl.VM = VM;
            MapUserControl.VM = VM;
            ChartUserControl.VM = VM;


            

        }
        

        private void ChartUserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void MapUserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void SearchBannerUserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void TableUserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void DayWeatherUserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void DayWeatherUserControl_Loaded_1(object sender, RoutedEventArgs e)
        {

        }
    }
}

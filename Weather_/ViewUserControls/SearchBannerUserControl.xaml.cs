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
    /// Interaction logic for SearchBannerUserControl.xaml
    /// </summary>
    public partial class SearchBannerUserControl : UserControl
    {
        public Weather_.ViewModels.ControlVM VM;
        public SearchBannerUserControl()
        {
         
            InitializeComponent();

           
        }
       


        public void SearchCity(object sender, RoutedEventArgs e)
        {
          
            this.VM.WeatherDay(search.Text);
            this.VM.TableWeather(search.Text);
            this.VM.chartCity(search.Text);
        }

      

    }
}

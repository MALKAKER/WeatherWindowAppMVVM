using System;
using System.Xaml;
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

namespace Weather_.ViewUserControls
{
    /// <summary>
    /// Interaction logic for DayWeatherUserControl.xaml
    /// </summary>
    public partial class DayWeatherUserControl : UserControl
    {
        public Weather_.ViewModels.ControlVM VM;
    

        public DayWeatherUserControl()
        {

            InitializeComponent();
            //bali = new BL.MyBL();
            //var output = bali.dali.GetForecast("Jerusalem");
            //cityBlock.Text = "Jerusalem";
            //ans_Temp.Text = string.Format("{0}°С", Math.Round(output.tmp_day_1, 1));
            //ans_Hum.Text = string.Format("{0}", output.humidity + "%");
            //ans_Condition.Text = string.Format("{0}", output.description1);
            //ans_Speed.Text = string.Format("{0}", output.speed + "m/s");

            //string icon1 = "../icons/" + string.Format("{0}", output.icon1) + ".png";
            //Uri imageUri1 = new Uri(icon1, UriKind.Relative);
            //BitmapImage imageBitmap1 = new BitmapImage(imageUri1);
            //image_1.Source = imageBitmap1;
            //image_1.Visibility = Visibility.Visible;
        }
        



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        
            //Map nex = new Map();
            //nex.ShowDialog();
            
        }
    }
}


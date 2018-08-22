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
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Windows.Controls;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Wpf;

namespace Weather_.ViewUserControls
{
    /// <summary>
    /// Interaction logic for ChartUserControl.xaml
    /// </summary>
    public partial class ChartUserControl : UserControl
    {
        public Weather_.ViewModels.ControlVM VM;


      
        BL.MyBL bali;
        public ChartUserControl()
        {
            
            
        //    bali = new BL.MyBL();
            InitializeComponent();
        //    var output = bali.dali.GetForecast(chartCity);

        //    double tmp_1 = Math.Round(output.tmp_day_1, 1);
        //    string day_1_ = getDate(output.day_1);
        //    double tmp_2 = Math.Round(output.tmp_day_2, 1);
        //    string day_2_ = getDate(output.day_2);
        //    double tmp_3 = Math.Round(output.tmp_day_3, 1);
        //    string day_3_ = getDate(output.day_3);
        //    double tmp_4 = Math.Round(output.tmp_day_4, 1);
        //    string day_4_ = getDate(output.day_4);
        //    double tmp_5 = Math.Round(output.tmp_day_5, 1);
        //    string day_5_ = getDate(output.day_5);
        //    double tmp_6 = Math.Round(output.tmp_day_6, 1);
        //    string day_6_ = getDate(output.day_6);

        //    SeriesCollection = new SeriesCollection
        //    {
                
               
        //};
        //    Labels = new[] { day_1_, day_2_, day_3_, day_4_, day_5_, day_6_ };
        //    YFormatter = value => value.ToString()+"°С";

        //    //modifying the series collection will animate and update the chart
        //    SeriesCollection.Add(new LineSeries
        //    {
        //        Title = "",
        //        Values = new ChartValues<double> { tmp_1 , tmp_2, tmp_3, tmp_4, tmp_5, tmp_6},
        //        LineSmoothness = 0, //0: straight lines, 1: really smooth lines
        //        PointGeometry = DefaultGeometries.Square,
        //        PointGeometrySize = 15,
        //        PointForeground = Brushes.Red
        //    });

        //    //modifying any series values will also animate and update the chart
        //    //SeriesCollection[0].Values.Add();

        //    //DataContext = this;
        //   DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }


        public String getDate(double millisecond)
        {
            DateTime day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(millisecond).ToLocalTime();
            string day_ = string.Format("{0}", day);
            int index = day_.IndexOf(' ');
            string result = day_.Substring(0, index);
            return result;
        }


    }
}

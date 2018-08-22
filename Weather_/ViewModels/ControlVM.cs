using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather_.ViewUserControls;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Media;

namespace Weather_.ViewModels
{
    public class ControlVM:INotifyPropertyChanged
    {
       static public int flag=0;
        public SearchBannerUserControl Search;
        public DayWeatherUserControl TodayWeather;
        public TableUserControl Table;
        public MapUserControl Map;
        public ChartUserControl Chart;
        private SeriesCollection _SeriesCollection;
        public SeriesCollection SeriesCollection
        {
            get
            {
                return _SeriesCollection;
            }
            set
            {
                if (_SeriesCollection != value)
                {
                    _SeriesCollection = value;
                    OnPropertyChanged("SeriesCollection");

                }
            }
        }

        BL.MyBL bali;

        
        public string[] Labels { get; private set; }
        public Func<object, object> YFormatter { get; private set; }

        #region ctor
        public ControlVM(SearchBannerUserControl search, DayWeatherUserControl todayWeather, TableUserControl Table, MapUserControl Map, ChartUserControl Chart)
        {
            this.Search = search;
            this.TodayWeather = todayWeather;
            this.Table = Table;
            this.Map = Map;
            this.Chart = Chart;
            //init
            WeatherDay("Jerusalem");
            TableWeather("Jerusalem");
            chartCity("Jerusalem");

        }
        #endregion

        #region update chart
        public void chartCity(string City)
        {
            bali = new BL.MyBL();
            try
            {
                var output = bali.dali.GetForecast(City);

                double tmp_1 = Math.Round(output.tmp_day_1, 1);
                string day_1_ = getDate(output.day_1);
                double tmp_2 = Math.Round(output.tmp_day_2, 1);
                string day_2_ = getDate(output.day_2);
                double tmp_3 = Math.Round(output.tmp_day_3, 1);
                string day_3_ = getDate(output.day_3);
                double tmp_4 = Math.Round(output.tmp_day_4, 1);
                string day_4_ = getDate(output.day_4);
                double tmp_5 = Math.Round(output.tmp_day_5, 1);
                string day_5_ = getDate(output.day_5);
                double tmp_6 = Math.Round(output.tmp_day_6, 1);
                string day_6_ = getDate(output.day_6);

                SeriesCollection = new SeriesCollection
                {


                };
                Labels = new[] { day_1_, day_2_, day_3_, day_4_, day_5_, day_6_ };
                YFormatter = value => value.ToString() + "°С";

                //modifying the series collection will animate and update the chart
                SeriesCollection.Add(new LineSeries
                {
                    Title = "",
                    Values = new ChartValues<double> { tmp_1, tmp_2, tmp_3, tmp_4, tmp_5, tmp_6 },
                    LineSmoothness = 0, //0: straight lines, 1: really smooth lines
                    PointGeometry = DefaultGeometries.Square,
                    PointGeometrySize = 15,
                    PointForeground = Brushes.Red
                });

                //modifying any series values will also animate and update the chart
                //SeriesCollection[0].Values.Add();

                //DataContext = this;


                Chart.DataContext = this;
            }
            catch(Exception)
            {

            }
            





        }
        #endregion

        #region update map
        public void MapWeather(string City)
        {
            WeatherDay(City);
            TableWeather( City);


        }
        #endregion

        #region update details
        public void WeatherDay(string City)
        {
            try
            {
                
                bali = new BL.MyBL();
                var output = bali.dali.GetForecast(City);
                TodayWeather.ans_Hum.Text = string.Format("{0}", output.humidity + "%");
                TodayWeather.ans_Condition.Text = string.Format("{0}", output.description1);
                TodayWeather.ans_Speed.Text = string.Format("{0}", output.speed + "m/s");
                TodayWeather.ans_Temp.Text = string.Format("{0}°С", Math.Round(output.tmp_day_1, 1));

                string icon1 = "../icons/" + string.Format("{0}", output.icon1) + ".png";
                Uri imageUri1 = new Uri(icon1, UriKind.Relative);
                System.Windows.Media.Imaging.BitmapImage imageBitmap1 = new System.Windows.Media.Imaging.BitmapImage(imageUri1);
                TodayWeather.image_1.Source = imageBitmap1;
                TodayWeather.image_1.Visibility = Visibility.Visible;
                TodayWeather.cityBlock.Text = output.city+","+output.country;

            }
            catch (Exception)
            {
                Search.search.Text = "";
                MessageBox.Show("Invalid city!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            



        }
        #endregion

        #region update table
        public void TableWeather(string City)
        {
            try
            {
                bali = new BL.MyBL();
                var output = bali.dali.GetForecast(City);


                day1(output);


                day2(output);

                day3(output);


                day4(output);

                day5(output);


            }
            catch (Exception)
            {
                
            }


        }
        #endregion

        #region update days
        public void day1(BE.data_weather output)
        {
            //icon:
            string icon2 = "../icons/" + string.Format("{0}", output.icon2) + ".png";
            Uri imageUri2 = new Uri(icon2, UriKind.Relative);
            BitmapImage imageBitmap2 = new BitmapImage(imageUri2);
            Table.image_2.Source = imageBitmap2;
            Table.image_2.Visibility = Visibility.Visible;

            //description
            Table.desc_2.Text = string.Format("{0}", output.description2);

            //tmp_day
            Table.tmp_day_2.Text = string.Format("{0}°С", Math.Round(output.tmp_day_2, 1));
            //tmp_night
            Table.tmp_night_2.Text = string.Format("{0}°С", Math.Round(output.tmp_night_2, 1));

            //day
            Table.day_2.Text = string.Format("{0}", getDate(output.day_2));

        }

        public void day2(BE.data_weather output)
        {
            //icon:
            string icon3 = "../icons/" + string.Format("{0}", output.icon3) + ".png";
            Uri imageUri3 = new Uri(icon3, UriKind.Relative);
            BitmapImage imageBitmap3 = new BitmapImage(imageUri3);
            Table.image_3.Source = imageBitmap3;
            Table.image_3.Visibility = Visibility.Visible;

            //description
            Table.desc_3.Text = string.Format("{0}", output.description3);

            //tmp_day
            Table.tmp_day_3.Text = string.Format("{0}°С", Math.Round(output.tmp_day_3, 1));
            //tmp_night
            Table.tmp_night_3.Text = string.Format("{0}°С", Math.Round(output.tmp_night_3, 1));

            //day
            Table.day_3.Text = string.Format("{0}", getDate(output.day_3));


        }

        public void day3(BE.data_weather output)
        {
            //icon:
            string icon4 = "../icons/" + string.Format("{0}", output.icon4) + ".png";
            Uri imageUri4 = new Uri(icon4, UriKind.Relative);
            BitmapImage imageBitmap4 = new BitmapImage(imageUri4);
            Table.image_4.Source = imageBitmap4;
            Table.image_4.Visibility = Visibility.Visible;

            //description
            Table.desc_4.Text = string.Format("{0}", output.description4);

            //tmp_day
            Table.tmp_day_4.Text = string.Format("{0}°С", Math.Round(output.tmp_day_4, 1));
            //tmp_night
            Table.tmp_night_4.Text = string.Format("{0}°С", Math.Round(output.tmp_night_4, 1));

            //day
            Table.day_4.Text = string.Format("{0}", getDate(output.day_4));

        }

        public void day4(BE.data_weather output)
        {
            //icon:
            string icon5 = "../icons/" + string.Format("{0}", output.icon5) + ".png";
            Uri imageUri5 = new Uri(icon5, UriKind.Relative);
            BitmapImage imageBitmap5 = new BitmapImage(imageUri5);
            Table.image_5.Source = imageBitmap5;
            Table.image_5.Visibility = Visibility.Visible;

            //description
            Table.desc_5.Text = string.Format("{0}", output.description5);

            //tmp_day
            Table.tmp_day_5.Text = string.Format("{0}°С", Math.Round(output.tmp_day_5, 1));
            //tmp_night
            Table.tmp_night_5.Text = string.Format("{0}°С", Math.Round(output.tmp_night_5, 1));

            //day
            Table.day_5.Text = string.Format("{0}", getDate(output.day_5));

        }

        public void day5(BE.data_weather output)
        {
            //icon:
            string icon6 = "../icons/" + string.Format("{0}", output.icon6) + ".png";
            Uri imageUri6 = new Uri(icon6, UriKind.Relative);
            BitmapImage imageBitmap6 = new BitmapImage(imageUri6);
            Table.image_6.Source = imageBitmap6;
            Table.image_6.Visibility = Visibility.Visible;

            //description
            Table.desc_6.Text = string.Format("{0}", output.description6);

            //tmp_day
            Table.tmp_day_6.Text = string.Format("{0}°С", Math.Round(output.tmp_day_6, 1));
            //tmp_night
            Table.tmp_night_6.Text = string.Format("{0}°С", Math.Round(output.tmp_night_6, 1));

            //day
            Table.day_6.Text = string.Format("{0}", getDate(output.day_6));


        }
        #endregion

        #region get date
        public String getDate(double millisecond)
        {
            DateTime day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(millisecond).ToLocalTime();
            string day_ = string.Format("{0}", day);
            int index = day_.IndexOf(' ');
            string result = day_.Substring(0, index);
            return result;
           
        }
        #endregion

        #region property changed

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_.Models
{
    public class CurrentDetailes : INotifyPropertyChanged
    {


        #region fields

        BL.MyBL bali;

        #region location
        private string _city;
        private string _country;
        #endregion

        #region description
        private string _description1;
        private string _description2;
        private string _description3;
        private string _description4;
        private string _description5;
        private string _description6;
        #endregion

        #region icons
        private string _icon1;
        private string _icon2;
        private string _icon3;
        private string _icon4;
        private string _icon5;
        private string _icon6;
        #endregion

        #region temperature
        private double _tmp_day_1;
        private double _tmp_night_1;
        private double _tmp_day_2;
        private double _tmp_night_2;
        private double _tmp_day_3;
        private double _tmp_night_3;
        private double _tmp_day_4;
        private double _tmp_night_4;
        private double _tmp_day_5;
        private double _tmp_night_5;
        private double _tmp_day_6;
        private double _tmp_night_6;
        #endregion

        #region dates
        private double _day_1;
        private double _day_2;
        private double _day_3;
        private double _day_4;
        private double _day_5;
        private double _day_6;
        #endregion

        #region humidity & speed
        private int _humidity;
        private double _speed;

        public CurrentDetailes()
        {
            bali = new BL.MyBL();

        }
        public void UpdateWeather(string searchCity)
        {
            var output = bali.dali.GetForecast(searchCity);
            City = output.city;
            Country = output.country;
            Description1 = output.description1;
            Description2 = output.description2;
            Description3 = output.description3;
            Description4 = output.description4;
            Description5 = output.description5;
            Description6 = output.description6;
            Icon1 = output.icon1;
            Icon2 = output.icon2;
            Icon3 = output.icon3;
            Icon4 = output.icon4;
            Icon5 = output.icon5;
            Icon6 = output.icon6;
            Tmp_day_1 = output.tmp_day_1;
            Tmp_night_1 = output.tmp_night_1;
            Tmp_day_2 = output.tmp_day_2;
            Tmp_night_2 = output.tmp_night_2;
            Tmp_day_3 = output.tmp_day_3;
            Tmp_night_3 = output.tmp_night_3;
            Tmp_day_4 = output.tmp_day_4;
            Tmp_night_4 = output.tmp_night_4;
            Tmp_day_5 = output.tmp_day_5;
            Tmp_night_5 = output.tmp_night_5;
            Tmp_day_6 = output.tmp_day_6;
            Tmp_night_6 = output.tmp_night_6;
            Day_1 = output.day_1;
            Day_2 = output.day_2;
            Day_3 = output.day_3;
            Day_4 = output.day_4;
            Day_5 = output.day_5;
            Day_6 = output.day_6;
            Humidity = output.humidity;
            Speed = output.speed;
            City = output.city;
            Country = output.country;
            Description1 = output.description1;
            Description2 = output.description2;
            Description3 = output.description3;
            Description4 = output.description4;
            Description5 = output.description5;
            Description6 = output.description6;
            Icon1 = output.icon1;
            Icon2 = output.icon2;
            Icon3 = output.icon3;
            Icon4 = output.icon4;
            Icon5 = output.icon5;
            Icon6 = output.icon6;
            Tmp_day_1 = output.tmp_day_1;
            Tmp_night_1 = output.tmp_night_1;
            Tmp_day_2 = output.tmp_day_2;
            Tmp_night_2 = output.tmp_night_2;
            Tmp_day_3 = output.tmp_day_3;
            Tmp_night_3 = output.tmp_night_3;
            Tmp_day_4 = output.tmp_day_4;
            Tmp_night_4 = output.tmp_night_4;
            Tmp_day_5 = output.tmp_day_5;
            Tmp_night_5 = output.tmp_night_5;
            Tmp_day_6 = output.tmp_day_6;
            Tmp_night_6 = output.tmp_night_6;
            Day_1 = output.day_1;
            Day_2 = output.day_2;
            Day_3 = output.day_3;
            Day_4 = output.day_4;
            Day_5 = output.day_5;
            Day_6 = output.day_6;
            Humidity = output.humidity;
            Speed = output.speed;
        }
        #endregion

        #endregion

        #region properties
        public string City
        {
            get { return _city; }
            set
            {
                if (_city != value)
                {
                    _city = value;
                    RaisePropertyChanged("City");
                }
            }
        }
        public string Country
        {
            get { return _country; }
            set
            {
                if (_country != value)
                {
                    _country = value;
                    RaisePropertyChanged("Courntry");
                }
            }
        }
        public string Description1
        {
            get
            {
                return _description1;
            }
            set
            {
                if (_description1 != value)
                {
                    _description1 = value;
                    RaisePropertyChanged("Description1");
                }
            }
        }
        public string Description2
        {
            get
            {
                return _description2;
            }
            set
            {
                if (_description2 != value)
                {
                    _description2 = value;
                    RaisePropertyChanged("Description2");
                }
            }
        }
        public string Description3
        {
            get
            {
                return _description3;
            }
            set
            {
                if (_description3 != value)
                {
                    _description3 = value;
                    RaisePropertyChanged("Description3");
                }
            }
        }
        public string Description4
        {
            get
            {
                return _description4;
            }
            set
            {
                if (_description4 != value)
                {
                    _description4 = value;
                    RaisePropertyChanged("Description4");
                }
            }
        }
        public string Description5
        {
            get
            {
                return _description5;
            }
            set
            {
                if (_description5 != value)
                {
                    _description5 = value;
                    RaisePropertyChanged("Description5");
                }
            }
        }
        public string Description6
        {
            get
            {
                return _description6;
            }
            set
            {
                if (_description6 != value)
                {
                    _description6 = value;
                    RaisePropertyChanged("Description6");
                }
            }
        }
        public string Icon1
        {
            get
            {
                return _icon1;
            }
            set
            {
                if (_icon1 != value)
                {
                    _icon1 = value;
                    RaisePropertyChanged("Icon1");
                }
            }
        }
        public string Icon2
        {
            get
            {
                return _icon2;
            }
            set
            {
                if (_icon2 != value)
                {
                    _icon2 = value;
                    RaisePropertyChanged("Icon2");
                }
            }
        }
        public string Icon3
        {
            get
            {
                return _icon3;
            }
            set
            {
                if (_icon3 != value)
                {
                    _icon3 = value;
                    RaisePropertyChanged("Icon3");
                }
            }
        }
        public string Icon4
        {
            get
            {
                return _icon4;
            }
            set
            {
                if (_icon4 != value)
                {
                    _icon4 = value;
                    RaisePropertyChanged("Icon4");
                }
            }
        }
        public string Icon5
        {
            get
            {
                return _icon5;
            }
            set
            {
                if (_icon5 != value)
                {
                    _icon5 = value;
                    RaisePropertyChanged("Icon5");
                }
            }
        }
        public string Icon6
        {
            get
            {
                return _icon6;
            }
            set
            {
                if (_icon6 != value)
                {
                    _icon6 = value;
                    RaisePropertyChanged("Icon6");
                }
            }
        }
        public double Tmp_day_1
        {
            get
            {
                return _tmp_day_1;
            }
            set
            {
                if (_tmp_day_1 != value)
                {
                    _tmp_day_1 = value;
                    RaisePropertyChanged("Tmp_day_1");
                }
            }
        }
        public double Tmp_night_1
        {
            get
            {
                return _tmp_night_1;
            }
            set
            {
                if (_tmp_night_1 != value)
                {
                    _tmp_night_1 = value;
                    RaisePropertyChanged("Tmp_night_1");
                }
            }
        }
        public double Tmp_day_2
        {
            get
            {
                return _tmp_day_2;
            }
            set
            {
                if (_tmp_day_2 != value)
                {
                    _tmp_day_2 = value;
                    RaisePropertyChanged("Tmp_day_2");
                }
            }
        }
        public double Tmp_night_2
        {
            get
            {
                return _tmp_night_2;
            }
            set
            {
                if (_tmp_night_2 != value)
                {
                    _tmp_night_2 = value;
                    RaisePropertyChanged("Tmp_night_2");
                }
            }
        }
        public double Tmp_day_3
        {
            get
            {
                return _tmp_day_3;
            }
            set
            {
                if (_tmp_day_3 != value)
                {
                    _tmp_day_3 = value;
                    RaisePropertyChanged("Tmp_day_3");
                }
            }
        }
        public double Tmp_night_3
        {
            get
            {
                return _tmp_night_3;
            }
            set
            {
                if (_tmp_night_3 != value)
                {
                    _tmp_night_3 = value;
                    RaisePropertyChanged("Tmp_night_3");
                }
            }
        }
        public double Tmp_day_4
        {
            get
            {
                return _tmp_day_4;
            }
            set
            {
                if (_tmp_day_4 != value)
                {
                    _tmp_day_4 = value;
                    RaisePropertyChanged("Tmp_day_4");
                }
            }
        }
        public double Tmp_night_4
        {
            get
            {
                return _tmp_night_4;
            }
            set
            {
                if (_tmp_night_4 != value)
                {
                    _tmp_night_4 = value;
                    RaisePropertyChanged("Tmp_night_4");
                }
            }
        }
        public double Tmp_day_5
        {
            get
            {
                return _tmp_day_5;
            }
            set
            {
                if (_tmp_day_5 != value)
                {
                    _tmp_day_5 = value;
                    RaisePropertyChanged("Tmp_day_5");
                }
            }
        }
        public double Tmp_night_5
        {
            get
            {
                return _tmp_night_5;
            }
            set
            {
                if (_tmp_night_5 != value)
                {
                    _tmp_night_5 = value;
                    RaisePropertyChanged("Tmp_night_5");
                }
            }
        }
        public double Tmp_day_6
        {
            get
            {
                return _tmp_day_6;
            }
            set
            {
                if (_tmp_day_6 != value)
                {
                    _tmp_day_6 = value;
                    RaisePropertyChanged("Tmp_day_6");
                }
            }
        }
        public double Tmp_night_6
        {
            get
            {
                return _tmp_night_6;
            }
            set
            {
                if (_tmp_night_6 != value)
                {
                    _tmp_night_6 = value;
                    RaisePropertyChanged("Tmp_night_6");
                }
            }
        }
        public double Day_1
        {
            get
            {
                return _day_1;
            }
            set
            {
                if (_day_1 != value)
                {
                    _day_1 = value;
                    RaisePropertyChanged("Day_1");
                }
            }
        }
        public double Day_2
        {
            get
            {
                return _day_2;
            }
            set
            {
                if (_day_2 != value)
                {
                    _day_2 = value;
                    RaisePropertyChanged("Day_2");
                }
            }
        }
        public double Day_3
        {
            get
            {
                return _day_3;
            }
            set
            {
                if (_day_3 != value)
                {
                    _day_3 = value;
                    RaisePropertyChanged("Day_3");
                }
            }
        }
        public double Day_4
        {
            get
            {
                return _day_4;
            }
            set
            {
                if (_day_4 != value)
                {
                    _day_4 = value;
                    RaisePropertyChanged("Day_4");
                }
            }
        }
        public double Day_5
        {
            get
            {
                return _day_5;
            }
            set
            {
                if (_day_5 != value)
                {
                    _day_5 = value;
                    RaisePropertyChanged("Day_5");
                }
            }
        }
        public double Day_6
        {
            get
            {
                return _day_6;
            }
            set
            {
                if (_day_6 != value)
                {
                    _day_6 = value;
                    RaisePropertyChanged("Day_6");
                }
            }
        }
        public int Humidity
        {
            get
            {
                return _humidity;
            }
            set
            {
                if (_humidity != value)
                {
                    _humidity = value;
                    RaisePropertyChanged("Humidity");
                }
            }
        }
        public double Speed
        {
            get
            {
                return _humidity;
            }
            set
            {
                if (_speed != value)
                {
                    _speed = value;
                    RaisePropertyChanged("Speed");
                }
            }
        }
        #endregion

        private void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

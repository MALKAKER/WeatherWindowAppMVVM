using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BE
{
    /// <summary>
    /// data_weather - store weather meta-data
    /// </summary>
    public class data_weather
    {
        #region constructors
        public data_weather() { }
        public data_weather(string city, string country, string description1, string description2, string description3, string description4, string description5, string description6, string icon1, string icon2, string icon3, string icon4, string icon5, string icon6, double tmp_day_1, double tmp_night_1, double tmp_day_2, double tmp_night_2, double tmp_day_3, double tmp_night_3, double tmp_day_4, double tmp_night_4, double tmp_day_5, double tmp_night_5, double tmp_day_6, double tmp_night_6, double day_1, double day_2, double day_3, double day_4, double day_5, double day_6, int humidity, double speed)
        {
            #region init region
            this.city = city;
            this.country = country;
            #endregion

            #region init description
            this.description1 = description1;
            this.description2 = description2;
            this.description3 = description3;
            this.description4 = description4;
            this.description5 = description5;
            this.description6 = description6;
            #endregion

            #region icon
            this.icon1 = icon1;
            this.icon2 = icon2;
            this.icon3 = icon3;
            this.icon4 = icon4;
            this.icon5 = icon5;
            this.icon6 = icon6;
            #endregion

            #region temperature
            this.tmp_day_1 = tmp_day_1;
            this.tmp_night_1 = tmp_night_1;
            this.tmp_day_2 = tmp_day_2;
            this.tmp_night_2 = tmp_night_2;
            this.tmp_day_3 = tmp_day_3;
            this.tmp_night_3 = tmp_night_3;
            this.tmp_day_4 = tmp_day_4;
            this.tmp_night_4 = tmp_night_4;
            this.tmp_day_5 = tmp_day_5;
            this.tmp_night_5 = tmp_night_5;
            this.tmp_day_6 = tmp_day_6;
            this.tmp_night_6 = tmp_night_6;
            #endregion

            #region day
            this.day_1 = day_1;
            this.day_2 = day_2;
            this.day_3 = day_3;
            this.day_4 = day_4;
            this.day_5 = day_5;
            this.day_6 = day_6;
            #endregion

            #region humidity and speed
            this.humidity = humidity;
            this.speed = speed;
            #endregion
        }
        #endregion

        #region properties

        [Key]
        #region location
        public string city { get; set; }
        public string country { get; set; }
        #endregion

        #region description
        public string description1 { get; set; }
        public string description2 { get; set; }
        public string description3 { get; set; }
        public string description4 { get; set; }
        public string description5 { get; set; }
        public string description6 { get; set; }
        #endregion

        #region icons
        public string icon1 { get; set; }
        public string icon2 { get; set; }
        public string icon3 { get; set; }
        public string icon4 { get; set; }
        public string icon5 { get; set; }
        public string icon6 { get; set; }
        #endregion

        #region temperature
        public double tmp_day_1 { get; set; }
        public double tmp_night_1 { get; set; }
        public double tmp_day_2 { get; set; }
        public double tmp_night_2 { get; set; }
        public double tmp_day_3 { get; set; }
        public double tmp_night_3 { get; set; }
        public double tmp_day_4 { get; set; }
        public double tmp_night_4 { get; set; }
        public double tmp_day_5 { get; set; }
        public double tmp_night_5 { get; set; }
        public double tmp_day_6 { get; set; }
        public double tmp_night_6 { get; set; }
        #endregion

        #region dates
        public double day_1 { get; set; }
        public double day_2 { get; set; }
        public double day_3 { get; set; }
        public double day_4 { get; set; }
        public double day_5 { get; set; }
        public double day_6 { get; set; }
        #endregion

        #region humidity & speed
        public int humidity { get; set; }
        public double speed { get; set; }
        #endregion

        #endregion
    }
}

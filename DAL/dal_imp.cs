using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Web.Script.Serialization;
using static DAL._Default;
using BE;
using System.Data.Entity;

namespace DAL
{
    public partial class _Default
    {
        /// <summary>
        /// WeatherContext25 fetching entity
        /// </summary>
        public class WeatherContext25 : DbContext
        {
            public DbSet<BE.data_weather> forc { get; set; }

        }

        /// <summary>
        /// GetForecast: fetch weathe rfrom openweathermap API
        /// </summary>
        /// <param name="City">The location which the user requested</param>
        /// <returns>data_weather object: weather meta-data</returns>
        public BE.data_weather GetForecast(string City)
        {
            string url_ = "http://api.openweathermap.org/data/2.5/forecast/daily?q=";
            url_ += City;
            url_ += "&APPID=542ffd081e67f4512b705f89d2a611b2&units=metric&cnt=7";


            //web client
            using (WebClient client = new WebClient())
            {
                try
                {
                    string json = client.DownloadString(url_);
                    //scrafting info.
                    WeatherInfo_ weatherInfo1 = (new JavaScriptSerializer()).Deserialize<WeatherInfo_>(json);


                    //initiate weather_data fields
                    string city = weatherInfo1.city.name;
                    string country = weatherInfo1.city.country;
                    string description1 = weatherInfo1.list[0].weather[0].description;
                    string description2 = weatherInfo1.list[1].weather[0].description;
                    string description3 = weatherInfo1.list[2].weather[0].description;
                    string description4 = weatherInfo1.list[3].weather[0].description;
                    string description5 = weatherInfo1.list[4].weather[0].description;
                    string description6 = weatherInfo1.list[5].weather[0].description;
                    string icon1 = weatherInfo1.list[0].weather[0].icon;
                    string icon2 = weatherInfo1.list[1].weather[0].icon;
                    string icon3= weatherInfo1.list[2].weather[0].icon;
                    string icon4 = weatherInfo1.list[3].weather[0].icon;
                    string icon5 = weatherInfo1.list[4].weather[0].icon;
                    string icon6 = weatherInfo1.list[5].weather[0].icon;
                    
                    double tmp_day_1 = weatherInfo1.list[0].temp.day;
                    double tmp_night_1= weatherInfo1.list[0].temp.night;
                    double tmp_day_2 = weatherInfo1.list[1].temp.day;
                    double tmp_night_2 = weatherInfo1.list[1].temp.night;
                    double tmp_day_3 = weatherInfo1.list[2].temp.day;
                    double tmp_night_3 = weatherInfo1.list[2].temp.night;
                    double tmp_day_4 = weatherInfo1.list[3].temp.day;
                    double tmp_night_4 = weatherInfo1.list[3].temp.night;
                    double tmp_day_5 = weatherInfo1.list[4].temp.day;
                    double tmp_night_5 = weatherInfo1.list[4].temp.night;
                    double tmp_day_6 = weatherInfo1.list[5].temp.day;
                    double tmp_night_6 = weatherInfo1.list[5].temp.night;

                    double day_1 = weatherInfo1.list[0].dt;
                    double day_2 = weatherInfo1.list[1].dt;
                    double day_3 = weatherInfo1.list[2].dt;
                    double day_4 = weatherInfo1.list[3].dt;
                    double day_5 = weatherInfo1.list[4].dt;
                    double day_6 = weatherInfo1.list[5].dt;
                    int humidity = weatherInfo1.list[0].humidity;
                    double speed= weatherInfo1.list[0].speed;

                    int index = City.IndexOf(',');
                    if (index > 0)
                    {
                        City = City.Substring(0, index);
                    }

                     BE.data_weather data = new data_weather(city,country, description1, description2, description3, description4, description5, description6, icon1, icon2, icon3, icon4, icon5, icon6, tmp_day_1, tmp_night_1, tmp_day_2, tmp_night_2, tmp_day_3, tmp_night_3, tmp_day_4, tmp_night_4, tmp_day_5, tmp_night_5, tmp_day_6, tmp_night_6, day_1, day_2, day_3, day_4, day_5, day_6,humidity,speed);

                    using (var db = new WeatherContext25())
                    {
                        if (db.forc.Any(W => W.city == City))
                        {
                            var query = (from b in db.forc
                                         where b.city == City
                                         select b).FirstOrDefault();

                            db.forc.Remove(query);
                            db.forc.Add(data);
                            db.SaveChanges();

                        }
                        else
                        {
                            db.forc.Add(data);
                            db.SaveChanges();

                        }
                    }
                    return data;



            }
           
            
                catch (Exception)
                {
                    int index = City.IndexOf(',');
                    if (index > 0)
                    {
                        City = City.Substring(0, index);
                    }
                    using (var db = new WeatherContext25())
                    {
                        var query = (from b in db.forc
                                     where b.city == City
                                     select b).FirstOrDefault();
                        return query;
                      

                    }

                }
            }
        }
    }

        
}

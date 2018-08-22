using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    #region helper
    public class helper
    {
        public static int count = 34621;

    }
    #endregion

    #region information
    public class WeatherInfo_
    {
        
       
        
        
        public City city { get; set; }
        [Key]
        public long population { get; set; }
        public List<List> list { get; set; }

        
    }
    #endregion

    #region city info.
    public class City
    {
        
        public string name { get; set; }
        public string country { get; set; }
    }
    #endregion

    #region temp info.
    public class Temp
    {
        public double day { get; set; }
        public double min { get; set; }
        public double max { get; set; }
        public double night { get; set; }
    }
    #endregion

    #region weather info.
    public class Weather
    {
        
        private static int count=12;
        private int id = 0;
        [Key]
        public int _id { get { return id; } set { this.id = count++; } }
        public string description { get; set; }
        public string icon { get; set; }
    }
    #endregion

    #region date weather info.
    public class List
    {
        private static int count = 123455;
        private int id = 0;
        [Key]
        public int _id { get { return id; } set { this.id = count++; } }
        public double dt { get; set; }
        public Temp temp { get; set; }
        public int humidity { get; set; }
        public List<Weather> weather { get; set; }
        public double speed { get; set; }

    }
    #endregion
    
}

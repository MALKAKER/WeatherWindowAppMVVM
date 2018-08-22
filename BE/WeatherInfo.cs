using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{

    public class WeatherInfo
    {
        #region location coordinates
        /// <summary>
        /// WeatherInfo - location coordinates coordinates
        /// </summary>
        public class coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }
        #endregion

        #region weather basic data
        public class weather
        {
            public  int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }

        }
        #endregion

        #region weather basic parameters
        public class main
        {
            public double temp { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }


        }
        #endregion

        #region wind parameter
        public class wind
        {
            public double speed { get; set; }

        }
        #endregion

        #region location details
        public class sys
        {
            public string country { get; set; }

        }
        #endregion

        #region weather list
        public class root
        {
            [Key]
            public string name { get; set; }
            public sys sys{ get; set; }
            public double dt{ get; set; }
            public wind wind { get; set; }
            public main main  { get; set; }
            public List <weather> weatherList{ get; set; }
           // public coord coordinate { get; set; }
        }
        #endregion
         
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemon
{
    class Weather
    {

        // member variables ( HAS A )
        Day day;
        public int temperature;
        public string[] weatherConditions;
        public string condition;
        Random random;




        // constructor
        public Weather(Random random)
        {
            this.random = random;
        }



        // member methods ( CAN DO )
          public string CreateConditions()
          {
                weatherConditions = new string[5];
                weatherConditions[0] = "Sunny";
                weatherConditions[1] = "Rainy";
                weatherConditions[2] = "Windy";
                weatherConditions[3] = "Scorching Hot";
                weatherConditions[4] = "Cloudy";
                int chooseConditions = random.Next(weatherConditions.Length);
                condition = weatherConditions[chooseConditions];
                return condition;
          }

            public int CreateTemperature()
            {
                temperature = random.Next(60, 95);
                return temperature;

            }

        






      }
}

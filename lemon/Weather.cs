using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemon
{
    class Weather
    {
        Day day;
        // member variables ( HAS A )
        public string condition;
        public int temperature;
        private List<string> weatherConditions;
        public int weatherCount;
        private Random rand;
        public string weather;


        // constructor
        public Weather()
        {

            weatherConditions = new List<string>() { "rainy", "sunny", "cloudy", "snowy", "scorching hot", "windy", "cloudy" };
            
            rand = new Random();
            weatherCount = weatherConditions.Count;
            day.CreateWeatherConditions();
            day.CreateTemperature();
        }

        


        // member methods ( CAN DO )
        

        
        
        
        





    }
}

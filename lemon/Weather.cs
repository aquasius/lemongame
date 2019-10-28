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
            CreateWeatherConditions();
            CreateTemperature();
        }

        


        // member methods ( CAN DO )
        public void CreateWeatherConditions()
        {
            int CurrentWeather = rand.Next(weatherCount);
            weather = weatherConditions[CurrentWeather];
            Console.WriteLine(weather);
            Console.ReadLine();
        }

        public void CreateTemperature()
        {
           if (weather == "rainy")
            {
                temperature = 50;
                Console.WriteLine("The temperature is 50");
                Console.ReadLine();
            }
        
            else if (weather == "sunny")
            {
                temperature = 65;

                Console.WriteLine("The temperature is 65");
                Console.ReadLine();
            }
        
            else if (weather == "scorching hot")
            {
                temperature = 80;
                Console.WriteLine("The temperature is 80");
                Console.ReadLine();

            }
        
            else if (weather == "snowy")
            {
                temperature = 30;
                Console.WriteLine("The temperature is 30");
                Console.ReadLine();

                
            }
        
        
        }





    }
}

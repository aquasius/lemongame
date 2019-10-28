using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemon
{
    class Day
    {
        // member variables ( HAS A )
        public Weather weather;
        public List<Customer> customers;
        public List<Day> days; // i am creating days 


        // constructor
        public Day()
        {
            weather = new Weather();
        }



        // member methods ( CAN DO )    

        public void DetermineProfit()
        {

        }

        public void DetermineLoss()
        {

        }

        public void DetermineWeather()
        {
            
            weather.CreateWeatherConditions();

        }


    }
}

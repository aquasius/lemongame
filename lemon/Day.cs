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
        
       // public List<Customer> customers;
        //public string dayName;
        //public int numberOfDays;
        //public List<Day> days;
       
        //public int weatherCount;
        //private List<string> weatherConditions;
        //public string weather;
        //public int temperature;
       
        public Weather weather;
        Random random;
        




        // constructor
        public Day()
        {
           
            weather = new Weather(random);
            weather.CreateConditions();
            weather.CreateTemperature();

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



        }

       
       

        



        
    }
}
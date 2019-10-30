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
        //public Weather weather;
        public List<Customer> customers;
        public string dayName;
        public int numberOfDays;
        public List<Day>days;
        private Random rand;
        
        public int weatherCount;
        private List<string> weatherConditions;
        public string weather;
        public int temperature;

        // constructor
        public Day(string dayName)
        {
           
            

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

        //public void toDay()
        //{
        //    numberOfDays = 7;

        //    for (int i = 0; i < numberOfDays; i++)
        //    {
        //        Day day = new Day;

        //    }
        //}

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

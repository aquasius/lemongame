using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemon
{
    class Game
    {
        // member variables ( HAS A )
        Day day;
        private Player player;
        private List<Day> days;
        private int currentDay;
        public Store store;


        // constructor
        public Game()
        {
            
            days = new List<Day>();
            Day sunday = new Day("Sunday");
            days.Add(sunday);

            
            Day monday = new Day("Monday");
            days.Add(monday);

            
            Day tuesday = new Day("Tuesday");
            days.Add(tuesday);

           
            Day wednesday = new Day("Wednesday");
            days.Add(wednesday);

            Day thursday = new Day("Thursday");
            days.Add(thursday);

           Day friday = new Day("Friday");
            days.Add(friday);

           Day saturday = new Day("Saturday");
            days.Add(saturday);


        }


        // member methods ( CAN DO )
        public void RunGame()
        {
            DisplayRules();
            Player player = new Player();
            askName();

            Console.WriteLine();

            Store store = new Store();
            store.AmountOfLemons(player);
            store.AmountOfSugar(player);
            store.AmountOfIce(player);
            store.AmountOfCups(player);

            Console.WriteLine("Now it's time to create your recipe!");
             player.recipe.recipeCreator(player.inventory);
             player.UpdatedInventory();
             Console.ReadLine();

            Console.WriteLine("You will now begin your first day. The weather is:");

            Weather weather = new Weather();
            day.CreateWeatherConditions();
            day.CreateTemperature();
            Console.ReadLine();
            
            
            
        }


        public void DisplayWeather()
        {

        }
    
        public void DisplayWallet()
        {
               
        }
    
        public void DisplayRules()
        {
            Console.WriteLine("You’ve decided to open a lemonade stand! You have 7 days to make as much money as possible. You’ll have control over your business, including pricing, quality control, inventory control, and purchasing supplies. Buy your ingredients, set your recipe, and start selling!\nThe first thing you’ll have to worry about is your recipe. Try the default recipe, but also experiment and see if you can find a better recipe!\nMake sure you buy enough ingredients, or you won’t be able to sell!\nYou’ll also have to deal with the weather, which will play a big part when customers are deciding whether or not to buy your lemonade. Read the weather report every day! \n\nWhen the temperature drops, or the weather turns bad(snowy, rainy), don’t expect them to buy nearly as much as they would on a scorchin hot, or sunny day. Buy accordingly! \nFeel free to set your prices higher on those sunny, scorching hot days, as you’ll make more profit, even if you sell a bit less lemonade.\n\n As you sell your lemonade, people will decide how much they like or dislike it. At the end of the week you’ll see how much money you made.Play again, and try to beat your high score!");
        }
    

        public void DaySequence()
        {
            
        }

        public void askName()
        {
            Console.WriteLine("Please enter your name");
            Console.ReadLine();
        }

    
    }

}

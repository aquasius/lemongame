using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemon
{
    class Recipe
    {
        // member variables ( HAS A )
        public int numberOfLemons;
        public int numberOfSugarCubes;
        public int numberOfIceCubes;
        public int numberOfCups;
        public double pricePerCup;

        




        // constructor
        public Recipe()
        {
           
        }


        // member methods ( CAN DO )
        
        public void recipeCreator(Inventory inventory)
        {
            Console.WriteLine("\n Lemons: " + inventory.lemons.Count);
            Console.WriteLine("\n Sugar: " + inventory.sugarCubes.Count);
            Console.WriteLine("\n Ice: " + inventory.iceCubes.Count);
            Console.WriteLine("\n Cups: " + inventory.cups.Count);


        }






    }
}

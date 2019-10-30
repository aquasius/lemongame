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
            Console.WriteLine("How many lemons would you like to use in your pitcher?");
            numberOfLemons = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine(numberOfLemons + " lemons are now in your pitcher.");
            
            Console.WriteLine("How many sugar cubes would you like to put in your pitcher?");
            numberOfSugarCubes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numberOfSugarCubes + " surgar cubes are now mixed into your pitcher!");

            
            Console.WriteLine("How many ice cubes would you like to use in your recipe?");
            numberOfIceCubes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numberOfIceCubes + " ice cubes are now chilling inside your pitcher");



            Console.WriteLine("\n Lemons: " + inventory.lemons.Count);
            Console.WriteLine("\n Sugar: " + inventory.sugarCubes.Count);
            Console.WriteLine("\n Ice: " + inventory.iceCubes.Count);
            Console.WriteLine("\n Cups: " + inventory.cups.Count);


        }






    }
}

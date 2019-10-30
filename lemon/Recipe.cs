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
        public int lemonsLeftInInventory;
        public int sugarCubesLeftInInventory;
        public int iceCubesLeftInInventory;
        

        




        // constructor
        public Recipe()
        {
           
        }


        // member methods ( CAN DO )
        
        public void recipeCreator(Inventory inventory)
        {
             Console.WriteLine("How many lemons would you like to use in your pitcher?");
             numberOfLemons = Convert.ToInt32(Console.ReadLine());
         
            if (numberOfLemons >= inventory.lemons.Count)
            {
                lemonsLeftInInventory = inventory.lemons.Count - numberOfLemons;
                Console.WriteLine(numberOfLemons + " lemons are now in your pitcher.");
                Console.WriteLine("you currently have " + lemonsLeftInInventory + " left");
                
            }
            
          
            
            Console.WriteLine("How many sugar cubes would you like to put in your pitcher?");
            numberOfSugarCubes = Convert.ToInt32(Console.ReadLine());
            if (numberOfSugarCubes >= inventory.sugarCubes.Count)
            {
                sugarCubesLeftInInventory = inventory.sugarCubes.Count;
                Console.WriteLine(numberOfSugarCubes + " sugar cubes are now put into the pitcher.");
                Console.WriteLine("you now have " + sugarCubesLeftInInventory + " left");
            }
            

            
            Console.WriteLine("How many ice cubes would you like to use in your recipe?");
            numberOfIceCubes = Convert.ToInt32(Console.ReadLine());
            if (numberOfIceCubes >= inventory.iceCubes.Count)
            {
                iceCubesLeftInInventory = inventory.iceCubes.Count;
                Console.WriteLine();
                
                Console.WriteLine(numberOfIceCubes + " ice cubes are now chilling inside your pitcher");
            }

            


        }






    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemon
{
    class Player
    {
        // member variables ( HAS A )
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;
        public int newLemonTotal;
        public int newSugarTotal;
        public int newIceTotal;
        public int pitcherCanHold;

       

        // constructor
        public Player()
        {
            wallet = new Wallet();
            inventory = new Inventory();
            recipe = new Recipe();
        }

       

        // member methods ( CAN DO )
        public void BuyItems()
        {

        }
        public void SellLemonade()
        {

        }

        public void MakeProfit()
        {

        }

        public void GoBankrupt()
        {

        }

        public void LoseProfit()
        {

        }

        public void CreateLemonadeRecipe()
        {
            
        }
    
        public void UpdatedInventory()
        {

            newLemonTotal = inventory.lemons.Count - recipe.numberOfLemons;
            Console.WriteLine("you have " + newLemonTotal + "  lemons remaining");

            newSugarTotal = inventory.sugarCubes.Count - recipe.numberOfSugarCubes;
            Console.WriteLine("you have " + newSugarTotal + " sugar cubes ramaining");

            newIceTotal = inventory.iceCubes.Count - recipe.numberOfIceCubes;
            Console.WriteLine("you have " + newIceTotal + " ice cubes remaining");


        }
        
        public void refillPitcher()
        {
            
           // if (pitcher.cupsLeftInPitcher <= pitcher.cupsInPitcher)
            {
               // pitcherCanHold = cupsLeftInPitcher - cupsInPitcher;
            }
       
        
        
        }


    
    }
}

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

            Console.WriteLine(newLemonTotal + " you have lemons remaining");


        }
    
    
    }
}

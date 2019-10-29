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


        // constructor
        public Player()
        {
            wallet = new Wallet();
            inventory = new Inventory();
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
    
    
    
    
    }
}

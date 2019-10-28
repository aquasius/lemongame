using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemon
{
    class Store
    {
        // member variables ( HAS A )
        private double pricePerLemon;
        private double pricePerSugarCube;
        private double pricePerIceCube;
        private double pricePerCup;
        private double totalLemons;
        private double lemonTotal;
        private int itemTotal;


        // constructor
        public Store()
        {



        }




        // member methods ( CAN DO )
        public void ListItemsToSell()
        {
            pricePerLemon = .12;
            pricePerSugarCube = .10;
            pricePerIceCube = .05;
            pricePerCup = .08;

        }

        public void AmountOfProduct()
        {
            Console.WriteLine("How many lemons would you like to purchase? They are" + pricePerLemon + " each");
            totalLemons = Convert.ToInt32(Console.ReadLine());
            itemMath();
        }

        public void itemMath(int total, int amount, int price)
        {
            total = amount * price;
            Console.WriteLine("You purchased" + total + " at" + pricePerLemon + " each");
            Console.ReadLine();
        }

        public void sellProduct








    }
}

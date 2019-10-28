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

        public void AmountOfLemons()
        {
            Console.WriteLine("How many lemons would you like to purchase? They are" + pricePerLemon + " each");
            totalLemons = Convert.ToInt32(Console.ReadLine());
            LemonMath();
        }

        public void LemonMath()
        {
            lemonTotal = totalLemons * pricePerLemon;
            Console.WriteLine("You purchased" + totalLemons + " at" + pricePerLemon);
            Console.ReadLine()
        }









    }
}

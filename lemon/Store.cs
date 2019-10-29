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
       
        
        
 
        
       
        // constructor
        public Store()
        {
            pricePerLemon = .12;
            pricePerSugarCube = .10;
            pricePerIceCube = .05;
            pricePerCup = .08;
        }




        // member methods ( CAN DO )
        public void AmountOfLemons(Player player)
        {
            int totalLemons;
            double lemonTotal;

            Console.WriteLine("How many lemons would you like to purchase? They are" + pricePerLemon + " each");
            totalLemons = Convert.ToInt32(Console.ReadLine());
            lemonTotal = LemonMath(totalLemons);
            player.wallet.walletAmount = player.wallet.walletAmount - lemonTotal;
            Console.WriteLine(player.wallet.walletAmount + " dollars left");

            AddLemons(totalLemons, lemonTotal, player);

        }


        public void AmountOfSugar(Player player)
        {
            int totalSugar; 
            double sugarTotal;
            
           Console.WriteLine("How many sugar cubes would you like to purchase today? They are" + pricePerSugarCube + " each");
           totalSugar = Convert.ToInt32(Console.ReadLine());
           sugarTotal = SugarMath(totalSugar);
           player.wallet.walletAmount = player.wallet.walletAmount - sugarTotal;
            
            //Console.WriteLine("Your "+ player.inventory )
        }

        public void  AmountOfIce(Player player)
        {
            int totalIce;
            double iceTotal;

            Console.WriteLine("How many cubes would you like to purchase? They are" + pricePerIceCube + " each");
            totalIce = Convert.ToInt32(Console.ReadLine());
            iceTotal = IceMath(totalIce);
            player.wallet.walletAmount = player.wallet.walletAmount - iceTotal;
            Console.WriteLine("You have" + player.wallet.walletAmount);
        }

        public void AmountOfCups(Player player)
        {
            int totalCups;
            double cupTotal;

            Console.WriteLine("How many total cups would you like to purchase? They are" + pricePerCup);
            totalCups = Convert.ToInt32(Console.ReadLine());
            cupTotal = CupMath(totalCups);
            player.wallet.walletAmount = player.wallet.walletAmount - cupTotal;

        }

        public double LemonMath(int totalLemons)
        {
            double lemonTotal = totalLemons * pricePerLemon;
            Console.WriteLine("You purchased" + totalLemons + " at" + pricePerLemon);
            return lemonTotal;
        }
        public double SugarMath(int totalSugar )
        {
            double sugarTotal = totalSugar * pricePerSugarCube;
            Console.WriteLine("You purchased" + totalSugar + " at" + pricePerSugarCube);
            return sugarTotal;
        }

        public double IceMath(int totalIce)
        {
            double iceTotal = totalIce * pricePerIceCube;
            Console.WriteLine("You purchased" + totalIce + " at" + pricePerIceCube);
            return iceTotal;
        }

        public double CupMath(int totalCups)
        {
            double cupTotal = totalCups * pricePerCup;
            Console.WriteLine("You purchased" + totalCups + " at" + pricePerCup);
            return cupTotal;
        }

        public void AddLemons(double totalLemons, double lemonTotal, Player player)
        {
            for (int i = 0; i < totalLemons; i++)
            {
                Lemon lemon = new Lemon();
                player.inventory.lemons.Add(lemon);
            }
            Console.WriteLine("You now have " + lemonTotal + " lemons in you inventory");
        }




    }
}

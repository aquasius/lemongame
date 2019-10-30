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
        public int lemonInventory;
        public int sugarInventory;
        public int iceInventory;
        public int cupInventory;






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

            Console.WriteLine("How many lemons would you like to purchase? They are " + pricePerLemon + " each");
            totalLemons = Convert.ToInt32(Console.ReadLine());
            lemonTotal = LemonMath(totalLemons);
            player.wallet.WalletAmount = player.wallet.WalletAmount - lemonTotal;
            Console.WriteLine("You have " + player.wallet.WalletAmount + " dollars left");

            AddLemonsToInv(totalLemons, lemonTotal, player);

        }


        public void AmountOfSugar(Player player)
        {
            int totalSugar; 
            double sugarTotal;
            
           Console.WriteLine("How many sugar cubes would you like to purchase today? They are " + pricePerSugarCube + " each");
           totalSugar = Convert.ToInt32(Console.ReadLine());
           sugarTotal = SugarMath(totalSugar);
           player.wallet.WalletAmount = player.wallet.WalletAmount - sugarTotal;
           Console.WriteLine("You have " + player.wallet.WalletAmount + " dollars left");

            AddSugarToInv(totalSugar, sugarTotal, player);
        }

        public void  AmountOfIce(Player player)
        {
            int totalIce;
            double iceTotal;

            Console.WriteLine("How many ice cubes would you like to purchase? They are " + pricePerIceCube + " each");
            totalIce = Convert.ToInt32(Console.ReadLine());
            iceTotal = IceMath(totalIce);
            player.wallet.WalletAmount = player.wallet.WalletAmount - iceTotal;
            Console.WriteLine("You have " + player.wallet.WalletAmount + " dollars left");

            AddIceToInv(totalIce, iceTotal, player);
        }

        public void AmountOfCups(Player player)
        {
            int totalCups;
            double cupTotal;

            Console.WriteLine("How many total cups would you like to purchase? They are " + pricePerCup);
            totalCups = Convert.ToInt32(Console.ReadLine());
            cupTotal = CupMath(totalCups);
            player.wallet.WalletAmount = player.wallet.WalletAmount - cupTotal;
            Console.WriteLine("You have " + player.wallet.WalletAmount + " dollars left");

            AddCupsToInv(totalCups, cupTotal, player);

        }

        public double LemonMath(int totalLemons)
        {
            double lemonTotal = totalLemons * pricePerLemon;
            Console.WriteLine("You purchased " + totalLemons + " at " + pricePerLemon);
            return lemonTotal;
        }
        public double SugarMath(int totalSugar )
        {
            double sugarTotal = totalSugar * pricePerSugarCube;
            Console.WriteLine("You purchased " + totalSugar + " at " + pricePerSugarCube);
            return sugarTotal;
        }

        public double IceMath(int totalIce)
        {
            double iceTotal = totalIce * pricePerIceCube;
            Console.WriteLine("You purchased " + totalIce + " at " + pricePerIceCube);
            return iceTotal;
        }

        public double CupMath(int totalCups)
        {
            double cupTotal = totalCups * pricePerCup;
            Console.WriteLine("You purchased " + totalCups + " at " + pricePerCup);
            return cupTotal;
        }

        public void AddLemonsToInv(double totalLemons, double lemonTotal, Player player)
        {
            for (int i = 0; i < totalLemons; i++)
            {
                Lemon lemon = new Lemon();
                player.inventory.lemons.Add(lemon);
                
            }
           // player.inventory.displayInventory();

        }

        public void AddSugarToInv(double totalSugar , double sugarTotal , Player player)
        {
            for (int i = 0; i < totalSugar; i++)
            {
                SugarCube sugarcube = new SugarCube();
                player.inventory.sugarCubes.Add(sugarcube);
                
            }
           // player.inventory.displayInventory();

        }

        public void AddIceToInv(double totalIce, double iceTotal, Player player)
        {
            for (int i = 0; i < totalIce; i++)
            {
                IceCube icecube = new IceCube();
                player.inventory.iceCubes.Add(icecube);
               

            }
            //player.inventory.displayInventory();
        }

        public void AddCupsToInv(double totalCups, double cupTotal, Player player)
        {
            for (int i = 0; i < totalCups; i++)
            {
                Cup cup = new Cup();
                player.inventory.cups.Add(cup);
                
            }
            //player.inventory.displayInventory();
        }
    
         
    
    
    }






}

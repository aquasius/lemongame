using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemon
{
    class Inventory
    {
        // member variables ( HAS A )
        public List<Lemon> lemons;
        public List<IceCube> iceCubes;
        public List<Cup> cups;
        public List<SugarCube> sugarCubes;



        // constructor

    public Inventory()
        {
            lemons = new List<Lemon>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();
            sugarCubes = new List<SugarCube>();


        }


        // member methods ( CAN DO )

        public void displayInventory()
        {
            Console.WriteLine("You now have");
            Console.WriteLine("Lemons: " + lemons.Count);
            Console.WriteLine("Ice Cubes: " + iceCubes.Count);
            Console.WriteLine("Cups: " + cups.Count);
            Console.WriteLine("Sugar: " + sugarCubes.Count);
        }

        public void DisplayItems()
        {
            if (lemons.Count != 0)
            {
                Console.WriteLine("Lemons: " + lemons.Count);
            }

            if (sugarCubes.Count != 0)
            {
                Console.WriteLine("Sugar: " + sugarCubes.Count);
            }

            if (iceCubes.Count != 0)
            {
                Console.WriteLine("Ice:" + iceCubes.Count);
            }

            if (cups.Count != 0)
            {
                Console.WriteLine("Cups: " + cups.Count);
            }
        }





    }
}

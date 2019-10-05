using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code to demonstrate the classic Prorotype Pattern
            CJ player = new CJ();
            player.Health = 1;
            player.Felony = 10;
            player.Money = 2.0;

            Console.WriteLine("Original Player stats:");
            Console.WriteLine("Health: {0}, Felony: {1}, Money: {2}",
                player.Health.ToString(),
                player.Felony.ToString(),
                player.Money.ToString());

            // We enter the cheat code here and we have a new 
            // player object that we can save on the disk asyncronously.
            CJ playerToSave = player.Clone() as CJ;

            Console.WriteLine("\nCopy of player to save on disk:");
            Console.WriteLine("Health: {0}, Felony: {1}, Money: {2}",
                playerToSave.Health.ToString(),
                playerToSave.Felony.ToString(),
                playerToSave.Money.ToString());

            Console.ReadKey();
        }
    }
}

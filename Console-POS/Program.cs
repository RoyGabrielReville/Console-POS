using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_POS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();

            Console.ReadKey();
        }

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine("   WELCOME TO THE POS SYSTEM  ");
            Console.WriteLine("   WELCOME TO THE POS SYSTEM  ");
            Console.WriteLine("[1] Add item");
            Console.WriteLine("[2] Remove item");
            Console.WriteLine("[3] View Cart");
            Console.WriteLine("[4] Checkout");
            Console.WriteLine("[6] Exit");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Please select an option ");
               
        }
    }
}
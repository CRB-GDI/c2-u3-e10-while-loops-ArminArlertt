using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace exersize_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem 1 
            int choice;
            //Print menue
            Console.WriteLine("*************");
            Console.WriteLine("Menu");
            Console.WriteLine("1 - New game");
            Console.WriteLine("2 - Load game");
            Console.WriteLine("3 - options");
            Console.WriteLine("4 - quit");
            Console.WriteLine("*************");
            Console.WriteLine();

            //prompt for and get choice 
            Console.WriteLine("Enter your choice (1,2,3, or 4): ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            while (choice != 4)
            {
                if (choice == 1) 
                { 
                Console.WriteLine("Creating new game");
                    Console.ReadLine();
                    Console.WriteLine("*************");
                    Console.WriteLine("Menu");
                    Console.WriteLine("1 - New game");
                    Console.WriteLine("2 - Load game");
                    Console.WriteLine("3 - options");
                    Console.WriteLine("4 - quit");
                    Console.WriteLine("*************");
                    Console.WriteLine();

                    Console.WriteLine("Enter your choice (1,2,3, or 4): ");
                    choice = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
               
                
                if (choice == 2) 
                {
                    Console.WriteLine("Load game");
                    Console.ReadLine();
                    Console.WriteLine("*************");
                    Console.WriteLine("Menu");
                    Console.WriteLine("1 - New game");
                    Console.WriteLine("2 - Load game");
                    Console.WriteLine("3 - options");
                    Console.WriteLine("4 - quit");
                    Console.WriteLine("*************");
                    Console.WriteLine();

                    Console.WriteLine("Enter your choice (1,2,3, or 4): ");
                    choice = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                if (choice == 3) 
                Console.WriteLine("Options");
                Console.ReadLine();
                Console.WriteLine("*************");
                Console.WriteLine("Menu");
                Console.WriteLine("1 - New game");
                Console.WriteLine("2 - Load game");
                Console.WriteLine("3 - options");
                Console.WriteLine("4 - quit");
                Console.WriteLine("*************");
                Console.WriteLine();

                Console.WriteLine("Enter your choice (1,2,3, or 4): ");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (choice == 4)
                    Console.WriteLine("Quit");
                
            }
        }
    }
}
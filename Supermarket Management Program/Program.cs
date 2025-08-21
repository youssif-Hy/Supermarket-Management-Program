using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainMethodsClass;
using UI_MenuClass;
namespace Supermarket_Management_Program
{
    internal class Program
    {
        public static string path = "products.txt";
        static void Main(string[] args)
        {
            // Display the welcome menu
            menu.WelcomeMenu2();
            // Display the main menu
            int choice = menu.MainMenu();
            switch (choice)
            {
                case 1:
                    // Navigate to the customer section
                    //CustomerSection.CustomerMenu();
                    break;
                case 2:
                    // Navigate to the admin section
                    // AdminSection.AdminMenu();
                    break;
                case 3:
                    // Exit the program
                    Console.WriteLine("Thank you for using the Supermarket Management Program. Goodbye!");
                    Environment.Exit(0);
                    break;
            }



        }
    }
}

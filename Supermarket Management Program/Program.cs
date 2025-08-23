using System;
using System.Collections.Generic;
using UI_MenuClass;
using productSection;
namespace Supermarket_Management_Program
{
    public class Program
    {
        public static string path = "products.txt";
        public static List<Product> products = new List<Product>();
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Display the welcome menu
             menu.WelcomeMenu();
            // Display the main menu
            menu.MainMenu();
        }
    }
}

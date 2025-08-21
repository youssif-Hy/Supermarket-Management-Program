using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_MenuClass;
using System.IO;
namespace Supermarket_Management_Program
{
    public class Program
    {
        public static string path = "products.txt";
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Display the welcome menu
            menu.WelcomeMenu2();
            // Display the main menu
            menu.MainMenu();
        }
    }
}

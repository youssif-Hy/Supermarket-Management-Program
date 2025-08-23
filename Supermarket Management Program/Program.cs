using System;
using System.Collections.Generic;
using UI_MenuClass;
using productSection;
using MainMethodsClass;
using valid;
using System.IO;
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
        public static bool ReadFromFill()
        {
            bool isexest = false;
            if (File.Exists(Program.path))
            {
                string[] fileLines = File.ReadAllLines(Program.path);
                foreach (string line1 in fileLines)
                {
                    if (line1 == "")
                    {
                        continue;
                    }
                    string[] part = line1.Split(',');
                    Product productinfo = new Product(part[0], part[1], int.Parse(part[2]), DateTime.Parse(part[3]), DateTime.Parse(part[4]));
                    if (Validation.isExist(Program.products, part[0]))
                    {
                        Program.products.Add(productinfo);
                    }
                }
            }
            else if (!File.Exists(Program.path))
            {
                Main_Methods.WriteSlow("File not Exist\n", 20, 0, 0);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("press any kay to rutern Customer Menu...");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                isexest = true;

            }
            return isexest;
        }
    }
}

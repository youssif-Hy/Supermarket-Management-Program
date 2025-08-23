using Supermarket_Management_Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using MainMethodsClass;
using productSection;
using UI_MenuClass;
namespace Admin
{
    public class AdminModule
    {
        public string AdminUsername;
        public string AdminPassword;

        public AdminModule(string username, string password)
        {
            AdminUsername = username;
            AdminPassword = password;
        }
        public static List<AdminModule> adminList = new List<AdminModule>()
        {
            new AdminModule("mohamed_osama", "moh@2006"),
            new AdminModule("abdalrahman", "abod@2006"),
            new AdminModule("Youssef_Hy1", "yousssef@2006"),
        };
        public static void ViewProducts()
        {
            Console.Clear();
            List<Product> products = new List<Product>();
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
                    Product productinfo = new Product(part[0], part[1], part[2], int.Parse(part[3]), DateTime.Parse(part[4]), DateTime.Parse(part[5]));
                    products.Add(productinfo);
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

            }
            else
            {
                Console.WriteLine(Main_Methods.CenterText("+-----------------+-----------------+-----------------+---------+-----------------+-----------------+"));
                Console.WriteLine(Main_Methods.CenterText("| Name            | Category        | Serial Number   | Qty     | Production Date | Expiry Date     |"));
                Console.WriteLine(Main_Methods.CenterText("+-----------------+-----------------+-----------------+---------+-----------------+-----------------+"));
                string line = "+-----------------+-----------------+-----------------+---------+-----------------+-----------------+";
                foreach (Product proDuct in products)
                {
                    if (proDuct == null || proDuct.Quantity == 0 || proDuct.Expiry())
                    {
                        continue;
                    }
                    Console.WriteLine(Main_Methods.CenterText($"| {proDuct.Name,-15} | {proDuct.Category,-15} | {proDuct.SerialNumber,-10} | {proDuct.Quantity,-5} | {proDuct.ProductionDate:dd-MM-yyyy,-15} | {proDuct.ExpiryDate:dd-MM-yyyy,-15} |"));
                    Console.WriteLine(Main_Methods.CenterText(line));
                }
            }
        }
        public static void AddProduct()
        {
            List<Product> productsForAdd = new List<Product>();
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
                    Product productinfo = new Product(part[0], part[1], part[2], int.Parse(part[3]), DateTime.Parse(part[4]), DateTime.Parse(part[5]));
                    productsForAdd.Add(productinfo);
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Main_Methods.CenterText("+------------------------------------------------------+"));
            Console.WriteLine(Main_Methods.CenterText("|                     Add Product                      |"));
            Console.WriteLine(Main_Methods.CenterText("+------------------------------------------------------+"));
            Console.WriteLine(Main_Methods.CenterText(" | > Product Name        :                              |"));
            Console.WriteLine(Main_Methods.CenterText(" | > Category            :                              |"));
            Console.WriteLine(Main_Methods.CenterText(" | > Serial Number       :                              |"));
            Console.WriteLine(Main_Methods.CenterText(" | > Quantity            :                              |"));
            Console.WriteLine(Main_Methods.CenterText(" | > Production Date     :                              |"));
            Console.WriteLine(Main_Methods.CenterText(" | > Expiry Date         :                              |"));
            Console.WriteLine(Main_Methods.CenterText("+------------------------------------------------------+"));
            Console.WriteLine(Main_Methods.CenterText("| [ Please enter the product information above ]       |"));
            Console.WriteLine(Main_Methods.CenterText("| [ Press ENTER after each input to continue ]         |"));
            Console.WriteLine(Main_Methods.CenterText("+------------------------------------------------------+"));
            Console.ResetColor();

            Console.SetCursorPosition(57, 3);
            string name = Console.ReadLine();
            Console.SetCursorPosition(57, 4);
            string category = Console.ReadLine();
            Console.SetCursorPosition(57, 5);
            string serial = Console.ReadLine();
            Console.SetCursorPosition(57, 6);
            int qty = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(57, 7);
            DateTime production = DateTime.Parse(Console.ReadLine());
            Console.SetCursorPosition(57, 8);
            DateTime expiry = DateTime.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(0, 13);
            Main_Methods.WriteSlow("Product saved successfully!\n",20,0,13);
            Console.ResetColor();
            Product productinfo1 = new Product(name, category, serial, qty, production, expiry);
            productsForAdd.Add(productinfo1);
            List<string> lines = new List<string>();
            foreach (Product proDuct in productsForAdd)
            {
                if (proDuct == null)
                {
                    continue;
                }
                lines.Add($"{proDuct.Name},{proDuct.Category},{proDuct.SerialNumber},{proDuct.Quantity},{proDuct.ProductionDate},{proDuct.ExpiryDate}");

            }
            File.WriteAllLines(Program.path, lines);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nPress any key to return to Admin Menu...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        public static void DeleteProduct()
        {
            List<Product> productsForDelete = new List<Product>();
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
                    Product productinfo = new Product(part[0], part[1], part[2], int.Parse(part[3]), DateTime.Parse(part[4]), DateTime.Parse(part[5]));
                    productsForDelete.Add(productinfo);
                }
            }
            else
            {
                Console.WriteLine("File not Exist");
            }
            Console.WriteLine(Main_Methods.CenterText("+-------------------------------------------------------------------------+"));
            Console.WriteLine(Main_Methods.CenterText("|                               Delete Product                            |"));
            Console.WriteLine(Main_Methods.CenterText("+-------------------------------------------------------------------------+"));
            Console.WriteLine(Main_Methods.CenterText("| Please enter the Serial Number of the product to delete:                |"));
            Console.WriteLine(Main_Methods.CenterText("+-------------------------------------------------------------------------+"));
            // البحث عن المنتج الذي سيتم حذفه
            Console.SetCursorPosition(65, 5);
            string serialNumber = Console.ReadLine();
            Product productToDelete = productsForDelete.FirstOrDefault(p => p.SerialNumber == serialNumber);
            if (productToDelete != null)
            {
                productsForDelete.Remove(productToDelete);
                // إعادة كتابة البيانات في الملف بعد الحذف
                List<string> lines = new List<string>();
                foreach (Product proDuct in productsForDelete)
                {
                    if (proDuct == null)
                    {
                        continue;
                    }
                    lines.Add($"{proDuct.Name},{proDuct.Category},{proDuct.SerialNumber},{proDuct.Quantity},{proDuct.ProductionDate},{proDuct.ExpiryDate}");
                }
                File.WriteAllLines(Program.path, lines);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Main_Methods.WriteSlow("Product deleted successfully!\n",20,0,7);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Press any key to return to Admin Menu...");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Main_Methods.WriteSlow("Product not found!\n",20,0,7);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\nPress any key to return to Admin Menu...");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void viewExpiryAlerts()
        {
            List<Product> productsForAlert = new List<Product>();
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
                    Product productinfo = new Product(part[0], part[1], part[2], int.Parse(part[3]), DateTime.Parse(part[4]), DateTime.Parse(part[5]));
                    productsForAlert.Add(productinfo);
                }
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.DarkRed;
                Main_Methods.WriteSlow("File not Exist",20,0,0);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("press any kay to rutern Customer Menu...");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                menu.AdminMenu();
            }
            Console.WriteLine(Main_Methods.CenterText("+-----------------+-----------------+-----------------+---------+-----------------+-----------------+"));
            Console.WriteLine(Main_Methods.CenterText("| Name            | Category        | Serial Number   | Qty     | Production Date | Expiry Date     |"));
            Console.WriteLine(Main_Methods.CenterText("+-----------------+-----------------+-----------------+---------+-----------------+-----------------+"));
            string line = "+-----------------+-----------------+-----------------+---------+-----------------+-----------------+";
            foreach (Product proDuct in productsForAlert)
            {
                if (proDuct == null || !proDuct.Expiry())
                {
                    continue;
                }
                Console.WriteLine(Main_Methods.CenterText($"| {proDuct.Name,-15} | {proDuct.Category,-15} | {proDuct.SerialNumber,-10} | {proDuct.Quantity,-5} | {proDuct.ProductionDate:dd-MM-yyyy,-15} | {proDuct.ExpiryDate:dd-MM-yyyy,-15} |"));
                Console.WriteLine(Main_Methods.CenterText(line));
            }
        }
    }
}

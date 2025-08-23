using Supermarket_Management_Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using MainMethodsClass;
using productSection;
using UI_MenuClass;
using valid;
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
        public static void ViewProducts(bool isadmin)
        {
            if (Program.ReadFromFill())
            {
                if (isadmin)
                {
                    menu.AdminMenu();
                }
                else
                {
                    menu.CustomerMenu();

                }
            }
            Console.Clear();
            Console.WriteLine(Main_Methods.CenterText("+-----------------+-----------------+---------+-----------------+-----------------+"));
            Console.WriteLine(Main_Methods.CenterText("| Name            | Category        | Qty     | Production Date | Expiry Date     |"));
            Console.WriteLine(Main_Methods.CenterText("+-----------------+-----------------+---------+-----------------+-----------------+"));
            string line = "+-----------------+-----------------+---------+-----------------+-----------------+";
            foreach (Product proDuct in Program.products)
            {
                if (proDuct == null || proDuct.Quantity == 0 || proDuct.Expiry())
                {
                    continue;
                }
                Console.WriteLine(
                     Main_Methods.CenterText(
                         $"| {proDuct.Name,-15} " +
                         $"| {proDuct.Category,-15} " +
                         $"| {proDuct.Quantity,-7} " +
                         $"| {proDuct.ProductionDate,-14:dd/MM/yyyy}  " +
                         $"| {proDuct.ExpiryDate,-15:dd/MM/yyyy} " +
                         $"|"
                     )
                 ); 
                Console.WriteLine(Main_Methods.CenterText(line));
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nPress any key to return to Admin Menu...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

        }
        public static void AddProduct()
        {
            if (Program.ReadFromFill())
                menu.AdminMenu();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Main_Methods.CenterText("+------------------------------------------------------+"));
            Console.WriteLine(Main_Methods.CenterText("|                     Add Product                      |"));
            Console.WriteLine(Main_Methods.CenterText("+------------------------------------------------------+"));
            Console.WriteLine(Main_Methods.CenterText(" | > Product Name        :                              |"));
            Console.WriteLine(Main_Methods.CenterText(" | > Category            :                              |"));
            Console.WriteLine(Main_Methods.CenterText(" | > Quantity            :                              |"));
            Console.WriteLine(Main_Methods.CenterText(" | > Production Date     :                              |"));
            Console.WriteLine(Main_Methods.CenterText(" | > Expiry Date         :                              |"));
            Console.WriteLine(Main_Methods.CenterText("+------------------------------------------------------+"));
            Console.WriteLine(Main_Methods.CenterText("| [ Please enter the product information above ]       |"));
            Console.WriteLine(Main_Methods.CenterText("| [ Press ENTER after each input to continue ]         |"));
            Console.WriteLine(Main_Methods.CenterText("+------------------------------------------------------+"));
            Console.ResetColor();
            Console.SetCursorPosition(57, 3);
            string name = Validation.ValiDateNameproduct(Console.ReadLine(),57,3,0,13);
            Console.SetCursorPosition(57, 4);
            string category =Validation.ValidCategory( Console.ReadLine(),57,4,0,13);
            Console.SetCursorPosition(57, 5);
            int qty = Validation.ValidateQuantity(Console.ReadLine(),57,5,0,13);
            Console.SetCursorPosition(57, 6);
            DateTime production = Validation.ValidProduction(Console.ReadLine(),57,6,0,13);
            Console.SetCursorPosition(57, 7);
            DateTime expiry = Validation.ValidExpiryDate(Console.ReadLine(),production, 57, 7, 0, 13);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(0, 13);
            Main_Methods.WriteSlow("Product saved successfully!\n",20,0,13);
            Console.ResetColor();
            Product productinfo1 = new Product(name, category, qty, production, expiry);
            Program.products.Add(productinfo1);
            List<string> lines = new List<string>();
            foreach (Product proDuct in Program.products)
            {
                if (proDuct == null)
                {
                    continue;
                }
                lines.Add($"{proDuct.Name},{proDuct.Category},{proDuct.Quantity},{proDuct.ProductionDate},{proDuct.ExpiryDate}");

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
            if (Program.ReadFromFill())
                menu.AdminMenu();
            Console.Clear();
            Console.WriteLine(Main_Methods.CenterText("+-------------------------------------------------------------------------+"));
            Console.WriteLine(Main_Methods.CenterText("|                               Delete Product                            |"));
            Console.WriteLine(Main_Methods.CenterText("+-------------------------------------------------------------------------+"));
            Console.WriteLine(Main_Methods.CenterText("| Please enter the Name of the product to delete:                         |"));
            Console.WriteLine(Main_Methods.CenterText("+-------------------------------------------------------------------------+"));
            // البحث عن المنتج الذي سيتم حذفه
            Console.SetCursorPosition(65, 5);
            string Name = Console.ReadLine();
            Product productToDelete = Program.products.FirstOrDefault(p => p.Name.ToLower() == Name.ToLower());
            if (productToDelete != null)
            {
                Program.products.Remove(productToDelete);
                // إعادة كتابة البيانات في الملف بعد الحذف
                List<string> lines = new List<string>();
                foreach (Product proDuct in Program.products)
                {
                    if (proDuct == null)
                    {
                        continue;
                    }
                    lines.Add($"{proDuct.Name},{proDuct.Category},{proDuct.Quantity},{proDuct.ProductionDate},{proDuct.ExpiryDate}");
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
        public static void ViewExpiryAlerts()
        {
            if (Program.ReadFromFill())
                menu.AdminMenu();

            Console.WriteLine(Main_Methods.CenterText("+-----------------+-----------------+---------+-----------------+-----------------+"));
            Console.WriteLine(Main_Methods.CenterText("| Name            | Category        | Qty     | Production Date | Expiry Date     |"));
            Console.WriteLine(Main_Methods.CenterText("+-----------------+-----------------+---------+-----------------+-----------------+"));
            string line = "+-----------------+-----------------+---------+-----------------+-----------------+";
            foreach (Product proDuct in Program.products)
            {
                if (proDuct == null || !proDuct.Expiry())
                {
                    continue;
                }
                Console.WriteLine(Main_Methods.CenterText($"| {proDuct.Name,-15} | {proDuct.Category,-15} | {proDuct.Quantity,-5} | {proDuct.ProductionDate,-15:dd-MM-yyyy} | {proDuct.ExpiryDate,-15:dd-MM-yyyy} |"));
                Console.WriteLine(Main_Methods.CenterText(line));
            }
            Console.Write("press any kay to rutern Customer Menu...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            menu.AdminMenu();
        }
        public static void ChechProductsExpir()
        {
            if (Program.ReadFromFill())
                menu.AdminMenu();
            Console.WriteLine(Main_Methods.CenterText("+-------------------------------------------------------------------------------------------+"));
            Console.WriteLine(Main_Methods.CenterText("|                                    Chech Products Expir                                   |"));
            Console.WriteLine(Main_Methods.CenterText("+-------------------------------------------------------------------------------------------+"));
            Console.WriteLine(Main_Methods.CenterText("| Please enter the Name of the product you went cheched it:                                 |"));
            Console.WriteLine(Main_Methods.CenterText("+-------------------------------------------------------------------------------------------+"));
            Console.SetCursorPosition(75, 4);
            string name = Console.ReadLine();
            Product ProductsExpir = Program.products.FirstOrDefault(p => p.Name == name);
            if (ProductsExpir != null )
            {
                bool chek = ProductsExpir.Expiry();
                if (chek)
                {
                    Console.WriteLine("💀Near Expiry");
                }
                else
                {
                    Console.WriteLine("👌Valid");
                }
            }
            else
            {
                Console.WriteLine("the is not found.");
            }
            Console.Write("press any kay to rutern Customer Menu...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            menu.AdminMenu();
        }
    }
}

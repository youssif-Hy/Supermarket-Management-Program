using productSection;
using System;
using System.Collections.Generic;
using System.Linq;
using MainMethodsClass;
using valid;
using Supermarket_Management_Program;
using System.IO;
using UI_MenuClass;

namespace Customer_Section
{
    class Customer
    {
        public static string customer_name { get; set; }
        public static List<Product> cart = new List<Product>();
        public static void BuyProduct(string name ,int quantity)
        {
            Console.Clear();
            Console.ResetColor();
            // Check if the product is available in the store
            if (Program.ReadFromFill())
                menu.CustomerMenu();
            Product productsToBuyProduct = Program.products.FirstOrDefault(p => p.Name.ToLower() == name.ToLower());
            if (productsToBuyProduct != null && productsToBuyProduct.Quantity >= quantity)
            {
                Program.products.Remove(productsToBuyProduct);
                productsToBuyProduct.Quantity -= quantity;
                Program.products.Add(productsToBuyProduct);
                RewriteInFill(Program.products);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("The product has been added to your cart.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Main_Methods.WriteSlow("The product is not available or the quantity is not enough.\n",20,0,8);
            }
            Console.ForegroundColor= ConsoleColor.DarkGray;
            Console.Write("press any kay to rutern your Menu...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        public static void RemoveProductFromCart()
        {
            Console.Clear();
            Console.ResetColor();
            List<Product> RemoveProduct = new List<Product>();
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
                    Product productinfo = new Product(part[0], part[1], int.Parse(part[3]), DateTime.Parse(part[4]), DateTime.Parse(part[5]));
                    if (Validation.isExist(RemoveProduct, part[0]))
                    {
                        RemoveProduct.Add(productinfo);
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Main_Methods.WriteSlow("File not Exist",20,0,0);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("press any kay to rutern Customer Menu...");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                menu.CustomerMenu();
            }
            Console.WriteLine(Main_Methods.CenterText("+-------------------------------------------------------------------------------------------+"));
            Console.WriteLine(Main_Methods.CenterText("|                                    Remove from cart                                       |"));
            Console.WriteLine(Main_Methods.CenterText("+-------------------------------------------------------------------------------------------+"));
            Console.WriteLine(Main_Methods.CenterText("| Please enter the Name of the product to add prodct to cart:                               |"));
            Console.WriteLine(Main_Methods.CenterText("+-------------------------------------------------------------------------------------------+"));
            Console.SetCursorPosition(75, 4);
            string name = Console.ReadLine();

            Product RemoveProductfromcart = cart.FirstOrDefault(p => p.Name == name);
            Product productsToAddQtyProduct = RemoveProduct.FirstOrDefault(p => p.Name == name);

            if (RemoveProductfromcart != null && productsToAddQtyProduct == null)
            {
                cart.Remove(RemoveProductfromcart);
                RemoveProduct.Add(RemoveProductfromcart);
                RewriteInFill(RemoveProduct);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Main_Methods.WriteSlow("The product has been removed from your cart.",20,0,6);
            }
            else if(RemoveProductfromcart != null && productsToAddQtyProduct != null)
            {
                RemoveProduct.Remove(productsToAddQtyProduct);
                productsToAddQtyProduct.Quantity += RemoveProductfromcart.Quantity;
                cart.Remove(RemoveProductfromcart);
                RemoveProduct.Add(productsToAddQtyProduct);
                RewriteInFill(RemoveProduct);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Main_Methods.WriteSlow("The product has been removed from your cart.", 20, 0, 6);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Main_Methods.WriteSlow("The product is not in the cart or the serial number is incorrect", 20, 0, 6);
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("press any kay to rutern Customer Menu...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        public static void CheckOutProduct()
        {
            Console.Clear();
            Console.ResetColor();
            if (cart.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Main_Methods.WriteSlow("Your cart is empty.",20,0,0);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Main_Methods.WriteSlow("File not Exist", 20, 0, 0);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("press any kay to rutern Customer Menu...");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                menu.CustomerMenu();
            }
            Console.WriteLine(Main_Methods.CenterText("+-----------------+----------+"));
            Console.WriteLine(Main_Methods.CenterText("| Name            | Qty      |"));
            Console.WriteLine(Main_Methods.CenterText("+-----------------+----------+"));
            foreach (var item in cart)
            {
                Console.WriteLine(Main_Methods.CenterText($"| {item.Name,-15}(s) | {item.Quantity,-5} |"));
                Console.WriteLine(Main_Methods.CenterText("+-----------------+----------+--------------------+"));
            }
            Console.WriteLine($"Thanks {customer_name} for your purchase!");
            cart.Clear(); // Clear the cart after checkout
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nPress any key to return to Admin Menu...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            return;

        }
        public static void ViweCart()
        {
            Console.Clear();
            Console.ResetColor();
            if (cart.Count != 0)
            {
                Console.WriteLine(Main_Methods.CenterText("+-----------------+-----------------+---------+-----------------+-----------------+"));
                Console.WriteLine(Main_Methods.CenterText("| Name            | Category        | Qty     | Production Date | Expiry Date     |"));
                Console.WriteLine(Main_Methods.CenterText("+-----------------+-----------------+---------+-----------------+-----------------+"));
                string line = "+-----------------+-----------------+---------+-----------------+-----------------+";
                foreach (Product proDuct in cart)
                {
                    Console.WriteLine(Main_Methods.CenterText($"| {proDuct.Name,-15} | {proDuct.Category,-15} | {proDuct.Quantity,-5} | {proDuct.ProductionDate,-15:dd-MM-yyyy} | {proDuct.ExpiryDate,-15:dd-MM-yyyy} |"));
                    Console.WriteLine(Main_Methods.CenterText(line));
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
               Main_Methods.WriteSlow("Your cart is empty.",20,0,0);
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("press any kay to rutern Customer Menu...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        public static void RewriteInFill(List<Product> products)
        {
            List <string> infill = new List<string>();
            foreach (var product in products)
            {
                if (product==null)
                    continue;
                infill.Add($"{product.Name},{product.Category},{product.Quantity},{product.ProductionDate},{product.ExpiryDate}");
            }
            File.WriteAllLines(Program.path,infill);
        }

    }
}

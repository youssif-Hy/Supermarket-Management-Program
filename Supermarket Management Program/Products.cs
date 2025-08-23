
using System;
using System.IO;
using MainMethodsClass;
using Supermarket_Management_Program;
using UI_MenuClass;
using valid;

namespace productSection
{
    public class Product 
    {
        // Attributes
        public  string Name { get; set; }
        public  string Category { get; set; }
        public  int Quantity { get; set; }
        public  DateTime ProductionDate { get; set; }
        public  DateTime ExpiryDate { get; set; }
        public Product(string name, string category, int quantity, DateTime productionDate, DateTime expiryDate)
        {
            Name = name;
            Category = category;
            Quantity = quantity;
            ProductionDate = productionDate;
            ExpiryDate = expiryDate;
        }
        // Check days before expiry
        public bool Expiry()
        {
            TimeSpan remaining = ExpiryDate - DateTime.Now;
            if (remaining.TotalDays <= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Method
        public static void Display(bool isadmin)
        {
            Console.Clear();
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
            Console.WriteLine(Main_Methods.CenterText("+-----------------+-----------------+---------+-----------------+-----------------+--------------+"));
            Console.WriteLine(Main_Methods.CenterText("| Name            | Category        | Qty     | Production Date | Expiry Date     | Status       |"));
            Console.WriteLine(Main_Methods.CenterText("+-----------------+-----------------+---------+-----------------+-----------------+--------------+"));
            string line = "+-----------------+-----------------+---------+-----------------+-----------------+--------------+";
            foreach (Product proDuct in Program.products)
            {
                string s = proDuct.Expiry() ? "💀Near Expiry" : "Valid";
                Console.WriteLine(
                    Main_Methods.CenterText(
                        $"| {proDuct.Name,-15} " +
                        $"| {proDuct.Category,-15} " +
                        $"| {proDuct.Quantity,-7} " +
                        $"| {proDuct.ProductionDate,-14:dd/MM/yyyy}  " +
                        $"| {proDuct.ExpiryDate,-15:dd/MM/yyyy} " +
                        $"|{s,-11} |"
                    )
                ); Console.WriteLine(Main_Methods.CenterText(line));
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("press any kay to rutern to Menu...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
    }
}

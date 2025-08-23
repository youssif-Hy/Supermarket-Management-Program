
using System;
using System.IO;
using MainMethodsClass;
using Supermarket_Management_Program;

namespace productSection
{
    public class Product 
    {
        // Attributes
        public  string Name { get; set; }
        public  string Category { get; set; }
        public  string SerialNumber { get; set; }
        public  int Quantity { get; set; }
        public  DateTime ProductionDate { get; set; }
        public  DateTime ExpiryDate { get; set; }
        public Product(string name, string category, string serialNumber, int quantity, DateTime productionDate, DateTime expiryDate)
        {
            Name = name;
            Category = category;
            SerialNumber = serialNumber;
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
        public static void Display()
        {
            Console.Clear();
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
                    Program.products.Add(productinfo);
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
            }
            Console.WriteLine(Main_Methods.CenterText("+-----------------+-----------------+-----------------+---------+-----------------+-----------------+--------------+"));
            Console.WriteLine(Main_Methods.CenterText("| Name            | Category        | Serial Number   | Qty     | Production Date | Expiry Date     | Status       |"));
            Console.WriteLine(Main_Methods.CenterText("+-----------------+-----------------+-----------------+---------+-----------------+-----------------+--------------+"));
            string line = "+-----------------+-----------------+-----------------+---------+-----------------+-----------------+--------------+";
            foreach (Product proDuct in Program.products)
            {
                string s = proDuct.Expiry() ? "💀 Near Expiry" : "Valid";
                Console.WriteLine(Main_Methods.CenterText($"| {proDuct.Name,-15} | {proDuct.Category,-15} | {proDuct.SerialNumber,-10} | {proDuct.Quantity,-5} | {proDuct.ProductionDate:dd-MM-yyyy,-15} | {proDuct.ExpiryDate:dd-MM-yyyy,-15} | {s,-20} |"));
                Console.WriteLine(line);
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("press any kay to rutern Customer Menu...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
    }
}

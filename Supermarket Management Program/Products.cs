
using System;
using System.Collections.Generic;
using System.IO;

namespace test_1
{
    class Product
    {
        //Attributes
        public string Name { get; set; }
        public string Category { get; set; }
        public string SerialNumber { get; set; }
        public int Quantity { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        public Product(string name, string caregiry, string serialNumber, int quantity, DateTime productionDate, DateTime expiryDate)
        {
            Name = name;
            Category = caregiry;
            SerialNumber = serialNumber;
            Quantity = quantity;
            ProductionDate = productionDate;
            ExpiryDate = expiryDate;
        }
        //فحص عدد الايام قبل انتهاء الصلاحية
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
        public void Display()
        {
            Console.WriteLine($"Product name: {Name}");
            Console.WriteLine($"Product category: {Category}");
            Console.WriteLine($"Serial Number: {Quantity}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Production Date: {ProductionDate:dd:MM:yyyy}");
            Console.WriteLine($"Expiry Date: {ExpiryDate:dd:MM:yyyy}");

            if (Expiry())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(">>Alert this product is near expiry!");
                Console.ResetColor();
            }
        }


    };
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            string file = "products.txt";

            if (File.Exists(file))
            {

                string[] fileLines = File.ReadAllLines(file);
                foreach (string line in fileLines)
                {
                    if (line == "")
                    {
                        continue;
                    }
                    string[] part = line.Split(',');
                    Product p = new Product(part[0], part[1], part[2], int.Parse(part[3]), DateTime.Parse(part[4]), DateTime.Parse(part[5]));
                    products.Add(p);
                }

            }
            else
            {
                Console.WriteLine("File not Exist");
            }

            foreach (Product proDuct in products)
            {
                proDuct.Display();
                Console.WriteLine("=======");
            }

        }
    }
}

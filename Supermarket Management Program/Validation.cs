using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using MainMethodsClass;
using productSection;
using Supermarket_Management_Program;

namespace valid
{
    public class Validation
    {
        //دالة ValidateInput تقوم بالتحقق من صحة الإدخال المدخل من قبل المستخدم
        public static int ValidateInput(string input, int xaxis, int yaxis, int xaxis1, int yaxis1)
        {
            int value;
            string title = "Invalid input ,try again plese enter valid input";
            while (true)
            {
                // التحقق من أن الإدخال هو رقم صحيح
                if (!int.TryParse(input, out value))
                {
                    Main_Methods.space(title, xaxis1, yaxis1);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Main_Methods.WriteSlow(title, 20, xaxis1, yaxis1);
                    Main_Methods.space(input, xaxis, yaxis);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(xaxis, yaxis);
                    input = Console.ReadLine();
                }
                else
                {
                    Main_Methods.space(title, xaxis1, yaxis1);
                    return value;
                }
            }
        }
        public static string ValiDateName(string name, int xaxis, int yaxis, int xaxis1, int yaxis1)
        {
            string title = "invalid name, Please enter a valid name (at least 8 characters,first and last name must be more than 3 characters) ,try again. ";
            while (true)
            {
                // التحقق من طول الاسم ووجود مسافة بين الاسم الأول والاسم الأخير
                if (name.Length > 7 && name.Contains(' '))
                {
                    // تقسيم الاسم إلى أجزاء باستخدام المسافة كفاصل
                    string[] nameParts = name.Split(' ');
                    // التحقق من أن الاسم الأول والاسم الأخير يتكونان من أحرف فقط وطولهما أكبر من 3 أحرف
                    if (nameParts[0].Length > 3 && nameParts[0].All(char.IsLetter) && nameParts[1].Length > 3 && nameParts[1].All(char.IsLetter))
                    {
                        Main_Methods.space(title, xaxis1, yaxis1);
                        return name;
                    }
                    // إذا لم يكن الاسم صالحًا، يطلب من المستخدم إدخال اسم آخر
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.SetCursorPosition(xaxis1, yaxis1);
                        Console.Write(title);
                        Main_Methods.space(name, xaxis, yaxis);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(xaxis, yaxis);
                        name = Console.ReadLine();
                    }
                }
                // إذا لم يكن الاسم صالحًا، يطلب من المستخدم إدخال اسم آخر
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(xaxis1, yaxis1);
                    Console.Write(title);
                    Main_Methods.space(name, xaxis, yaxis);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(xaxis, yaxis);
                    name = Console.ReadLine();
                }
            }
        }

        public static string ValiDateNameproduct(string name, int xaxis, int yaxis, int xaxis1, int yaxis1)
        {
            while (true)
            {
                string error = "The product is exist already or the quantity is to much please enter new product.";

                Product productfound = Program.products.FirstOrDefault(p => p.Name.ToLower() == name.ToLower());
                if (productfound != null && productfound.Quantity >= 3)
                {
                    Main_Methods.space(error, xaxis1, yaxis1);
                    return name;

                }
                else if (productfound == null)
                {
                    Main_Methods.space(error, xaxis1, yaxis1);
                    return name;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(xaxis1, yaxis1);
                    Console.Write(error);
                    Main_Methods.space(name, xaxis, yaxis);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(xaxis, yaxis);
                    name = Console.ReadLine();
                }
            }
        }
        public static string ValidCategory(string category, int xaxis, int yaxis, int xaxis1, int yaxis1)
        {
            while (true)
            {
                string errorM = "Please enter a valid category (ex: Dairy, Bakery, Beverages, Snacks, Produce, Meat, Seafood, Frozen, Cleaning, Personal Care).";
                while (true)
                {
                    category =category.ToLower();
                    if (category == "dairy" || category == "bakery" || category == "beverages" || category == "snacks" || category == "produce" || category == "meat" || category == "seafood" || category == "frozen" || category == "cleaning" || category == "personal care")
                    {
                        Main_Methods.space(errorM, xaxis1, yaxis1);
                        return category;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.SetCursorPosition(xaxis1, yaxis1);
                        Console.Write(errorM);
                        Main_Methods.space(category, xaxis, yaxis);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(xaxis, yaxis);
                        category = Console.ReadLine();
                    }
                }
            }
        }
        public static DateTime ValidProduction(string production, int xaxis, int yaxis, int xaxis1, int yaxis1)
        {
            while (true)
            {
                string errorM = "Invalid production date, please enter valid date in the format mm/dd/yyyy, try again. ";
                if (DateTime.TryParse(production,out DateTime prod))
                {
                    if (prod < DateTime.Now)
                    {
                        Main_Methods.space(errorM, xaxis1, yaxis1);
                        return prod;
                    }
                }
                // إذا كان تاريخ الميلاد في المستقبل، يطلب من المستخدم إدخال تاريخ آخر
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(xaxis1, yaxis1);
                    Console.Write(errorM);
                    Main_Methods.space(production, xaxis, yaxis);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(xaxis, yaxis);
                    production = Console.ReadLine();
                }
            }
        }
        public static DateTime ValidExpiryDate(string ExpiryDate, int xaxis, int yaxis, int xaxis1, int yaxis1)
        {
            while (true)
            {
                string errorM = "Invalid Expiry Date date, please enter valid date in the format mm/dd/yyyy, try again. ";
                if (DateTime.TryParse(ExpiryDate, out DateTime Expiry))
                {
                    if (Expiry > DateTime.Now)
                    {
                        Main_Methods.space(errorM, xaxis1, yaxis1);
                        return Expiry;
                    }
                }
                // إذا كان تاريخ الميلاد في المستقبل، يطلب من المستخدم إدخال تاريخ آخر
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(xaxis1, yaxis1);
                    Console.Write(errorM);
                    Main_Methods.space(ExpiryDate, xaxis, yaxis);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(xaxis, yaxis);
                    ExpiryDate = Console.ReadLine();
                }
            }
        }
        public static bool isExist(List <Product> product ,string name)
        {
            
            bool isExist = true;
            foreach (Product product1 in product)
            {
                if (product1.Name == name)
                {
                    isExist = false;
                    break;
                }
            }
            return isExist;
        }
    }
}

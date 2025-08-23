using System;
using MainMethodsClass;
using valid;
using Admin;
using Customer_Section;
using productSection;
using System.Diagnostics;


namespace UI_MenuClass
{
    public class menu
    {
        // This class contains methods to display various menus for the supermarket management program.
        public static void WelcomeMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Main_Methods.CenterText("░██████╗██╗░░░██╗██████╗░███████╗██████╗░███╗░░░███╗░█████╗░██████╗░██╗░░██╗███████╗████████╗"));
            Console.WriteLine(Main_Methods.CenterText("██╔════╝██║░░░██║██╔══██╗██╔════╝██╔══██╗████╗░████║██╔══██╗██╔══██╗██║░██╔╝██╔════╝╚══██╔══╝"));
            Console.WriteLine(Main_Methods.CenterText("╚█████╗░██║░░░██║██████╔╝█████╗░░██████╔╝██╔████╔██║███████║██████╔╝█████═╝░█████╗░░░░░██║░░░"));
            Console.WriteLine(Main_Methods.CenterText("░╚═══██╗██║░░░██║██╔═══╝░██╔══╝░░██╔══██╗██║╚██╔╝██║██╔══██║██╔══██╗██╔═██╗░██╔══╝░░░░░██║░░░"));
            Console.WriteLine(Main_Methods.CenterText("██████╔╝╚██████╔╝██║░░░░░███████╗██║░░██║██║░╚═╝░██║██║░░██║██║░░██║██║░╚██╗███████╗░░░██║░░░"));
            Console.WriteLine(Main_Methods.CenterText("╚═════╝░░╚═════╝░╚═╝░░░░░╚══════╝╚═╝░░╚═╝╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝░░░╚═╝░░░"));
            Console.WriteLine(Main_Methods.CenterText("███╗░░░███╗███╗░░██╗░██████╗░░░░██████╗░██████╗░░█████╗░"));
            Console.WriteLine(Main_Methods.CenterText("████╗░████║████╗░██║██╔════╝░░░░██╔══██╗██╔══██╗██╔══██╗"));
            Console.WriteLine(Main_Methods.CenterText("██╔████╔██║██╔██╗██║██║░░██╗░░░░██████╔╝██████╔╝██║░░██║"));
            Console.WriteLine(Main_Methods.CenterText("██║╚██╔╝██║██║╚████║██║░░╚██╗░░░██╔═══╝░██╔══██╗██║░░██║"));
            Console.WriteLine(Main_Methods.CenterText("██║░╚═╝░██║██║░╚███║╚██████╔╝██╗██║░░░░░██║░░██║╚█████╔╝"));
            Console.WriteLine(Main_Methods.CenterText("╚═╝░░░░░╚═╝╚═╝░░╚══╝░╚═════╝░╚═╝╚═╝░░░░░╚═╝░░╚═╝░╚════╝░"));
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(Main_Methods.CenterText("Welcome to the Supermarket Management Program!"));
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(Main_Methods.CenterText("press any key to continue..."));
            Console.ReadKey();
            Console.Clear();
        }
        public static void MainMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(Main_Methods.CenterText("Welcome to the Supermarket Management Program!"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Customer section");
            Console.WriteLine("2. Admin section");
            Console.WriteLine("3. Exit");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Enter your choice:");
            Console.ResetColor();
            int choice;
            while (true)
            {
                // رسالة خطأ في حالة إدخال غير صحيح
                string errorMessage = "Invalid input, please enter a number between 1 and 3.";
                // تعيين موضع المؤشر في الشاشة
                Console.SetCursorPosition(18, 4);
                // قراءة إدخال المستخدم والتحقق من صحته
                choice = Validation.ValidateInput(Console.ReadLine(), 18, 4, 0, 5);
                // إذا كان الخيار غير صحيح، عرض رسالة الخطأ
                if (choice != 1 && choice != 2 && choice != 3)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Main_Methods.WriteSlow(errorMessage, 20, 0, 5);
                    Console.ForegroundColor = ConsoleColor.White;
                    Main_Methods.space(choice.ToString(), 18, 4);
                }
                // إذا كان الإدخال صحيحًا، الخروج من الحلقة
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Main_Methods.space(errorMessage, 0, 5);
                    break;
                }
            }
            switch (choice)
            {
                case 1:
                    // عرض قسم العملاء
                    Customerlogin();
                    break;
                case 2:
                    // عرض قسم المسؤول
                    adminlogin();
                    break;
                case 3:
                    // الخروج من البرنامج
                    Main_Methods.WriteSlow("Thank you for using the Supermarket Management Program. Goodbye!",20,0,0);
                    Environment.Exit(0);
                    break;
            }
        }
        public static void Customerlogin()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            // ASCII Art لعرض عنوان تسجيل الدخول 
            Console.WriteLine(Main_Methods.CenterText("╔══════════════════════════════════════════════════════╗"));
            Console.WriteLine(Main_Methods.CenterText("║                      Customer LOG IN                 ║"));
            Console.WriteLine(Main_Methods.CenterText("║               --------------------------             ║"));
            Console.WriteLine(Main_Methods.CenterText("║                                                      ║"));
            Console.WriteLine(Main_Methods.CenterText("║   ➤ Enter Your Name :                                ║"));
            Console.WriteLine(Main_Methods.CenterText("║                                                      ║"));
            Console.WriteLine(Main_Methods.CenterText("║               [ Press ENTER to Submit ]              ║"));
            Console.WriteLine(Main_Methods.CenterText("╚══════════════════════════════════════════════════════╝"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(55, 4);
            var customer =new Customer();
            Customer.customer_name = Validation.ValiDateName(Console.ReadLine(),55,4,0,8);
            CustomerMenu(); 

        }
        public static void CustomerMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(Main_Methods.CenterText("Customer section"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. View available products");
            Console.WriteLine("2. View all products");
            Console.WriteLine("3. Add Product to Cart");
            Console.WriteLine("4. Remove Product from Cart");
            Console.WriteLine("5. View my cart");
            Console.WriteLine("6. Checkout");
            Console.WriteLine("7. Exit to Main Menu");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Enter your choice: ");
            Console.ResetColor();
            int choice;
            while (true)
            {
                // قراءة إدخال المستخدم والتحقق من صحته
                choice = Validation.ValidateInput(Console.ReadLine(), 18, 8, 0, 9);
                string errorMessage = "Invalid input, please enter a number between 1 and 5.";
                // إذا كان الخيار غير صحيح، عرض رسالة الخطأ
                if (choice < 1 || choice > 7)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Main_Methods.WriteSlow(errorMessage, 20, 0, 5);
                    Console.ForegroundColor = ConsoleColor.White;
                    Main_Methods.space(choice.ToString(), 18, 4);
                }
                // إذا كان الإدخال صحيحًا، الخروج من الحلقة
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Main_Methods.space(errorMessage, 0, 5);
                    break;
                }
            }
            switch (choice)
            {
                case 1:
                    // عرض المنتجات
                    AdminModule.ViewProducts(false);
                    CustomerMenu();
                    break;
                case 2:
                    Product.Display(false);
                    CustomerMenu();
                    break;
                case 3:
                    // إضافة منتج إلى السلة
                    MenuBuyProduct();
                    CustomerMenu();
                    break;
                case 4:
                    // إزالة منتج من السلة
                    Customer.RemoveProductFromCart();
                    CustomerMenu();
                    break;
                case 5:
                    //عرض عربة التسوق
                    Customer.ViweCart();
                    CustomerMenu();
                    break;
                case 6:
                    // إتمام عملية الشراء
                    Customer.CheckOutProduct();
                    CustomerMenu();
                    break;
                case 7:
                    // العودة إلى القائمة الرئيسية
                    Console.Clear();
                    MainMenu();
                    break;
            }
        }
        public static void adminlogin()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            // ASCII Art لعرض عنوان تسجيل الدخول 
            Console.WriteLine(Main_Methods.CenterText("╔══════════════════════════════════════════════════════╗"));
            Console.WriteLine(Main_Methods.CenterText("║                      Admin LOG IN                    ║"));
            Console.WriteLine(Main_Methods.CenterText("║               --------------------------             ║"));
            Console.WriteLine(Main_Methods.CenterText("║                                                      ║"));
            Console.WriteLine(Main_Methods.CenterText("║   ➤ Enter Your Username :                            ║"));
            Console.WriteLine(Main_Methods.CenterText("║   ➤ Enter Your Password :                            ║"));
            Console.WriteLine(Main_Methods.CenterText("║                                                      ║"));
            Console.WriteLine(Main_Methods.CenterText("║               [ Press ENTER to Submit ]              ║"));
            Console.WriteLine(Main_Methods.CenterText("╚══════════════════════════════════════════════════════╝"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(59, 4); 
            string user_name = Console.ReadLine();
            Console.SetCursorPosition(59, 5); 
            string password = Console.ReadLine();
            foreach (AdminModule i in AdminModule.adminList)
            {
                
                if (i.AdminUsername == user_name && i.AdminPassword == password)
                {
                    Console.Clear();
                    AdminMenu();
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Main_Methods.WriteSlow("Invalid username or password. Please try again.\n",20,0,9);
            Console.ResetColor();
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
            Console.Clear();
            MainMenu();// العودة إلى القائمة الرئيسية
        }
        public static void AdminMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(Main_Methods.CenterText("Admin section"));
            // هنا يمكنك إضافة المزيد من الخيارات والإجراءات الخاصة بالمسؤول
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. View available products");
            Console.WriteLine("2. View all products");
            Console.WriteLine("3. Add Product");
            Console.WriteLine("4. Remove Product");
            Console.WriteLine("5. view Expiry Alerts");
            Console.WriteLine("6. Chich Products Expiry");
            Console.WriteLine("7. Exit to Main Menu");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Enter your choice: ");
            Console.ResetColor();
            int choice;
            while (true)
            {
                // قراءة إدخال المستخدم والتحقق من صحته
                choice = Validation.ValidateInput(Console.ReadLine(), 18, 8, 0, 9);
                string errorMessage = "Invalid input, please enter a number between 1 and 7.";
                // إذا كان الخيار غير صحيح، عرض رسالة الخطأ
                if (choice < 1 || choice > 7)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Main_Methods.WriteSlow(errorMessage, 20, 0, 9);
                    Console.ForegroundColor = ConsoleColor.White;
                    Main_Methods.space(choice.ToString(), 18, 8);
                }
                // إذا كان الإدخال صحيحًا، الخروج من الحلقة
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Main_Methods.space(errorMessage, 0, 9);
                    break;
                }
            }
            switch (choice)
            {
                case 1:
                    // عرض المنتجات
                    AdminModule.ViewProducts(true);
                    AdminMenu();
                    break;
                case 2:
                    Product.Display(true);
                    AdminMenu();
                    break;
                case 3:
                    // إضافة منتج
                    AdminModule.AddProduct();
                    AdminMenu();
                    break;
                case 4:
                    // إزالة منتج
                    AdminModule.DeleteProduct();
                    AdminMenu();
                    break;
                case 5:
                    // عرض كل المنتجات القريبة من اتهاء الصلاحية
                    AdminModule.ViewExpiryAlerts();
                    AdminMenu();
                    break;
                case 6:
                    AdminModule.ChechProductsExpir();
                    AdminMenu();
                    break;
                case 7:
                    // العودة إلى القائمة الرئيسية
                    Console.Clear();
                    MainMenu();
                    break;
            }
        }
        public static void MenuBuyProduct()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Main_Methods.CenterText("+-------------------------------------------------------------------------------------------+"));
            Console.WriteLine(Main_Methods.CenterText("|                                     add to cart                                           |"));
            Console.WriteLine(Main_Methods.CenterText("+-------------------------------------------------------------------------------------------+"));
            Console.WriteLine(Main_Methods.CenterText("| Please enter the Name of the product to add prodct to cart:                               |"));
            Console.WriteLine(Main_Methods.CenterText("| Plaese enter the Quantity you want:                                                       |"));
            Console.WriteLine(Main_Methods.CenterText("+-------------------------------------------------------------------------------------------+"));
            // البحث عن المنتج الذي سيتم حذفه
            Console.ResetColor();
            Console.SetCursorPosition(74, 3);
            string name = Console.ReadLine();
            Console.SetCursorPosition(50, 4);
            int quantity = Validation.ValidateInput(Console.ReadLine(), 55, 4, 0, 8);
            Customer.BuyProduct(name, quantity);
        }
    }
}
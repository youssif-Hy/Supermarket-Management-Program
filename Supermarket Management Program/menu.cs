using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainMethodsClass;
using valid;
using System.IO;
using Supermarket_Management_Program;


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
            Console.WriteLine(Main_Methods.CenterText("███╗░░░███╗░█████╗░███╗░░██╗░█████╗░░██████╗░███████╗███╗░░░███╗███████╗███╗░░██╗████████╗░░░██████╗░░█████╗░░██████╗░██████╗░░█████╗░███╗░░░███╗"));
            Console.WriteLine(Main_Methods.CenterText("████╗░████║██╔══██╗████╗░██║██╔══██╗██╔════╝░██╔════╝████╗░████║██╔════╝████╗░██║╚══██╔══╝░░░██╔══██╗██╔══██╗██╔════╝░██╔══██╗██╔══██╗████╗░████║"));
            Console.WriteLine(Main_Methods.CenterText("██╔████╔██║███████║██╔██╗██║███████║██║░░██╗░█████╗░░██╔████╔██║█████╗░░██╔██╗██║░░░██║░░░░░░██████╔╝██║░░██║██║░░██╗░██████╔╝███████║██╔████╔██║"));
            Console.WriteLine(Main_Methods.CenterText("██║╚██╔╝██║██╔══██║██║╚████║██╔══██║██║░░╚██╗██╔══╝░░██║╚██╔╝██║██╔══╝░░██║╚████║░░░██║░░░░░░██╔══██╗██║░░██║██║░░╚██╗██╔══██╗██╔══██║██║╚██╔╝██║"));
            Console.WriteLine(Main_Methods.CenterText("██║░╚═╝░██║██║░░██║██║░╚███║██║░░██║╚██████╔╝███████╗██║░╚═╝░██║███████╗██║░╚███║░░░██║░░░░░░██║░░██║╚█████╔╝╚██████╔╝██║░░██║██║░░██║██║░╚═╝░██║"));
            Console.WriteLine(Main_Methods.CenterText("╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚═════╝░╚══════╝╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░░░░╚═╝░░╚═╝░╚════╝░░╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░░░╚═╝"));
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(Main_Methods.CenterText("Welcome to the Supermarket Management Program!"));
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(Main_Methods.CenterText("press any key to continue..."));
            Console.ReadKey();
            Console.Clear();
        }
        public static void WelcomeMenu2()
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
                    CustomerMenu();
                    break;
                case 2:
                    // عرض قسم المسؤول
                    adminlogin();
                    break;
                case 3:
                    // الخروج من البرنامج
                    Console.WriteLine("Thank you for using the Supermarket Management Program. Goodbye!");
                    Environment.Exit(0);
                    break;
            }
        }
        public static void CustomerMenu()
        {
            Console.Clear();
            Console.WriteLine(Main_Methods.CenterText("Customer section"));
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
            Console.SetCursorPosition(59, 4); // اعادة تعيين موضع المؤشر لاسم المستخدم
            string user_name = Console.ReadLine();
            Console.SetCursorPosition(59, 5); // اعادة تعيين موضع المؤشر لكلمة المرور
            string password = Console.ReadLine();
            // قراءة بيانات المسؤول والتحقق من صحة اسم المستخدم وكلمة المرور
            /*
            if (adminData[0] == user_name && adminData[1] == password)
            {
                AdminMenu();
            }
            else
            {
                Console.SetCursorPosition(0, 10); // تعيين موضع المؤشر لعرض رسالة الخطأ
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid username or password. Please try again.");
                Console.ResetColor();
                Console.SetCursorPosition(0, 11); // تعيين موضع المؤشر لعرض رسالة العودة
                Console.WriteLine("Press any key to return to the main menu...");
                Console.ReadKey();
                Console.Clear();
                MainMenu();// العودة إلى القائمة الرئيسية
            }
            */
        }
        public static void AdminMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(Main_Methods.CenterText("Admin section"));
            // هنا يمكنك إضافة المزيد من الخيارات والإجراءات الخاصة بالمسؤول
            Console.WriteLine("1. View Products");
            Console.WriteLine("2. Add Product");
            Console.WriteLine("3. Remove Product");
            Console.WriteLine("4. Update Product");
            Console.WriteLine("5. Exit to Main Menu");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Enter your choice: ");
            Console.ResetColor();
            int choice;
            while (true)
            {
                // قراءة إدخال المستخدم والتحقق من صحته
                choice = Validation.ValidateInput(Console.ReadLine(), 18, 4, 0, 5);
                string errorMessage = "Invalid input, please enter a number between 1 and 5.";
                // إذا كان الخيار غير صحيح، عرض رسالة الخطأ
                if (choice < 1 || choice > 5)
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
                    Console.WriteLine("Displaying products...");
                    // هنا يمكنك إضافة الكود لعرض المنتجات
                    break;
                case 2:
                    // إضافة منتج
                    Console.WriteLine("Adding a new product...");
                    // هنا يمكنك إضافة الكود لإضافة منتج جديد
                    break;
                case 3:
                    // إزالة منتج
                    Console.WriteLine("Removing a product...");
                    // هنا يمكنك إضافة الكود لإزالة منتج
                    break;
                case 4:
                    // تحديث منتج
                    Console.WriteLine("Updating a product...");
                    // هنا يمكنك إضافة الكود لتحديث منتج
                    break;
                case 5:
                    // العودة إلى القائمة الرئيسية
                    Console.Clear();
                    MainMenu();
                    break;
            }
        }
    }
}
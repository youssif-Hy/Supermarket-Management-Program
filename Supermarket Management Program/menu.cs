using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainMethodsClass;
using UI_MenuClass;
using valid;


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
        public static int MainMenu()
        {
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
            return choice;

        }
        public static void CustomerMenu()
        {
            Console.WriteLine("Customer Management Menu:");
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Update Customer");
            Console.WriteLine("3. Delete Customer");
            Console.WriteLine("4. View Customers");
            Console.WriteLine("5. Back to Main Menu");
        }

    }
}





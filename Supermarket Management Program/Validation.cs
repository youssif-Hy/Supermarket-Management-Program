using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainMethodsClass;
using UI_MenuClass;

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
    }
}

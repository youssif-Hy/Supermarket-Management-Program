using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MainMethodsClass
{
    public class Main_Methods
    {
        //دالة WriteSlow تقوم بكتابة النص ببطء على الشاشة
        public static void WriteSlow(string word, int delay, int xaxis, int yaxis)
        {
            //loop تلف حول طول الكلمة وتقوم بكتابتها ببطء في المكان المحدد
            for (int i = 0; i < word.Length; i++)
            {
                // تعيين موضع الكتابة على الشاشة
                Console.SetCursorPosition(xaxis + i, yaxis);
                // كتابة الحرف الحالي من الكلمة
                Console.Write(word[i]);
                // الانتظار لمدة معينة قبل كتابة الحرف التالي
                Thread.Sleep(delay);
            }
        }
        //دالة space تقوم بإزالة الكتابة في مكان معين في الشاشة
        public static void space(string input, int xaise, int yaise)
        {
            //loop تلف حول طول الإدخال وتقوم بإزالة الكتابة في المكان المحدد
            for (int i = 0; i < input.Length; i++)
            {
                int positionX = xaise + i;
                // التحقق من أن الموضع لا يتجاوز حدود الشاشة
                // console.BufferWidth و Console.BufferHeight تعطيان عرض وارتفاع الشاشة
                if (positionX < Console.BufferWidth && yaise < Console.BufferHeight)
                {
                    Console.SetCursorPosition(positionX, yaise);
                    Console.Write(" ");
                }
            }
        }
        // دالة CenterText تقوم بجعل النص في وسط الشاشة
        public static string CenterText(string text)
        {
            int padding = (Console.WindowWidth - text.Length) / 2;
            return new string(' ', Math.Max(padding, 0)) + text;
        }
    }
}

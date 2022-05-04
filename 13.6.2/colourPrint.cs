using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13._6._2
{
    internal class colourPrint
    {
       public static void ColourPrintGreen(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }

       public static void ColourPrintRed(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }

       public static void ColourPrintYellow(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void ColourPrintBlue(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public static void ColourPrintBlueRed(string text,int count)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Слово: ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(text+ " ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Повторений в тексте: ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(count + " \n");
            Console.ResetColor();

        }
    }
}


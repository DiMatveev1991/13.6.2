using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13._6._2
{
    public class ReadPathFile
    {
       public static string FileSelection()
        {
            colourPrint.ColourPrintBlue("\nУкажите полный путь до тестируемого текстового файла:");
            string file_path = Console.ReadLine();
         // string file_path = @"C:\Users\Дмитрий\OneDrive\Рабочий стол\данные по программе аршин\Text1.txt";
            if (File.Exists(file_path))
            {
                colourPrint.ColourPrintGreen("\nФайл найден и принят программой.");
                return file_path;
            }
            else
            {
                do
                {
                    colourPrint.ColourPrintRed("\nФайл не найден или не существует.");
                    colourPrint.ColourPrintBlue("\nУкажите полный путь до тестируемого текстового файла еще раз:");
                    file_path = Console.ReadLine();
                }
                while (!File.Exists(file_path));
                {
                    colourPrint.ColourPrintGreen("Файл найден и принят программой.");
                    return file_path;
                }
            }
        }
    }
}

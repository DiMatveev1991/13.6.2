using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Linq;
using System.Collections.Immutable;

namespace Task_13._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string file_path = ReadPathFile.FileSelection();
            TopWords.TopWord(file_path);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13._6._2
{
    internal class TopWords
    {
        public static void TopWord (string PathFile)
        {
           try {
                var x = File.ReadAllText(PathFile);
                var noPunctuationText = new string(x.Where(c => !char.IsPunctuation(c)).ToArray());
                IEnumerable<string> words = noPunctuationText.Split(' ').Where(q => !string.IsNullOrEmpty(q));

                var wordList = new List<String>(words);
                var grouped = wordList
                                    .GroupBy(i => i)
                                    .Select(i => new { Word = i.Key, Count = i.Count() }).OrderByDescending(i => i.Count)
                                    .Take(10);

                foreach (var i in grouped)
                {
                    colourPrint.ColourPrintBlueRed(i.Word, i.Count);
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
             Console.WriteLine(ex.Message); 
            }
        }
    }
}

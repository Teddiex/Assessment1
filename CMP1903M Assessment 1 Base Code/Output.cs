using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Output
    {
        public List<int> outputFile(string input)
        {
            List<int> output = new List<int>();
            //Create a file named longWords.txt
            //Should be saved in CMP1903M Assessment 1 Base Code\CMP1903M Assessment 1 Base Code\bin\Debug\net6.0\longwords.txt
            using StreamWriter file = new StreamWriter("longWords.txt");
            string[] words = input.Split(new Char[] { ' ', '.', '!', '?', ',' }); //remove these characters
            foreach (var w in words)
            {
                if (w.Trim() != " ")
                {
                    if (w.Length >= 7)
                    {
                        file.Write(w + "\n"); //write word to file + newline
                        output.Add(0);
                    }
                }

            }
            if (output.Count > 0) //if list has greater than 0 values then there is a 7 letter word.
            {
                Console.WriteLine("\n");
                Console.WriteLine($"The number of words 7 letters or greater is {output.Count}.");
                Console.WriteLine("\n"); //looks neater
            }

            return output;
        }
    }
}

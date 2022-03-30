//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CMP1903M_Assessment_1_Base_Code.Input;
using static CMP1903M_Assessment_1_Base_Code.Analyse;
using static CMP1903M_Assessment_1_Base_Code.Report;


namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {

        static void Main()
        {
            //List to hold parameters and output
            List<int> parameters = null;
            List<int> output = null;
            //string to hold input
            string input = "nothing"; 
            

            //Create 'Input' object
            Input newInput = new Input();
            //Creating an Analyse object
            Analyse analyse = new Analyse();
            //Creating a Report Object
            Report report = new Report();
            //Creating an output object - new class <----
            Output outputFile = new Output();

            //User chooses to enter text manually or read text from a file within a desired path.
            Console.WriteLine("1: Enter text manually.");
            Console.WriteLine("2: Read text from a file.");
            
            while (true)
            {
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        
                        input = newInput.ManualTextInput();
                        parameters = analyse.AnalyseText(input);
                        
                        break;

                    }
                    else if (choice == 2)
                    {
                       
                        input = newInput.FileTextInput(input);//pass the input from the file path
                        parameters = analyse.AnalyseText(input);
                        output = outputFile.OutputFile(input);
                        outputFile.messageOutput = "Frequencies:\n";
                        Console.WriteLine(outputFile.messageOutput);
                        
                        break;


                    }
                    else
                        Console.WriteLine("1: Enter text manually.");
                        Console.WriteLine("2: Read text from a file.");

                }

                catch
                {
                    Console.WriteLine("1: Enter text manually.");
                    Console.WriteLine("2: Read text from a file.");
                }
            }
            
            int vowels = report.VowelCount(parameters);
            int upperLetters = report.UpperCount(parameters);
            int sentences = report.SentenceCount(parameters);
            int lowerLetters = report.LowerCount(parameters);
            int consonants = report.ConsonantCount(parameters);

            //Outputting the count of each to user.
            Console.WriteLine("Number of vowels: "+vowels);
            Console.WriteLine("Number of upper case letters: " + upperLetters);
            Console.WriteLine("Number of sentences: " + sentences);
            Console.WriteLine("Number of lower case letters "+ lowerLetters);
            Console.WriteLine("Number of consonants: " + consonants);

        }
    
    }
}

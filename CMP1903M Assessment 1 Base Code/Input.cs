using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1

        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            Console.WriteLine("Enter a set of strings, ending each sentence with a '.' followed by an asterisk");
            string text = Console.ReadLine();
            return text;
        }

        //Method: fileTextInput
        //Arugments: path
        //Returns: string or null
        //Gets text input from a .txt file
        public string fileTextInput(string path)
        {
            
            //Exits program if the file is not found.
            try
            {
                Console.WriteLine("Enter the path of the file");
                path = Console.ReadLine();
                string text = File.ReadAllText(@path);
                return text;
            }
            catch
            {
                Console.WriteLine("File not found, program terminated");
                Environment.Exit(1);
                return null;
            }

        }

    }


}

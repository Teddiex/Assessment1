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
        public string ManualTextInput()
        {
            Console.WriteLine("Enter a set of strings, ending each sentence with a '.' followed by an asterisk");
            string text = Console.ReadLine();
            return text;
        }

        //Method: fileTextInput
        //Arugments: path
        //Returns: string or null
        //Gets text input from a .txt file
        public string FileTextInput(string path)
        {
            
            do //loop until a valid path is given
            {     
                Console.WriteLine("Enter the path of the file: ");
                path = Console.ReadLine();
                if (!path.EndsWith(".txt"))
                    path = path + ".txt";
                string text = File.ReadAllText(@path);
                return text;
                
                
            } while (path == ".txt" || !File.Exists(path));
        }

    }


}

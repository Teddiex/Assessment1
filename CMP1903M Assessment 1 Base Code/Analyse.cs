using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text
        public void RemoveAsterisk(string input)
        {
            if (input.Contains('*'))
            {
                input = input.Substring(0, input.IndexOf("*"));
            }
        }
      
        public List<int> AnalyseText(string input)
        {

            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> parameters = new List<int>();
            //Initialise all the values in the list to '0'
            for (int i = 0; i < 5; i++)
            {
                parameters.Add(0);
            }

            
            RemoveAsterisk(input);
            

            //count the number of sentences in the input.
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '!' || input[i] == '.' || input[i] == '?')
                    parameters[1]++;

            }


            //count vowels and consonants
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' ||
                    input[i] == 'i' || input[i] == 'o' ||
                    input[i] == 'u' || input[i] == 'A' ||
                    input[i] == 'E' || input[i] == 'I' ||
                    input[i] == 'O' || input[i] == 'U')
                    
                    parameters[2]++; //count vowel
                
                else if ((input[i] >= 'a' && input[i] <= 'z') ||
                        (input[i] >= 'A' && input[i] <= 'Z'))
                    parameters[3]++; //count consonant
                

            }

            //count number of lower and upper case charecters
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*')
                    break;
                if (char.IsUpper(input[i]))
                    parameters[0]++;
                if (char.IsLower(input[i]))
                    parameters[4]++;

            }

            return parameters;
        }
    }
}
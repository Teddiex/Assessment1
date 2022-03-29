using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CMP1903M_Assessment_1_Base_Code.Analyse;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Report class that handles the analysis parameters
        //All methods return an Integer
        //All methods have the list 'parameters' as an arugment

        
        public int SentenceCount(List<int>parameters)
        {
            int sentences = parameters[1];
            return sentences;
        }

        
        public int VowelCount(List<int>parameters)
        {
            int vowels = parameters[2];
            return vowels;
        }

        
        public int ConsonantCount(List<int>parameters)
        {
            int consonants = parameters[3];
            return consonants;
        }

        public int UpperCount(List<int>parameters)
        {
            int upperLetters = parameters[0];
            return upperLetters;
        }


        public int LowerCount(List<int>parameters)
        {
            int lowerLetters = parameters[4];
            return lowerLetters;
        }

    }
}

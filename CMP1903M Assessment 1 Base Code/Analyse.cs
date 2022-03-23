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
        private const string vowelArray = ("aiueoAIUEO");
        private const string consonantArray = ("qwrtzpsdfghjklyxcvbnmQWRTZPSDFGHJKLYXCVBNM");
        private const string upperArray = ("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
        private int numberOfSentences;
        private int numberOfVowels;
        private int numberOfConsonants;
        private int numberOfUpperCase;
        private int numberOfLowerCase;

        public Analyse()
        {
            numberOfConsonants = 0;
            numberOfLowerCase = 0;
            numberOfSentences = 0;
            numberOfUpperCase = 0;
            numberOfVowels = 0;
        }       

        public List<int> analyseText(string input)
        {
            List<int> Values = new List<int>();
            for(int i = 0; i<5; i++)
            {
                Values.Add(0);
            }

            if(input == null)
            {
                throw new ArgumentException("Invalid Input.");
            }
            // Finding the number of sentences
            string[] sentences = input.Split('.');
            foreach (var item in sentences)
            {
                if (item.Trim() != "")
                {
                    numberOfSentences++;
                }
            }
            Values[0] = numberOfSentences;

            // Finding the vowels and consonants
            foreach (var item in input)
            {
                if (vowelArray.Contains(item))
                {
                    numberOfVowels++;
                }
                else if (consonantArray.Contains(item))
                {
                    numberOfConsonants++;
                }
            }
            Values[1] = numberOfVowels;
            Values[2] = numberOfConsonants;

            // Finding the Upper-case and Lower-case letters;
            string lowerArray = upperArray.ToLower();
            foreach (var item in input)
            {
                if (upperArray.Contains(item))
                {
                    numberOfUpperCase++;
                }
                else if (lowerArray.Contains(item))
                {
                    numberOfLowerCase++;
                }
            }
            Values[3] = numberOfUpperCase;
            Values[4] = numberOfLowerCase;

            return Values;
        }

        
    }
}
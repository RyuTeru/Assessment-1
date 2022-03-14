using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
public class Analyse
    {
        private const string vowelArray = "aiueoAIUEO";
        private const string consonantArray = "qwrtzpsdfghjklyxcvbnmQWRTZPSDFGHJKLYXCVBNM";
        //Handles the analysis of text
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
        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public void analyseText(string input)
        {
            if(input == null){
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
            
            foreach (var item in input)
            {
                if (vowelArray.Contains(item))
                {
                    numberOfVowels++;
                }
                else if (consonantArray.Contains(item)){
                    numberOfConsonants++;
                }
            }
        }

        public override string ToString()
        {
            return $"Sentences: {numberOfSentences}\nVowels: {numberOfVowels}\nConsonants: {numberOfConsonants}\nUpper Case: {numberOfUpperCase}\nLower Case: {numberOfLowerCase}";
        }
    }
}
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

        // (Example of Encapsulation) 1/2
        // The Data members or 'State' for the Analyse class is set below
        // Such as 'private const string upperArray' or 'private int numberOfVowels'
        // So that only the Analyse class alone can accesses these variables
        private const string vowelArray = "aiueoAIUEO";
        private const string consonantArray = "qwrtzpsdfghjklyxcvbnmQWRTZPSDFGHJKLYXCVBNM";
        private const string upperArray = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string lowerArray = "abcdefghijklmnopqrstuvwxyz";
        private const int longWordCap = 7;
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
        // (Example of Encapsulation) 2/2
        // The methods below are the Function members or 'Behaviours' of this class
        // Such as 'public List<int> analyseText(string input)'
        // These methods that can be invoked outside the class are the only things which can access the private variables
        public List<int> analyseText(string input)
        {
            List<int> values = new List<int>();
            for(int i = 0; i<5; i++)
            {
                values.Add(0);
            }

            if(input == null)
            {
                throw new ArgumentException("Invalid Input.");
            }
            // Finding the number of sentences
            char[] delimiter = {'.', '!', '?'};
            string[] sentences = input.Split(delimiter);
            foreach (var item in sentences)
            {
                if (item.Trim() != string.Empty)
                {
                    numberOfSentences++;
                }
            }
            values[0] = numberOfSentences;

            // Finding the vowels and consonants
            foreach (var character in input)
            {
                if (vowelArray.Contains(character))
                {
                    numberOfVowels++;
                }
                else if (consonantArray.Contains(character))
                {
                    numberOfConsonants++;
                }
            }
            values[1] = numberOfVowels;
            values[2] = numberOfConsonants;

            // Finding the Upper-case and Lower-case letters;
            foreach (var character in input)
            {
                if (upperArray.Contains(character))
                {
                    numberOfUpperCase++;
                }
                else if (lowerArray.Contains(character))
                {
                    numberOfLowerCase++;
                }
            }
            values[3] = numberOfUpperCase;
            values[4] = numberOfLowerCase;

            return values;
        }
        
        // Method to find the frequency of all letters 
        public void letterFrequency(string input)
        {
            // Creation of letter frequency array
            int[] frequencyArray = new int [(int)char.MaxValue];
            
            // Iterates through each letter in the input
            foreach (char letter in input)
            {
                frequencyArray[(int)letter]++;
            }
            // Display frequency of each letter
            for (int i = 0; i < (int)char.MaxValue; i++)
            {
                if (frequencyArray[i] > 0 && char.IsLetterOrDigit((char)i))
                {
                    Console.WriteLine($"Letter: {(char)i} appears : {frequencyArray[i]} times");
                }
            }

        }  
        
    }
}
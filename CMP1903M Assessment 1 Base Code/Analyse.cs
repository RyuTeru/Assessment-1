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
        private const int longwordcap = 7;
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
        // Method to find all words longer than 7 letters 
        public void findLongWords(string input)
        {   // Creation of list of long words
            List<string> longWords = new List<string>();
            // Temporary string to hold words
            string words = "";
            foreach (char item in input.ToCharArray())
            {  // If a real character is found then adds it to the temp string
               if (char.IsLetterOrDigit(item))
               {
                   words += item.ToString();
               }
               // If a non-character is found then checks the length of current temp string 
               else
               {
                   if (words.Length > longwordcap)
                   {
                       longWords.Add(words);
                   }
                   words = "";
                   continue;
               } 
            }
            // Creation of set to gather the unique long words
            var longWordSet = new HashSet<string>(longWords);
            string[] uniqueLongWords = longWordSet.ToArray();

            string CurrentDir = Environment.CurrentDirectory;

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(CurrentDir, "long words.txt")))
            {
            foreach (string word in uniqueLongWords)
                outputFile.WriteLine(word);
            }
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